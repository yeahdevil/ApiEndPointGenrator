using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAPIEndpoints
{
    public class CommonResponseObject
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMsg { get; set; }
        public string? ErrorCode { get; set; }

    }
}
