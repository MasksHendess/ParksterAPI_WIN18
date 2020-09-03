using Parkster.Data;
using Parkster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkster.Domain.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDbContext context;

        public VehicleService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> DeleteVehicle(int id)
        {
            var product = context.Vehicles.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return await Task.FromResult(false);
            }

            context.Vehicles.Remove(product);
            var recordsAffected = await context.SaveChangesAsync();
            return await Task.FromResult(true);
        }
        // POst
        public async Task<Vehicle> CreateVehicle(string regnr, string owner)
        {
            var NewVehicle = new Vehicle { RegistrationNumber = regnr, Owner = owner };
            context.Vehicles.Add(NewVehicle);

            await context.SaveChangesAsync();

            return NewVehicle;
        }
    }
}
