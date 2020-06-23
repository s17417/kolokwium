using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.Services
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
