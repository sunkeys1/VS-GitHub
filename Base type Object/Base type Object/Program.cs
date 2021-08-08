using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_type_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Object === obj
            // System.Int32 === int
            object obj = new object();
            var i = 5;
            var j = 5;
            Console.WriteLine(i.Equals(j));
            object oi = (object)i;  // var oi = (object)i;
            object oj = (object)j;
            Console.WriteLine(oi.Equals(oj));
            var p1 = new Point() { X = 5 }; 
            var p2 = new Point() { X = 5 };   // нужно убрать в Point.cs с 29 строки проверку типов.
            Console.WriteLine(p1.Equals(p2)); // тут будет false тк объекты находятся в разных участках памяти
            Console.WriteLine();
            Console.WriteLine(i.GetHashCode());
            Console.WriteLine(oj.GetHashCode());
            Console.WriteLine(new MyClass().GetHashCode());
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(i.ToString());
            Console.WriteLine(p1.ToString());



            Console.ReadLine();
        }
    }
}
