namespace ArchitectureStudies.Strategy
{
    public class Request
    {
        public Request(string token, string price, OrderingStrategies strategy)
        {
            Token = token;
            Price = price;
            Strategy = strategy;
        }

        public string Token { get; set; }

        public string Price { get; set; }

        public OrderingStrategies Strategy { get; set; }
    }
}
