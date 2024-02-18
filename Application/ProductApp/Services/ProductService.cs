using Application.ProductApp.Commands;
using Application.ProductApp.Interfaces;
using Application.ProductApp.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;

namespace Application.ProductApp.Services
{
    public class ProductService : IproductService
    {
        private IPlatformLogger<ProductService> _logger;
        private IShophubRepository _repo;

        public ProductService(IPlatformLogger<ProductService> logger, IShophubRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public async Task<ShopHubResponseModel> CreateProductAsync(CreateProductCommand query)
        {
            var response = new ShopHubResponseModel();
            try
            {
                var product = new Product();
                await _repo.InsertItemAsync(product);
                response.SetSuccess(product);
            }
            catch
            {
                response.SetError();
            }

            return response;
        }

        public async Task<ShopHubResponseModel> GetProductsAsync(GetProductsQuery query)
        {
            var response = new ShopHubResponseModel();
            var products = await _repo.GetManyItemAsync<Product>();
            
            return response.SetSuccess(products);
           
        }
    }
}
