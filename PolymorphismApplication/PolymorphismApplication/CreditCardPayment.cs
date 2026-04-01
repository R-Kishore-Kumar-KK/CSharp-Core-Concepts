using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApplication
{
    public class CreditCardPayment :Payment
    {
        public string cardNumber {  get; set; }

        public CreditCardPayment(double amount, string payerName, string cardNumber) :base(amount, payerName)
        { 
           this.cardNumber = cardNumber;
        }

        public override void processPayment()
        {
            Console.WriteLine($"Processing credit card payment for '{payerName}' of '{amount}' using card '{cardNumber}'");
        }
    }
}
