using B.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAuction.Server.Models
{
    public interface IVehicle_Repo
    {
        Task<IEnumerable<Vehicle>> GetVehicles();
        Task<Vehicle> GetVehicle(int vehicleId);
        Task<Vehicle> CreateVehicle(Vehicle vehicle);
        Task<Vehicle> UpdateVehicle(Vehicle vehicle);
        Task<Vehicle> DeleteVehicle(int vehicleId);
    }
}
