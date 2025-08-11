using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
    public class Child : Person
    { 
        public Child(string name, int age) 
            : base(name, age)
        { 
            if(age>15)
            {
             throw new ArgumentException("Age cannot be greater than 15 for a child.");
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
