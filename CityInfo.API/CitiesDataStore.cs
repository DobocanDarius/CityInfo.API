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
                    Description = "The one without the towers."
                },
                new CityDto()
                {
                    Id= 2,
                    Name = "Craiova",
                    Description = "The one with the knives."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "London",
                    Description = "God Save The King."
                }
            };
        }
    }
}
