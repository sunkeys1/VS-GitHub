using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dict<int, string>();
            dict.Add(new Item<int, string>(1, "Один"));
            dict.Add(new Item<int, string>(1, "Один"));
            dict.Add(new Item<int, string>(2, "Два"));
            dict.Add(new Item<int, string>(3, "Три"));
            dict.Add(new Item<int, string>(4, "Четыре"));
            dict.Add(new Item<int, string>(5, "Пять"));
            dict.Add(new Item<int, string>(101, "Сто один"));
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(dict.Search(7) ?? "Нету такого!");
            Console.WriteLine(dict.Search(3) ?? "Нету такого!");
            Console.WriteLine(dict.Search(101) ?? "Нету такого!");
            dict.Remove(88);
            dict.Remove(101);
            dict.Remove(3);
            dict.Remove(1);
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadLine();




            var easyMap = new EasyMap<int, string>();
            easyMap.Add(new Item<int, string>(1, "Один"));
            easyMap.Add(new Item<int, string>(2, "Два"));
            easyMap.Add(new Item<int, string>(3, "Три"));
            easyMap.Add(new Item<int, string>(4, "Четыре"));
            easyMap.Add(new Item<int, string>(5, "Пять"));
            foreach(var item in easyMap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(easyMap.Search(7) ?? "Нету такого!");
            Console.WriteLine(easyMap.Search(3) ?? "Нету такого!");
            easyMap.Remove(3);
            easyMap.Remove(1);
            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
