using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__6
{
    public class Animals
    {
        string TypeAnimals { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string Gender { get; set; }

        public Animals(string typeAnimal,string name, int age, string gender)
        {
            this.TypeAnimals = typeAnimal;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;           
           
        }
        public virtual void ProduceSound()
        { 
        }
    }
}
