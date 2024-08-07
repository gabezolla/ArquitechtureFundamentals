namespace ArchitectureStudies.Strategy
{
    public class OrderingStrategyFactory : IOrderingStrategyFactory
    {
        public IPayment GetOrderingStrategy(Request request)
        {
            return request.Strategy switch
            {
                OrderingStrategies.DebitCard => new DebitCardStrategy(),
                OrderingStrategies.CreditCard => new CreditCardStrategy(),
                _ => throw new ArgumentException("Method does not exist"),
            };
        }
    }
}
