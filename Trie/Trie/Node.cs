using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Node<T>
    {
        public char Symbol { get; set; } // можно делать string, но надо будет ToString делать
        public T Data { get; set; }
        public bool IsWord { get; set; }
        public string Prefix { get; set; }
        public Dictionary<char, Node<T>> SubNodes { get; set; }
        public Node(char symbol, T data)
        {
            Symbol = symbol;
            Data = data;
            SubNodes = new Dictionary<char, Node<T>>();
        }
        public override string ToString()
        {
            return Data.ToString();
        }
        public Node<T> TryFind(char symbol)
        {
            if(SubNodes.TryGetValue(symbol, out Node<T> value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }
        public override bool Equals(object obj) // еще бы переопределить gethashcode
        {
            if(obj is Node<T> item)
            {
                return Data.Equals(item);
            }
            else
            {
                return false;
            }
            
        }

    }
}
