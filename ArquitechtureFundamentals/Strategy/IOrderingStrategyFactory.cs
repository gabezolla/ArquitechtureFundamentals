namespace ArchitectureStudies.Strategy
{
    public interface IOrderingStrategyFactory
    {
        public IPayment GetOrderingStrategy(Request request);
    }
}
