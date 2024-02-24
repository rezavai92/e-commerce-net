using Core.Shared.Interfaces;
using Domain.IdentityEntities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Shared.Services
{
    public class JwtService : IJwtService
    {
        private IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateJwtToken(ApplicationUser user)
        {
            var min = _configuration["Jwt:Expiration_Minutes"];

            var duraiton = DateTime.UtcNow.AddMinutes( Convert.ToDouble(min));

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Id),
                new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                new Claim(JwtRegisteredClaimNames.Exp,duraiton.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Name, user.FirstName+" "+user.LastName),
                new Claim(ClaimTypes.NameIdentifier, user.Email),
           };

            var securityKey = new SymmetricSecurityKey(UTF8Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signCreds = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var tokenGenerator = new JwtSecurityToken(issuer: _configuration["Jwt:Issuer"], audience: _configuration["Jwt:Audience"],
                claims: claims, expires: duraiton, signingCredentials: signCreds);

            return new JwtSecurityTokenHandler().WriteToken(tokenGenerator);
            
        }
    }
}
