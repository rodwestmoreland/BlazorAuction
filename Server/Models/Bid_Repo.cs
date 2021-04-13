using B.Models;
using BlazorAuction.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuction.Server.Models
{
    public class Bid_Repo:IBid_Repo
    {
        private readonly ApplicationDbContext _context;
        public Bid_Repo(ApplicationDbContext _context) => this._context = _context;
        private async Task<Bid> GetById(int bidId) => await _context.Bids.FirstOrDefaultAsync(x => x.BidId == bidId);
        public async Task<IEnumerable<Bid>> GetBids() => await _context.Bids.ToListAsync();
        public async Task<Bid> GetBid(int bidId) => await GetById(bidId);

        public async Task<Bid> CreateBid(Bid bid)
        {

            var newItem = await _context.Bids.AddAsync(bid);

            await _context.SaveChangesAsync();
            return newItem.Entity;
        }
    }
}
