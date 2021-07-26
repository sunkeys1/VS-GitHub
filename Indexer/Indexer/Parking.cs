using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Parking
    {
        private List<Car> _cars = new List<Car>();
        private const int  Max_Cars = 100; 

        public Car this[string number]
        {
            get
            {
                var car = _cars.FirstOrDefault(c => c.Number == number);
                return car;
            }
 

        }

        public Car this[int position]
        {
            get
            {
                if(position < _cars.Count)
                {
                    return _cars[position];
                }
                return null;
            }
            set
            {
                if (position < _cars.Count)
                {
                    _cars[position] = value;
                }
            }
        }
        public int Count => _cars.Count;
        public string Name { get; set; }
        
        public int Add(Car car)
        {
            if(car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null");
            }
            if(_cars.Count < Max_Cars)
            {
                _cars.Add(car);
                return _cars.Count - 1;
            }
            else
            {
                return -1;
            }

            
        }
        public void GoOut (string number)
        {
            if(string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number null or empty");

            }
            var car = _cars.FirstOrDefault(c => c.Number == number);
            if(car != null)
            {
                _cars.Remove(car);
            }
        }
    }
}
