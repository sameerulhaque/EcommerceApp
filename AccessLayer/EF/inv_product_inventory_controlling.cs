using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product_inventory_controlling
    {
        public inv_product_inventory_controlling()
        {
            inv_product = new HashSet<inv_product>();
        }

        public int inventory_id { get; set; }
        public string import_inventory_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public decimal? max_order_level { get; set; }
        public decimal? min_order_quantity { get; set; }
        public decimal? max_order_quantity { get; set; }
        public decimal? lead_days_requried { get; set; }
        public decimal? re_order_level { get; set; }
        public string comments { get; set; }

        public virtual ICollection<inv_product> inv_product { get; set; }
    }
}
