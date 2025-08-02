namespace ClassBoxData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write the length");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Write the width");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Write the height");
                double height = double.Parse(Console.ReadLine());
               

                Box box = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {box.SurfaceArea(width, height, length):f2} ");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea(width, height, length):f2}");
                Console.WriteLine($"Volume - {box.Volume(width, height, length):f2}");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
