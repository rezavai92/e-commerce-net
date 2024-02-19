using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.shared.services
{
    public class GenericQueryService : IGenericQueryService
    {
        private IShophubRepository _repo;

        public GenericQueryService(IShophubRepository repo)
        {
            _repo = repo;
        }

        public async Task<ShopHubResponseModel> GetItemByIdAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            var response = new ShopHubResponseModel();

            var entity = await _repo.GetItemAsync<TEntity>(filter);

            return response.SetSuccess(entity);

        }
    }
}
