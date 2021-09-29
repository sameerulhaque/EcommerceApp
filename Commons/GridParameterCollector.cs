using System.Collections.Generic;

namespace Commons.Entities
{
    public class GridParameterCollector
    {
        public int start { get; set; }

        public int length { get; set; }

        public string searchText { get; set; }     // search[value]

        public bool isSearchRegex { get; set; }     // search[regex]

        //public List<ColumnParameterCollector> columnCollector { get; set; }
    }
}