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
        public IEnumerable<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Vehicles = (await VehicleService.GetVehicles()).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

