namespace AbstractFactory.Factory_Method.Products
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class PixPaymentMethodProcessor(string token) : PaymentMethodProcessor(token)
    {
        public override string ProcessPayment(string paymentMethodId)
        {
            return $"Processing pix payment with token {this.Token}";
        }
    }
}
