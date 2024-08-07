namespace AbstractFactory.Factory_Method.Products
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public abstract class PaymentMethodProcessor
    {
        protected string Token { get; set; }
        
        protected PaymentMethodProcessor(string token)
        {
            Token = token;
        }

        public abstract string ProcessPayment(string paymentMethodId);

    }
}
