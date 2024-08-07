using ArquitechtureFundamentals.Products;

namespace ArquitechtureFundamentals.Factories
{
    /// <summary>
    /// Concrete Factory (type 2)
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() => new Bear();

        public override Herbivore CreateHerbivore() => new Rabbit();
    }
}
