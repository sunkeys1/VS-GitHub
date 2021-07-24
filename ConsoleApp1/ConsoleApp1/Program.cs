using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Hello");
             string i = Console.ReadLine();

             Console.WriteLine("Cool, look at this");
             Console.ReadLine();
             Console.WriteLine("I remember you said: " + i);
             Console.ReadKey();
             Console.WriteLine("So, i have what to do with you -_-");
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("WOOOOOOOOF");
             Console.ReadKey();
            
            Console.WriteLine("Напиши че-нибудь");
            string ConsoleText = Console.ReadLine();
            //int Conv = Convert.ToInt32(ConsoleText);
            int Conv = int.Parse(ConsoleText);
            
            Conv = Conv + 1*5;
            Console.WriteLine(Conv);
            Console.ReadLine();
            
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine(result + 2);

            }
            else
            {
                Console.WriteLine("ты чо дурак? пеши нормально "+ result);
            }
            
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
           
            
            if (input < 10 && input > 0)
            {
                Console.WriteLine("Число меньше 10 и больше 0");
            }
            else
            {
                Console.WriteLine("Число больше 10");
            }
            */
            int input = int.Parse(Console.ReadLine());
            switch (input)
            { case 1:
                    Console.WriteLine("опа это что");
                    break;
              case 2:
                    Console.WriteLine("каво");
                    //goto case 1;
                    break;
            }
            Console.WriteLine(input == 10 ? "да" : "нет");
            Console.ReadLine();
        }
    }
}
