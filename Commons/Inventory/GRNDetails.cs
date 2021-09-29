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
   public class GRNDetails : AbstractEntity
    {
        public GRNDetails()
        {
            Product = new Product();
            ProductList = new List<Product>();

            Group = new Product();
            GroupList = new List<Product>();

            UnitOfMeasure = new UnitOfMeasure();
            UnitOfMeasureList = new List<UnitOfMeasure>();

            Currency = new Currency();
            CurrencyList = new List<Currency>();
        }


        public int ProductId { get; set; }
        public Product Product { get; set; }
        public List<Product> ProductList { get; set; }

        public int GroupId { get; set; }
        public Product Group { get; set; }
        public List<Product> GroupList { get; set; }

        public int UnitId { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public List<UnitOfMeasure> UnitOfMeasureList { get; set; }

        public int Quantity { get; set; }
        public decimal Rate { get; set; }

        public decimal Amount { get; set; }
        public decimal LocalAmount { get; set; }
        public decimal ExchangeRate { get; set; }

        public bool HasExpiryDate { get; set; }
        public string ExpiryDateString { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Currency Currency { get; set; }
        public List<Currency> CurrencyList { get; set; }
        public int CurrencyId { get; set; }
    }
}
