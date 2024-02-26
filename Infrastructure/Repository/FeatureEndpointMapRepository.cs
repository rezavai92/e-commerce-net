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
    internal class FeatureEndpointMapRepository : GenericRepository<FeatureEndpointMap>, IFeatureEndpointMapRepository
    {
        public FeatureEndpointMapRepository(ShophubContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CreateFeatureEndpointMapAsync(FeatureEndpointMap map)
        {
            return await InsertItemAsync(map);
        }

        public async Task<List<FeatureEndpointMap>> GetFeatureEndpointMapsAsync(Expression<Func<FeatureEndpointMap, bool>> filter)
        {
            return (await GetManyItemAsync(filter)).ToList();
        }
    }
}
