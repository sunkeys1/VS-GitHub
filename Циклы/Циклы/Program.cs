using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<int>();

            //for (int i = 1; i<=10; i+=2 )
            //{

            //    list.Add(i);
            //    //Console.WriteLine(i);
            //}

            //for(int i = 0; i<list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);

            //}

            //var list = new List<string>();
            //while (list.Count < 5)
            //{
            //    list.Add(Console.ReadLine());
            //    Console.Clear();

            //}
            //var i = 0;

            //while (i < list.Count)
            //{
            //    Console.WriteLine(list[i]);
            //    i++;

            //}
            //var list = new List<string>();
            //var rnd = new Random();
            //for(var i=0; i<10; i++)
            //{
            //    list.Add(rnd.Next(0, 100).ToString());

            //}



            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);

            //}
            var list = new List<int>();
            //int a;
            
            Console.WriteLine("Введите 3 числа");

            while (list.Count < 3)
            {
                
                string num = Console.ReadLine();
                if (int.TryParse(num, out int numberFromUser))
                {
                    list.Add(numberFromUser);
                    
                }
                else
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число.");
                }
            }

            if(list.Count == 3)
            {
                int sum = 0;
                int diff = 0;
                int multi = list[0];

                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i]; 

                }

                int l = 1;
                while (l < list.Count)
                {
                    diff -= list[0];
                    l++;
                }

                int j = 0;
                do
                {
                    multi *= list[j]; // косяк, еще лишне умножает на первое введенное число
                    j++;
                }
                while (j < list.Count);

                Console.WriteLine(diff);
                Console.WriteLine(sum);
                Console.WriteLine(multi);
            }
               
                
            
            //for(int i=0; i<3; i++)
            //{
            //    if (!int.TryParse(Console.ReadLine(), out a))
            //    {
            //        Console.WriteLine("Ошибка ввода! Введите целое число");
            //    }
            //    else
            //    {
            //        list.Add(Int32.Parse(Console.ReadLine()));

            //    }
            //}


            //while (list.Count < 3)
            //{

            //    while (!int.TryParse(Console.ReadLine(), out a))
            //    {
            //        Console.WriteLine("Ошибка ввода! Введите целое число");
            //    }
            //    if (String.//(Console.ReadLine()))
            //    {
            //        Console.WriteLine("пиши");
            //    }
            //    else
            //    {

            //    }

            //    c = int.Parse(Console.ReadLine());
            //    list.Add(Int32.Parse(Console.ReadLine()));
            //}
            foreach (var items in list)
            {
                Console.WriteLine(items);
            }

            
            Console.ReadLine();
        }
    }
}
