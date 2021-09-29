using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class fr_website
    {
        public int donation_website_id { get; set; }
        public string import_donation_website_id { get; set; }
        public string email { get; set; }
        public int? is_deleted { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string contact_quote { get; set; }
        public string contact_number { get; set; }
        public string about_blog_description { get; set; }
        public string about_faqs { get; set; }
        public string service_banner_url { get; set; }
    }
}
