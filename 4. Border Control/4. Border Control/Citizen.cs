using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Border_Control
{
    public class Citizen:ICitizen
    {
        private string name;
        private int age;
        private string id;
        
        public Citizen(string name,int age,string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            
        }

        public string Name
        {
            get
            {
                return this.Name;

            }
            private set
            {
                this.name = value;
            }
        }

        public int Age 
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        
        }
        public string Id 
        {
            get 
            {
            return this.id;
            }

            private set
            {
                if (long.Parse(value) < 1)
                {
                    throw new ArgumentException("ID cannot be negative.");
                }
                this.id = value;
            } 
       
        }
    }
}
