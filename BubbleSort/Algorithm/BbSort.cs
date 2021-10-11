using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BbSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;

            for(int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - j - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    if (a.CompareTo(b) == 1) // компарабле для сравнения штук с T типом можно юзать
                    {
                        Swap(i, i + 1);
                        ComparisonCount++;
                    }
                }
                
            }
            

        }
    }
}
