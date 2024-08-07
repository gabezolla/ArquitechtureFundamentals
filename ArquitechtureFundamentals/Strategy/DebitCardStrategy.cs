namespace ArchitectureStudies.Strategy
{
    public class DebitCardStrategy : IPayment
    {
        public void ProcessPayment(Request request)
        {
            // Do something for debit card strat
            Console.WriteLine($"Processing {this.GetType().Name} payment");
        }
    }
}
