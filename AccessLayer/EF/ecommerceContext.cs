using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AccessLayer.EF
{
    public partial class ecommerceContext : DbContext
    {
        public ecommerceContext()
        {
        }

        public ecommerceContext(DbContextOptions<ecommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<inv_order> inv_order { get; set; }
        public virtual DbSet<inv_product> inv_product { get; set; }
        public virtual DbSet<inv_product_brands> inv_product_brands { get; set; }
        public virtual DbSet<inv_product_images> inv_product_images { get; set; }
        public virtual DbSet<inv_product_pricing_promo> inv_product_pricing_promo { get; set; }
        public virtual DbSet<inv_product_variant> inv_product_variant { get; set; }
        public virtual DbSet<inv_product_variant_details> inv_product_variant_details { get; set; }
        public virtual DbSet<inv_ut_category> inv_ut_category { get; set; }
        public virtual DbSet<inv_ut_offer> inv_ut_offer { get; set; }
        public virtual DbSet<inv_ut_option> inv_ut_option { get; set; }
        public virtual DbSet<inv_ut_party> inv_ut_party { get; set; }
        public virtual DbSet<inv_ut_promo> inv_ut_promo { get; set; }
        public virtual DbSet<inv_ut_unit_of_measure> inv_ut_unit_of_measure { get; set; }
        public virtual DbSet<inv_ut_variant> inv_ut_variant { get; set; }
        public virtual DbSet<str_gin_detail> str_gin_detail { get; set; }
        public virtual DbSet<str_grn_detail> str_grn_detail { get; set; }
        public virtual DbSet<ut_company> ut_company { get; set; }
        public virtual DbSet<ut_currency> ut_currency { get; set; }
        public virtual DbSet<ut_form_action> ut_form_action { get; set; }
        public virtual DbSet<ut_form_code> ut_form_code { get; set; }
        public virtual DbSet<ut_form_layout> ut_form_layout { get; set; }
        public virtual DbSet<ut_user> ut_user { get; set; }
        public virtual DbSet<ut_user_role> ut_user_role { get; set; }
        public virtual DbSet<view_inv_stock_management> view_inv_stock_management { get; set; }
        public virtual DbSet<view_inv_stock_management_transations> view_inv_stock_management_transations { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<inv_order>(entity =>
            {
                entity.HasKey(e => e.order_id)
                    .HasName("PK_user_type_copy1_copy1_copy2_copy1_copy1_copy1_copy1_copy2_copy1_copy4_copy2_copy4_copy1");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((11)/(6))/(2020))");

                entity.Property(e => e.import_order_id)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.net_amount)
                    .HasColumnType("decimal(24, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.Property(e => e.transaction_number)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.company)
                    .WithMany(p => p.inv_order)
                    .HasForeignKey(d => d.company_id)
                    .HasConstraintName("FK__inv_sale___compa__5D95E53A");

                entity.HasOne(d => d.customer)
                    .WithMany(p => p.inv_order)
                    .HasForeignKey(d => d.customer_id)
                    .HasConstraintName("FK__inv_order__custo__69FBBC1F");
            });

            modelBuilder.Entity<inv_product>(entity =>
            {
                entity.HasKey(e => e.product_id)
                    .HasName("PK_product");

                entity.Property(e => e.approved_date).HasColumnType("datetime");

                entity.Property(e => e.category_id).HasDefaultValueSql("((0))");

                entity.Property(e => e.company_id).HasDefaultValueSql("((1))");

                entity.Property(e => e.cost_price)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.has_variants).HasDefaultValueSql("((0))");

                entity.Property(e => e.import_product_id).HasMaxLength(250);

                entity.Property(e => e.is_variant).HasDefaultValueSql("((0))");

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.product_name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.product_variant_id)
                    .HasDefaultValueSql("((1))")
                    .HasComment("if variant, then id of that varaint else nothing");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.Property(e => e.selling_price)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.category)
                    .WithMany(p => p.inv_product)
                    .HasForeignKey(d => d.category_id)
                    .HasConstraintName("FK__product__categor__6BE40491");

                entity.HasOne(d => d.company)
                    .WithMany(p => p.inv_product)
                    .HasForeignKey(d => d.company_id)
                    .HasConstraintName("FK__inv_produ__compa__2CF2ADDF");

                entity.HasOne(d => d.product_brand)
                    .WithMany(p => p.inv_product)
                    .HasForeignKey(d => d.product_brand_id)
                    .HasConstraintName("FK__inv_produ__produ__756D6ECB");

                entity.HasOne(d => d.product_variant)
                    .WithMany(p => p.inv_product)
                    .HasForeignKey(d => d.product_variant_id)
                    .HasConstraintName("FK__inv_produ__produ__511AFFBC");

                entity.HasOne(d => d.unit_of_measure)
                    .WithMany(p => p.inv_product)
                    .HasForeignKey(d => d.unit_of_measure_id)
                    .HasConstraintName("FK__product__unit_of__6AEFE058");
            });

            modelBuilder.Entity<inv_product_brands>(entity =>
            {
                entity.HasKey(e => e.product_brand_id)
                    .HasName("unit_of_measure_id_copy1");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_product_brand_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.product_brand_name).HasMaxLength(250);

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.HasOne(d => d.company)
                    .WithMany(p => p.inv_product_brands)
                    .HasForeignKey(d => d.company_id)
                    .HasConstraintName("FK__inv_ut_un__compa__73852659");
            });

            modelBuilder.Entity<inv_product_images>(entity =>
            {
                entity.HasKey(e => e.product_images_id)
                    .HasName("PK_user_copy1_copy1_copy1_copy1_copy5");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.image_url).HasColumnType("text");

                entity.Property(e => e.import_product_images_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.HasOne(d => d.product)
                    .WithMany(p => p.inv_product_images)
                    .HasForeignKey(d => d.product_id)
                    .HasConstraintName("FK__inv_ut_pr__produ__59D0414E");
            });

            modelBuilder.Entity<inv_product_pricing_promo>(entity =>
            {
                entity.HasKey(e => e.pricing_promo_id)
                    .HasName("PK_user_type_copy1_copy1_copy2_copy2_copy3_copy1_copy1_copy2_copy1_copy1_copy1");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_pricing_promo_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.product_id).HasDefaultValueSql("((5))");

                entity.Property(e => e.promo_id).HasDefaultValueSql("((1))");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.HasOne(d => d.product)
                    .WithMany(p => p.inv_product_pricing_promo)
                    .HasForeignKey(d => d.product_id)
                    .HasConstraintName("FK__inv_produ__produ__41EDCAC5");

                entity.HasOne(d => d.promo)
                    .WithMany(p => p.inv_product_pricing_promo)
                    .HasForeignKey(d => d.promo_id)
                    .HasConstraintName("FK__inv_ut_pr__promo__2B155265");
            });

            modelBuilder.Entity<inv_product_variant>(entity =>
            {
                entity.HasKey(e => e.product_variant_id)
                    .HasName("PK_user_type_copy1_copy1_copy2_copy2_copy3_copy1_copy2");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_product_variant_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.product_id)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Main product id (non variant product)");

                entity.Property(e => e.product_variant_name).HasMaxLength(255);

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.HasOne(d => d.product)
                    .WithMany(p => p.inv_product_variant)
                    .HasForeignKey(d => d.product_id)
                    .HasConstraintName("FK__inv_produ__produ__2042BE37");
            });

            modelBuilder.Entity<inv_product_variant_details>(entity =>
            {
                entity.HasKey(e => e.product_variant_details_id)
                    .HasName("PK_user_type_copy1_copy1_copy2_copy2_copy3_copy1_copy2_copy1");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_product_variant_details_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.product_variant_id).HasDefaultValueSql("((1))");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.HasOne(d => d.product_variant)
                    .WithMany(p => p.inv_product_variant_details)
                    .HasForeignKey(d => d.product_variant_id)
                    .HasConstraintName("FK__inv_ut_pr__produ__2FDA0782");

                entity.HasOne(d => d.variant)
                    .WithMany(p => p.inv_product_variant_details)
                    .HasForeignKey(d => d.variant_id)
                    .HasConstraintName("FK__inv_ut_pr__varia__7D4E87B5");
            });

            modelBuilder.Entity<inv_ut_category>(entity =>
            {
                entity.HasKey(e => e.category_id)
                    .HasName("PK_category");

                entity.Property(e => e.category_name).HasMaxLength(250);

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_category_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.remarks).HasMaxLength(800);
            });

            modelBuilder.Entity<inv_ut_offer>(entity =>
            {
                entity.HasKey(e => e.offer_id)
                    .HasName("PK__inv_ut_o__03D37AC26F989227");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_offer_id)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.offer_name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.remarks)
                    .IsRequired()
                    .HasMaxLength(800);
            });

            modelBuilder.Entity<inv_ut_option>(entity =>
            {
                entity.HasKey(e => e.option_id)
                    .HasName("PK_user_type_copy1_copy1_copy4fbrc1");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_option_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.option_name).HasMaxLength(100);

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.Property(e => e.short_code).HasMaxLength(10);

                entity.HasOne(d => d.company)
                    .WithMany(p => p.inv_ut_option)
                    .HasForeignKey(d => d.company_id)
                    .HasConstraintName("FK__inv_ut_pr__compa__6CD828Cc");
            });

            modelBuilder.Entity<inv_ut_party>(entity =>
            {
                entity.HasKey(e => e.party_id)
                    .HasName("PK_user_type_copy1_copy1_copy2_copy1_copy2");

                entity.Property(e => e.address).HasMaxLength(255);

                entity.Property(e => e.cnic).HasMaxLength(50);

                entity.Property(e => e.contact_person).HasMaxLength(255);

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.email).HasMaxLength(100);

                entity.Property(e => e.fax).HasMaxLength(100);

                entity.Property(e => e.import_party_id).HasMaxLength(250);

                entity.Property(e => e.mobile).HasMaxLength(50);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.name).HasMaxLength(255);

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.Property(e => e.short_name).HasMaxLength(50);

                entity.Property(e => e.website).HasMaxLength(100);

                entity.HasOne(d => d.company)
                    .WithMany(p => p.inv_ut_party)
                    .HasForeignKey(d => d.company_id)
                    .HasConstraintName("FK__inv_ut_pa__compa__70A8B9AE");
            });

            modelBuilder.Entity<inv_ut_promo>(entity =>
            {
                entity.HasKey(e => e.promo_id)
                    .HasName("PK_user_type_copy1_copy1_copy2_copy2_copy3_copy1_copy1_copy1");

                entity.Property(e => e.amount)
                    .HasColumnType("decimal(24, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_promo_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.percentage)
                    .HasColumnType("decimal(24, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.promo_name).HasMaxLength(255);

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.HasOne(d => d.company)
                    .WithMany(p => p.inv_ut_promo)
                    .HasForeignKey(d => d.company_id)
                    .HasConstraintName("FK__inv_ut_pr__compa__6CD828CA");
            });

            modelBuilder.Entity<inv_ut_unit_of_measure>(entity =>
            {
                entity.HasKey(e => e.unit_of_measure_id)
                    .HasName("unit_of_measure_id");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_unit_of_measure_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.Property(e => e.unit_of_measure_name).HasMaxLength(250);
            });

            modelBuilder.Entity<inv_ut_variant>(entity =>
            {
                entity.HasKey(e => e.variant_id)
                    .HasName("PK_user_type_copy1_copy1_copy4_copy1fbrc");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_variant_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.option_id).HasDefaultValueSql("((1))");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.Property(e => e.short_code).HasMaxLength(10);

                entity.Property(e => e.variant_name).HasMaxLength(100);

                entity.HasOne(d => d.company)
                    .WithMany(p => p.inv_ut_variant)
                    .HasForeignKey(d => d.company_id)
                    .HasConstraintName("FK__inv_ut_pr__compa__6CD828Cd");

                entity.HasOne(d => d.option)
                    .WithMany(p => p.inv_ut_variant)
                    .HasForeignKey(d => d.option_id)
                    .HasConstraintName("FK__fbrc_ut_v__optio__731B1205");
            });

            modelBuilder.Entity<str_gin_detail>(entity =>
            {
                entity.HasKey(e => e.gin_detail_id)
                    .HasName("PK__str_grn___852FF21EF659A75D_copy1");

                entity.Property(e => e.amount).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.date).HasColumnType("datetime");

                entity.Property(e => e.exchange_rate).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.import_gin_detail_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.quantity).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.HasOne(d => d.currency)
                    .WithMany(p => p.str_gin_detail)
                    .HasForeignKey(d => d.currency_id)
                    .HasConstraintName("FK__str_gin_d__curre__3C34F16F");

                entity.HasOne(d => d.order)
                    .WithMany(p => p.str_gin_detail)
                    .HasForeignKey(d => d.order_id)
                    .HasConstraintName("FK__str_gin_d__order__5F7E2DAC");

                entity.HasOne(d => d.product)
                    .WithMany(p => p.str_gin_detail)
                    .HasForeignKey(d => d.product_id)
                    .HasConstraintName("FK__str_gin_d__produ__37703C52");

                entity.HasOne(d => d.unit_of_measure)
                    .WithMany(p => p.str_gin_detail)
                    .HasForeignKey(d => d.unit_of_measure_id)
                    .HasConstraintName("FK__str_gin_d__unit___3864608B");
            });

            modelBuilder.Entity<str_grn_detail>(entity =>
            {
                entity.HasKey(e => e.grn_detail_id)
                    .HasName("PK__str_grn___852FF21EF659A75D");

                entity.Property(e => e.amount).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.date).HasColumnType("datetime");

                entity.Property(e => e.exchange_rate).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.import_grn_detail_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.quantity).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.HasOne(d => d.currency)
                    .WithMany(p => p.str_grn_detail)
                    .HasForeignKey(d => d.currency_id)
                    .HasConstraintName("FK__str_gin_d__curre__3C34F17F");

                entity.HasOne(d => d.product)
                    .WithMany(p => p.str_grn_detail)
                    .HasForeignKey(d => d.product_id)
                    .HasConstraintName("FK__str_gin_d__produ__37703C53");

                entity.HasOne(d => d.unit_of_measure)
                    .WithMany(p => p.str_grn_detail)
                    .HasForeignKey(d => d.unit_of_measure_id)
                    .HasConstraintName("FK__str_gin_d__unit___3864609B");
            });

            modelBuilder.Entity<ut_company>(entity =>
            {
                entity.HasKey(e => e.company_id)
                    .HasName("PK_user_copy1_copy1");

                entity.Property(e => e.address).HasMaxLength(100);

                entity.Property(e => e.company_name).HasMaxLength(250);

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.email).HasMaxLength(50);

                entity.Property(e => e.fax).HasMaxLength(50);

                entity.Property(e => e.import_company_id).HasMaxLength(250);

                entity.Property(e => e.mobile).HasMaxLength(50);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.ntn_no).HasMaxLength(50);

                entity.Property(e => e.remarks).HasMaxLength(800);

                entity.Property(e => e.sales_tax_no).HasMaxLength(50);

                entity.Property(e => e.short_name).HasMaxLength(50);

                entity.Property(e => e.website).HasMaxLength(50);
            });

            modelBuilder.Entity<ut_currency>(entity =>
            {
                entity.HasKey(e => e.currency_id)
                    .HasName("PK_user_type_copy1_copy1");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.currency_name).HasMaxLength(100);

                entity.Property(e => e.exchange_rate).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.import_currency_id).HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.remarks).HasMaxLength(800);
            });

            modelBuilder.Entity<ut_form_action>(entity =>
            {
                entity.HasKey(e => e.action_id)
                    .HasName("PK_action");

                entity.Property(e => e.action_name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.display_name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.form_code_id).HasDefaultValueSql("((1))");

                entity.Property(e => e.import_action_id)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.remarks)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.HasOne(d => d.form_code)
                    .WithMany(p => p.ut_form_action)
                    .HasForeignKey(d => d.form_code_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ut_form_a__form___0B7CAB7B");
            });

            modelBuilder.Entity<ut_form_code>(entity =>
            {
                entity.HasKey(e => e.form_code_id)
                    .HasName("PK__ut_form___B943269AA9F9ABAE");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.form_code_action).HasMaxLength(100);

                entity.Property(e => e.form_code_name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.href)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.import_form_code_id)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.label_text)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.language_id).HasDefaultValueSql("((1))");

                entity.Property(e => e.main_module).HasMaxLength(100);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.view_module).HasMaxLength(100);

                entity.Property(e => e.view_role).HasMaxLength(100);
            });

            modelBuilder.Entity<ut_form_layout>(entity =>
            {
                entity.HasKey(e => e.layout_id)
                    .HasName("PK_user_type_copy1_copy1_copy4_copy2_copy1");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.form_code_id).HasDefaultValueSql("((1))");

                entity.Property(e => e.import_layout_id)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.parent_code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.span).HasColumnType("text");

                entity.HasOne(d => d.form_code)
                    .WithMany(p => p.ut_form_layout)
                    .HasForeignKey(d => d.form_code_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ut_form_l__form___44CB02C7");
            });

            modelBuilder.Entity<ut_user>(entity =>
            {
                entity.HasKey(e => e.user_id)
                    .HasName("PK_user");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.import_user_id)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.mobile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.remarks)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.Property(e => e.show_password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.user_name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ut_user_role>(entity =>
            {
                entity.HasKey(e => e.user_role_id)
                    .HasName("PK_user_role");

                entity.Property(e => e.created_date).HasColumnType("datetime");

                entity.Property(e => e.import_user_role_id)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.modified_date).HasColumnType("datetime");

                entity.Property(e => e.remarks)
                    .IsRequired()
                    .HasMaxLength(800);

                entity.HasOne(d => d.action)
                    .WithMany(p => p.ut_user_role)
                    .HasForeignKey(d => d.action_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__user_role__actio__3B75D760");

                entity.HasOne(d => d.user)
                    .WithMany(p => p.ut_user_role)
                    .HasForeignKey(d => d.user_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__user_role__user___3C69FB99");
            });

            modelBuilder.Entity<view_inv_stock_management>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_inv_stock_management");

                entity.Property(e => e.product_name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.quantity).HasColumnType("decimal(38, 6)");
            });

            modelBuilder.Entity<view_inv_stock_management_transations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_inv_stock_management_transations");

                entity.Property(e => e.amount).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.currency_name).HasMaxLength(100);

                entity.Property(e => e.date).HasColumnType("datetime");

                entity.Property(e => e.exchange_rate).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.is_grn)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.product_name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.quantity).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.unit_of_measure_name).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
