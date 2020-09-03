using Parkster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkster.Domain.Services
{
    public interface IParkingService
    {
        Task<Parking>
        GetParkingsByVehicleId(int vehicleId);

        Task<Parking> StartParking(int vehicleId,
        Location location, DateTime startTime, int DurationInMinutes);
      //  Task<Parking> EndParking(string
       // registrationNumber);
    }
}

