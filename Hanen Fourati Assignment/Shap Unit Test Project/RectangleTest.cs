using Shaps_Project.Classes;

namespace Shap_Unit_Test_Project
{
 
        public class RectangleTest
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void Rectangle_Area_CalculatedCorrectly()
            {
                // Arrange
                double side1 = 4;
                double side2 = 6;
                Rectangle rectangle = new Rectangle(side1, side2);

                // Act
                double area = rectangle.Area();

                // Assert
                Assert.That(area, Is.EqualTo(side1 * side2).Within(0.0001));
            }

            [Test]
            public void Rectangle_Perimeter_CalculatedCorrectly()
            {
                // Arrange
                double side1 = 4;
                double side2 = 6;
                Rectangle rectangle = new Rectangle(side1, side2);

                // Act
                double perimeter = rectangle.Perimeter();

                // Assert
                Assert.That(perimeter, Is.EqualTo(2 * (side1 + side2)).Within(0.0001));
            }
        }
    
}
