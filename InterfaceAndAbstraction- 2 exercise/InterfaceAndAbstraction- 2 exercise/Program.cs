namespace InterfaceAndAbstraction__2_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a name");
            string name = Console.ReadLine();
            Console.WriteLine("Write an age");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Write an Id");
            string id=Console.ReadLine();
            Console.WriteLine("Write a birthdate");
            string birthdate=Console.ReadLine();

            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable ibirthable = new Citizen(name, age, id, birthdate);

            Console.WriteLine(identifiable.Id);
            Console.WriteLine(ibirthable.Birthdate);

        }
    }
}
