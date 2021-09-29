using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class ut_user_role
    {
        public int user_role_id { get; set; }
        public string import_user_role_id { get; set; }
        public int user_id { get; set; }
        public int action_id { get; set; }
        public int? is_deleted { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public string remarks { get; set; }

        public virtual ut_form_action action { get; set; }
        public virtual ut_user user { get; set; }
    }
}
