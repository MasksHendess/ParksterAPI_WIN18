using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkster.Domain.Entities
{
    public class Parking
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public Location Location { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
