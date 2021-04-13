using B.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace BlazorAuction.Client.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly HttpClient httpClient;
        public VehicleService(HttpClient httpClient) => this.httpClient = httpClient;

        public async Task<IEnumerable<Vehicle>> GetVehicles() =>    await httpClient.GetFromJsonAsync<Vehicle[]>("api/vehicle");
        public async Task<Vehicle> GetVehicle(int id) =>            await httpClient.GetFromJsonAsync<Vehicle>($"api/vehicle/{id}");
        public async Task CreateVehicle(Vehicle newVehicle) =>      await httpClient.PostAsJsonAsync<Vehicle>("api/vehicle", newVehicle);
        public async Task UpdateVehicle(Vehicle editVehicle) =>     await httpClient.PutAsJsonAsync("api/vehicle", editVehicle );
        public async Task DeleteVehicle(int id) =>                  await httpClient.DeleteAsync($"api/vehicle/{id}");
    }         
}