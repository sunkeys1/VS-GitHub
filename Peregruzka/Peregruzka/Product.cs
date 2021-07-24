using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peregruzka
{
    public abstract class Product
    {
        public string Name { get; }

        public int Calorie { get; }

        public int Volume { get; set; }

        public double Energy
        {
            get
            {
                return Volume * Calorie / 100.0;
            }
            set
            {

            }

        }

        public Product(string name, int calorie, int volume)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));

            }

            if (volume <= 0)
            {
                throw new ArgumentException(nameof(volume));

            }

            if (calorie < 0)
            {
                throw new ArgumentException(nameof(calorie));

            }

            Name = name;
            Calorie = calorie;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name}. Калорийность: {Calorie}, объем: {Volume}.";
        }
    }
}
