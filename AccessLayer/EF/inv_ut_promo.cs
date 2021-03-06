using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_ut_promo
    {
        public inv_ut_promo()
        {
            inv_product_pricing_promo = new HashSet<inv_product_pricing_promo>();
        }

        public int promo_id { get; set; }
        public string import_promo_id { get; set; }
        public string promo_name { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public decimal? amount { get; set; }
        public decimal? percentage { get; set; }
        public int? company_id { get; set; }

        public virtual ut_company company { get; set; }
        public virtual ICollection<inv_product_pricing_promo> inv_product_pricing_promo { get; set; }
    }
}
