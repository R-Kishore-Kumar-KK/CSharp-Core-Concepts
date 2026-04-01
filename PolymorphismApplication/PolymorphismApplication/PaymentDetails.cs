using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApplication
{
    public class PaymentDetails
    {
        public void makePayment(String cardNum, String cardHolderName)
        {
            Console.WriteLine($"Processsing Credit Payment for '{cardHolderName}' using Card No: '{cardNum}'");
        }

        public void makePayment(String cardNum, String cardHolderName, String pin)
        {
            Console.WriteLine($"Processsing Debit Payment for '{cardHolderName}' using Card No: '{cardNum}'");
        }

        public void makePayment(double cashAmount)
        {
            Console.WriteLine($"Processing cash payment of '{cashAmount}' Rupees");
        }
    }
}
