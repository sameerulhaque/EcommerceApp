using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product_pricing_tax
    {
        public int pricing_tax_id { get; set; }
        public string import_pricing_tax_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public int tax_id { get; set; }
        public decimal percentage { get; set; }
        public decimal amount { get; set; }
        public int pricing_id { get; set; }

        public virtual inv_product_pricing pricing { get; set; }
        public virtual inv_ut_tax_type tax { get; set; }
    }
}
