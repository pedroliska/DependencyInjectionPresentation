using DependencyInjectionPresentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void PlaceOrder_NotifiesCustomer()
        {
            //// Arrange
            var notifierMock = new Mock<ICustomerNotifier>();
            var orderService = new OrderService(notifierMock.Object);

            //// Act
            orderService.PlaceOrder(new Order { CustomerId = 77 });

            //// Assert
            notifierMock.Verify(x => x.NotifyCustomer(77, "Your order was successfully placed!"), Times.Once);
        }
        [TestMethod]
        public void Testing_BadOrderService()
        {
            //// Arrange
            var orderService = new BadOrderService();

            //// Act
            orderService.PlaceOrder(new Order { CustomerId = 77 });

            //// Assert
            //notifierMock.Verify(x => x.NotifyCustomer(77, "Your order was successfully placed!"), Times.Once);
        }
    }
}
