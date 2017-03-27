using System;

namespace Soru1.PaymentConcretes
{
    public class CreditCardPayment : IPayment
    {
        public bool DoPayment()
        {
            Console.WriteLine("Kredi Kartı ile Ödeme");
            return true;
        }
    }
}
