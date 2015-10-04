using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PlanetWeb.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PlanetWeb.Controllers
{
    public class HomeController : Controller
    {
        private PlanetWeb.Services.IPlanetService _service;

        public HomeController(PlanetWeb.Services.IPlanetService service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _service.GetPlanets();

            if(result.Result != null) { 

                return View(result.Result.ListOfPlanets);
            }

            return View(new List<Planet>());
        }
    }
}
