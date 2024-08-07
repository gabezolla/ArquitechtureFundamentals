using ArquitechtureFundamentals.Factories;
using ArquitechtureFundamentals.Products;

namespace ArquitechtureFundamentals
{
    /// <summary>
    /// Client class
    /// </summary>
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public string RunFoodChain()
        {
            return _carnivore.Eat(_herbivore);
        }
    }
}
