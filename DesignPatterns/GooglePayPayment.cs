using System;

namespace DesignPatterns
{
    public class GooglePay : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Payment of $ {amount} made with GOOGLE PAY");
        }
    }
}
