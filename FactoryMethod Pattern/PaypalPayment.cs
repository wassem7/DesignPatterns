using System;

namespace DesignPatterns
{
    public class PaypalPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Amount ${amount} paid with PAYPAL PAY");
        }
    }
}
