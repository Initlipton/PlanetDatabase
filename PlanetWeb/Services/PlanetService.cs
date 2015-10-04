using System;
using System.Collections.Generic;
using System.Linq;
using PlanetWeb.Model;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace PlanetWeb.Services
{
    public class PlanetService : IPlanetService
    {
        private Config _config;

        public PlanetService(Config config)
        {
            _config = config;
        }

        public async Task<PlanetWeb.Model.Planets> GetPlanets()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_config.Url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync(_config.ApiEndpoint);
                if (response.IsSuccessStatusCode)
                {
                    var res = await response.Content.ReadAsStringAsync();
                    var listOfPlanets = JsonConvert.DeserializeObject<Planets>(res);
                    
                    return listOfPlanets;
                }
            }

            return null;
        }
    }
}
