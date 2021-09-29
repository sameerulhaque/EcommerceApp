using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class fr_slider
    {
        public int slider_id { get; set; }
        public string import_slider_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string heading { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
    }
}
