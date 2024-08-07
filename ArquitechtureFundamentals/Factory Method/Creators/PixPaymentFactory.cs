using AbstractFactory.Factory_Method.Products;

namespace AbstractFactory.Factory_Method.Creators
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class PixPaymentFactory : PaymentFactory
    {
        public override PaymentMethodProcessor CreatePaymentProcessor(string token)
        {
            return new PixPaymentMethodProcessor(token);
        }
    }
}
