using B.Models;
using BlazorAuction.Client.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuction.Client.Pages
{
    public class EditVehicleBase : ComponentBase
    {
        [Inject]
        public IVehicleService VehicleService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        public Vehicle Vehicle { get; set; } = new Vehicle();

        protected async override Task OnInitializedAsync() => Vehicle = await VehicleService.GetVehicle(int.Parse(Id)); 
        
        protected async Task HandleValidSubmit()
        {
            await VehicleService.UpdateVehicle(Vehicle);
            Console.WriteLine("Test start "+Vehicle.BidStartDate + " end "+ Vehicle.BidEndDate);
            NavigationManager.NavigateTo("/");
        }
    }
}
