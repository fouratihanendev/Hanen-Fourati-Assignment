using Shaps_Project.Classes;

namespace Shap_Unit_Test_Project
{
    public class CalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetShapes_ReturnsCorrectNumberOfShapes()
        {
            // Arrange
            int n = 5;

            // Act
            List<Shape> shapes = Calculator.GetShapes(n);

            // Assert
            Assert.That(shapes.Count, Is.EqualTo(n));
        }

        [Test]
        public void GetSumOfCircles_CalculatesCorrectSum()
        {
            // Arrange
            List<Shape> shapes = new List<Shape>
            {
                new Circle(2),
                new Rectangle(3, 4),
                new Circle(1.5),
                new Rectangle(2, 2),
                new Circle(3)
            };

            // Act
            double sum = Calculator.GetSumOfCircles(shapes);

            // Assert
            Assert.That(sum, Is.EqualTo(2 * Math.PI * 2 + 2 * Math.PI * 1.5 + 2 * Math.PI * 3).Within(0.0001));
        }

        [Test]
        public void OptimizedGetSumOfCircles_CalculatesCorrectSum()
        {
            // Arrange
            List<Shape> shapes = new List<Shape>
            {
                new Circle(2),
                new Rectangle(2, 4),
                new Circle(1.5),
                new Rectangle(2, 3),
                new Circle(4)
            };

            // Act
            double sum = Calculator.OptimizedGetSumOfCircles(shapes);

            // Assert
            Assert.That(sum, Is.EqualTo(2 * Math.PI * 2 + 2 * Math.PI * 1.5 + 2 * Math.PI * 4).Within(0.0001));
        }

    }
}
