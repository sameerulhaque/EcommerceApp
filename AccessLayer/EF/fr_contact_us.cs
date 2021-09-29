using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class fr_contact_us
    {
        public int contact_us_id { get; set; }
        public string import_contact_us_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string our_store { get; set; }
        public string hours_of_operation { get; set; }
        public string careers { get; set; }
        public string about_contact_us { get; set; }
        public decimal lattitude { get; set; }
        public decimal longitude { get; set; }
    }
}
