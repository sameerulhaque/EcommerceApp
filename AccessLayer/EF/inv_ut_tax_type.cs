using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_ut_tax_type
    {
        public int tax_type_id { get; set; }
        public string import_tax_type_id { get; set; }
        public string tax_type_name { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
    }
}
