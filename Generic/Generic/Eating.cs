using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Eating<T>
        where T: Product<T>
    {
        public int Volume { get; private set; }

        public T Add(T product)
        {
            return default(T);

        }

    }
}
