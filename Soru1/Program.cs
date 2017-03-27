namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();
            var instance = payment.GetInstance(PaymentType.Cash);
            //var instance = payment.GetInstance(PaymentType.CreditCard);
            var result = instance.DoPayment();
        }
    }
}
