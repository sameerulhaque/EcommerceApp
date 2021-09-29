using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class WebPages: AbstractEntity
    {
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string DisplayName { get; set; }
        public string Category { get; set; }
    }
}
