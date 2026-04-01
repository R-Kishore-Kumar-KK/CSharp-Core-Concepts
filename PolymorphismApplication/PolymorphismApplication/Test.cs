using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApplication
{
    public class Test : Payment
    {
        public Test(double amount, string payerName) : base(amount, payerName)
        {
        }

        public void processPayment()
        {
            Console.WriteLine($"Processing test payment for '{payerName}' of '{amount}' in Rupees.");

        }
    }
}
