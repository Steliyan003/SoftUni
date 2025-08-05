using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstraction__2_exercise
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        string name;
        int age;
        string id;
        string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate=birthdate; 
        }

        public string Name 
        { 
            get
            {
                return this.name;
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
                return this.age;
            }
             set
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
             set
            {
                this.id = value;
            }
        }

        public string Birthdate
        {
            get
            {
                return this.birthdate;
            }
             set
            {
                this.birthdate = value;
            }
        }

        
    }
}
