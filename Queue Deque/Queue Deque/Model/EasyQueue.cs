using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Deque.Model
{
    public class EasyQueue<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;
        public EasyQueue() { }
        public EasyQueue(T data)
        {
            //проверка входящих данных
            items.Add(data);
        }
        public void Enqueue(T data)
        {
            items.Insert(0, data);
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
