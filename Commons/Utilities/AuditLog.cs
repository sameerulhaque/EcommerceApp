using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class AuditLog : AbstractEntity
    {
        public AuditLog()
        {
            accrualMediaSpendings = new AuditReconcilation();
        }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int NewUserId { get; set; }
        public string NewUserName { get; set; }
        public int TypeId { get; set; }
        public int ParentAuditLogId { get; set; }
        public int UniqueTableId { get; set; }
        public string TypeName { get; set; }
        public string Note { get; set; }
        public string IP { get; set; }
        public AuditReconcilation accrualMediaSpendings { get; set; }
    }

    public class AuditReconcilation
    {
        public string ReconciledSpend { get; set; }
        public string MediaSystemSpend { get; set; }
        public string Variance { get; set; }
        public string VariancePercentage { get; set; }
        public string NewReconciledSpend { get; set; }
        public string NewMediaSystemSpend { get; set; }
        public string NewVariance { get; set; }
        public string NewVariancePercentage { get; set; }
        public int VendorId { get; set; }
        public int NewVendorId { get; set; }
        public string VendorName { get; set; }
        public string NewVendorName { get; set; }
        public int CustomerId { get; set; }
        public int NewCustomerId { get; set; }
        public string CustomerName { get; set; }
        public string NewCustomerName { get; set; }
    }
}