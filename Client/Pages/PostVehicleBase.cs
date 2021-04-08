using AutoMapper;
using B.Models;
using BlazorAuction.Client.Models;
using BlazorAuction.Client.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorAuction.Client.Pages
{
    public class PostVehicleBase: ComponentBase
    {
        [Inject]
        public IVehicleService VehicleService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Vehicle  Vehicle { get; set; } = new Vehicle();
        public Bid      Bid     { get; set; } = new Bid();

        protected async Task HandleValidSubmit()
        {
            await VehicleService.CreateVehicle(Vehicle);
            NavigationManager.NavigateTo("/");
        }
    }
}
