using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IFeatureRoleMapRepository
    {
       
        Task<bool> CreateFeatureRoleMapAsync(FeatureRoleMap map);
        Task<List<FeatureRoleMap>> GetFeatureRoleMapsAsync(Expression<Func<FeatureRoleMap, bool>> filter);
        Task<bool> CreateManyFeatureRoleMapAsync(List<FeatureRoleMap> maps);



    }
}
