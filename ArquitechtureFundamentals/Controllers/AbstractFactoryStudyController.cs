using ArquitechtureFundamentals.Factories;
using Microsoft.AspNetCore.Mvc;

namespace ArquitechtureFundamentals.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class AbstractFactoryStudyController : ControllerBase
    {
        private readonly ILogger<AbstractFactoryStudyController> _logger;

        public AbstractFactoryStudyController(ILogger<AbstractFactoryStudyController> logger)
        {
            _logger = logger;
        }

        [HttpGet("abstractFactory")]
        public IEnumerable<string> Get()
        {
            var americaWorld = new AnimalWorld(new AmericaFactory());
            var africaWorld = new AnimalWorld(new AfricaFactory());

            return new List<string>
            {
                americaWorld.RunFoodChain(),
                africaWorld.RunFoodChain(),
            };

        }
    }
}
