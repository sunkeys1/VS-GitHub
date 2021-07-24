using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var collection = new List<Product>();
            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт" + i,
                    Energy = rnd.Next(10, 12)

                };
                collection.Add(product);

            }
            var result = from item in collection
                         where item.Energy < 200
                         select item;
            var result4 = from item in collection
                          select item;
            //var result2 = collection.Where(item => item < 5).Where(item => item % 2 == 0);
            var result3 = collection.Where(item => item.Energy % 2 == 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Все продукты: ");
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var selectCollection = collection.Select(product => product.Energy); // делаем из коллекции продуктов коллекцию энергии
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }
            var orderbyCollection = collection.OrderBy(product => product.Energy) // упорядоч по весу от меньшего к большему
                                              .ThenBy(product => product.Name); // упорядоч по имени от большего к меньшему
            Console.WriteLine();
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            var groupbyCollection = collection.GroupBy(product => product.Energy); // сгруппировать по группам
            foreach (var group in groupbyCollection)
            {
                Console.WriteLine($"Ключ: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }

            collection.Reverse();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(collection.All(item => item.Energy == 10));
            Console.WriteLine(collection.Any(item => item.Energy == 10));
            Console.WriteLine();
            var prod = new Product();
            Console.WriteLine(collection.Contains(prod)); // прод не принадлежит данной коллекции => False 
                                                          //(проверка на принадлежность к коллекции)
            Console.WriteLine();
            var array = new int[]{1, 2, 3, 4 };
            var array2 = new int[] { 3, 4, 5, 6 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var union = array.Union(array2);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var intersect = array.Intersect(array2); // interseect выводит пересечение двух массивов.
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var except = array.Except(array2);
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var sum = array.Sum();
            var min = collection.Min(p => p.Energy);
            var max = collection.Max(p => p.Energy);
            var aggregate = array.Aggregate((x, y) => x * y);
            var sum2 = array.Skip(1).Take(2).Sum();

            var first = array.First(); // первый элемент коллекции
            var last = array.LastOrDefault(); //последний элемент // .FirstOfDefault нужен дабы не словить эксепшен если массив будет пуст
            var single = collection.Single(product => product.Energy == 10);
            var first1 = collection.First(product => product.Energy == 10); // первый продукт, энергия которого == 10
            var elementAt = collection.ElementAt(5); // выводит элемент по индексу в коллекции


            Console.ReadLine();

        }
    }
}
