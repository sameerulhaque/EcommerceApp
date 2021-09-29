using System;
using System.Collections.Generic;
using System.Text;

namespace Commons.Response
{
    public class ApiResponse
    {
        public List<Object> ResultList { get; set; }
        public Object Result { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
