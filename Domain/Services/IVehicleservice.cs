using Parkster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkster.Domain.Services
{
        public interface IVehicleService
        {
            Task<Vehicle>
            CreateVehicle(string registrationNumber, string
            owner);
            Task<bool> DeleteVehicle(int id);
        }
    
}
