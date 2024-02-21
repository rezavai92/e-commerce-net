using Application.ProductApp.Queries;
using Application.shared.Models;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ShophubContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> DeleteProductAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductByIdAsync(string itemId)
        {
            return await GetItemAsync(x => x.ItemId == itemId);
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return (await GetManyItemAsync(x => true)).ToList();
        }

        public async Task<ShopHubResponseModel> GetProductsAsync(GetProductsQuery query)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertProductAsync(Product product)
        {
            return await InsertItemAsync(product);
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            return await UpdateItemAsync(product);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(SearchableProductsDto query)
        {
            // filter config
            var filteredProducts = _dbContext.Products
            .Include(x => x.Categories)
            .Include(x => x.Brand)
            .Where(x =>
                (query.CategoryIds.Count== 0 ||  query.CategoryIds.Contains(x.ItemId)) &&
                x.Price >= query.MinimumPrice && x.Price < query.MaximumPrice &&
                (query.BrandIds.Count == 0 || query.BrandIds.Contains(x.BrandItemId)) &&
                (string.IsNullOrEmpty(query.SearchKey) ||
                    x.Title.Contains(query.SearchKey) ||
                    (x.Brand != null && x.Brand.Name.Contains(query.SearchKey))
                )
            );

            // Sort config
            if (query.IsAscendingSort)
            {
                filteredProducts = filteredProducts.OrderBy(x => x.CreatedOn);
            }
            else
            {
                filteredProducts = filteredProducts.OrderByDescending(x => x.CreatedOn);
            }



            return await filteredProducts
                .Skip(query.PageNo * query.PageSize)
                .Take(query.PageSize)
                .ToListAsync();
        }
    }
}
