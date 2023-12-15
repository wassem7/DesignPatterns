using System;

namespace DesignPatterns
{
    public class GooglePayPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Amount ${amount} paid with GOOGLE PAY");
        }
    }
}
