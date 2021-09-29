using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Commons
{
    public class response
    {
        public response()
        {
            numberlist = new List<numberlist>();
        }
        public string errorno { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public int valid_numbers { get; set; }
        public string nature { get; set; }
        public int tableid { get; set; }
        public string tablename { get; set; }
        public List<numberlist> numberlist { get; set; }
        public int id { get; set; }
        public string table_name { get; set; }
    }
    public class numberlist
    {
        public string msgid { get; set; }
        public string number { get; set; }
    }
}