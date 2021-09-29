using System;
using System.Collections.Generic;
using System.Text;

namespace Commons.Inventory
{
    public class UserSession:AbstractEntity
    {
        public string Token { get; set; }
        public DateTime StartTime { get; set; }
        public int UserId { get; set; }
        public decimal StartingAmount { get; set; }
        public int CompanyCostCenterId { get; set; }
        public int StoreId { get; set; }
    }
}
