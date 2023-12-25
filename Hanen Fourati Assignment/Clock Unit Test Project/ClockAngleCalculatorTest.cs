using Clock_Project.Classes;

namespace Clock_Unit_Test_Project
{
    public class ClockAngleCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetClockAngle()
        {
            // Arrange
            int hour = 3;
            int minute = 15;

            // Act
            double result = ClockAngleCalculator.GetClockAngle(hour, minute);

            // Assert
            double expectedValue = 7.5;
            Assert.That(result, Is.EqualTo(expectedValue));
        }

        [Test]
        public void GetClockAngle_InvalidHour_ThrowsArgumentException()
        {
            // Arrange
            int invalidHour = 15;
            int minute = 30;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => ClockAngleCalculator.GetClockAngle(invalidHour, minute));
        }

        [Test]
        public void GetClockAngle_InvalidMinute_ThrowsArgumentException()
        {
            // Arrange
            int hour = 4;
            int invalidMinute = 80;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => ClockAngleCalculator.GetClockAngle(hour, invalidMinute));
        }
    }
}