using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

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
        public required ICollection<Role> Roles { get; set; } 
        //    public  string PrimaryAddressId { get; set; }

        public Customer? Customer { get; set; }
    }
}
