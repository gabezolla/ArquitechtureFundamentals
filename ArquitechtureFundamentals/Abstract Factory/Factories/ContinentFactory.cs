using ArquitechtureFundamentals.Products;

namespace ArquitechtureFundamentals.Factories
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    abstract public class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();

        public abstract Carnivore CreateCarnivore();
    }
}
