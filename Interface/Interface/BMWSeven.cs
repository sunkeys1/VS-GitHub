using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class BMWSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 100;
        }

        public double Speed(double speed)
        {
            return 100 / speed;
        }
    }
}
