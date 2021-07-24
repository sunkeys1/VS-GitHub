using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {

        public string SecName { get; set; }

        public string Name { get; set; }

        public string FullName
        { 
            get
            {
                return Name + " " + SecName;
            }
        }

        public string ShortName
        {
            get
            {
                return $"Фамилия: {SecName} Имя: {Name.Substring(0,1)}.";
            }

        }
        
        // конструкторы:
        public Person(string secondName, string name)
        {
            SecName = secondName;
            Name = name;

        }

        //private string _name;
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException("Имя не может быть пустым!");
        //        }
        //        _name = value; 
        //    }
        //}
        

        
        
        //public string GetName()
        //{
        //    return _name;
        //}
        //public void SetName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        throw new ArgumentNullException("Имя не может быть пустым!");
        //    }
        //    _name = name;

        //}


    }
}
