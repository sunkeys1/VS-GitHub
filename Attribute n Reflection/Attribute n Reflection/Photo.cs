using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_n_Reflection
{
    
    public class Photo
    {
        [Geo(10, 20)]
        public string Path { get; set; }
        public string Name { get; set; }

        public Photo (string name)
        {
            // проверка
            Name = name;
        }
    }
}
