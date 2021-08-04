using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    //[Serializable]
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public Group Group { get; set; }
        public Student(string name, int age)
        {
            // проверка входных данных
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
