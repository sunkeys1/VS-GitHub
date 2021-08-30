using Queue_Deque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Deque
{
    class Program
    {
        static void Main(string[] args) // через F2(или нет) можно выделить что-нибудь и изменить имя везде
        {
            var easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dequeue());





            Console.ReadLine();
        }
    }
}
