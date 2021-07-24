using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Person person = new Person();
            person.Name = "Коля";
            person.Lastname = "Жоский";
            Person p2 = new Person();
            p2.Name = "Борис";
            p2.Lastname = "Чушлан";

            //Person d = new Person();
            var d = new Doctor();
            d.Name = "Жулез";
            d.Spec = "Крутой";
            Person p = d;
            Console.WriteLine(d.Spec);
            Console.WriteLine(d.Name);
            Console.ReadLine();
        }
    }
}
