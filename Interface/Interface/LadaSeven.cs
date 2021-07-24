using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class LadaSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 40;
        }
        public double Speed(double speed)
        {   
            return 160 / speed;
        }
    }
}
