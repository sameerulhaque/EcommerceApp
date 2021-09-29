using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class UserRoles : AbstractEntity
    {
        public UserRoles()
        {
            RoleIdList = new List<string>();
            RoleIdIntList = new List<int>();
        }

        public int UserId { get; set; }
        public int WebPageId { get; set; }
        public string UserName { get; set; }
        public string WebPageName { get; set; }
        public string DisplayName { get; set; }
        public string Category { get; set; }

        public List<string> RoleIdList { get; set; }
        public List<int> RoleIdIntList { get; set; }
    }
}
