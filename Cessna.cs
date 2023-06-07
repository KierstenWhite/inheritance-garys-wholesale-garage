//We will represent types of vehicles using C# classes.
//Cessna is a plane
namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public void RefuelTank()
        {
            // method definition omitted
        }

        //Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Zoooooooom!"); //To have each vehicle make its own sound, you need to do two things. 2)Override the method in the child class.
        }

        //Override all three of those methods on some of the vehicles. 
        public override void Turn(string direction)
        {
            Console.WriteLine("The Cessna did a loop in the sky.");
        }

        //Override all three of those methods on some of the vehicles. 
        public override void Stop()
        {
            Console.WriteLine("The plane landed in the ocean.");
        }
    }
}