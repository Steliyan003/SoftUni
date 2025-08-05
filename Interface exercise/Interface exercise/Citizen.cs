using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_exercise
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age

        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}
