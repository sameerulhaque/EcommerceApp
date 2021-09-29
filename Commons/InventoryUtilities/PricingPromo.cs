using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.InventoryUtilities
{
    public class PricingPromo : AbstractEntity
    {
        public PricingPromo()
        {
            PromoList = new List<Promo>();
            Promo = new Promo();
        }

        public int? PromoId { get; set; }
        public Promo Promo { get; set; }
        public List<Promo> PromoList { get; set; }
    }
}
