using LoggerApp.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoggerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly LoggerApp.Domain.Abstractions.ITextLogger _textLogger;
        private readonly LoggerApp.Domain.Abstractions.ILogger _consoleLogger;

        public UsersController(LoggerApp.Domain.Abstractions.ITextLogger logger, Domain.Abstractions.ILogger consoleLogger)
        {
            _textLogger = logger;
            _consoleLogger = consoleLogger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _textLogger.AddSpaceLine();
            _textLogger.Log("All Users Sent");
            return Ok("Users");
        }

        [HttpPost]
        public IActionResult Add()
        {
            _textLogger.Log("User Added");
            return Ok();
        }
    }
}
