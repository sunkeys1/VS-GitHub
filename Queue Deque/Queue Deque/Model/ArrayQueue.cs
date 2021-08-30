using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Deque.Model
{
    public class ArrayQueue<T>
    {
        private T[] items;

        private T Head => items[Count > 0 ? Count - 1 : 0];
        private T Tail => items[0];
        private int MaxCount => items.Length();
        public int Count { get; private set; }
        public ArrayQueue(int size)
        {
            items = new T[size];
            Count = 0;
        }
        public ArrayQueue(int size, T data)
        {
            //проверка входящих данных
            items = new T[size];
            items[0] = data;
            Count = 1;
        }
        public void Enqueue(T data)
        {
            var result = new T[MaxCount];
            result[0] = data;
            for(int i = 0; i < Count; i++)
            {
                result[] // тута стоп
            }
        }
        public T Dequeue()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }
        public T Peek()
        {
            return Head;
        }
    }
}
