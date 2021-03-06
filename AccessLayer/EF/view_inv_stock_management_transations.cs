using System;
using System.Collections.Generic;

#nullable disable

namespace AccessLayer.EF
{
    public partial class view_inv_stock_management_transations
    {
        public int? product_id { get; set; }
        public string product_name { get; set; }
        public int? unit_of_measure_id { get; set; }
        public string unit_of_measure_name { get; set; }
        public int? currency_id { get; set; }
        public string currency_name { get; set; }
        public decimal? exchange_rate { get; set; }
        public decimal? amount { get; set; }
        public decimal? quantity { get; set; }
        public int detail_id { get; set; }
        public DateTime? date { get; set; }
        public string is_grn { get; set; }
    }
}
