using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    class MyException : Exception
    {
        public MyException() : base("Это моё исключение!")
        {


        }
        public MyException(string message) : base(message)
        {

        }
    }
}
