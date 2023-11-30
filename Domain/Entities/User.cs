using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }   
        public string PhoneNumber { get; set; } 
        public string Password { get; set; }
        public List<string> Roles { get; set; } = new List<string>();

        public Address Address { get; set; }
       
    }
}
