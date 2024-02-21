using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<string>
    {
        [MaxLength(50)]
        public required string FirstName { get; set; }
        [MaxLength(50)]
        public required string LastName { get; set; }
        [AllowNull]
        public DateOnly DateOfBirth { get; set; }

        public Customer? Customer { get; set; }
        public string? CustomerId { get; set; }


    }
}
