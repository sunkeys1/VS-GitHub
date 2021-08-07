using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage
{
    class Program
    {
        static void Main(string[] args)
        {
            //GC.Collect(0 /*очистка 0 поколения*/);
            Console.WriteLine(GC.GetTotalMemory(false));
            for(var i = 0; i < 10000; i++)
            {

                var obj = (object)i;
                int j = (int)obj;
            }
            Console.WriteLine(GC.GetTotalMemory(false));
            using (var c = new MyClass())
            {


            }


            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));



            Console.ReadLine();
        }
    }
}
