using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductBrandRepository
    {
        Task<Brand> GetProductBrandByIdAsync(string itemId);
        Task<bool> CreateProductBrandAsync(Brand brand);
        Task<List<Brand>> GetProductBrandsAsync(Expression<Func<Brand, bool>> filter);
        Task<bool> DeleteProductBrandAsync(Brand category);
        Task<bool> UpdateProductBrandAsync(Brand category);
    }
}
