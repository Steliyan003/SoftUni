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
                double surfaceArea = box.SurfaceArea(length, width, height);
                double lateralSurfaceArea = box.LateralSurfaceArea(length, width, height);
                double volume = box.Volume(length, width, height);

                Console.WriteLine($"Surface Area - {surfaceArea:F2}");
                Console.WriteLine($"Lateral Surface - {lateralSurfaceArea:F2}");
                Console.WriteLine($"Volume - {volume:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }
    }
}
