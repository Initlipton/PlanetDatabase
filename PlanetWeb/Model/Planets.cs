using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetWeb.Model
{
    public class Planets
    {
        public Planets()
        {
            ListOfPlanets = new List<Planet>();
        }

        public IList<Planet> ListOfPlanets { get; set; }
    }
}
