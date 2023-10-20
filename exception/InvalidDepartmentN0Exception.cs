using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class InvalidDepartmentN0Exception : Exception
    {
        
            public InvalidDepartmentN0Exception()
            {

            }

            public InvalidDepartmentN0Exception(string message) : base(message)
            {

            }
        
    }
}
