
namespace Clock_Project.Classes
{
    public class ClockAngleCalculator
    {
        // Exercise 2:  Que hora es?
        public static double GetClockAngle(int hour, int minute)
        {
            const int degreesPerHour = 30;  // Each hour represents 30 degrees (360 degrees / 12 hours)
            const int degreesPerMinute = 6; // Each minute represents 6 degrees (360 degrees / 60 minutes)

            // Validate input values
            if (hour < 0 || hour >= 12)
            {
                throw new ArgumentException("Hour value must be between 0 and 11.");
            }

            if (minute < 0 || minute >= 60)
            {
                throw new ArgumentException("Minute value must be between 0 and 59.");
            }

            // Calculate the angle of the hour hand from 12 o'clock
            double hourAngle = (hour % 12) * degreesPerHour + minute * 0.5; // Each minute adds 0.5 degrees to the hour hand

            // Calculate the angle of the minute hand from 12 o'clock
            double minuteAngle = minute * degreesPerMinute;

            // Calculate the absolute difference between the two angles
            double angle = Math.Abs(hourAngle - minuteAngle);

            // Ensure the angle is not greater than 180 degrees
            if (angle > 180)
            {
                angle = 360 - angle;
            }

            return angle;
        }
    }
}
