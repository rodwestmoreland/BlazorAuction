using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace B.Models
{
    public class Bid
    {
        public Bid(){}
        public Bid(DateTimeOffset start, DateTimeOffset end, decimal startAmount, decimal endAmount, decimal highBid)
        {
            BidStartDate = start;
            BidStartAmount = startAmount;
            BidEndDate = end;
            BidEndAmount = endAmount;
            HighBid = highBid;

        }
        public Bid(decimal startAmount)
        {
            BidStartAmount = startAmount;
        }
        public int BidId { get; set; }
        public DateTimeOffset BidStartDate { get; set; }
        public DateTimeOffset BidEndDate { get; set; }
        public DateTimeOffset BidTimeCreated { get; set; } = DateTimeOffset.Now; // Time when vehicle was bidded on
        [Column(TypeName ="decimal(16,2)")]
        public decimal BidStartAmount { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public decimal BidEndAmount { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public decimal HighBid { get; set; }

        //[ForeignKey(nameof(ApplicationUser))]
        public int BidderId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

        //[ForeignKey(nameof(Vehicle))]
        //public int VehicleId { get; set; }
        //public virtual Vehicle Vehicle { get; set; }


    }
}
