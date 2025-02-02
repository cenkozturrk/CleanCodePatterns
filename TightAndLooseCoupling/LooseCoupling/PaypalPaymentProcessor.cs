using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightAndLooseCoupling.LooseCoupling
{
    public class PaypalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            string text = $"Processing payment of ${amount} through PayPal.";
            Console.WriteLine(text);
        }
    }

    public class StripePaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            string text = $"Processing payment of ${amount} through Stripe.";
            Console.WriteLine(text);
        }
    }
    public class OrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public OrderService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void Checkout(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
            Console.WriteLine("Order completed.");
        }
    }
}
