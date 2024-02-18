using Application.shared.Models;
using Application.shared.Queries;

namespace Application.shared.services
{
    public interface IGenericQueryService
    {
        Task<ShopHubResponseModel> GetItemByIdAsync<TEntity>(TEntity entity,string ItemId) where TEntity : class;
    }
}