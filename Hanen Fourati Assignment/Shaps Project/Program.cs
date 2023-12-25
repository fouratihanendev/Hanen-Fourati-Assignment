
namespace Shaps_Project.Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            List<Shape> shapes = Calculator.GetShapes(n);
            double sumOfCirclesPerimeters = Calculator.GetSumOfCircles(shapes);
            double OptimizedsumOfCirclesPerimeters = Calculator.OptimizedGetSumOfCircles(shapes);
            Console.WriteLine("Generated Shapes:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Type: {shape.GetType().Name} | Perimeter: {shape.Perimeter()}");
            }
            Console.WriteLine($"Sum Of Generated Circles: {sumOfCirclesPerimeters}");
            Console.WriteLine($"Optimized Sum Of Generated Circles: {OptimizedsumOfCirclesPerimeters}");
        }


    }
}