using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class Frequency : AbstractEntity
    {
        public string FrequencyName { get; set; }
        public string Type { get; set; }
        public int NumberOfDays { get; set; }
        public int Days { get; set; }
        public int Months { get; set; }
        public int Years { get; set; }
    }
}
