using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Robot : IRobot
    {
        private string model;
        private long id;

        public Robot(string model, long id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model
        {
            get =>this.model; 
            private set
            {
                this.model = value;
            }
        }

        public long Id
        {
            get=>this.id;
            private set
            {
                this.id = value;
            }
        }
    }
}
