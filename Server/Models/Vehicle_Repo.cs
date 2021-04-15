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
        public async Task<Vehicle> GetVehicle(int vehicleId) =>     await GetById(vehicleId);
        
        private async Task<Vehicle> GetById(int vehicleId)
        {            
            return await _context.Vehicles.Include(x => x.Bid).FirstOrDefaultAsync(x => x.VehicleId == vehicleId);
        }


        public async Task<IEnumerable<Vehicle>> GetVehicles() 
        {
            return await _context.Vehicles.ToListAsync();
        }

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
                result.Year =               vehicle.Year;
                result.Make =               vehicle.Make;
                result.Model =              vehicle.Model;
                result.Mileage =            vehicle.Mileage;
                result.VehicleImagePath =   vehicle.VehicleImagePath;
                result.StartAmount =        vehicle.StartAmount;
                result.BidStartDate =       vehicle.BidStartDate;
                result.BidEndDate =         vehicle.BidEndDate;
                result.Color =              vehicle.Color;
                result.Condition =          vehicle.Condition;
                result.Cylinders =          vehicle.Cylinders;
                result.Damage =             vehicle.Damage;
                result.DriveTrain =         vehicle.DriveTrain;
                result.FuelType =           vehicle.FuelType;
                result.TitleType =          vehicle.TitleType;

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