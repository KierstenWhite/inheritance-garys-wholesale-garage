﻿using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            //fxs.Drive();
            //modelS.Drive();
            //mx410.Drive();

            //Create an instance of each vehicle.
            Zero zero1 = new Zero();
            Tesla tesla1 = new Tesla();
            Cessna cessna1 = new Cessna();
            Ram ram1 = new Ram();

            //Define a different value for each vehicle's properties.
            zero1.FuelCapacity = 12;
            zero1.MainColor = "Purple";
            zero1.MaximumOccupancy = 2;

            tesla1.FuelCapacity = 17;
            tesla1.MainColor = "Red";
            tesla1.MaximumOccupancy = 2;
            tesla1.BatteryKWh = 12;

            ram1.FuelCapacity = 10;
            ram1.MainColor = "White";
            ram1.MaximumOccupancy = 22;

            cessna1.FuelCapacity = 154;
            cessna1.MainColor = "White";
            cessna1.MaximumOccupancy = 234;

            cessna1.Drive();
            ram1.Drive();
            tesla1.Drive();
            zero1.Drive();

        }
    }
}