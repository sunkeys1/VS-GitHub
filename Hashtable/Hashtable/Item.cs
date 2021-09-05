using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    class Item<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }
        public Item(int key)
        {
            Key = key;
            Nodes = new List<T>();

        }
    }
}
