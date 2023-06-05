using TravelProject.Models;

namespace TravelProject.Data
{
    public class CityRepository
    {
        private static List<City>? _cities=null;
        static CityRepository()
        {
            _cities=new List<City>
            {
                new City{CityId=1,Name="NEVŞEHİR",ImageUrl="slider_kapadokya.jpeg"},
                new City{CityId=2,Name="BURSA",ImageUrl="slider_cumalıkızık.jpg"},
                new City{CityId=3,Name="BOLU",ImageUrl="slider_yedigoller.jpg"},
                new City{CityId=4,Name="ESKİŞEHİR",ImageUrl="slider_odunpazarı.jpg"},
                new City{CityId=5,Name="KIKLARELİ",ImageUrl="slider_iğneada.jpg"},
                new City{CityId=6,Name="PAMUKKALE",ImageUrl="slider_pamukkale.jpg"},
                new City{CityId=7,Name="PRAG",ImageUrl="slider_prag.jpg"},
                new City{CityId=8,Name="MİLANO",ImageUrl="slider_milano.jpg"},
                new City{CityId=9,Name="ROMA",ImageUrl="slider_roma.jpg"},
                new City{CityId=10,Name="BERLİN",ImageUrl="slider_berlin.jpeg"},
                new City{CityId=11,Name="BUDAPEŞTE",ImageUrl="slider_budapeşte.jpg"},
                new City{CityId=12,Name="VİYANA",ImageUrl="slider_viyana.jpg"}
            };
        }
        public static List<City>?City
        {
            get
            {
                return _cities;
            }
        }
        public static void AddCategory(City cities)
        {
            _cities.Add(cities);
        }
        public static City GetCityById(int id)
        {
            return _cities.FirstOrDefault(c=>c.CityId==id);
        }                
    }
}