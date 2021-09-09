using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie<int>();
            trie.Add("привет", 50);
            trie.Add("мир", 100);
            trie.Add("приз", 200);
        }
    }
}
