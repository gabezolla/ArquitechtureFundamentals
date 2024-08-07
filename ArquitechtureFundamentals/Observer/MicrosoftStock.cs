namespace ArchitectureStudies.Observer

{
    /// <summary>
    /// Concrete subject
    /// </summary>
    public class MicrosoftStock : Stock
    {
        public MicrosoftStock(double price) : base("MSFT", price)
        {
        }
    }
}
