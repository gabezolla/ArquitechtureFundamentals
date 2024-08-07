using AbstractFactory.Singleton;
using ArquitechtureFundamentals.Factories;
using Microsoft.AspNetCore.Mvc;

namespace ArquitechtureFundamentals.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class SingletonStudyController : ControllerBase
    {
        private readonly ILogger<SingletonStudyController> _logger;

        public SingletonStudyController(ILogger<SingletonStudyController> logger)
        {
            _logger = logger;
        }

        [HttpGet("singleton")]
        public List<string> Get()
        {
            var loadBalancer = LoadBalancer.GetInstance();

            var list = new List<string>();

            for (var i = 0; i < 10; i++)
            {
                var nextServer = loadBalancer.NextServer;
                list.Add($"Calling {nextServer.Name} with Id {nextServer.Id}");
            }
            return list;
        }
    }
}
