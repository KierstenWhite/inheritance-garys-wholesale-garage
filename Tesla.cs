//We will represent types of vehicles using C# classes.

// namespace Garage
// {
//     public class Tesla  // Electric car
//     {
//         public double BatteryKWh { get; set; }
//         public string MainColor { get; set; }
//         public int MaximumOccupancy { get; set; }

//         public void ChargeBattery()
//         {
//             // method definition omitted
//         }
//     }
// }

/*
When two classes are involved in an inheritance relationship, 
we call the more general type (e.g. Vehicle) the base class or 
parent class and we call the more specific (e.g. Tesla) the subclass 
or child class.
*/

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}