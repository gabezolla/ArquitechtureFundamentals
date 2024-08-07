using AbstractFactory.Factory_Method;
using AbstractFactory.Factory_Method.Creators;
using ArquitechtureFundamentals.Factories;
using Microsoft.AspNetCore.Mvc;

namespace ArquitechtureFundamentals.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class FactoryMethodStudyController : ControllerBase
    {
        private readonly ILogger<FactoryMethodStudyController> _logger;

        public FactoryMethodStudyController(ILogger<FactoryMethodStudyController> logger)
        {
            _logger = logger;
        }

        [HttpGet("factoryMethod/{token}")]
        public string Get(string token)
        {
            string paymentMethodId = Guid.NewGuid().ToString();
            // Instância de CreditCardFactory
            var processResult = PaymentFactory.DecidePaymentMethod(PaymentMethodType.CreditCard)
                                                                        .CreatePaymentProcessor(token)
                                                                        .ProcessPayment(paymentMethodId);
            
            return processResult;
        }
    }
}
