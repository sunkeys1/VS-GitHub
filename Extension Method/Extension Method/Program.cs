using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var input = Console.ReadLine();
            if(int.TryParse(input, out int result))
            {
                //var isEven = IsEven(result);
                //result.IsEven();
                if(result.IsEven())/*isEven*/
                {
                    Console.WriteLine($"Число {result} четное!");
                }
                else
                {
                    Console.WriteLine($"Число {result} нечетное!");
                }
                var h = 184;
                h.IsDevidedBy(7);

                //var list = new List<Road>();

                
            }
            else
            {
                Console.WriteLine("Вы вводите что-то не то!");
            }
            Console.ReadLine();

            var roads = new List<Road>();
            for(var i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(100, 1000);
                roads.Add(road);
                
            }
            var roadsName = roads.ConverterToString();
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }
        
    }
}
