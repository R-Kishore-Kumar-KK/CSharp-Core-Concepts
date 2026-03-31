using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    public class Bike : Vehicle
    {
        public String type { get; set; }

        public void showType()
        {
            Console.WriteLine("Bike Type: " + type);
        }
    }
}
