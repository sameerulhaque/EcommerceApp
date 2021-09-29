using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.InventoryUtilities
{
    public class Promo:AbstractEntity
    {
        public string PromoName{ get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Amount { get; set; }
    }
}
