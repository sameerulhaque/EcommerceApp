using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class PaymentType:AbstractEntity
    {
        public string PaymentTypeName { get; set; }
        public bool IsMostlyUsed { get; set; }
    }
}
