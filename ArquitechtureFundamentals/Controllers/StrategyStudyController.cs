using ArchitectureStudies.Strategy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Net;
using System.Runtime.CompilerServices;

namespace ArchitectureStudies.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class StrategyStudyController : ControllerBase
    {
        private readonly IOrderingService _orderingService;

        private readonly IOrderingStrategyFactory _orderingStrategyFactory;

        public StrategyStudyController(IOrderingService orderingService, IOrderingStrategyFactory orderingStrategyFactory)
        {
            _orderingService = orderingService;
            _orderingStrategyFactory = orderingStrategyFactory;
        }

        [HttpGet("strategy")]
        public IActionResult Get()
        {
            // Could put everything on Facade
            var request = new Request(Guid.NewGuid().ToString(), "30", OrderingStrategies.CreditCard);

            // First, using factory
            var strategy = _orderingStrategyFactory.GetOrderingStrategy(request);
            strategy.ProcessPayment(request);

            // Using service
            _orderingService.SetPaymentStrategy(strategy)
                            .ProcessPayment(request);

            return Ok();
        }
    }
}
