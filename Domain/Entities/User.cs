using Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Entities
{
   
    public class User : EntityBase
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        [AllowNull]
        public DateOnly DateOfBirth { get; set; }
        public required string Email { get; set; }
        [AllowNull]
        public string? PhoneNumber { get; set; }
        
        public required string Password { get; set; }
        public List<string> Roles { get; set; } = new List<string>();

        [NotMapped]

        [AllowNull]
        public Address? Address { get; set; }
    }
}
