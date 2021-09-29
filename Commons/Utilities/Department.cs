using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class Department : AbstractEntity
    {
        public Department()
        {

            DepartmentList = new List<Department>();
        }
        
        public int CompanyCostCenterId { get; set; }
        public string DepartmentName { get; set; }
        public string MachineCode { get; set; }

        public List<Department> DepartmentList { get; set; }
    }
}
