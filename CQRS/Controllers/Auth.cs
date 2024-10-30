using CQRS.Controllers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Auth : ControllerBase 
    {
        private readonly ILogger<Auth> _logger;

        public Auth(ILogger<Auth> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.FromResult(Ok("Ok"));
        }
    }
}
