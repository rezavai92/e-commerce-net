using Domain.IdentityEntities;

namespace Core.Shared.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwtToken(ApplicationUser user);
    }
}
