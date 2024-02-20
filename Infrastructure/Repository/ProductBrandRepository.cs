using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.DatabaseContext;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class ProductBrandRepository : GenericRepository<Brand>, IProductBrandRepository
    {
        public ProductBrandRepository(ShophubContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CreateProductBrandAsync(Brand brand)
        {

            var result = await InsertItemAsync(brand);

            return result;
        }

        public async Task<bool> DeleteProductBrandAsync(Brand brand)
        {
            return await DeleteItemAsync(brand);
        }

        public async Task<List<Brand>> GetProductBrandsAsync(Expression<Func<Brand, bool>> filter)
        {
            return (await GetManyItemAsync(filter)).ToList();
        }

        public async Task<Brand> GetProductBrandByIdAsync(string itemId)
        {
            return await GetItemAsync(x => x.ItemId == itemId);
        }

        public async Task<bool> UpdateProductBrandAsync(Brand brand)
        {
            return await UpdateItemAsync(brand);
        }
    }
}
