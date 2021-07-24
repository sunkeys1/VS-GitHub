using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true)
            //{
            //    var input = Console.ReadLine();
            //    if (int.TryParse(input, out int result))
            //    {
            //        Console.WriteLine("Опа" + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Введи нормально, ёпта");

            //    }

            //}
            var a = 1;
            var c = 4;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите что-нибудь: ");
            var input = Console.ReadLine();
            if(input == "чушлан")
            {
                Console.WriteLine("Чушлан здесь только один ");
            }
            else
            {
                Console.WriteLine($"Думаешь что {input} это круто? Пфф смотри сюда!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Попробуй ввести еще чего-нибудь: ");
            }
            var input2 = Console.ReadLine();
            
            try
            {

                if (input == "бык")
                {
                    throw new MyException();
                }
            }
            catch(MyException ex)
            {
                Console.WriteLine("УУУУУ это ты зря быканул");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Ну и зря ничего не ввел");
            }
            finally
            {
                Console.ResetColor();
                Console.WriteLine("Канец епта");
            }
            //try
            //{
            //    //var i = 5;
            //    //var j = i / 1;
            //    //Console.WriteLine(j);
            //    //var a = 20000000;
            //    //var b = 200000000;
            //    //var c = checked(a * b);
            //    throw new MyException();
            //}
            //catch(MyException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Деление на ноль");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Ошибка! Но не деление на ноль.");
            //}
            //finally
            //{
            //    Console.WriteLine("работа завершена");
              Console.ReadLine();
            //}
        }
    }
}
