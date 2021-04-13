using B.Models;
using BlazorAuction.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Dynamic;
using System.Threading.Tasks;

namespace BlazorAuction.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicle_Repo _vehicle_Repo;
        public VehicleController(IVehicle_Repo _vehicle_Repo) => this._vehicle_Repo = _vehicle_Repo;

        [HttpGet]
        public async Task<ActionResult> GetVehicles()
        {
            try
            {
                
                return Ok(await _vehicle_Repo.GetVehicles());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error. Nothing returned. "+e);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
            try
            {
                var result = await _vehicle_Repo.GetVehicle(id);
                

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateVehicle([FromBody]Vehicle vehicle)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            
            try
            {
                var newVehicle = await _vehicle_Repo.CreateVehicle(vehicle);

                return CreatedAtAction(nameof(GetVehicles),
                                        new { id = newVehicle.VehicleId },newVehicle
                                        );
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error. Vehicle not added: " + e);
            }
        }

        [HttpPut()]
        public async Task<ActionResult<Vehicle>> UpdateVehicle(Vehicle editVehicle)
        {
            try
            {
                var vehicle = await _vehicle_Repo.GetVehicle(editVehicle.VehicleId);

                if (editVehicle == null) return NotFound($"Vehicle Id {editVehicle.VehicleId} not found");
                
                return await _vehicle_Repo.UpdateVehicle(editVehicle);
            }
            catch (Exception e) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating vehicle"+e);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Vehicle>> DeleteEmployee(int id)
        {
            try
            {
                var delVehicle = await _vehicle_Repo.GetVehicle(id);

                if (delVehicle == null) return NotFound($" Id {id} not found");

                return await _vehicle_Repo.DeleteVehicle(id);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,"Error deleting data"+e);
            }
        }

    }
}
