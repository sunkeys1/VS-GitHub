using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_type_Object
{
    class Point
    {
        public int X { get; set; }
        public Point Y { get; set; } //public MyClass MyClass { get; set; }

        public override bool Equals(object obj) // если вылезает null это не должен быть exeption 
        {                                       // и нужно вернуть false
            //if(obj == null)
            //{
            //    return false;
            //}

            //var point = obj as Point;  всю вот эту конструкцию можно заменить на: (29)
            //if(point != null)
            //{

            //}
            //else
            //{
            //    return false;
            //}
            if(obj is Point point)
            {
                return point.X == X;
            }
            else
            {
                return false;
            }
            

        }
        public override int GetHashCode()
        {
            return X;
        }
        public override string ToString()
        {
            return X.ToString(); //base.ToString(); 
        }

        public new Type GetType()
        {
            return typeof(UInt32);  // переопределение стандартного типа (new)

        }
        public Point Clone()
        {
            return MemberwiseClone() as Point;
            
        }

    }
}
