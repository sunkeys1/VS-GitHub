using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbo_Faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.Write(fibb(i) + " ");
            }
            Console.ReadLine();


            Console.Write(fact(6));
            Console.WriteLine();
            Console.WriteLine(refact(5));
            //int a = 5;
            //while (true)
            //{
            //    rec(5);
            //    Console.WriteLine(a++);
            //}

            Console.ReadLine();
        }

        //public static void rec(int n) для стек оверфлова
        //{

        //    Console.WriteLine(n++);

        //    rec(n);

        //}
        public static int fibb(int c)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < c; i++)
            {
                int t = a;
                a = b;
                b = t + a;
            }

            return a;
        }
        public static int fact(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i; // result = result * i;
            }
            return result;
        }
        public static int refact(int b)
        {
            int result2 = 1;
            if (b == 0)
            {
                return 1;
            }
            else
            {
                result2 = refact(b - 1) * b; // рекурсия
            }

            return result2;
        }
    }
}
