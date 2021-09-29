using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class ut_form_layout
    {
        public int layout_id { get; set; }
        public string import_layout_id { get; set; }
        public string parent_code { get; set; }
        public string span { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public int form_code_id { get; set; }
        public int priority { get; set; }

        public virtual ut_form_code form_code { get; set; }
    }
}
