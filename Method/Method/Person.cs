using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Person
    {
        public string SecondName { get; set; }
        
        public string Name { get; set; }

        public int x { get; set; }

        public int y { get; set; }
        //public Person(string secondName, string name)
        //{
        //    SecondName = secondName;
        //    Name = name;
        //    x = 0;
        //    y = 0;

        //}
        
        //public string Run()
        //{
        //    var rnd =  new Random();
        //    x += rnd.Next(-2, 2);
        //    y += rnd.Next(-2, 2);
        //    return $"{Name} ({x}, {y})";
        //}

        public string Run(int a, int b)
        {
            x += a;
            y += b;

           return $"{Name} ({x}, {y})";

        }

        //public string Run(int a)
        //{
            
           

        //    return $"{Name} ({x}, {y})";

        //}

        //public string Run(double a)
        //{
            
            

        //    return $"{Name} ({x}, {y})";

        //}


    }
}
