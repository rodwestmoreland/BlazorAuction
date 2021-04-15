using Microsoft.AspNetCore.Components;
using B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAuction.Client.Services;

namespace BlazorAuction.Client.Pages
{
    public class CarListBase : ComponentBase
    {
        [Inject]
        public IVehicleService VehicleService { get; set; }
        [Inject]
        public IBidService BidService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        public Vehicle Vehicle { get; set; } = new Vehicle();
        public Bid Bid { get; set; } = new Bid();

        public IEnumerable<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public IEnumerable<Bid> Bids { get; set; } = new List<Bid>();

        public string PageSubHeader { get; set; } = "Admin - Edit/Delete";

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Bids = (await BidService.GetBids()).ToList();
                Vehicles = (await VehicleService.GetVehicles()).ToList();

            }
            catch (Exception e)
            {
                Console.WriteLine("Is there an error >>  " +e);
            }
        } 

        protected async Task HandleValidSubmit()
        {
            
             PageSubHeader = "Bidding";
            NavigationManager.NavigateTo("/vehicle/{id}");
        }
    }
}

//<EditForm Model="@Vehicle" OnValidSubmit="HandleValidSubmit">
// @*@{ var carANDbid = Vehicles.Zip(Bids, (X, Y) => new { X, Y }); }
//*@

//                                @*@(from bidAmount in Bids where (car.VehicleId == bid.VehicleId) select bidAmount.HighBid).Max(); *@
//                                @*@Bids.Where(a => a.VehicleId == car.VehicleId).Select(b => b.HighBid).Max(); *@

//                                @*no ID filter: @Bids.AsEnumerable().Select(b => b.HighBid).Max() //works but no filtering for vehicle id*@
//                                < br />

//                                < strong >


//                                    @*@Bids.AsEnumerable().Where(i => i.VehicleId == bid.VehicleId).Select(b => b.HighBid).Max() *@


//                                    @*@foreach(var bid in Bids)
//        {
//    Console.WriteLine("anything? " + bid.VehicleId);

//}
//*@
//                                    @*@if(car.X.VehicleId == car.Y.VehicleId) {
//    Console.WriteLine($"vID {car.X.VehicleId} bVID {car.Y.VehicleId} bHighBid {car.Y.HighBid}") *@


//                                    @Bids.AsEnumerable().Select(b => b.HighBid).Max();




//                                </ strong >