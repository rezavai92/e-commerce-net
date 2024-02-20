using Application.ProductApp.Commands;
using Application.ProductApp.Queries;
using Application.shared.Models;

namespace Application.ProductApp.Interfaces
{
    public interface IproductService
    {
        Task<ShopHubResponseModel> GetProductsAsync(GetProductsQuery query);
        Task<ShopHubResponseModel> GetProductByIdAsync(string itemId);
        Task<ShopHubResponseModel> CreateProductAsync(CreateProductCommand query);
        Task<ShopHubResponseModel> CreateProductCategoryAsync(CreateProductCategoryCommand query);
        Task<ShopHubResponseModel> CreateProductBrandAsync(CreateProductBrandCommand query);

        #region Category

        Task<ShopHubResponseModel> GetProductCategoryByIdAsync(string itemId);
        #endregion
    }
}
