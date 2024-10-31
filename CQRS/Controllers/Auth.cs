using CQRS.Controllers.Abstract;
using CQRS.Infrastructure;
using CQRS.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Auth : ControllerBase 
    {
        private readonly ILogger<Auth> _logger;
        private readonly Context _context;

        public Auth(ILogger<Auth> logger, Context context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.FromResult(Ok("Ok"));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]postParams data)
        {
            User newUser = new User() { 
                Id = Guid.NewGuid(),
                FirstName = data.FirstName,
                LastName = data.LastName,
                Email = data.Email,
                HashPassword = data.Password
            };
            var g = _context.Database.EnsureCreated();
            _context.Add(newUser);
            _context.SaveChanges();
            return await Task.FromResult(Ok("Ok"));
        }
    }

    public class postParams
    {
        public required string LastName { get; set; }
        public required string FirstName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
