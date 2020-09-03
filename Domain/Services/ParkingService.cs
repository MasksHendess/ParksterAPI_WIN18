using Microsoft.AspNetCore.Mvc;
using Parkster.Data;
using Parkster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkster.Domain.Services
{
    public class ParkingService : IParkingService
    {
        private readonly ApplicationDbContext context;

        public ParkingService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<Parking> GetParkingsByVehicleId(int id)
        {
            var parking = await context.Parkings.FindAsync(id);

            if (parking == null)
            {
                return null;
            }

            return parking;
        }

        public async Task<Parking> StartParking(int vehicleid, Location locationid, DateTime date, int durationInMinutes)
        {
            var NewParking = new Parking { VehicleId = vehicleid, Location = locationid,
                StartDate = date, DurationInMinutes = durationInMinutes };
            context.Parkings.Add(NewParking);
            await context.SaveChangesAsync();

            return NewParking;
        }
        
    }
}
