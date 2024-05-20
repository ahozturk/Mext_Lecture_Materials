using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spovify.Application;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private readonly IProducerService _producerService;

        public ProducersController(IProducerService producerService)
        {
            _producerService = producerService;
        }

        [HttpPost]
        public IActionResult Add(AddProducerDto addProducerDto)
        {
            _producerService.Add(addProducerDto);

            return Ok();
        }
    }
}
