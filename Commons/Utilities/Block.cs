using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utilities
{
    public class Block:AbstractEntity
    {
        public Block()
        {
            TownList = new List<Town>();
            Town = new Town();
        }

        public string BlockName { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }
        public List<Town> TownList { get; set; }
    }
}
