

namespace Shaps_Project.Classes
{
    public abstract class Shape
    {
        // Properties
        public Location Location { get; set; }

        // Method Signature
        public abstract double Area();
        public abstract double Perimeter();
    }
}
