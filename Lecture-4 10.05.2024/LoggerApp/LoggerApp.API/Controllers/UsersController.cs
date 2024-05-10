using LoggerApp.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoggerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly LoggerApp.Domain.Abstractions.ILogger _logger;

        public UsersController(LoggerApp.Domain.Abstractions.ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.Log("All Users Sent");
            return Ok("Users");
        }

        [HttpPost]
        public IActionResult Add()
        {
            _logger.Log("User Added");
            return Ok();
        }
    }
}
