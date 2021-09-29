////using Commons.AccountUtilities;
//using Commons.InventoryUtilities;
//using Commons.Utilities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Commons.Inventory
//{
//    public class Purchase : AbstractEntity
//    {
//        public Purchase()
//        {
//            //CompanyCostCenters = new CompanyCostCenters();
//            //CompanyCostCentersList = new List<CompanyCostCenters>();

//            Supplier = new InventoryUtilities.Vendor();
//            SupplierList = new List<InventoryUtilities.Vendor>();

//            PurchaseType = new Category();
//            PurchaseTypeList = new List<Category>();

//            ProductList = new List<Product>();
//            Product = new Product();

//            RFPNo = new RFP();
//            RFPNoList = new List<RFP>();

//            PurchaseOrderReceivingList = new List<PurchaseOrderReceiving>();
//            PurchaseOrderReceiving = new PurchaseOrderReceiving();

//            Store = new Store();
//            StoreList = new List<Store>();

//            PaymentType = new PaymentType();
//            PaymentTypeList = new List<PaymentType>();

//            //Account = new Account();
//            //AccountList = new List<Account>();

//            PurchaseOrder = new PurchaseOrder();
//            PurchaseOrderList = new List<PurchaseOrder>();


//            PurchaseDetails = new PurchaseDetails();
//            PurchaseDetailsList = new List<PurchaseDetails>();

//            PurchaseList = new List<Purchase>();

//        }

//        public string PurchaseNo { get; set; }

//        //public CompanyCostCenters CompanyCostCenters { get; set; }
//        public int CompanyCostCentersId { get; set; }
//        //public List<CompanyCostCenters> CompanyCostCentersList { get; set; }

//        public Store Store { get; set; }
//        public int StoreId { get; set; }
//        public List<Store> StoreList { get; set; }

//        public InventoryUtilities.Vendor Supplier { get; set; }
//        public int SupplierId { get; set; }
//        public List<InventoryUtilities.Vendor> SupplierList { get; set; }

//        public Product Product { get; set; }
//        public int GroupId { get; set; }
//        public List<Product> ProductList { get; set; }

//        public Category PurchaseType { get; set; }
//        public int PurchaseTypeId { get; set; }
//        public List<Category> PurchaseTypeList { get; set; }

//        public PaymentType PaymentType { get; set; }
//        public int PaymentTypeId { get; set; }
//        public List<PaymentType> PaymentTypeList { get; set; }



//        public DateTime PurchaseDate { get; set; }
//        public string PurchaseDateString { get; set; }

//        public DateTime ReceivingDate { get; set; }
//        public string ReceivingDateString { get; set; }


//        public DateTime DueDate { get; set; }
//        public string DueDateString { get; set; }


//        public DateTime ChequeDate { get; set; }
//        public string ChequeDateString { get; set; }
//        public string ChequeNo { get; set; }


//        public int CreditDays { get; set; }
//        public string InvoiceNumber { get; set; }
//        public string BillNo { get; set; }


//        public string PurchaseStatus { get; set; }

//        //public Account Account { get; set; }
//        public int AccountId { get; set; }
//        //public List<Account> AccountList { get; set; }

//        public bool IsPurchaseOrder { get; set; }
//        public PurchaseOrder PurchaseOrder { get; set; }
//        public int PurchaseOrderId { get; set; }
//        public List<PurchaseOrder> PurchaseOrderList { get; set; }

//        public bool IsRFP { get; set; }
//        public RFP RFPNo { get; set; }
//        public int RFPId { get; set; }
//        public List<RFP> RFPNoList { get; set; }


//        public decimal ExclusiveSTaxAmount { get; set; }
//        public decimal STaxAmount { get; set; }
//        public int QuantityTotal { get; set; }
//        public decimal TotalAmount { get; set; }
//        public decimal IncludeSTaxAmount { get; set; }
//        public decimal OtherExpAmount { get; set; }
//        public decimal DiscountAmount { get; set; }
//        public decimal RoundingAmount { get; set; }
//        public decimal NetAmount { get; set; }
//        public decimal STaxWithHeldAmount { get; set; }
//        public decimal FEDAmount { get; set; }

//        public bool IsSTax { get; set; }
//        public bool IsSTaxWithHeldPercentage { get; set; }
//        public decimal STaxWithHeldPercentage { get; set; }

//        public bool IsIncludeInPurchaseRegister { get; set; }
//        public decimal ExpPayableToSupplier { get; set; }

//        public int IsPurchase { get; set; }
//        public PurchaseDetails PurchaseDetails { get; set; }
//        public List<PurchaseDetails> PurchaseDetailsList { get; set; }

//        public List<Purchase> PurchaseList { get; set; }
//        public int PurchaseReturnId { get; set; }


//        public int PurchaseOrderReceivingId { get; set; }
//        public PurchaseOrderReceiving PurchaseOrderReceiving { get; set; }
//        public List<PurchaseOrderReceiving> PurchaseOrderReceivingList { get; set; }



//        public bool ExpectedDateFilter { get; set; }
//        public DateTime ExpectedDelDateStartFilter { get; set; }
//        public DateTime ExpectedDelDateEndFilter { get; set; }

//        public bool DateFilter { get; set; }
//        public DateTime DateStartFilter { get; set; }
//        public DateTime DateEndFilter { get; set; }

//        public bool PartialDeliveredFilter { get; set; }
//        public bool FullyDeliveredFilter { get; set; }
//        public bool NonDeliveredFilter { get; set; }
//        public int ProductId { get; set; }
//    }
//}
