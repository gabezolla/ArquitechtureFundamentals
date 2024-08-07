namespace ArchitectureStudies.Strategy
{
    public class CreditCardStrategy : IPayment
    {
        public void ProcessPayment(Request request)
        {
            // Do something for credit card strat
            Console.WriteLine($"Processing {this.GetType().Name} payment");
        }
    }
}
