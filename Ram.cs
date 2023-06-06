//We will represent types of vehicles using C# classes.

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public void RefuelTank()
        {
            // method definition omitted
        }

        //Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. Vroooom!"); //To have each vehicle make its own sound, you need to do two things. 2)Override the method in the child class.
        }
    }
}