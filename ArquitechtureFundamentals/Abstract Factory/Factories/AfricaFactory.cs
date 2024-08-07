using ArquitechtureFundamentals.Products;

namespace ArquitechtureFundamentals.Factories
{
    /// <summary>
    /// Concrete Factory (type 1)
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() => new Lion();

        public override Herbivore CreateHerbivore() => new Zebra();
        
    }
}
