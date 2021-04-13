using B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorAuction.Client.Services
{
    public class BidService:IBidService
    {
        private readonly HttpClient httpClient;
        public BidService(HttpClient httpClient) => this.httpClient = httpClient;

        public async Task<IEnumerable<Bid>> GetBids() => 
            await httpClient.GetFromJsonAsync<Bid[]>("api/bid");
        
        public async Task<Bid> GetBid(int id) => 
            await httpClient.GetFromJsonAsync<Bid>($"api/bid/{id}");
        
        public async Task CreateBid(Bid newBid) => 
            await httpClient.PostAsJsonAsync<Bid>("api/bid", newBid);
    }
}
