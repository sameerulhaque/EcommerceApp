using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.InventoryUtilities
{
    public class Option : AbstractEntity
    {
        public Option()
        {
            VariantIds = new List<int>();
            VariantList = new List<Variant>();
        }

        public string OptionName { get; set; }
        public List<int> VariantIds { get; set; }
        public List<Variant> VariantList { get; set; }
    }
}
