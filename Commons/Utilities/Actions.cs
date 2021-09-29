using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class Actions : AbstractEntity
    {
        public int ActionId { get; set; }
        public string ActionName { get; set; }
        public string DisplayName { get; set; }
        public object CategoryName { get; set; }
    }
}
