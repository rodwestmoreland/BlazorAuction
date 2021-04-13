using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        public string Color { get; set; } = "unknown";
        [Required]
        [Range(0,999999)]
        public int Mileage { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public decimal StartAmount { get; set; } = 100.0m;
        public DateTimeOffset? BidStartDate { get; set; }
        public DateTimeOffset? BidEndDate { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal BidEndAmount { get; set; } = 0.0m;

        public string Condition { get; set; }
        public string Damage { get; set; }
        // Drive train types are AWD, FWD, RWD, 4WD //
        public string DriveTrain { get; set; }
        // Fuel types are gas, diesel, electric, hybrid //
        public string FuelType { get; set; }
        [Range(0,48)]
        public int Cylinders { get; set; }
        // Titles: clean, salvage, bonded, lemon, rebuilt, dismantled, flood, odo rollback  
        public string TitleType { get; set; } = "clean";
        public string VehicleImagePath { get; set; } = "https://loremflickr.com/480/320/vehicle";
        
        public string WinnerId { get; set; }

        //public virtual ICollection<Bid> BidList { get; set; }

        [ForeignKey(nameof(Bid))]
        public int? BidId { get; set; }
        public virtual Bid Bid { get; set; }

        public int myCount { get; set; }

        //[ForeignKey(nameof(ApplicationUser))]
        public string BidderId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
