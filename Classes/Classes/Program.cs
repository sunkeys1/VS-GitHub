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

            //Console.Write("Введите конец диапазона от 1 до : ");
            //int end = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                Console.Write(fibb(i) + " ");
            }
           

            Console.ReadLine();
        }
        public static int fibb(int c)
        {
            int a = 0;
            int b = 1;
            for(int i = 0; i < c; i++)
            {
                int t = a;
                a = b;
                b = t + a;
            }
            
            return a;
        }
    }
}
