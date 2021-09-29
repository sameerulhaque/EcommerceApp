using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commons.TableSearching;
using CommonsStandard;

namespace Commons
{
    public class AbstractEntity
    {
        public AbstractEntity()
        {
            ThisClassList = new List<object>();
        }

        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }


        public int TotalRecords { get; set; }
        public List<Object> ThisClassList { get; set; }
        


        public bool DataSaved { get; set; }
        public string Message { get; set; }
    }
}
