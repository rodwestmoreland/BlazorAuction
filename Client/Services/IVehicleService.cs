using B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuction.Client.Services
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicle>> GetVehicles();
        Task<Vehicle> GetVehicle(int id);
        Task CreateVehicle(Vehicle newVehicle);
        Task  UpdateVehicle(Vehicle editVehicle);
        Task DeleteVehicle(int vehicleId);
    }
}
