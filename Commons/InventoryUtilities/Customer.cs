using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.Utilities;

namespace Commons.InventoryUtilities
{
    public class Customer : AbstractEntity
    {
        public Customer()
        {
        }
        public string CustomerName { get; set; }
        public string ShortName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string NTN { get; set; }
        public string STRN { get; set; }
        public string CNIC { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal SaleTax { get; set; }
        public decimal SaleTaxWithHold { get; set; }
        public string NatureName { get; set; }
        public bool IsFiler { get; set; }

    }
}
