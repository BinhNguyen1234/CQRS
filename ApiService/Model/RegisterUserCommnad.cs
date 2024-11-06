using MediatR;

namespace ApiService.Model
{
    public class RegisterUserCommnad : IRequest<string>
    {
        public required string Email { get; set; }

        public required string LastName { get; set; }

        public required string FirstName { get; set; }

        public required string HashPassword { get; set; }
    }
}
