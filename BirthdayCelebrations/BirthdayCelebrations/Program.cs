namespace BirthdayCelebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                            .Split(' ')
                            .ToArray();
            List<Citizen> citizen=new List<Citizen>();
            List<Pet> pet=new List<Pet>();

            while(!input.Contains("End"))
            {
                if (input.Length == 5)
                {
                    string type = input[0];
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    long id = long.Parse(input[3]);
                    string date = input[4];

                    Citizen citizens = new Citizen(name, age, id, date);
                    citizen.Add(citizens);
                }

                else if (input.Length == 3)
                {
                    string type = input[0];
                    if (type == "Pet")
                    {
                        string name = input[1];
                        string birthDate = input[2];
                        Pet pets = new Pet(name, birthDate);
                        pet.Add(pets);
                    }

                    else if (type == "Robot")
                    {
                        string model = input[1];
                        long id = long.Parse(input[2]);
                        IRobot robot = new Robot(model, id);
                    }
                }
                input=Console.ReadLine()
                        .Split(' ')
                        .ToArray();
            }
            string year=Console.ReadLine();

            foreach (var citi in citizen)
            {
                if(citi.BirthDate.Contains(year))
                {
                    Console.WriteLine(citi.BirthDate);
                }
            }

            foreach(var pets in pet)
            {
                if(pets.BirthDate.Contains(year))
                {
                    Console.WriteLine(pets.BirthDate);
                }
            }
        }
    }
}
