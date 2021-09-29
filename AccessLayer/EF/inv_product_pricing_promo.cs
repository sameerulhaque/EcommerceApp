using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product_pricing_promo
    {
        public int pricing_promo_id { get; set; }
        public string import_pricing_promo_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public int? product_id { get; set; }
        public int? promo_id { get; set; }

        public virtual inv_product product { get; set; }
        public virtual inv_ut_promo promo { get; set; }
    }
}
