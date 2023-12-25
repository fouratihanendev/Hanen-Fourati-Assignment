using Shaps_Project.Classes;

namespace Shap_Unit_Test_Project
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Circle_Area_CalculatedCorrectly()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double expected = Math.PI * radius * radius;
            double actual = circle.Area();

            // Assert
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        public void Circle_Perimeter_CalculatedCorrectly()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double perimeter = circle.Perimeter();

            // Assert
            Assert.That(perimeter, Is.EqualTo(2 * Math.PI * radius).Within(0.0001));
        }

    }
}