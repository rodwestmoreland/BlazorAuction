using B.Models;
using BlazorAuction.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazorAuction.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options,
                                    IOptions<OperationalStoreOptions> operationalStoreOptions) 
                : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Bid>       Bids    { get; set; }
        public DbSet<Vehicle>   Vehicles { get; set; }
        public DbSet<Watch>     Watches { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Vehicle>().HasData(new Vehicle(2010, "Chevy", "Volt", 12000, "img/2010Volt.jpg"));
        //    modelBuilder.Entity<Vehicle>().HasData(new Vehicle(1968, "Pontiac", "Firebird", 62000, "img/1968Firebird.jpg"));
        //    modelBuilder.Entity<Vehicle>().HasData(new Vehicle(1998, "Ford", "Ranger", 88000, "img/1998Ranger.jpg"));
        //    modelBuilder.Entity<Vehicle>().HasData(new Vehicle(2019, "Volvo", "S60", 33000, "img/2019S60.jpg"));
        //    modelBuilder.Entity<Vehicle>().HasData(new Vehicle(2006, "BMW", "i530", 112000, "img/2006i530.jpg"));
        //    modelBuilder.Entity<Vehicle>().HasData(new Vehicle(1998, "Ford", "F150", 120000, "img/1998F150.jpg"));

            //modelBuilder.Entity<Bid>().HasData(new Bid(1000.00m));
            

        //}
    }

 }
