using Application.ProductApp.Interfaces;
using Application.ProductApp.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using System.Net;

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
            var res = new ShopHubResponseModel();
            try
            {
                return await _productService.GetProductsAsync(query);
            }
            catch(Exception ex)
            {
                return res.SetError(HttpStatusCode.InternalServerError,ex.Message);
            }
          
        }
    }
}
