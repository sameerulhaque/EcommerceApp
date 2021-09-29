using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product_type
    {
        public inv_product_type()
        {
            inv_product = new HashSet<inv_product>();
        }

        public int product_type_id { get; set; }
        public string product_type_name { get; set; }
        public int? is_deleted { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
        public string import_product_type_id { get; set; }

        public virtual ICollection<inv_product> inv_product { get; set; }
    }
}
