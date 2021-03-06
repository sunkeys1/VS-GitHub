using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHashTable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Борис", Age = 15, Gender = 0 };
            superHashTable.Add(new Person() { Name = "Борис", Age = 15, Gender = 3});
            superHashTable.Add(new Person() { Name = "Василис", Age = 5, Gender = 2 });
            superHashTable.Add(new Person() { Name = "Жульбан", Age = 15, Gender = 3 });
            superHashTable.Add(person);
            Console.WriteLine(superHashTable.Search(new Person() { Name = "Борис", Age = 15, Gender = 3 }));
            Console.WriteLine(superHashTable.Search(person));


            Console.ReadLine();

            var hashTable = new HashTable<int, string>(100); // тут берется первая цифра от ключа
            hashTable.Add(6, "Опа");
            hashTable.Add(81, "Как ты сюда попал?"); 
            hashTable.Add(963, "Пасхалка!");
            hashTable.Add(8, "Взял и вытеснил!");
            Console.WriteLine(hashTable.Search(6, "Где"));
            Console.WriteLine(hashTable.Search(963, "Пасхалка!"));
            Console.WriteLine(hashTable.Search(8, "Взял и вытеснил!"));
            Console.WriteLine(hashTable.Search(6, "Опа"));

            Console.ReadLine();

            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5); // хеш идет по количеству цифр.
            //Console.WriteLine(badHashTable.Search(5));
            badHashTable.Add(20);
            badHashTable.Add(678);
            badHashTable.Add(7); // тут 5 пропадает и на ее место записывается 7
            Console.WriteLine(badHashTable.Search(5));
            Console.WriteLine(badHashTable.Search(20));


            Console.ReadLine();
        }
    }
}
