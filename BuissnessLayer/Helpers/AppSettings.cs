using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuissnessLayer.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string LocalDbCon { get; set; }
        public string ServerDbCon { get; set; }
    }
}
