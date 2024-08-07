namespace AbstractFactory.Factory_Method.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class DebitCardProcessor : PaymentMethodProcessor
    {
        public DebitCardProcessor(string token) : base(token)
        {
        }

        public override string ProcessPayment(string paymentMethodId)
        {
            return $"Processing debit card payment with token {this.Token}";
        }
    }
}
