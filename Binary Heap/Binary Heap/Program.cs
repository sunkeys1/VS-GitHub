using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Heap
{
    class Program
    {
        static void Main(string[] args)
        {

            //heap.Add(20);
            //heap.Add(11);
            //heap.Add(17);
            //heap.Add(7);
            //heap.Add(4);
            //heap.Add(13);
            //heap.Add(15);
            //heap.Add(14);
            //while(heap.Count > 0)
            //{
            //    Console.WriteLine(heap.GetMax());
            //}

            var timer = new Stopwatch();
            var rnd = new Random();
            var startItems = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }


            timer.Start();
            var heap = new Heap(startItems);
            timer.Stop();
            Console.WriteLine("Первоначальная инициализация пачки элементов: " + timer.Elapsed);

            timer.Restart();
            for (int i = 0; i < 10; i++)
            {
                heap.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop();
            Console.WriteLine("Добавление второй пачки: "+ timer.Elapsed);

            timer.Restart();
            foreach(var item in heap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Вывод пачки элементов: " + timer.Elapsed);


            Console.ReadLine();
        }
    }
}
