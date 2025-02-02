using TightAndLooseCoupling.LooseCoupling;

Console.WriteLine("Choose Payment Method: 1. PayPal  2. Stripe");
int choice = Convert.ToInt32(Console.ReadLine());

IPaymentProcessor paymentProcessor = choice == 1
    ? new PaypalPaymentProcessor()
    : new StripePaymentProcessor();

var orderService = new OrderService(paymentProcessor);
orderService.Checkout(100);
