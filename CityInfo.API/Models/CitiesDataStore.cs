namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public List<CityDTO> Cities { get; set; }
        public static CitiesDataStore Current { get;  } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                    Id  =11,
                    Name = "Kathmandu",
                    Description = "Capital city"
                },
                 new CityDTO()
                {
                    Id  =13,
                    Name = "Butwal",
                    Description = "Fwak city"
                },
                  new CityDTO()
                {
                    Id  =12,
                    Name = "Nepal",
                    Description = "Country "
                },
            };
        }
    }
}
