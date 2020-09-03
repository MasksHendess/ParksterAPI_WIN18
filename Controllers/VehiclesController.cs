using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parkster.Data;
using Parkster.Domain.Entities;
using Parkster.Domain.Services;

namespace Parkster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        private readonly IVehicleService Vehicleservice;

        public VehiclesController(IVehicleService vehicleservice)
        {
            Vehicleservice = vehicleservice;
        }
        [HttpPost]
        public async Task<IActionResult> PostVehicle(Vehicle vehicle)
        {
            var newCatalog = await Vehicleservice.CreateVehicle(vehicle.RegistrationNumber, vehicle.Owner);

            return Created($"/api/catalogs/{newCatalog.Id}", newCatalog);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var deleted = await Vehicleservice.DeleteVehicle(id);

            if (deleted)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
