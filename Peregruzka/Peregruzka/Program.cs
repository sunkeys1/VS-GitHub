using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peregruzka
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Красное яблоко", 100, 100);
            Apple apple2 = new Apple("Зеленое яблоко", 90, 110);

            var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2; // для Apple.cs 26 строка
            var sumApple3 = apple + 100; // 37 строка
            var minusApple = apple - 50;

            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);
            Console.WriteLine(sumApple3);
            Console.WriteLine(minusApple);

            Console.WriteLine(apple == apple2);
            Console.WriteLine(sumApple == sumApple2);
            Console.WriteLine();
            Console.WriteLine(apple > apple2);
            Console.WriteLine(apple < apple2);
            
            Console.ReadLine();
        }
    } 
}
