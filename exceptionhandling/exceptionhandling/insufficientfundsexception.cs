using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    public class insufficientfundsexception:Exception
    {
        public  insufficientfundsexception(string message) : base(message)
        {
        }
    }

}

