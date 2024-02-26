using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IFeatureEndpointMapRepository
    {



        Task<bool> CreateFeatureEndpointMapAsync(FeatureEndpointMap map);
        Task<List<FeatureEndpointMap>> GetFeatureEndpointMapsAsync(Expression<Func<FeatureEndpointMap, bool>> filter);

    }
}
