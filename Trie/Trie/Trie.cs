using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Trie<T>
    {
        private Node<T> root;
        public int Count { get; set; }
        public Trie()
        {
            root = new Node<T>('\0', default(T));
            Count = 1;
        }

        public void Add(string key, T data)
        {
            AddNode(key, data, root);
        }
        private void AddNode(string key, T data, Node<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (!node.IsWord)
                {
                    node.Data = data;
                    node.IsWord = true;
                }
                else
                {
                    var symbol = key[0];
                    var subnode = node.TryFind(symbol);
                    if (subnode != null)
                    {
                        AddNode(key.Substring(1), data, subnode);
                    }
                    else
                    {
                        var newNode = new Node<T>(key[0], data);
                        node.SubNodes.Add(key[0], newNode);
                        AddNode(key.Substring(1), data, newNode);
                    }
                }
            }
            
        }
        public void Remove(string key)
        {
            throw new NotImplementedException();
        }
        public T Search(string key)
        {
            throw new NotImplementedException();
        }
    }
}
