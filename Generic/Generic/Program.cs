using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product<int>("Яблоко", 100, 100);
            var list = new List<string>();
            Console.WriteLine(default(string));

            Console.ReadLine();
        }
    }
}
