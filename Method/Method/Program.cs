using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person1 = new Person("Делюб", "Борис");
            //var person2 = new Person("Жульбан", "Сеня");
            //for (var i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(person1.Run());
            //    //Console.WriteLine(person2.Run());
            //    var position1 = person1.Run();
            //    var position2 = person2.Run();
            //    Console.WriteLine(position1);

            //    Console.WriteLine(person2.Run());
            //}
            //public static int PrintHello(string name, int age)
            //{
            //    Console.WriteLine($"Привет {name}, я думаю тебе {age} лет?");

            Console.WriteLine(Faktorial(3));


            Console.ReadLine();
        }
        public static int Faktorial(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Faktorial(value - 1);
            }


        }
            //    return 1+3     //}
    }   
}
