using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetWeb.Model
{
    public class Planet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal DistanceFromSun { get; set; }

        public override string ToString()
        {
            return string.Format("{0} km from Sun", DistanceFromSun.ToString("#,##0.##"));
        }
    }
}
