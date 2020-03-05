using System;

namespace DependencyInjectionPresentation
{
    class Program
    {
        static void Main()
        {
            //var notifier = new EmailNotifier();
            var notifier = new SmsNotifier();
            var orderService = new OrderService(notifier);
            var customerId = 77;
            orderService.PlaceOrder(customerId);
        }
    }
}
