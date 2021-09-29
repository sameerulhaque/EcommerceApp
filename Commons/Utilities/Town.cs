using Commons.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class Town:AbstractEntity
    {
        public Town()
        {
            CityList = new List<City>();
            City = new City();
        }

        public string TownName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public List<City> CityList { get; set; }
    }
}
