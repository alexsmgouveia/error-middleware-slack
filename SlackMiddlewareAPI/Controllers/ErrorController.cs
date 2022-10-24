using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SlackMiddlewareAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ErrorController : ControllerBase
    { 
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get()
        {
            _logger.LogInformation("loading...");

            var num = int.Parse("aaaaaa");
            return num;
        }
    }
}
