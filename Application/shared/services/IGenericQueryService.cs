using Application.shared.Models;
using System.Linq.Expressions;

namespace Application.shared.services
{
    public interface IGenericQueryService
    {
        Task<ShopHubResponseModel> GetItemByIdAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class;
    }
}