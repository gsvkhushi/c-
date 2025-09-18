namespace PaymentApp
{
    using PaymentApp;
    using System;

    namespace Store
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Payment creditCardPayment = new CreditCardPayment(2000, DateTime.Now, "1234567890", "abc");
                creditCardPayment.ProcessPayment();

                Payment upiPayment = new UPIPayment(100, DateTime.Now, "abc.upi", "Union  Bank");
                upiPayment.ProcessPayment();
            }
        }
    }

}