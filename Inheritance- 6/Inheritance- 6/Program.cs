using System.Collections.Concurrent;
using System.Reflection;
using System.Xml.Linq;

namespace Inheritance__6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the type of animal ");
            string typeAnimal = Console.ReadLine();
          
            while (typeAnimal!="Beast !")
            {          
                Console.Write("Write the name ");
               string name = Console.ReadLine();
                Console.Write("Write the age ");
               int age = int.Parse(Console.ReadLine());
                if (age < 0)
                 {
                      Console.WriteLine("Invalid input!");
                      return;
                }
                Console.Write("Write the gender ");
               string gender = Console.ReadLine();

                if (typeAnimal == "Cat")
                {
                    Cat cat = new Cat(typeAnimal, name, age, gender);
                    Console.WriteLine(typeAnimal);
                    Console.WriteLine($"{name} {age} {gender}");
                    cat.ProduceSound();
                }

                if (typeAnimal == "Dog")
                {
                    Dog dog = new Dog(typeAnimal, name, age, gender);
                    Console.WriteLine(typeAnimal);
                    Console.WriteLine($"{name} {age} {gender}");
                    dog.ProduceSound();
                }

                if (typeAnimal == "Frog")
                {
                    Frog frog = new Frog(typeAnimal, name, age, gender);
                    Console.WriteLine(typeAnimal);
                    Console.WriteLine($"{name} {age} {gender}");
                    frog.ProduceSound();
                }

                if (typeAnimal == "Kitten")
                {
                    Kitten kitten = new Kitten(typeAnimal, name, age, gender);
                    Console.WriteLine(typeAnimal);
                    Console.WriteLine($"{name} {age} {gender}");
                    kitten.ProduceSound();
                }

                if (typeAnimal == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(typeAnimal, name, age, gender);
                    Console.WriteLine(typeAnimal);
                    Console.WriteLine($"{name} {age} {gender}");
                    tomcat.ProduceSound();
                }
                Console.Write("Write the type of animal ");
                    typeAnimal = Console.ReadLine();
            }
               
        }
    }
}
