using CQRS.Controllers.Abstract;
using CQRS.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiService.Controllers
{
    public class User : ControllerBase 
    {
        private readonly ILogger<User> _logger;
        private readonly ApplicationDbContext _context;

        public User(ILogger<User> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Info()
        {
            return await Task.FromResult(Ok("Ok"));
        }

        [HttpPost]
        public async Task<IActionResult> Register()
        {
            return await Task.FromResult(Ok("Ok"));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]postParams data)
        {
            var g = _context.Database.EnsureCreated();
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
