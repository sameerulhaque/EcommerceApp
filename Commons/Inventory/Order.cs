using Commons.InventoryUtilities;
using Commons.Stores;
using Commons.TableSearching;
using Commons.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Inventory
{
    public class Order:AbstractEntity
    {
        public Order()
        {
            Company = new Company();
            Customer = new Customer();
            GINDetailList = new List<GINDetail>();

            DataTable = new DataTable<Order>();
        }
        public string TransactionNumber { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public decimal? NetAmount { get; set; }
        public DateTime? Date { get; set; }
        public string DateString { get; set; }
        public List<GINDetail> GINDetailList { get; set; }
        public bool IsDescriptive { get; set; }
        public DataTable<Order> DataTable { get; set; }
    }
}
