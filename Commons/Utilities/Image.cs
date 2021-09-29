using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Commons.Utilities
{
    public class Image
    {
        public string ImageName { get; set; }
        //public HttpPostedFileWrapper ImageFile { get; set; }
        public byte[] ImageByteArray { get; set; }
        public int LastId { get; set; }
        public string ImageFolderUrl { get; set; }
        public string ImageOf { get; set; }
        public string ImagePrefix { get; set; }
    }
}
