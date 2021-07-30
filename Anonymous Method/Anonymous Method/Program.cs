using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Method
{
    class Program
    {
        delegate int MyHandler(int i);
        static void Main(string[] args)
        {

            var lesson = new Lesson("Начало");
            lesson.Started += (sender, date) =>
            {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };

            lesson.Start();











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

        public static int Method(int i)
        {
            var r = i * i * i;
            Console.WriteLine(r);
            return r;
        }
    }
}
