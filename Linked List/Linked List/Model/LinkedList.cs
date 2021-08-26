using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List.Model
{
    /// <summary>
    /// Односвязный список
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент списка.
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Последний элемент списка.
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Количество элементов списка.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Создание пустого списка.
        /// </summary>
        public LinkedList()
        {
            Clear();
        }

        

        /// <summary>
        /// Создание списка с начальным элементом.
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
            
        }
        /// <summary>
        /// Добавление данных в конец списка.
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            
            if(Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// Удаление первого вхождения данных в список.
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if(Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head; 
                while(current != null)
                {
                    if(current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// Добавление элемента в начало списка.
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                
                var current = Head;
                while(current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                } 
            }
            else
            {
                // что добавлять в итоге, если не найден элемент
            }
        }
        /// <summary>
        /// Очистить список.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        /// <summary>
        /// Получение перечисления всех элементов списка.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;

            }
        }
        public override string ToString()
        {
            return "Linked List " + Count + " элементов";
        }
    }
}
