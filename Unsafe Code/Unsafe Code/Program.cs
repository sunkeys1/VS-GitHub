using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unsafe_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 30; // обычная переменная
                int* addres = &i; // указатель
                Console.WriteLine(*addres /*операция разименования*/); // 
                Console.WriteLine((long)addres); // физический адрес ячейки в памяти

                int a = 5;
                int b = 7;

                Console.WriteLine("b = " + *(&a + 2)); // +1 +2 +4

                Calc(a, &b);
                Console.WriteLine(a);
                Console.WriteLine(b);

                int* addres2 = addres + 4;
                *addres2 = 777;
                Console.WriteLine(*addres2);
                Console.WriteLine();

                int** adr = &addres; // положили в переменную адрес 
                Console.WriteLine((long)adr); // номер ячейки в которой хранится переменная
                Console.WriteLine((long)*adr); // то что хранится в ячейке
                Console.WriteLine(**adr); // 

            }

            Console.ReadLine();
        }
        static unsafe void Calc(int i, int* j)
        {
            i = 500;
            *j = 700;

        }
        static void Calc(int i, ref int j)
        {

        }
    }
}
