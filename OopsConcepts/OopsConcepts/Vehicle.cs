using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    public class Vehicle
    {
        public int speed {  get; set; }

        public void showSpeed()
        {
            Console.WriteLine("Speed: " + speed);
        }
    }
}
