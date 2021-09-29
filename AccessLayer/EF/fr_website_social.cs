using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class fr_website_social
    {
        public int donation_website_social_id { get; set; }
        public string import_donation_website_social_id { get; set; }
        public string _class { get; set; }
        public int? is_deleted { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string redirection_url { get; set; }
    }
}
