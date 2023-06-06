//Since all of the types are vehicles, a good name for this new type would be Vehicle.
//Then each of the other, more specific, types would inherit from it. We use a colon between the class name and the base class name when inheriting.

// namespace Garage
// {
//     public class Vehicle
//     {
//         public string MainColor { get; set; }
//         public int MaximumOccupancy { get; set; }
//     }
// }

/*
To this point, you've seen how to inherit common properties from a parent class, 
and now you're going to implement a behavior on a parent class. Each child class 
will automatically inherit it, but then an override the default logic.

You can safely assume that each vehicle can be driven. What you would then do is 
implement a Drive() method on the Vehicle class.

*/
namespace Garage
{
    public class Vehicle
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        //Create a Drive() method in the Vehicle class.
        public virtual void Drive() //To have each vehicle make its own sound, you need to do two things. 1) Define the Drive() method as virtual.
        {
            Console.WriteLine("Vrooom!");
        }
    }
}