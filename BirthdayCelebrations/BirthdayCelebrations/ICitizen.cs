using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public interface ICitizen
    {
        public string Name { get; }
        public int Age { get; }
        public long Id { get; }
        string BirthDate { get; }
        
    }
}
