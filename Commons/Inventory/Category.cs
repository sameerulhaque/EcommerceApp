using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.InventoryUtilities
{
    public class Category : AbstractEntity
    {
        public Category()
        {
            CategoryList = new List<Category>();
        }
        public string CategoryName { get; set; }
        public List<Category> CategoryList { get; set; }
        public string PurchaseReturnNo { get; set; }
        public string PurchaseNo { get; set; }
    }
}
