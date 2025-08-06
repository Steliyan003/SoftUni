namespace _4._Border_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                            .Split(' ' , StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            List<IIdentificator> entities = new List<IIdentificator>();

            while (!input.Contains("End"))
            {
                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id1 = input[2];
                    ICitizen citizen = new Citizen(name, age, id1);
                    entities.Add(citizen);
                }
                else if (input.Length == 2)
                {
                    string model = input[0];
                    string id2 = input[1];
                    IRobots robot = new Robots(model, id2);
                    entities.Add(robot);
                }

                input = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            }

            string id= Console.ReadLine();
            foreach (var entity in entities)
            {
                if (entity.Id.Contains(id) )
                {
                    Console.WriteLine(entity.Id);
                }
            }

        }
    }
}
