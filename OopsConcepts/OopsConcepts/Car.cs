using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts
{
    public class Car : Vehicle
    {
        public string model;

        public void showModel()
        {
            Console.WriteLine("Mode: " + model);
        }
    }
}
