using Microsoft.AspNetCore.Components;
using B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAuction.Client.Services;

namespace BlazorAuction.Client.Pages
{
    public class CarDetailsBase:ComponentBase
    {
        [Inject]
        public IVehicleService VehicleService { get; set; }
        [Inject]
        public IBidService BidService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }
        [Parameter]
        public string pagesubheader { get; set; }
        [Parameter]
        public string maxbid { get; set; }

        public Vehicle Vehicle { get; set; } = new Vehicle();
        public Bid Bid { get; set; } = new Bid();

        protected override async Task OnInitializedAsync() => Vehicle = await VehicleService.GetVehicle(int.Parse(Id));

        protected async Task HandleValidSubmit()
        {
            await VehicleService.DeleteVehicle(Vehicle.VehicleId);
            NavigationManager.NavigateTo("/");
        }
    }
}
