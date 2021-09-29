using System;
using System.Collections.Generic;
using System.Text;

namespace Commons.TableSearching
{
    public class DataTable<T> where T : class
    {
        public DataTable()
        {
            filter = new DataTableFilter<T>();
        }
        public string searchTerm { get; set; }
        public DataTableFilter<T> filter { get; set; }
        public int pageNumber { get; set; }
        public int pageSize { get; set; }
        public string sortField { get; set; }
        public string sortOrder { get; set; }
    }
    public class DataTableFilter<T> where T : class
    {
        public int Id { get; set; }
        public T Data { get; set; }
    }

}
