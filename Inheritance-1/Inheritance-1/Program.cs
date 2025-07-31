using System.Xml.Linq;

namespace Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age= int.Parse(Console.ReadLine());
          
                Child child = new Child(name, age);
                child.DisplayInfo();
            
           
           

        }
    }
}
