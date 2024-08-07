namespace ArquitechtureFundamentals.Products
{
    /// <summary>
    /// Concrete Product A (type 1)
    /// </summary>
    public class Lion : Carnivore
    {
        public override string Eat(Herbivore herbivore)
        {
            return $"{this.GetType().Name} eats {herbivore.GetType().Name}";                                              
        }
    }
}
