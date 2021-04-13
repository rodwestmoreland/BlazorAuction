using B.Models;
using BlazorAuction.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace BlazorAuction.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options,
                                    IOptions<OperationalStoreOptions> operationalStoreOptions)
                : base(options, operationalStoreOptions) { }

        public DbSet<Bid>       Bids { get; set; }
        public DbSet<Vehicle>   Vehicles { get; set; }
        public DbSet<Watch>     Watches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Vehicle>()
            //.HasMany(p => p.BidList)
            //.WithOne();

            modelBuilder.Entity<Bid>().HasData(
                new Bid { BidId = 1, VehicleId = 1, HighBid = 1200 },
                new Bid { BidId = 2, VehicleId = 1, HighBid = 1500 },
                new Bid { BidId = 3, VehicleId = 2, HighBid = 2300 },
                new Bid { BidId = 4, VehicleId = 3, HighBid = 500 },
                new Bid { BidId = 5, VehicleId = 4, HighBid = 5000 },
                new Bid { BidId = 6, VehicleId = 1, HighBid = 1600 }

                );
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    VehicleId = 1,
                    Year = 1968,
                    Make = "Pontiac",
                    Model = "Firebird",
                    Color = "Black",
                    Cylinders = 8,
                    TitleType = "Clean",
                    Mileage = 82000,
                    StartAmount = 850,
                    BidStartDate = DateTimeOffset.Now,
                    VehicleImagePath = "img/1968Firebird.jpg",

                },
                new Vehicle
                {
                    VehicleId = 2,
                    Year = 1998,
                    Make = "Ford",
                    Model = "F150",
                    Color = "White",
                    Cylinders = 8,
                    TitleType = "Clean",
                    Mileage = 150000,
                    StartAmount = 1150,
                    BidStartDate = DateTimeOffset.Now,
                    VehicleImagePath = "img/1998F150.jpg",

                },
                new Vehicle
                {
                    VehicleId = 3,
                    Year = 1998,
                    Make = "Ford",
                    Model = "Ranger",
                    Color = "Blue",
                    Cylinders = 6,
                    TitleType = "Flood",
                    Mileage = 23000,
                    StartAmount = 250,
                    BidStartDate = DateTimeOffset.Now,
                    VehicleImagePath = "img/1998Ranger.jpg",

                },
                new Vehicle
                {
                    VehicleId = 4,
                    Year = 2006,
                    Make = "BMW",
                    Model = "i530",
                    Color = "Black",
                    Cylinders = 6,
                    TitleType = "Rebuilt",
                    Mileage = 102000,
                    StartAmount = 4050,
                    BidStartDate = DateTimeOffset.Now,
                    VehicleImagePath = "img/2006i530.jpg",

                },
                new Vehicle
                {
                    VehicleId = 5,
                    Year = 2010,
                    Make = "Chevy",
                    Model = "Volt",
                    Color = "Silver",
                    Cylinders = 4,
                    TitleType = "Salvage",
                    Mileage = 10000,
                    StartAmount = 450,
                    BidStartDate = DateTimeOffset.Now,
                    VehicleImagePath = "img/2010Volt.jpg",

                },
                new Vehicle
                {
                    VehicleId = 6,
                    Year = 2019,
                    Make = "Volvo",
                    Model = "S60",
                    Color = "Black",
                    Cylinders = 4,
                    TitleType = "Clean",
                    Mileage = 23000,
                    StartAmount = 13850,
                    BidStartDate = DateTimeOffset.Now,
                    VehicleImagePath = "img/2019S60.jpg",

                }

                );
        }
    }
 }
