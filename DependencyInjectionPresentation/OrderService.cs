namespace DependencyInjectionPresentation
{
    public class OrderService
    {
        private readonly ICustomerNotifier _notifier;

        public OrderService(ICustomerNotifier notifier)
        {
            _notifier = notifier;
        }

        public void PlaceOrder(Order order)
        {
            // save the order in DB here
            // ...

            var complexMessage = "Your order was successfully placed!";
            _notifier.NotifyCustomer(order.CustomerId, complexMessage);
        }
    }

    public class BadOrderService
    {
        public void PlaceOrder(Order order)
        {
            // save the order in DB here
            // ...

            var complexMessage = "Your order was successfully placed!";
            var notifier = new SmsNotifier();
            notifier.NotifyCustomer(order.CustomerId, complexMessage);
        }
    }
}