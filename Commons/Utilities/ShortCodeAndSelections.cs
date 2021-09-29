using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class ShortCodeAndSelections
    {
        public string Code { get; set; }
        public string Action { get; set; }
        public int Id { get; set; }
    }
    public class ShortCodeProperties
    {
        public string OpeningBalanceCode { get; set; }
        public int CurrencyId { get; set; }
        public int CostCenterId { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public int ChequeTypeId { get; set; }
        public decimal ExchangeRate { get; set; }
        public int AccountCharacterId { get; set; }
        public int AccountCategoryId { get; set; }
        public int UserId { get; set; }
        public int CompanyCostCenterId { get; set; }
        public int PurchaseCategoryId { get; set; }
        public int StoreId { get; set; }
        public int SupplierId { get; set; }
        public int ProductCategoryId { get; set; }
        public int UnitOfMeasureId { get; set; }
        public int NatureId { get; set; }
        public int DesignationId { get; set; }
        public string Barcode { get; set; }
        public string ProductCode { get; set; }
        public string RequisitionCode { get; set; }
        public List<ShortCodeAndSelections> VoucherCodes { get; set; }
        public string ItemType { get; set; }
        public string Location { get; set; }
        public string RfpCode { get; set; }
        public string RfqCode { get; set; }
        public int DonorId { get; set; }
        public string DonationCode { get; set; }
        public int DonationTypeId { get; set; }

        public int PartyId { get; set; }
        public int GreyFabricId { get; set; }
        public int DesignProcessId { get; set; }
        public int ArticleId { get; set; }
        public int CartonSizeId { get; set; }
        public int VariantId { get; set; }
        public int DesignId { get; set; }
        public int StyleId { get; set; }
        public string PurchaseOrderCode { get; set; }
        public string SiteUrl { get; set; }
        public int AllowMessageService { get; set; }
        public int AllowEmailService { get; set; }
        public int DonationLandAccountId { get; set; }
        public int DonationShareAccountId { get; set; }
    }
}
