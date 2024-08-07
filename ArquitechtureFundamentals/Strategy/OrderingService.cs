namespace ArchitectureStudies.Strategy
{
    public class OrderingService : IOrderingService
    {
        public OrderingService(IPayment payment)
        {
            _payment = payment;
        }

        public IPayment _payment { get; set; }

        public void ProcessPayment(Request request)
        {
            _payment.ProcessPayment(request);
        }

        public IOrderingService SetPaymentStrategy(IPayment payment)
        {
            _payment = payment;
            return this;
        }
    }
}
