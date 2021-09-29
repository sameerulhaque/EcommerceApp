using AccessLayer.EF;
using BuissnessLayer.Repositories.Implementations;
using BuissnessLayer.Repositories.Interfaces;
using Commons;
using Commons.InventoryUtilities;
using Microsoft.EntityFrameworkCore;
using ServicesLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ServicesLayer.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IBaseRepo _IBaseRepo;
        private readonly ecommerceContext dbContext;
        public ProductService(IBaseRepo IBaseRepo, ecommerceContext context)
        {
            this._IBaseRepo = IBaseRepo;
            this.dbContext = context;
        }

        public Product GetAllProducts(Product Product)
        {
            var query = dbContext.inv_product.AsQueryable();
            #region Sorting
            if (String.IsNullOrEmpty(Product.DataTable.sortField))
            {
                Product.DataTable.sortField = "product_id";
                Product.DataTable.sortOrder = "asc";
            }
            var type = typeof(AccessLayer.EF.inv_product);
            var prop = type.GetProperty(Product.DataTable.sortField);
            if (prop != null)
            {
                var param = Expression.Parameter(type);
                var expr = Expression.Lambda<Func<AccessLayer.EF.inv_product, object>>(Expression.Convert(Expression.Property(param, prop), typeof(object)), param);
                query = Product.DataTable.sortOrder == "asc" ? query.OrderBy(expr) : query.OrderByDescending(expr);
            }
            #endregion

            #region Searching

            if (Product.Id > 0)
                {
                    query = query.Where(x => x.product_id == Product.Id);
                }
                if (Product.CompanyId > 0)
                {
                    query = query.Where(x => x.company_id == Product.CompanyId);
                }
                if (!string.IsNullOrEmpty(Product.ProductName))
                {
                    query = query.Where(x => x.product_name.ToUpper().StartsWith(Product.ProductName.ToUpper()));
                }
                #endregion
                Product.TotalRecords = query.Count();
            #region Pagination
            if (Product.DataTable.pageNumber > 0)
            {
                query = query.Skip((Product.DataTable.pageNumber - 1) * Product.DataTable.pageSize);
                query = query.Take(Product.DataTable.pageSize);
            }
            #endregion
            #region Selection
            var itemList = new List<inv_product>();
            if (Product.IsDescriptive)
            {
                itemList = query
                    .Include(x => x.company)
                    .Include(x => x.unit_of_measure)
                    .Include(x => x.category)
                    .Include(x => x.product_brand)
                    .Include(x => x.product_variant)
                    .Include(x => x.inv_product_images)
                    .Include(x => x.inv_product_pricing_promo).ThenInclude(x => x.promo)
                    .Include(x => x.inv_product_variant).ThenInclude(x => x.inv_product)
                    .Include(x => x.inv_product_variant).ThenInclude(x => x.product)
                    .Include(x => x.inv_product_variant).ThenInclude(x => x.inv_product_variant_details).ThenInclude(x => x.variant).ThenInclude(x => x.option)
                    .ToList();
            }
            else
            {
                itemList = query
                    .Include(x => x.company)
                    .Include(x => x.unit_of_measure)
                    .Include(x => x.category)
                    .Include(x => x.product_brand)
                    .ToList();
            }

            var ProductList = new List<Product>();
            var view_inv_stock_management = dbContext.view_inv_stock_management.AsEnumerable().Where(x => itemList.Any(y => y.product_id == x.product_id)).ToList();
            foreach (var item in itemList)
            {
                Product product = new Product();
                product.Id = item.product_id;
                product.ProductName = item.product_name;
                product.SellingPrice = item.selling_price;
                product.CostPrice = item.cost_price;

                var Thisview_inv_stock_management = view_inv_stock_management.Where(x => x.product_id == item.product_id).FirstOrDefault();
                product.Quantity = (int)(Thisview_inv_stock_management != null ? Thisview_inv_stock_management.quantity : 0);

                product.CompanyId = item.company_id;
                if (item.company != null)
                {
                    product.Company = new Company() { CompanyName = item.company.company_name, Id = item.company_id ?? 0 };
                }

                product.UnitOfMeasureId = item.unit_of_measure_id;
                if (item.unit_of_measure != null)
                {
                    product.UnitOfMeasure = new UnitOfMeasure() { UnitOfMeasureName = item.unit_of_measure.unit_of_measure_name, Id = item.unit_of_measure_id ?? 0 };
                }


                product.CategoryId = item.category_id;
                if (item.category != null)
                {
                    product.Category = new Category() { CategoryName = item.category.category_name, Id = item.category_id ?? 0 };
                }

                product.ProductBrandId = item.product_brand_id;
                if (item.product_brand != null)
                {
                    product.ProductBrand = new ProductBrand() { ProductBrandName = item.product_brand.product_brand_name, Id = item.product_brand_id ?? 0 };
                }

                if (Product.IsDescriptive)
                {
                    #region Images
                    //Product Images
                    foreach (var image in item.inv_product_images.Where(x => x.is_active == 1))
                    {
                        ProductImages productImages = new ProductImages();
                        productImages.Id = image.product_images_id;
                        productImages.ImageUrl = image.image_url;
                        product.ProductImageList.Add(productImages);
                    }
                    #endregion

                    #region Promo
                    foreach (var PricingTaxitem in item.inv_product_pricing_promo.Where(y => y.is_active == 1))
                    {
                        PricingPromo PricingTax = new PricingPromo();

                        PricingTax.Id = PricingTaxitem.pricing_promo_id;
                        PricingTax.PromoId = PricingTaxitem.promo_id;
                        if (PricingTaxitem.promo != null)
                        {
                            PricingTax.Promo.PromoName = PricingTaxitem.promo.promo_name;
                            PricingTax.Promo.Amount = PricingTaxitem.promo.amount;
                            PricingTax.Promo.Percentage = PricingTaxitem.promo.percentage;
                            product.PricingPromoList.Add(PricingTax);
                        }
                    }
                    #endregion

                    #region Variants
                    //Is Variant
                    product.IsVariant = Convert.ToBoolean(item.is_variant);
                    product.ProductVariantId = item.product_variant_id;
                    if (item.product_variant != null)
                    {
                        product.VariantOfId = item.product_variant.product_id;
                    }

                    //Has Variants

                    product.HasVariants = Convert.ToBoolean(item.inv_product_variant.Where(x => x.is_active == 1).Count() > 0 ? 1 : 0);
                    var VariantList = item.inv_product_variant.Where(x => x.is_active == 1).ToList();

                    foreach (var Variant in VariantList)
                    {
                        var ThisProduct = Variant.inv_product.FirstOrDefault();
                        if (ThisProduct != null)
                        {
                            ProductVariant ProductVariants = new ProductVariant();
                            ProductVariants.Id = item.product_variant_id ?? 0;
                            ProductVariants.Product = GetAllProducts(new Product() { Id = ThisProduct.product_id }).ThisClassList.Cast<Product>().FirstOrDefault();
                            foreach (var VariantDetails in Variant.inv_product_variant_details.Select(x => x.variant))
                            {
                                Variant variantobj = new Variant();
                                variantobj.Id = VariantDetails.variant_id;
                                variantobj.Name = VariantDetails.variant_name;
                                variantobj.OptionId = VariantDetails.option_id;
                                if (VariantDetails.option != null)
                                {
                                    variantobj.OptionName = VariantDetails.option.option_name;
                                }
                                ProductVariants.VariantList.Add(variantobj);
                            }
                            product.ProductVariantList.Add(ProductVariants);
                        }
                    }
                    #endregion
                }

                product.DateCreated = item.created_date.HasValue == true ? item.created_date.Value : DateTime.Now;
                product.DateModified = item.modified_date.HasValue == true ? item.modified_date.Value : DateTime.Now;
                product.CreatedBy = item.created_by.HasValue == true ? item.created_by.Value : 0;
                product.ModifiedBy = item.modified_by.HasValue == true ? item.modified_by.Value : 0;

                ProductList.Add(product);
            }
            Product.ThisClassList = ProductList.Cast<Object>().ToList();
            #endregion
            return Product;
        }
        public Product AddProduct(Product product)
        {
            var inv_product = dbContext.inv_product.AsQueryable();
            var IsExist = inv_product.Where(x => x.is_active == 1 && x.product_name == product.ProductName && x.company_id == product.CompanyId).FirstOrDefault();
            if (IsExist == null)
            {
                inv_product inv_Product = new inv_product();
                if (product.IsVariant)
                {
                    var VaraintOf = inv_product.Where(x => x.product_id == product.Id).FirstOrDefault();
                    if (VaraintOf != null)
                    {
                        VaraintOf.has_variants = 1;
                        product.CategoryId = VaraintOf.category_id;
                        product.UnitOfMeasureId = VaraintOf.unit_of_measure_id;
                        product.CompanyId = VaraintOf.company_id;
                        product.ProductBrandId = VaraintOf.product_brand_id;
                        product.SellingPrice = product.SellingPrice.HasValue ? (product.SellingPrice.Value == 0 ? VaraintOf.selling_price : product.SellingPrice) : VaraintOf.selling_price;
                        product.CostPrice = product.CostPrice.HasValue ? (product.CostPrice.Value == 0 ? VaraintOf.cost_price : product.CostPrice) : VaraintOf.cost_price;
                    }
                    inv_Product.is_variant = 1;
                    inv_Product.product_variant_id = product.ProductVariantId;
                }
                inv_Product.product_name = product.ProductName;
                inv_Product.category_id = product.CategoryId;
                inv_Product.company_id = product.CompanyId;
                inv_Product.unit_of_measure_id = product.UnitOfMeasureId;
                inv_Product.product_brand_id = product.ProductBrandId;

                inv_Product.has_variants = Convert.ToInt32(product.HasVariants);
                if (!product.HasVariants)
                {
                    inv_Product.selling_price = product.SellingPrice;
                    inv_Product.cost_price = product.CostPrice;
                    foreach (var item in product.PricingPromoList)
                    {
                        inv_product_pricing_promo inv_product_pricing_tax = new inv_product_pricing_promo();
                        inv_product_pricing_tax.promo_id = item.PromoId;
                        inv_product_pricing_tax.created_date = DateTime.Now;
                        inv_product_pricing_tax.modified_date = DateTime.Now;
                        inv_product_pricing_tax.created_by = 1;
                        inv_product_pricing_tax.modified_by = 1;
                        inv_product_pricing_tax.is_active = 1;
                        inv_product_pricing_tax.is_locked = 1;
                        inv_product_pricing_tax.import_pricing_promo_id = "0";
                        inv_product_pricing_tax.remarks = "";
                        inv_Product.inv_product_pricing_promo.Add(inv_product_pricing_tax);
                    }
                    if (product.Quantity > 0)
                    {
                        str_grn_detail str_grn_detail = new str_grn_detail();
                        str_grn_detail.unit_of_measure_id = product.UnitOfMeasureId;
                        str_grn_detail.currency_id = 1;
                        str_grn_detail.exchange_rate = 1;
                        str_grn_detail.amount = product.Quantity * product.CostPrice;
                        str_grn_detail.quantity = product.Quantity;
                        str_grn_detail.date = DateTime.Now;
                        str_grn_detail.created_date = DateTime.Now;
                        str_grn_detail.modified_date = DateTime.Now;
                        str_grn_detail.created_by = 1;
                        str_grn_detail.modified_by = 1;
                        str_grn_detail.is_active = 1;
                        str_grn_detail.is_locked = 1;
                        str_grn_detail.import_grn_detail_id = "0";
                        str_grn_detail.remarks = "";
                        inv_Product.str_grn_detail.Add(str_grn_detail);
                    }
                }
                dbContext.inv_product.Add(inv_Product);
                dbContext.SaveChanges();
                product.Message = "Product Added Successfully";
                product.Id = inv_Product.product_id;
                if (product.HasVariants)
                {
                    try
                    {
                        product.Message += AddProductVariants(product).Message;
                    }
                    catch (Exception)
                    {
                        product.Message += " Variant Can't be saved";
                    }
                }
            }
            else
            {
                product.Message = "Product Name Already Exist!";
            }
            return product;
        }
        private Product AddProductVariants(Product Obj)
        {
            try
            {
                List<inv_product_variant> inv_product_variants = new List<inv_product_variant>();

                List<inv_product_variant_details> inv_product_variant_details_list = new List<inv_product_variant_details>();
                var inv_product_variant = dbContext.inv_product_variant.Where(x => x.is_active == 1).AsQueryable();

                foreach (var item in Obj.ProductVariantList)
                {
                    var ProductNameExist = inv_product_variant.Where(x => x.product_variant_name.ToUpper() == item.Name.ToUpper() && x.product.company_id == Obj.CompanyId).FirstOrDefault();
                    if (ProductNameExist == null)
                    {
                        inv_product_variant ProductVariantObjDb = new inv_product_variant();
                        ProductVariantObjDb.product_id = Obj.Id;
                        ProductVariantObjDb.product_variant_name = item.Name;
                        foreach (var ProductVariantitem in item.VariantIds)
                        {
                            inv_product_variant_details inv_product_variant_details = new inv_product_variant_details();
                            inv_product_variant_details.variant_id = ProductVariantitem;
                            inv_product_variant_details.created_date = DateTime.Now;
                            inv_product_variant_details.modified_date = DateTime.Now;
                            inv_product_variant_details.created_by = 1;
                            inv_product_variant_details.modified_by = 1;
                            inv_product_variant_details.is_active = 1;
                            inv_product_variant_details.is_locked = 1;
                            ProductVariantObjDb.inv_product_variant_details.Add(inv_product_variant_details);
                        }

                        ProductVariantObjDb.created_date = DateTime.Now;
                        ProductVariantObjDb.modified_date = DateTime.Now;
                        ProductVariantObjDb.created_by = 1;
                        ProductVariantObjDb.modified_by = 1;
                        ProductVariantObjDb.is_active = 1;
                        ProductVariantObjDb.is_locked = 1;
                        inv_product_variants.Add(ProductVariantObjDb);
                    }
                    else
                    {
                        Obj.Message += item.Name + " Product Name Already Exist";
                    }


                }
                dbContext.inv_product_variant.AddRange(inv_product_variants);
                dbContext.SaveChanges();
                foreach (var item in inv_product_variants)
                {
                    var ProductParms = Obj.ProductVariantList.Where(x => x.Name.ToUpper() == item.product_variant_name.ToUpper()).FirstOrDefault();

                    Product product = new Product();
                    product.ProductName = item.product_variant_name;
                    product.Id = item.product_id ?? 0;
                    product.ProductVariantId = item.product_variant_id;
                    product.IsVariant = true;
                    product.SellingPrice = ProductParms.SellingPrice;
                    product.CostPrice = ProductParms.CostPrice;
                    product.Quantity = ProductParms.Quantity;
                    product.PricingPromoList = Obj.PricingPromoList;
                    AddProduct(product);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return Obj;
        }
        private Product UpdateProductVaraints(Product Obj)
        {

            try
            {
                List<inv_product_variant> inv_product_variants = new List<inv_product_variant>();

                List<inv_product_variant_details> inv_product_variant_details_list = new List<inv_product_variant_details>();
                var inv_product_variant = dbContext.inv_product_variant.Where(x => x.is_active == 1).ToList();

                var itemsToDelete = inv_product_variant.Where(y => !Obj.ProductVariantList.Any(z => z.Id == y.product_variant_id)).ToList();
                foreach (var item in itemsToDelete)
                {
                    item.is_active = 0;
                    foreach (var inv_product_variant_details in item.inv_product_variant_details)
                    {
                        inv_product_variant_details.is_active = 0;
                    }
                }
                foreach (var item in Obj.ProductVariantList)
                {
                    var ProductVariantIsExist = inv_product_variant.Where(x => x.product_id == Obj.Id && x.product_variant_id == item.Id && item.Id != 0).FirstOrDefault();
                    if (ProductVariantIsExist == null)
                    {
                        var ProductNameExist = inv_product_variant.Where(x => x.product_variant_name.ToUpper() == item.Name.ToUpper() && x.product.company_id == Obj.CompanyId).FirstOrDefault();
                        if (ProductNameExist == null)
                        {
                            inv_product_variant ProductVariantObjDb = new inv_product_variant();
                            ProductVariantObjDb.product_id = Obj.Id;
                            ProductVariantObjDb.product_variant_name = item.Name;
                            foreach (var ProductVariantitem in item.VariantIds)
                            {
                                inv_product_variant_details inv_product_variant_details = new inv_product_variant_details();
                                inv_product_variant_details.variant_id = ProductVariantitem;
                                inv_product_variant_details.created_date = DateTime.Now;
                                inv_product_variant_details.modified_date = DateTime.Now;
                                inv_product_variant_details.created_by = 1;
                                inv_product_variant_details.modified_by = 1;
                                inv_product_variant_details.is_active = 1;
                                inv_product_variant_details.is_locked = 1;
                                ProductVariantObjDb.inv_product_variant_details.Add(inv_product_variant_details);
                            }

                            ProductVariantObjDb.created_date = DateTime.Now;
                            ProductVariantObjDb.modified_date = DateTime.Now;
                            ProductVariantObjDb.created_by = 1;
                            ProductVariantObjDb.modified_by = 1;
                            ProductVariantObjDb.is_active = 1;
                            ProductVariantObjDb.is_locked = 1;
                            inv_product_variants.Add(ProductVariantObjDb);
                        }
                        else
                        {
                            Obj.Message += item.Name + " Product Name Already Exist";
                        }
                    }
                    else
                    {
                        ProductVariantIsExist.product_id = Obj.Id;
                        ProductVariantIsExist.product_variant_name = item.Name;

                        foreach (var ProductVariantitem in item.VariantIds)
                        {
                            var ProductVariantDetailsForProductVariant = ProductVariantIsExist.inv_product_variant_details.Where(x => x.variant_id == ProductVariantitem).FirstOrDefault();
                            if (ProductVariantDetailsForProductVariant == null)
                            {
                                inv_product_variant_details inv_product_variant_details = new inv_product_variant_details();
                                inv_product_variant_details.variant_id = ProductVariantitem;

                                inv_product_variant_details.created_date = DateTime.Now;
                                inv_product_variant_details.modified_date = DateTime.Now;
                                inv_product_variant_details.created_by = 1;
                                inv_product_variant_details.modified_by = 1;
                                inv_product_variant_details.is_active = 1;
                                inv_product_variant_details.is_locked = 1;
                                inv_product_variant_details.import_product_variant_details_id = "0";
                                inv_product_variant_details.remarks = "";
                                ProductVariantIsExist.inv_product_variant_details.Add(inv_product_variant_details);
                            }
                        }

                        var VariantDetailsToDelete = ProductVariantIsExist.inv_product_variant_details.Where(y => !item.VariantIds.Any(z => z == y.variant_id)).ToList();
                        foreach (var VariantDetail in VariantDetailsToDelete)
                        {
                            VariantDetail.is_active = 0;
                        }
                        ProductVariantIsExist.modified_date = DateTime.Now;
                        ProductVariantIsExist.modified_by = 1;
                    }

                }
                dbContext.inv_product_variant.AddRange(inv_product_variants);
                dbContext.SaveChanges();
                foreach (var item in inv_product_variants)
                {
                    var ProductParms = Obj.ProductVariantList.Where(x => x.Name.ToUpper() == item.product_variant_name.ToUpper()).FirstOrDefault();

                    Product product = new Product();
                    product.ProductName = item.product_variant_name;
                    product.Id = item.product_id ?? 0;
                    product.ProductVariantId = item.product_variant_id;
                    product.IsVariant = true;
                    product.SellingPrice = ProductParms.SellingPrice;
                    product.CostPrice = ProductParms.CostPrice;
                    product.Quantity = ProductParms.Quantity;
                    AddProduct(product);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return Obj;


        }

    }
}
