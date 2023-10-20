using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class InvalidExperienceException : Exception
    {
        public InvalidExperienceException()
        {
            
        }
        public InvalidExperienceException(string message) : base(message) 
        {
            
        }
    }
}
