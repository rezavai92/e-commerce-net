using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class FeatureRoleMapRepository : GenericRepository<FeatureRoleMap>, IFeatureRoleMapRepository
    {
        public FeatureRoleMapRepository(ShophubContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CreateFeatureRoleMapAsync(FeatureRoleMap map)
        {
            
           return await InsertItemAsync(map);
        }

        public async Task<bool> CreateManyFeatureRoleMapAsync(List<FeatureRoleMap> maps)
        {

            return await InsertManyItemAsync(maps);
        }

        public async Task<List<FeatureRoleMap>> GetFeatureRoleMapsAsync(Expression<Func<FeatureRoleMap, bool>> filter)
        {
           return (await GetManyItemAsync(filter)).ToList();
        }
    }
}
