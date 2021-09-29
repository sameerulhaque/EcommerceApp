using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class fr_faq
    {
        public int faq_id { get; set; }
        public string import_faq_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
    }
}
