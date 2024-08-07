namespace ArchitectureStudies.Observer
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Stock
    {
        private string _tag;

        private double _price;

        private readonly List<IInvestor> _investors = [];

        public Stock(string tag, double price)
        {
            _tag = tag;
            _price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
            Console.WriteLine($"{investor.Name} has subscribed to {Tag} watch");
        }

        public void Unattach(IInvestor investor)
        {
            _investors.Remove(investor);
            Console.WriteLine($"{investor.Name} has unsubscribed to {Tag} watch");
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.SendNotification(this);
            }
        }

        public double Price
        {
            get => _price;

            set {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Tag
        {
            get => _tag;
        }
    }
}
