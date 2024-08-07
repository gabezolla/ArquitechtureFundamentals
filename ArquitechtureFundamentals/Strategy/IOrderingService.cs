namespace ArchitectureStudies.Strategy
{
    public interface IOrderingService
    {
        public void ProcessPayment(Request request);

        public IOrderingService SetPaymentStrategy(IPayment payment);
    }
}
