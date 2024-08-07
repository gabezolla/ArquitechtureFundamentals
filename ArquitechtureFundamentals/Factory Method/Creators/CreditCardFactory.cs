using AbstractFactory.Factory_Method.Products;

namespace AbstractFactory.Factory_Method.Creators
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class CreditCardFactory : PaymentFactory
    {
        public override CreditCardProcessor CreatePaymentProcessor(string token)
        {
            return new CreditCardProcessor(token);            
        }
    }
}
