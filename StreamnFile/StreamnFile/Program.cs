using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamnFile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ReadWrite
            //using (var sw = new StreamWriter("test.txt", false, Encoding.UTF8 /*или Unicode, но он тяжелее*/))
            //{
            //    sw.WriteLine("Жук");
            //    sw.WriteLine("Большой такой жук!");
            //    sw.WriteLine("Heyy");
            //    sw.WriteLine("arabian");

            //}
            //using (var sr = new StreamReader("test.txt", Encoding.UTF8))
            //{
            //    while(!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine() + " конец строки");  // построчное чтение 
            //    }
            //    sr.DiscardBufferedData();                //
            //    sr.BaseStream.Seek(0, SeekOrigin.Begin); // вывод "читалки" с конца в начало текста
            //    var text = sr.ReadToEnd();
            //    Console.WriteLine(text);
            //}
            #endregion 
            // тута плюсик нажать и откроется
            using (var sw = new StreamWriter("test1.txt", true, Encoding.UTF8))
            {
                Console.WriteLine("Введите что-нибудь, а потом это покажется");
                sw.WriteLine(Console.ReadLine());
                Console.WriteLine("Вот что есть в этом документе: ");
            }
            using (var sr = new StreamReader("test1.txt", Encoding.UTF8))
            {
                while(!sr.EndOfStream)
                {
                    
                    Console.WriteLine(sr.ReadLine()); 

                }
                //var texx = sr.ReadToEnd();
                //Console.WriteLine("Смотри что ты писал: "+ texx);

            }
                Console.ReadLine();
        }
    }
}
