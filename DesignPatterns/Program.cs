﻿using System;
using System.Text;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            var payment = PaymentFactory.CreatePayment(PaymentMethod.ApplePay);
            payment.Pay(290.23);
        }
    }
}
