using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product_pricing
    {
        public int pricing_id { get; set; }
        public string import_pricing_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public int? is_promo_applicable { get; set; }
        public int? allow_price_override_regardless_of_permission { get; set; }
        public int? change_cost_price_during_sale { get; set; }
        public int? commission_applicable { get; set; }
        public int? price_include_tax { get; set; }
        public decimal? commission { get; set; }
        public string percentage { get; set; }
        public string profit { get; set; }
        public int? product_variant_id { get; set; }

        public virtual inv_product_variant product_variant { get; set; }
    }
}
