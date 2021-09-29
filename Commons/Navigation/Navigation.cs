using System;
using System.Collections.Generic;
using System.Text;

namespace Commons.Navigation
{
    public class Navigation
    {
        public Navigation()
        {
            submenu = new List<Navigation>();
        }

        public string title { get; set; }
        public bool root { get; set; }
        public string icon { get; set; }
        public string svg { get; set; }
        public string page { get; set; }
        public string translate { get; set; }
        public string bullet { get; set; }
        public string section { get; set; }
        public string permission { get; set; }
        public List<Navigation> submenu { get; set; }
        public string separator { get; set; }
    }
}
