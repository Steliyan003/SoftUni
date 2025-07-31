using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__6
{
    public class Cat:Animals
    {
        public Cat(string typeAnimal,string name, int age, string gender)
            :base(typeAnimal,name,age,gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow meow");
        }

    }
}
