using Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Entities
{
   
    public class User : EntityBase
    {
        [MaxLength(50)]    
        public required string FirstName { get; set; }
        [MaxLength(50)]
        public required string LastName { get; set; }
        [AllowNull]
        public DateOnly DateOfBirth { get; set; }
        [MaxLength(100)]
        public required string Email { get; set; }
        [AllowNull]
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }
        [MinLength(8)]
        public required string Password { get; set; }
        public List<string> Roles { get; set; } = new List<string>();

        [NotMapped]

        [AllowNull]
        public Address? Address { get; set; }
    }
}
