using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() {Name = "Supra", Number = "MA023B42"},
                new Car() {Name = "Reno", Number = "PM342E02"}

            };
            var parking = new Parking();

            foreach(var car in cars)
            {
                parking.Add(car);
            }
            foreach(var car in parking)
            {
                Console.WriteLine(car);

            }
            foreach(var item in parking)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach(var name in parking.GetNames())
            {
                Console.WriteLine("Имя: " + name);
            }
            Console.WriteLine();
            Console.WriteLine(parking["MA023B42"].Name);
            Console.WriteLine(parking["AA543C17"]?.Name);

            Console.WriteLine("Введите номер нового авто");
            var num = Console.ReadLine();
            parking[1] = new Car() { Name = "BMW", Number = num };
            Console.WriteLine(parking[1]);



            Console.ReadLine();
        }
    }
}
