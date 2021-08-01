using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_n_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"F:\hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach(var attribute in attributes)
            {
                Console.WriteLine(attribute);

            }
            var properties = type.GetProperties();
            foreach(var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);
                if(attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name);
                }
                
                
                //foreach (var a in attrs)
                //{
                //    Console.WriteLine(a);
                //}


            }





            Console.ReadLine();
        }
    }
}
