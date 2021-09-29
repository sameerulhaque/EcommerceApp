using Commons.InventoryUtilities;
using Commons.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonsStandard;
using Commons.TableSearching;

namespace Commons.InventoryUtilities
{
    public class Product : AbstractEntity
    {
        public Product()
        {
            Category = new Category();
            CategoryList = new List<Category>();
            UnitOfMeasure = new UnitOfMeasure();
            UnitOfMeasureList = new List<UnitOfMeasure>();
            ProductImageList = new List<ProductImages>();
            VariantList = new List<Variant>();
            OptionList = new List<Option>();
            ProductVariantList = new List<ProductVariant>();
            Company = new Company();
            PricingPromoList = new List<PricingPromo>();
            ProductBrand = new ProductBrand();

            DataTable = new DataTable<Product>();
        }
        public string ProductName { get; set; }


        public int? UnitOfMeasureId { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public List<UnitOfMeasure> UnitOfMeasureList { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Category> CategoryList { get; set; }

  
        public List<ProductImages> ProductImageList { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public bool IsVariant { get; set; }
        public int? ProductVariantId { get; set; }
        public List<ProductVariant> ProductVariantList { get; set; }

        public List<PricingPromo> PricingPromoList { get; set; }

        public int? Quantity { get; set; }


        //=================================================== PosItem ===============================================


        public bool HasVariants { get; set; }

        public List<Variant> VariantList { get; set; }
        public List<Option> OptionList { get; set; }

        public decimal? SellingPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? Amount { get; set; }
        public int? VariantOfId { get; set; }
        public bool IsDescriptive { get; set; }
        public int? ProductBrandId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public DataTable<Product> DataTable { get; set; }
    }
}
