using B.Models;
using BlazorAuction.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuction.Server.Models
{
    public interface IBid_Repo
    {
        Task<IEnumerable<Bid>> GetBids();
        Task<Bid> GetBid(int bidId);
        Task<Bid> CreateBid(Bid bid);
    }
}
