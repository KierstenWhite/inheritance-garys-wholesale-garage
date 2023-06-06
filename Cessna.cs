//We will represent types of vehicles using C# classes.

namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("Zoooooooom!"); //To have each vehicle make its own sound, you need to do two things. 2)Override the method in the child class.
        }
    }
}