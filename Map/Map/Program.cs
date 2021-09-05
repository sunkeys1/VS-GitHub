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
