using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Pet : IPet
    {
        private string name;
        private string birthDate;

        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                this.name = value;
            }
        }

        public string BirthDate
        {
            get => this.birthDate;
                private set
                {
                
                this.birthDate=value;
                }
        }
    }
}
