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
    public class ParkingsController : ControllerBase
    {
        private readonly IParkingService parkingService;

        public ParkingsController(IParkingService locationService_)
        {
            parkingService = locationService_;
        }

        // COME BACK LATER MMKAY
        [HttpGet]
        public async Task<Parking> GetLocations(int id)
        {
            var dicktits = await parkingService.GetParkingsByVehicleId(id);
            return dicktits;
        }
        [HttpPost]

        public async Task<IActionResult> PostLocation(int id, Location location, DateTime date, int Duratation)
        {
          //  return null;
            var newService = await parkingService.StartParking(id, location,date, Duratation);
            
            return Created($"/api/catalogs/{newService.Id}", newService);
        }
        

    }
}
