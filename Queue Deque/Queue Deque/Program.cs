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
            var linkedDeque = new EasyDeque<int>();
            linkedDeque.PushFront(1);
            linkedDeque.PushFront(2);
            linkedDeque.PushFront(3);
            linkedDeque.PushBack(4);
            linkedDeque.PushBack(5);
            linkedDeque.PushFront(6);
            linkedDeque.PushBack(7);
            Console.WriteLine(linkedDeque.PopFront());
            Console.WriteLine(linkedDeque.PopBack());
            Console.WriteLine(linkedDeque.PopFront());
            Console.WriteLine(linkedDeque.PopBack());

            Console.ReadLine();


            var easyDeque = new EasyDeque<int>();
            easyDeque.PushFront(1);
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushBack(40);
            easyDeque.PushBack(50);
            easyDeque.PushFront(600);
            easyDeque.PushBack(700);
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());

            Console.ReadLine();



            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5);
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Dequeue());

            Console.ReadLine();

            var arrayQueue = new ArrayQueue<int>(10);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue()); // если много вытаскиваем, будет вытаскивать последний элемент
            Console.WriteLine(arrayQueue.Dequeue()); // но можно и кидать эксепшен
           

            Console.ReadLine();

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
