using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public  class UserAuth
    {
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        public DateTime expiresIn { get; set; }
    }
}
