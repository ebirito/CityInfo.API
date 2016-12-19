using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if(context.Cities.Any())
            {
                return;
            }
            
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York",
                    Description = "The city that never sleeps",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Empire State",
                            Description = "A tall building"
                        },
                        new PointOfInterest()
                        {
                            Name = "Centrtal Park",
                            Description = "A nice green park"
                        }
                    }
                },
                new City()
                {
                    Name = "Caracas",
                    Description = "Murder capital of the world"
                },
                new City()
                {
                    Name = "Geneva",
                    Description = "Yawn, so peaceful"
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
