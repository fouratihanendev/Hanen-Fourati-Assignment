
namespace Shaps_Project.Classes
{
    public class Circle : Shape
    {
        // Properties
        public double Radious { get; set; }

        // Constructor
        public Circle(double radious)
        {
            Radious = radious;
        }

        public Circle()
        {
        }

        // Method to calculate area
        public override double Area()
        {
            return Math.PI * Radious * Radious; ;
        }

        // Method to calculate perimeter
        public override double Perimeter()
        {
            return 2 * Math.PI * Radious;
        }
    }
}
