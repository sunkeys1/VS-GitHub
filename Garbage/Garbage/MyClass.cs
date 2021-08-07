using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage
{
    class MyClass : IDisposable
    {
        public MyClass() {} // констркутор

        ~MyClass() { } //деструктор

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
