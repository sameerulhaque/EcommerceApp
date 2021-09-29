using Commons.InventoryUtilities;
using Commons.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.InventoryUtilities
{
    public class ProductVariant : AbstractEntity
    {
        public ProductVariant()
        {
            VariantList = new List<Variant>();
            Variant = new Variant();
            VariantIds = new List<int>();

            PromoIds = new List<int>();

            Product = new Product();
        }

        public Product Product { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }

        public bool HasPromo { get; set; }
        public List<int> PromoIds { get; set; }

        public decimal ReOrderLevel { get; set; }
        public decimal MaxOrderLevel { get; set; }
        public decimal MinOrderQuantity { get; set; }
        public decimal MaxOrderQuantity { get; set; }
        public decimal LeadDaysRequired { get; set; }
        public string Comments { get; set; }

        public List<int> VariantIds { get; set; }
        public Variant Variant { get; set; }
        public List<Variant> VariantList { get; set; }
        public decimal ItemNumber { get; set; }
        public string VariantCode { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string PromoIdsString { get; set; }
    }
}