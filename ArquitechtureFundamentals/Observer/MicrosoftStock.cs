namespace ArchitectureStudies.Observer
{
    /// <summary>
    /// Concrete subject B
    /// </summary>
    public class MicrosoftStock : Stock
    {
        public MicrosoftStock(double price) : base("MSFT", price)
        {
        }
    }
}
