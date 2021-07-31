using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Method
{
    class Program
    {
        public delegate int MyHandler(int i);
        static void Main(string[] args)
        {

            var lesson = new Lesson("Начало");
            lesson.Started += (sender, date) =>
            {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };

            lesson.Start();
            Console.WriteLine("Лист: ");
            var list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            var res = list.Aggregate((x,y) => x + y);
            Console.WriteLine(res);

            var result1 = Arg(list, delegate (int i)
            {
                var r = i * i;
                Console.WriteLine(r);
                return r;
            });
            var result2 = Arg(list, Method);

            var result3 = Arg(list, x => x * x * x * x);

            


            if (int.TryParse(Console.ReadLine(), out int result))
            {
                MyHandler handler = delegate (int i)
                {
                    var r = i * i;
                    Console.WriteLine(r);
                    return r;
                };
                handler += Method;
                handler(result);
                handler(30);
                
            }


            MyHandler lambdahandler = (i) => // i * i;
            {

                var r = i * i;
                Console.WriteLine(r);
                return r;
            };
            lambdahandler(56);


            Console.ReadLine();
            
        }

        public static int Arg(List<int> list, MyHandler handler)
        {
            var result = 0;
            foreach(var item in list)
            {
                result += handler(item);
               
            }
            return result;
        }
        public static int Method(int i)
        {
            var r = i * i * i;
            Console.WriteLine(r);
            return r;
        }
    }
}
