
namespace Shaps_Project.Classes
{
    public class Rectangle : Shape
    {
        // Properties
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        // Constructor
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        // Method to calculate area
        public override double Area()
        {
            return Side1 * Side2;
        }

        // Method to calculate perimeter
        public override double Perimeter()
        {
            return 2 * (Side1 + Side2);
        }
    }
}
