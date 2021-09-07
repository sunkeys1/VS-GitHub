using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T> : IComparable
        where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; } // тут должны быть проверки на доступ! (лучше полное свойство с проверкой!)
        public Node<T> Right { get; private set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Left = left;
            Right = right;
            Data = data;
        }

        public int CompareTo(object obj)
        {
            if(obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("Несовпадение типов!");
            }
        }
    }
}
