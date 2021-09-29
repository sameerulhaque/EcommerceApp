using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class inv_product
    {
        public inv_product()
        {
            inv_product_images = new HashSet<inv_product_images>();
            inv_product_pricing_promo = new HashSet<inv_product_pricing_promo>();
            inv_product_variant = new HashSet<inv_product_variant>();
            str_gin_detail = new HashSet<str_gin_detail>();
            str_grn_detail = new HashSet<str_grn_detail>();
        }

        public int product_id { get; set; }
        public string product_name { get; set; }
        public string import_product_id { get; set; }
        public int? created_by { get; set; }
        public int? modified_by { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public int? unit_of_measure_id { get; set; }
        public int? category_id { get; set; }
        public string remarks { get; set; }
        public int? is_active { get; set; }
        public int? is_approved { get; set; }
        public int? is_locked { get; set; }
        public int? approved_by { get; set; }
        public DateTime? approved_date { get; set; }
        public int? is_variant { get; set; }
        public int? product_variant_id { get; set; }
        public int? has_variants { get; set; }
        public decimal? selling_price { get; set; }
        public decimal? cost_price { get; set; }
        public int? company_id { get; set; }
        public int? product_brand_id { get; set; }

        public virtual inv_ut_category category { get; set; }
        public virtual ut_company company { get; set; }
        public virtual inv_product_brands product_brand { get; set; }
        public virtual inv_product_variant product_variant { get; set; }
        public virtual inv_ut_unit_of_measure unit_of_measure { get; set; }
        public virtual ICollection<inv_product_images> inv_product_images { get; set; }
        public virtual ICollection<inv_product_pricing_promo> inv_product_pricing_promo { get; set; }
        public virtual ICollection<inv_product_variant> inv_product_variant { get; set; }
        public virtual ICollection<str_gin_detail> str_gin_detail { get; set; }
        public virtual ICollection<str_grn_detail> str_grn_detail { get; set; }
    }
}
