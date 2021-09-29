using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product_modifier_details
    {
        public int modifier_details_id { get; set; }
        public string import_modifier_details_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public int product_id { get; set; }
        public int unif_of_measure_id { get; set; }
        public decimal rate { get; set; }
        public int modifier_id { get; set; }

        public virtual inv_product_modifier modifier { get; set; }
        public virtual inv_product product { get; set; }
        public virtual inv_ut_unit_of_measure unif_of_measure { get; set; }
    }
}
