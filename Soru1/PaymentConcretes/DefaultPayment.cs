using System;

namespace Soru1.PaymentConcretes
{
    public class DefaultPayment : IPayment
    {
        public bool DoPayment()
        {
            Console.WriteLine("Ödeme Seçimi Yapınız");
            return true;
        }
    }
}
