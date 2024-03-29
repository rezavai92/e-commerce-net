﻿using Domain.Enums;
using Domain.IdentityEntities;

namespace Application.Identity.Dtos
{
    public class LoginResponseDto
    {
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Token { get; set; }
        public List<string> UserRoles { get; set; } = new List<string>();   
    }
}
