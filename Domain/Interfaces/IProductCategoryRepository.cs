using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task<ProductCategory> GetProductCategoryByIdAsync(string itemId);
        Task<bool> CreateProductCategoryAsync(ProductCategory category);
        Task<List<ProductCategory>> GetProductCategoriesAsync(Expression<Func<ProductCategory,bool>> filter);
        Task<bool> DeleteProductCategoryAsync(ProductCategory category);
        Task<bool> UpdateProductCategoryAsync(ProductCategory category);
    }
}
