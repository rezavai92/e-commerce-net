using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Identity.Dtos
{
    public class SignupResponseDto
    {
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Token { get; set; }
        public List<string> UserRoles { get; set; }
    }
}
