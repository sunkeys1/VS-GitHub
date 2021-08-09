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

            Console.WriteLine(i.GetType());
            Console.WriteLine(oi.GetType());
            Console.WriteLine(p1.GetType());

            Console.WriteLine(typeof(Point) == p1.GetType()); // можно сравнивать типы
            Console.WriteLine();

            //Object.Equals - сравнение объектов по значению
            //Object.ReferenceEquals - сравнение по ссылке, игнорируя значения
            Console.WriteLine(Object.Equals(5,5));
            Console.WriteLine(Object.ReferenceEquals(5,5));

            Console.WriteLine();
            var pp = new Point() { X = 7, Y = new Point() };
            var pp2 = pp;
            pp2.X = 77;
            pp2.Y = new Point() { X = 99 };
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);
            
            var pp3 = pp.Clone();
            pp3.X = 88;
            pp3.Y.X = 222;
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);


            Console.ReadLine();
        }
    }
}
