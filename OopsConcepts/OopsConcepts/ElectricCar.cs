using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    public class ElectricCar : Car
    {
        public int batteryLevel { get; set; }

        public void showBattery()
        {
            Console.WriteLine("Battery Level: " + batteryLevel);
        }
    }
}
