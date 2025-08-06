using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Border_Control
{
    public interface IRobots: IIdentificator
    {
        public string Model { get; }
    }
}
