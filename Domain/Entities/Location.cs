using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkster.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerMinute { get; set; }
    }
}
