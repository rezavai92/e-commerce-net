using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {

        Task<Product> GetProductByIdAsync(string itemId);
        Task<bool> InsertProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<List<Product>> GetProductsAsync();
        Task<bool> DeleteProductAsync();
        Task<IEnumerable<Product>> GetProductsAsync(SearchableProductsDto query);
        //Task<ProductCategory> GetProductCategoryByIdAsync(string itemId);
    }
}
