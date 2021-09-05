﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    class SuperHashTable<T>
    {
        private Item<T>[] items;
        public SuperHashTable(int size)
        {
            items = new Item<T>[size];

        }
        public void Add(T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item);
        }
        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }
        private int GetHash(T item)
        {
            return items.GetHashCode() % items.Length;
        }
    }
}
