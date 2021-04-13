using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.Models
{
    public class Bid
    {
        public int              BidId { get; set; }
        
        public DateTimeOffset   BidTimeCreated { get; set; } = DateTimeOffset.Now; // Time when vehicle was bidded on
        
        [Column(TypeName = "decimal(16,2)")]
        public decimal          HighBid { get; set; }

        [ForeignKey(nameof(Vehicle))]
        public int? VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public int myCount { get; set; }

        //[ForeignKey(nameof(ApplicationUser))]
        public int BidderId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
