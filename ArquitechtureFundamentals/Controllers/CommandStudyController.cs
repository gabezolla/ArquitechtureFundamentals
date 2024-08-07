using ArchitectureStudies.Command;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureStudies.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class CommandStudyController : ControllerBase
    {
        private readonly IInvoker _invoker;
        private readonly IReceiver _receiver;

        public CommandStudyController(IInvoker invoker, IReceiver receiver)
        {
            _invoker = invoker;
            _receiver = receiver;
        }

        [HttpGet("command")]
        public List<string> Get()
        {
            var returns = new List<string>();
            
            _invoker.SetOnStart(new SimpleCommand("Simple command payload"));
            _invoker.SetOnFinish(new ComplexCommand(_receiver, "Complex command part A", "Complex command part B"));

            return _invoker.DoSomethingImportant();
        }
    }
}
