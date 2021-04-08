using B.Models;
using BlazorAuction.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAuction.Server.Models
{
    public class Vehicle_Repo:IVehicle_Repo
    {
        private readonly ApplicationDbContext _context;
        public Vehicle_Repo(ApplicationDbContext _context) =>       this._context = _context;
        private async Task<Vehicle> GetById(int vehicleId) =>       await _context.Vehicles.FirstOrDefaultAsync(x => x.VehicleId == vehicleId);
        public async Task<IEnumerable<Vehicle>> GetVehicles() =>    await _context.Vehicles.ToListAsync();
        public async Task<Vehicle> GetVehicle(int vehicleId) =>     await GetById(vehicleId);
        
        public async Task<Vehicle> CreateVehicle(Vehicle vehicle)
        {
            var newItem = await _context.Vehicles.AddAsync(vehicle);
            await _context.SaveChangesAsync();
            return newItem.Entity;
        }
        public async Task<Vehicle> UpdateVehicle(Vehicle vehicle)
        {
            var result = await _context.Vehicles.FirstOrDefaultAsync(x=>x.VehicleId == vehicle.VehicleId);
            if (result != null)
            {
                result.Year =           vehicle.Year;
                result.Make =           vehicle.Make;
                result.Model =          vehicle.Model;
                result.Mileage =        vehicle.Mileage;
                result.VehicleImagePath = vehicle.VehicleImagePath;

                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task<Vehicle> DeleteVehicle(int vehicleId)
        {
            var result = await GetById(vehicleId);
            if(result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

    }
}