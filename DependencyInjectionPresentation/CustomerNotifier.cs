namespace DependencyInjectionPresentation
{
    public interface ICustomerNotifier
    {
        void NotifyCustomer(int customerId , string message);
    }

    public class EmailNotifier : ICustomerNotifier
    {
        public void NotifyCustomer(int customerId, string message)
        {
            throw new System.NotImplementedException();
        }
    }


    public class SmsNotifier : ICustomerNotifier
    {
        public void NotifyCustomer(int customerId, string message)
        {
            throw new System.NotImplementedException();
        }
    }
}