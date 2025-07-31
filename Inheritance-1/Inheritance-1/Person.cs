using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            if(age<0)
            {
              throw new ArgumentException("Age cannot be negative.");
            }
        }
        
    }
}
