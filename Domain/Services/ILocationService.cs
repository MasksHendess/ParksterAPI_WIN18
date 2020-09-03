
using Parkster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkster.Domain.Services
{
   public interface ILocationService
    {
        Task<IEnumerable<Location>> GetLocations();
        Task<Location> CreateLocation(string name,
        decimal pricePerMinute);
      //  Task<bool> DeleteLocation(int id);
    }
}
