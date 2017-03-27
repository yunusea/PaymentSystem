using System;

namespace Soru1.PaymentConcretes
{
    public class CashPayment : IPayment
    {
        public bool DoPayment()
        {
            Console.WriteLine("Nakit Ödeme");
            return true;
        }
    }
}
