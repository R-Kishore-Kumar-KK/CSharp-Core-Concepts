using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApplication
{
    public class DebitCardPayment : Payment
    {
        public string cardNumber { get; set; }

        public DebitCardPayment(double amount, string payerName, string cardNumber) : base(amount, payerName)
        {
            this.cardNumber = cardNumber;
        }

        public override void processPayment()
        {
            Console.WriteLine($"Processing debit card payment for '{payerName}' of '{amount}' using card '{cardNumber}'");
        }
    }
}
