using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.Models
{
    public class Watch
    {
        [Key]
        public int WatchId { get; set; }

        //[ForeignKey(nameof(ApplicationUser))]
        public string WatcherId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey(nameof(Vehicle))]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        // Use following in View //
        //CarYear
        //CarMake
        //CarModel
        //BidEndDateTime
        //CarImage

    }
}
