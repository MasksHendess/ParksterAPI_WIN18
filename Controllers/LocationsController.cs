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
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService locationService;

        public LocationsController(ILocationService locationService_)
        {
            locationService = locationService_;
        }
        [HttpGet]
        public async Task<IEnumerable<Location>> GetLocations()
        {
           return await locationService.GetLocations();
        }
        [HttpPost]

        public async Task<IActionResult> PostLocation(Location location)
        {
            var newService = await locationService.CreateLocation(location.Name, location.PricePerMinute);

            return Created($"/api/catalogs/{newService.Id}", newService);
        }
        

    }
}
