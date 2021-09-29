﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class ut_store
    {
        public int company_id { get; set; }
        public string import_company_id { get; set; }
        public string company_name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public int? is_deleted { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public string fax { get; set; }
        public string website { get; set; }
        public string sales_tax_no { get; set; }
        public string ntn_no { get; set; }
        public string short_name { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }
    }
}
