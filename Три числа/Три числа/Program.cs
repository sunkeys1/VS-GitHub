using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Три_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, big;
            Console.WriteLine("Введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            c = int.Parse(Console.ReadLine());
            if (a>b)
            {

                if (a>c)
                {
                    big = a;
                    Console.WriteLine("Наибольшее число:" + big);
                }
                else
                {
                    big = c;
                    Console.WriteLine("Наибольшее число:" + big);
                }
                //Console.WriteLine("Наибольшее число:"+ a);
            }
            else
            {
                if (b < c)
                {
                    big = c;
                    Console.WriteLine("Наибольшее число:" + big);
                }
                else
                {
                    big = b;
                    Console.WriteLine("Наибольшее число:" + big);
                }
            }

            switch (big%2)
            {
                case 0:
                    Console.WriteLine("Наибольшее число четное!");
                    break;
                case 1:
                    Console.WriteLine("Наибольшее число нечетное!");
                    break;
            }
            
            Console.WriteLine(big < 100 ? "Наибольшее число меньше 100!" : "Наибольшее число больше 100!");
            Console.ReadLine();

        }
    }
}
