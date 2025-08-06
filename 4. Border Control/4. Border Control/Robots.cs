using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Border_Control
{
    public class Robots : IRobots
    {
        private string model;
        private string id;
        public Robots(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model 
        { 
            get
            { 
            return this.model;
            }
            private set
            {
            model = value;
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
                this.id = value;
            }
        }
    }
}
