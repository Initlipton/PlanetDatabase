using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlanetService.Model;

namespace PlanetService.Services
{
    public class PlanetService : IPlanetService
    {
        public Planets GetPlanets()
        {
            var planetList = new List<Planet>()
            {
                new Planet() {Id = 1, Name="Mercury", DistanceFromSun= 70000000 },
                new Planet() {Id = 2, Name="Venus", DistanceFromSun = 108000000 },
                new Planet() {Id = 3, Name="Earth", DistanceFromSun= 150000000},
                new Planet() {Id = 4, Name="Mars", DistanceFromSun = 228000000 },
                new Planet() {Id = 5, Name="Jupiter", DistanceFromSun= 779000000 },
                new Planet() {Id = 6, Name="Saturn", DistanceFromSun = 1043000000 },
                new Planet() {Id = 7, Name="Uranus", DistanceFromSun= 2088000000 },
                new Planet() {Id = 8, Name="Neptune", DistanceFromSun = 4050000000 },
            };

            return new Planets { ListOfPlanets = planetList};
        }
    }
}