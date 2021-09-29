using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class FormCode : AbstractEntity
    {
        public FormCode()
        {
            Actions = new Actions();
            ActionsList = new List<Actions>();
        }

        public string FormCodeName { get; set; }
        public string FormCodeAction { get; set; }
        public string LabelText { get; set; }
        public string FormUrl { get; set; }
        public string Module { get; set; }
        public int LanguageId { get; set; }
        public string ViewRole { get; set; }
        public string MainModule { get; set; }
        public string ViewModule { get; set; }
        public string ParentCode { get; set; }
        public string Span { get; set; }

        public Actions Actions { get; set; }
        public List<Actions> ActionsList { get; set; }
        public bool IsApproval { get; set; }
    }
}
