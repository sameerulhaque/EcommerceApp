using Commons.Inventory;
using Commons.InventoryUtilities;
using Commons.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Stores
{
  public  class GINDetail :AbstractEntity
    {

        public GINDetail()
        {
            Product = new Product();
            ProductList = new List<Product>();

            Unit = new UnitOfMeasure();
            UnitOfMeasureList = new List<UnitOfMeasure>();

            Currency = new Currency();
            CurrencyList = new List<Currency>();
        }


        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public List<Product> ProductList { get; set; }

        public int? UnitId { get; set; }
        public UnitOfMeasure Unit { get; set; }
        public List<UnitOfMeasure> UnitOfMeasureList { get; set; }

        public int? CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public List<Currency> CurrencyList { get; set; }

        public decimal? Quantity { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
    }
}
