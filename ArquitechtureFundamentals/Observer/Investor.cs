namespace ArchitectureStudies.Observer
{
    /// <summary>
    /// Concrete Observer class
    /// </summary>
    public class Investor : IInvestor
    {
        public string Name { get; set; }

        public Investor(string name)
        {
            Name = name;
        }

        public void SendNotification(Stock stock)
        {
            Console.WriteLine($"Firing {stock.Tag} price change to {stock.Price} notification for investor {Name}");
        }
    }
}