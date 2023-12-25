
namespace Clock_Project.Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            int hour;
            int minute;
            Console.Write("Enter hour: ");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minute: ");
            minute = Convert.ToInt32(Console.ReadLine());
            double angle = ClockAngleCalculator.GetClockAngle(hour, minute);
            Console.WriteLine($"Angle degree: {angle} degrees");
        }


    }
}