namespace DependencyInjectionPresentation
{
    class Program
    {
        static void Main()
        {
            //var notifier = new EmailNotifier();
            var notifier = new SmsNotifier();

            var orderService = new OrderService(notifier);
            
            var order = new Order
            {
                CustomerId = 77,
                //...
            };
            orderService.PlaceOrder(order);
        }
    }
}
