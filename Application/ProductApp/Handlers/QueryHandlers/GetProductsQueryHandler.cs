using Application.ProductApp.Interfaces;
using Application.ProductApp.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;

namespace Application.ProductApp.Handlers.QueryHandlers
{
    public class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, ShopHubResponseModel>
    {
        private IproductService _productService;

        public GetProductsQueryHandler(IproductService productService)
        {
            _productService = productService;
        }

        public async Task<ShopHubResponseModel> Handle(GetProductsQuery query, CancellationToken cancellationToken)
        {
            return await _productService.GetProductsAsync(query);
        }
    }
}
