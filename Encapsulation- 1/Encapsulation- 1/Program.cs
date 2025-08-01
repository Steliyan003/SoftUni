namespace Encapsulation__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write length");
            double length= double.Parse(Console.ReadLine());
            Console.WriteLine("Write width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Write height");
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
