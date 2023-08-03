using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAPIEndpoints
{
    public class Helper
    {
        public T GetDefaultGeneric<T>()
        {
            
            return default(T);
        }
    }
}
