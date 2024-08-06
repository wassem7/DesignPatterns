using System;

namespace DesignPatterns
{
    public class PaymentFactory
    {
        public static IPayment CreatePayment(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();

                case PaymentMethod.Paypal:
                    return new PaypalPayment();

                default:
                    throw new NotSupportedException($"{paymentMethod} currently not supported");
            }
        }
    }
}
