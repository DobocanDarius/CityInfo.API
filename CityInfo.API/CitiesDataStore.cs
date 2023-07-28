using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        
        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one without the towers.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Most visited park in th US."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Not the towers",
                            Description = "Probably an inside job."
                        }
                    }
                },
                new CityDto()
                {
                    Id= 2,
                    Name = "Craiova",
                    Description = "The one with the knives.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Central Park",
                            Description = "Most visited park in th Romania(probably not)."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "London",
                    Description = "God Save The King.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "test1",
                            Description = "123"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "test2",
                            Description = "123."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "test3",
                            Description = "123"
                        }
                    }
                }
            };
        }
    }
}
