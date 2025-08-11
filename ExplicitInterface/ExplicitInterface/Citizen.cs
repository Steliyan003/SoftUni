using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    public class Citizen : IResident, IPerson
    {
       private string name ;
        
        private string country;
        private int age;

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
            
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }

        public string Country
        {
            get => country;
           private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Country cannot be null or empty.");
                }
                country = value;
            }
        }

        public int Age
        {
            get => age;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                age = value;
            }
        }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs";
        }

        string IPerson.GetName()
        {
            return this.name;
        }
    }
}
