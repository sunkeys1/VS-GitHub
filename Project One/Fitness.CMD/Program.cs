using Fitness.BL.Controller;
using Fitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");

            Console.WriteLine("Введите имя пользователя: ");
            var name = Console.ReadLine();


            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.Write("Введите пол: ");
                var gender = Console.ReadLine();

                DateTime birthDate;
                double weight;
                double height;
                while (true)
                {
                    Console.Write("Введите дату рождения (dd.MM.yyyy): ");
                    if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат даты рождения.");
                    }
                }
                userController
            }
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();
        }
        private static T ParseDouble<T>(string name)
        {
            while (true)
            {
                Console.Write($"Введите {name}: ");
                if (double.TryParse(Console.ReadLine(), out T value))
                {
                    return value
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверный формат {name}.");
                }
            }

        }
    }
}
