using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class Language : AbstractEntity
    {
        public string LanguageName { get; set; }
        public string LanguageConversion { get; set; }
        public string LanguageImage { get; set; }
        public bool IsSelected { get; set; }
        public bool IsStarted { get; set; }
        public bool IsRtl { get; set; }
    }
}
