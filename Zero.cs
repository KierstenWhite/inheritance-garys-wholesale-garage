//We will represent types of vehicles using C# classes.
// Zero is a motorcycle
namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public void ChargeBattery()
        {
            // method definition omitted
        }

        //Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zooms past. Bbbbbzzzz!"); //To have each vehicle make its own sound, you need to do two things. 2)Override the method in the child class.
        }
    }
}