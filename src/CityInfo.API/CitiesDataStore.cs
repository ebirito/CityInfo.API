using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The city that never sleeps",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Empire State",
                            Description = "A tall building"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Centrtal Park",
                            Description = "A nice green park"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Caracas",
                    Description = "Murder capital of the world"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Geneva",
                    Description = "Yawn, so peaceful"
                }
            };
        }
    }
}
