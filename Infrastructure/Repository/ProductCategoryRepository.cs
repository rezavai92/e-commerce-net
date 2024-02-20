using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.DatabaseContext;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ShophubContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CreateProductCategoryAsync(ProductCategory category)
        {

            var result = await InsertItemAsync(category);

            return result;
        }

        public async Task<bool> DeleteProductCategoryAsync(ProductCategory category)
        {
            return await DeleteItemAsync(category);
        }

        public async Task<List<ProductCategory>> GetProductCategoriesAsync(Expression<Func<ProductCategory, bool>> filter)
        {
            return (await GetManyItemAsync(filter)).ToList();
        }

        public async Task<ProductCategory> GetProductCategoryByIdAsync(string itemId)
        {
            return await GetItemAsync(x => x.ItemId == itemId);
        }

        public async Task<bool> UpdateProductCategoryAsync(ProductCategory category)
        {
            return await UpdateItemAsync(category);
        }
    }
}
