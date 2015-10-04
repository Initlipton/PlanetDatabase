using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PlanetService.Services;

namespace PlanetService.Controllers
{
    [Route("api/[controller]")]
    public class PlanetController : Controller
    {
        public IPlanetService _planetService;

        public PlanetController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            var result = _planetService.GetPlanets();

            return new JsonResult(result);
        }
    }
}
