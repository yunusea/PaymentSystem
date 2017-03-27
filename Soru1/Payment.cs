using Soru1.PaymentConcretes;

namespace Soru1
{
    public class Payment
    {
        public IPayment GetInstance(PaymentType paymentType)
        {
            IPayment payment;
            switch (paymentType)
            {
                case PaymentType.Cash:
                    payment = new CashPayment();
                    break;
                case PaymentType.CreditCard:
                    payment = new CreditCardPayment();
                    break;
                default:
                    payment = new DefaultPayment();
                    break;
            }
            return payment;
        }
    }
}
