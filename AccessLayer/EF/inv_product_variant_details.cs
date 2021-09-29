using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product_variant_details
    {
        public int product_variant_details_id { get; set; }
        public string import_product_variant_details_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public int? variant_id { get; set; }
        public int? product_variant_id { get; set; }

        public virtual inv_product_variant product_variant { get; set; }
        public virtual inv_ut_variant variant { get; set; }
    }
}
