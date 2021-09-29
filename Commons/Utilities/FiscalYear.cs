using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class FiscalYear : AbstractEntity
    {
        public FiscalYear()
        {
            FiscalYearIdList = new List<string>();
        }

        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IsDefault { get; set; }
        public string FiscalYearName { get; set; }
        public string ShortCode { get; set; }

        public List<string> FiscalYearIdList { get; set; }
    }
}
