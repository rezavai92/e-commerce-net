using Application.shared.Interfaces;
using Application.shared.Models;

namespace Application.shared.services
{
    public class GenericQueryService : IGenericQueryService
    {
        private IShophubRepository _repo;

        public GenericQueryService(IShophubRepository repo)
        {
            _repo = repo;
        }

        public async Task<ShopHubResponseModel> GetItemByIdAsync<TEntity>(TEntity entity, string ItemId) where TEntity : class
        {
            var response = new ShopHubResponseModel();

            entity = await _repo.GetItemAsync<TEntity>();

            return response.SetSuccess(entity);

        }
    }
}
