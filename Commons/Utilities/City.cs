using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
   public class City : AbstractEntity
    {
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }
}
