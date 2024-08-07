using ArchitectureStudies.Observer;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureStudies.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class ObserverStudyController : ControllerBase
    {
        [HttpGet("observer")]
        public IActionResult Get()
        {
            var random = new Random();
            var microsoftStock = new MicrosoftStock(100);
            var amazonStock = new AmazonStock(200);

            var john = new Investor("John");
            var kleber = new Investor("Kleber");
            var mark = new Investor("Mark");

            microsoftStock.Attach(john);
            microsoftStock.Attach(kleber);
            amazonStock.Attach(mark);

            microsoftStock.Price = random.Next(100, 200);
            microsoftStock.Unattach(john);
            microsoftStock.Price = random.Next(100, 200);
            amazonStock.Price = random.Next(200, 300);

            return Ok();
        }
    }
}
