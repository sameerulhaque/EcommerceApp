using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class Currency : AbstractEntity
    {

        public Currency()
        {
            CurrencyList = new List<Currency>();
        }
        public string CurrencyName { get; set; }
        public decimal ExchangeRate { get; set; }
        public List<Currency> CurrencyList { get; set; }
    }
}
