using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() 
        {
            //Dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with big park.",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Statue of Liberty",
                            Description = "A symbol of freeeeedom"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Manhattan Park",
                            Description = "Big Park"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Big cathedral.",
                    PointOfInterests = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral",
                            Description = "Almost finished"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Some canals",
                            Description = "They have water"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Eifel tower.",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eifel tower",
                            Description = "Big tower"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Luvra",
                            Description = "Art"
                        }
                    }
                }
            };
        }

    }
}
