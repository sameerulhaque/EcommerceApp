using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CommonsStandard
{
    public class File
    {
        public string FileName { get; set; }
        //public HttpPostedFileWrapper FileWrapper { get; set; }
        public byte[] FileByteArray { get; set; }
        public int LastId { get; set; }
        public string FileFolderUrl { get; set; }
        public string FileOf { get; set; }
        public string FilePrefix { get; set; }
    }
}
