using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Citizen : ICitizen
    {
        private string name;
        private int age;
        private long id;
        private string date;

        public Citizen(string name, int age, long id, string date)
        {
            this.Name = name;
            this.Age= age;
            this.Id = id;
            this.BirthDate = date;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if(value<0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                this.age = value;
            }
        }

        public long Id
        {
            get=>this.id;
            private set
            {
                if(value<=0)
                {
                    throw new ArgumentException("Id cannot be zero or negative");
                }
                this.id = value;
            }
        }

        public string BirthDate
        {
            get => this.date;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birthdate cannot be null");
                }
                this.date = value;
            }
        }
    }
}
