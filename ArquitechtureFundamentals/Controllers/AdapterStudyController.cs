using ArchitectureStudies.Adapter;
using ArquitechtureFundamentals.Factories;
using Microsoft.AspNetCore.Mvc;

namespace ArquitechtureFundamentals.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class AdapterStudyController : ControllerBase
    {
        private readonly ILogger<AdapterStudyController> _logger;
        private readonly IClientService _clientService;

        public AdapterStudyController(ILogger<AdapterStudyController> logger, IClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet("adapter")]
        public IEnumerable<string> Get()
        {
            return _clientService.Execute();
        }
    }
}
