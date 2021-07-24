using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        public static object locker = new object();

        public static int i1 = 100;
        //public static int i2 = 0;

        //static void M1()
        //{
        //    for(int i = 0; i <= i1; i++)
        //    {
        //        Console.WriteLine();
        //    }
            
        //}
        //static void M2()
        //{
        //    for (int i = 0; i >= i1; i--)
        //    {
        //        Console.WriteLine();
        //    }
        //}
        static void Main(string[] args)
        {
            #region thread
            //Thread thread = new Thread(new ThreadStart(DoWork)); // без параметра
            //thread.Start();
            //Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));// с параметром
            //thread2.Start(int.MaxValue);

            //int j = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;
            //    if (j % 10000 == 0)
            //    {
            //        Console.WriteLine("Main");
            //    }
            //}
            #endregion
            #region async/await
            //Console.WriteLine("Main start");
            //DoWorkAsync(1000);
            //Console.WriteLine("Main continue");
            //int j = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //        Console.WriteLine("Main");
            //}
            //Console.WriteLine("Main end");
            #endregion

            var result = SaveFileAsync("F:\\test.txt");
            var input = Console.ReadLine();
            Console.WriteLine(result.Result); 
            Console.ReadLine();
        }
        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task<bool>.Run(() => SaveFile(path));
            return result;

        }
        static bool SaveFile(string path)
        {
            lock (locker)
            {
                var rnd = new Random();
                var text = "";
                for (int i = 0; i < 40000; i++)
                {
                    text += rnd.Next();

                }
            }
            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine();
            }
            return true;
        }
        static async Task DoWorkAsync(int max)
        {
            Console.WriteLine("Start async");
            await Task.Run(() => DoWork(max));
            Console.WriteLine("End async");

        }
        static void DoWork (int max)
        {
            int j = 0;
            for (int i = 0; i < max; i++)/*(int i = 0; i < int.MaxValue; i++)*/
            {
                Console.WriteLine("Do work");
                //j++;
                //if (j % 10000 == 0)
                //{
                //    Console.WriteLine("DoWork");
                //}
            }
        }
        static void DoWork2(object max)
        {

            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 10000 == 0)
                {
                    Console.WriteLine("DoWork2");
                }
            }
        }
        
    }
}
