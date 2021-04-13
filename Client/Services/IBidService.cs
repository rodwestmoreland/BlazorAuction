using B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuction.Client.Services
{
    public interface IBidService
    {
        
            Task<IEnumerable<Bid>> GetBids();
            Task<Bid> GetBid(int id);
            Task CreateBid(Bid newBid);
        
    }
}
