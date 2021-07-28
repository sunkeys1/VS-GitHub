using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new // доступно только для чтения анон тип
            {
                Name = "Milk",
                Energy = 10
            };
            Console.WriteLine(product.Energy + product.Name);
            var eat = new Eat()
            {
                Name = "Meat"
            };
            var product2 = new
            {
                eat.Name,
                Energy = 200
            };
            Console.WriteLine(product2);
            

            Tuple<int, string> tuple = new Tuple<int, string>(5, "Привет");
            Console.WriteLine(tuple.Item2);
            var tuple2 = (10, "Морж");
            var tuple3 = (Name: "Борщ", Energy: 1000);
            tuple3.Energy = 600;
            
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3.Energy);

            var result = GetData();
            Console.WriteLine(result.Number + " " + result.Name + " " + result.Flag);

            Console.ReadLine();

        }
        public static (int Number, string Name, bool Flag) GetData()
        {
            var number = 3250; // откуда-то получаем данные
            var name = Guid.NewGuid().ToString(); // тоже получаем откуда-то
            bool b = number > 500; // проверка условия
            
            return (number, name, b);

        }
            

    }
}
