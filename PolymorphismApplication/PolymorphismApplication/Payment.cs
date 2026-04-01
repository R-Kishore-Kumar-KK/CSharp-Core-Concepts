using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApplication
{
    public class Payment
    {
        public double amount {  get; set; }
        public string payerName { get; set; }

        public Payment(double amount, string payerName)
        {
            this.amount = amount;
            this.payerName = payerName;
        }

        public virtual void processPayment()
        {
            Console.WriteLine($"Processing payment for '{payerName}' in general Way.");
           
        }
    }
}
