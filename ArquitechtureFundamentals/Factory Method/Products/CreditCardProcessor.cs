namespace AbstractFactory.Factory_Method.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CreditCardProcessor : PaymentMethodProcessor
    {
        public CreditCardProcessor(string token) : base(token)
        {
            Token = token;
        }
        public override string ProcessPayment(string paymentMethodId)
        {
            return $"Processing credit card payment with token {this.Token}";
        }
    }
}
