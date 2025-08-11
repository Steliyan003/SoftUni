using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace ExplicitInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a name, country and age")
            string[] smd = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            List<Citizen> citizens = new List<Citizen>();

            while (!smd.Contains("End"))
            {
                if (smd.Length == 3)
                {
                    string name = smd[0];
                    string country = smd[1];
                    int age = int.Parse(smd[2]);
 
                    Citizen citizen = new Citizen(name, country, age);
                    citizens.Add(citizen);
                }

                smd = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            }
            foreach(var citizen in citizens)
            {
                IResident resident = citizen;
                IPerson person = citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine($"{resident.GetName()} {person.GetName()}");
            }

        }
    }
}
