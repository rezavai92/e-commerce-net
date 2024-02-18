using Application.ProductApp.Commands;
using Application.ProductApp.Queries;
using Application.shared.Models;

namespace Application.ProductApp.Interfaces
{
    public interface IproductService
    {
        Task<ShopHubResponseModel> GetProductsAsync(GetProductsQuery query);
        Task<ShopHubResponseModel> CreateProductAsync(CreateProductCommand query);
    }
}
