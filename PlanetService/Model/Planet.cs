using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetService.Model
{
    public class Planet
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal DistanceFromSun { get; set; }
    }
}
