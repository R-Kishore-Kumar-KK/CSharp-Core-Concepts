using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApplication
{
    public class CashPayment : Payment
    {
        public CashPayment(double amount, string payerName) : base(amount, payerName)
        {

        }

        public override void processPayment()
        {
            Console.WriteLine($"Processing cash payment for '{payerName}' in Rupees.");

        }
    }
}
