using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вам нужно преодолеть 100км. \nВведите скорость:");
            double speed = Convert.ToDouble(Console.ReadLine());
            
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMWSeven());

            Console.WriteLine($"Вы решили ехать со скоростью: {speed}км/ч. Верно?");
            
            foreach (var car in cars)
            {
                Console.WriteLine(car.Move(200));
                Console.WriteLine($"Итог: вы проезжаете 100км со скоростью {speed}км/ч за {car.Speed(Math.Round(speed ,2))}часа");

            }
            Kiborg kiborg = new Kiborg();
            Console.WriteLine(((ICar)kiborg).Move(100));
            Console.WriteLine(((IPerson)kiborg).Move(100));
            

            Console.ReadLine();
        }
    }
}
