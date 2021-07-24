using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Kiborg : ICar, IPerson
    {
        public double Speed(double speed)
        {
            throw new NotImplementedException();
        }

        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }
    }
}
