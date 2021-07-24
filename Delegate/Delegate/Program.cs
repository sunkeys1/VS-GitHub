using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void MyDelegate();

    class Program
    {

        public delegate int ValueDelegate(int i);
        public event MyDelegate Event;
        
        static void Main(string[] args)
        {
            #region delegate
            //MyDelegate myDelegate = Method1;
            //myDelegate += Method4;
            //myDelegate();


            //MyDelegate myDelegate2 = new MyDelegate(Method4);
            //myDelegate2 += Method4;
            //myDelegate2 -= Method4;
            //myDelegate2.Invoke();

            //MyDelegate myDelegate3 = myDelegate + myDelegate2;
            //myDelegate3.Invoke();

            //var valueDelegate = new ValueDelegate(MethodValue);
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate((new Random()).Next(10, 50));

            //Action action = Method1;
            //action();

            //Predicate<int> predicate;
            //Func<int, int> func = MethodValue; // последнее значение - ВОЗВРАЩАЕМОЕ!(в данном случае int)
            ////if(func != null)
            ////func(7); эквивалентно следующему=>
            //func.Invoke(7);

            //Console.ReadLine();
            #endregion

            Person person = new Person();
            person.Name = "Борис";
            person.GoToSleep += Person_GoToSleep;
            person.GoWork += Person_GoWork;
            person.TakeTime(DateTime.Parse("16.07.2021 19:40:01"));
            person.TakeTime(DateTime.Parse("16.07.2021 3:40:01"));
        }

        private static void Person_GoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} работает работу.");
            }
        }

        private static void Person_GoToSleep()
        {
            
            Console.WriteLine($"пошел спать.");
            Console.ReadLine();
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }
        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }
        public static void Method3(int i)
        {
            Console.WriteLine("Method3");
        }
        public static void Method4()
        {
            Console.WriteLine("Method4");
        }
    }
}
