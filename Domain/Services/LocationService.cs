using Microsoft.EntityFrameworkCore;
using Parkster.Data;
using Parkster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkster.Domain.Services
{
    public class LocationService : ILocationService
    {
        private readonly ApplicationDbContext context;

        public LocationService(ApplicationDbContext _context)
        {
            context = _context;
        }


        //GET
        public async Task<IEnumerable<Location>> GetLocations()
        {
            return await context.Locations.ToListAsync();
        }

        // POst
        public async Task<Location> CreateLocation(string name, decimal priceperminute)
        {
            var Newproduct = new Location { Name = name, PricePerMinute = priceperminute };
            context.Locations.Add(Newproduct);

            await context.SaveChangesAsync();

            return Newproduct;
        }
    }
}
