using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorAuction.Server.Data;
using BlazorAuction.Server.Models;

namespace BlazorAuction.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                                                        options.UseSqlServer(
                                                                Configuration.GetConnectionString("DBConnection")
                                                        ));
            
            services.AddScoped<IVehicle_Repo, Vehicle_Repo>();  // <- this is definitely required
            services.AddScoped<IBid_Repo, Bid_Repo>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<ApplicationUser>(options => 
                                                         options.SignIn.RequireConfirmedAccount = true)
                                                                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentityServer().AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

            services.AddAuthentication().AddIdentityServerJwt();

            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddServerSideBlazor(); // is this needed?

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
