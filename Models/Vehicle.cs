using System.ComponentModel.DataAnnotations;

namespace B.Models
{
    public class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(int year, string make, string model, int mileage,string path)
        {
            Year = year;
            Make = make;
            Model = model;
            Mileage = mileage;
            VehicleImagePath = path;
        }
        [Key]
        public int VehicleId { get; set; }
        [Required]
        
        public int Year { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        public string Color { get; set; }
        [Required]
        [Range(0,999999)]
        public int Mileage { get; set; }
        public string Condition { get; set; }
        public string Damage { get; set; }
        // Drive train types are AWD, FWD, RWD, 4WD //
        public string DriveTrain { get; set; }
        // Fuel types are gas, diesel, electric, hybrid //
        public string FuelType { get; set; }
        [Range(0,48)]
        public int Cylinders { get; set; }
        // Titles: clean, salvage, bonded, lemon, rebuilt, dismantled, flood, odo rollback  
        public string TitleType { get; set; }
        public string VehicleImagePath { get; set; }
        
        public string WinnerId { get; set; }
        
        //public virtual Bid Bid { get; set; }


        //[ForeignKey(nameof(ApplicationUser))]
        public string BidderId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
