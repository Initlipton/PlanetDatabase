using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetWeb.Services
{
    public interface IPlanetService
    {
        Task<PlanetWeb.Model.Planets> GetPlanets();
    }
}
