using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.SetName(Console.ReadLine());
            Person p = new Person("Василий2", "Морж");
            p.Name = "Василий";
            p.SecName = "Морж";
            Console.WriteLine(p.FullName);
            Console.WriteLine(p.ShortName);
            Console.WriteLine();
            Console.ReadLine();
            
        }

    }
}
