using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class view_inv_stock_management
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public decimal? quantity { get; set; }
    }
}
