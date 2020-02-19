using System;

namespace DependencyInjectionPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            var customerId = 77;
            orderService.PlaceOrder(customerId);
        }
    }
}
