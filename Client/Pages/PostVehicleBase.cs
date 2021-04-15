using AutoMapper;
using B.Models;
using BlazorAuction.Client.Models;
using BlazorAuction.Client.Services;
using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
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

        public async Task HandlePhoto(IFileListEntry[] files)
        {
            var sourceFile = files.FirstOrDefault();
            if (sourceFile != null)
            {
                // Convert to reasonably-sized JPEG
                var imageFile = await sourceFile.ToImageFileAsync("image/jpeg", 800, 600);

                // Represent it as a data URL we can display
                var bytes = await imageFile.ReadAllAsync();
                var teststring = bytes.ToDataUrl("image/jpeg");
                Console.WriteLine("imgString = " + teststring);

                //Vehicle.VehicleImagePath = bytes.ToDataUrl("image/jpeg");
                
                
            }
        }
    }
}
