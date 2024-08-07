namespace ArquitechtureFundamentals.Products
{
    /// <summary>
    /// Concrete Product A (type 2)
    /// </summary>
    public class Bear : Carnivore
    {
        public override string Eat(Herbivore herbivore)
        {
            return $"{this.GetType().Name} eats {herbivore.GetType().Name}";
        }
    }
}
