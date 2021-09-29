using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_ut_ecommerce
    {
        public inv_ut_ecommerce()
        {
            inv_product_variant = new HashSet<inv_product_variant>();
        }

        public int ecommerce_id { get; set; }
        public string import_ecommerce_id { get; set; }
        public string ecommerce_name { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }

        public virtual ICollection<inv_product_variant> inv_product_variant { get; set; }
    }
}
