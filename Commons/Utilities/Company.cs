using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class Company : AbstractEntity
    {

        public string CompanyName { get; set; }
        public string ShortCode { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string SalesTaxNo { get; set; }
        public string NtnNo { get; set; }
    }
}
