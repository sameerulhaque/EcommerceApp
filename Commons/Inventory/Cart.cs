//using Commons.InventoryUtilities;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Commons.Inventory
//{
//    public class Cart:AbstractEntity
//    {
//        public Cart()
//        {
//            ProductList = new List<Product>();
//            Product = new Product();

//            PromoList = new List<Promo>();
//            Promo = new Promo();

//            TaxList = new List<Tax>();
//            Tax = new Tax();

//            UserSessionList = new List<UserSession>();
//            UserSession = new UserSession();

//            CartList = new List<Cart>();
//        }

//        public int ProductId { get; set; }
//        public Product Product { get; set; }
//        public List<Product> ProductList { get; set; }

//        public int PromoId { get; set; }
//        public Promo Promo { get; set; }
//        public List<Promo> PromoList { get; set; }

//        public int TaxId { get; set; }
//        public Tax Tax { get; set; }
//        public List<Tax> TaxList { get; set; }

//        public bool ChangeCostPriceDuringSale { get; set; }
//        public decimal DiscountAmount { get; set; }
//        public decimal DiscountPercentage { get; set; }

//        public int Quantity { get; set; }

//        public int SessionId { get; set; }
//        public UserSession UserSession { get; set; }
//        public List<UserSession> UserSessionList { get; set; }

//        public List<Cart> CartList { get; set; }

//    }
//}
