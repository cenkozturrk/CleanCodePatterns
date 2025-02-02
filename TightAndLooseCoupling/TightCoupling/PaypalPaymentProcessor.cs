
// Tight Coupling Example 
// Hard to extend or test because dependencies are fixed.



//namespace TightAndLooseCoupling.TightCoupling
//{
//    public class PaypalPaymentProcessor
//    {
//        public void ProcessPayment(decimal amount)
//        {
//            Console.WriteLine($"Processing payment of ${amount} through PayPal.");
//        }
//    }

//    public class OrderService
//    {
//        private readonly PaypalPaymentProcessor _paymentProcessor = new PaypalPaymentProcessor();

//        public void Checkout(decimal amount)
//        {
//            _paymentProcessor.ProcessPayment(amount);
//            Console.WriteLine("Order completed.");
//        }
//    }

//}
