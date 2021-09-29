using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product_modifier
    {
        public inv_product_modifier()
        {
            inv_product_modifier_details = new HashSet<inv_product_modifier_details>();
        }

        public int modifier_id { get; set; }
        public string import_modifier_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public int is_offer { get; set; }
        public string offer_name { get; set; }
        public int offer_id { get; set; }
        public decimal modifier_cost_price { get; set; }

        public virtual inv_ut_offer offer { get; set; }
        public virtual ICollection<inv_product_modifier_details> inv_product_modifier_details { get; set; }
    }
}
