using AbstractFactory.Factory_Method.Products;
using System.Runtime.CompilerServices;

namespace AbstractFactory.Factory_Method.Creators
{
    /// <summary>
    /// Abstract Creator
    /// </summary>
    public abstract class PaymentFactory
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        public abstract PaymentMethodProcessor CreatePaymentProcessor(string token);

        // (isso não faz parte do pattern)
        public static PaymentFactory DecidePaymentMethod(PaymentMethodType paymentMethodType)
        {
            return paymentMethodType switch
            {
                PaymentMethodType.CreditCard => new CreditCardFactory(),
                PaymentMethodType.DebitCard => new DebitCardFactory(),
                PaymentMethodType.Pix => new PixPaymentFactory(),
                _ => throw new NotSupportedException(),
            };
        }

    }
}
