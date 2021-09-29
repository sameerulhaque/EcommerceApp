using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.InventoryUtilities
{
    public class Variant : AbstractEntity
    {
        public Variant()
        {
            OptionList = new List<Option>();
            Option = new Option();
        }

        public int VariantId { get; set; }
        public string Name { get; set; }
        public int? OptionId { get; set; }
        public string OptionName { get; set; }
        public List<Option> OptionList { get; set; }
        public Option Option { get; set; }
    }
}
