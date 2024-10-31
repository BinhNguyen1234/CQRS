using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQRS.Infrastructure.Models
{
    public class User
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Column("last_name")]
        [Required]
        public string? LastName { get; set; }

        [Column("first_name")]
        [Required]
        public string? FirstName { get; set; }

        [Column("email")]
        [Required]
        public string? Email { get; set; }

        [Column("hash_password")]
        [Required]
        public string? HashPassword { get; set; }
    }
}
