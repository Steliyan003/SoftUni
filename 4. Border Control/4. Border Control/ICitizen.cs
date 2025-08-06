using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Border_Control
{
    public interface ICitizen: IIdentificator
    {
        public string Name { get; }
        public int Age { get; }

        
        
    }
}
