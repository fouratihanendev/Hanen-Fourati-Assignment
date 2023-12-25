
namespace Shaps_Project.Classes
{
    public class Calculator
    {
        // Properties
        private static readonly Random random = new Random();


        // Methods
        // Exercise 1:  Qst 2
        public static List<Shape> GetShapes(int n)
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= n;)
            {
                Shape shape;

                if (FlipCoin()) // As required, We flip a coin to decide whether it’s a circle or a rectangle
                {
                    // Create a Circle
                    double radius = random.NextDouble();
                    shape = new Circle(radius);
                }
                else
                {
                    // Create a Rectangle
                    double side1 = random.NextDouble(); 
                    double side2 = random.NextDouble();
                    shape = new Rectangle(side1, side2);
                }

                // Check if the perimeter matches the index
                if (((int)shape.Perimeter()) == i)
                {
                    // Add the matching shape to the list
                    shapes.Add(shape);
                    i++; // increment index
                }
            }

            return shapes;
        }

        private static bool FlipCoin()
        {
            return random.Next(2) == 0;
        }

        // Exercise 1:  Qst 3
        public static double GetSumOfCircles(List<Shape> shapes)
        {
            double sumOfCirclesPerimeters = 0;

            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    // Cast shape to circle
                    Circle circle = (Circle)shape;

                    // Sum up the Perimeters
                    sumOfCirclesPerimeters += circle.Perimeter();
                }
            }

            return sumOfCirclesPerimeters;
        }

        // Exercise 1:  Qst 4
        public static double OptimizedGetSumOfCircles(List<Shape> shapes)
        {
            double sumOfCirclesPerimeters = 0;

            // Use Parallel.ForEach as an optimization technique
            Parallel.ForEach(shapes, shape =>
            {
                if (shape is Circle)
                {
                    // Cast Shap to Circle
                    Circle circle = (Circle)shape;

                    // Sum up the Perimeters
                    sumOfCirclesPerimeters += circle.Perimeter();
                }
            });

            return sumOfCirclesPerimeters;
        }
    }
}
