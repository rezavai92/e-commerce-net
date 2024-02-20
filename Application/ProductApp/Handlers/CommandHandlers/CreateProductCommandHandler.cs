using Application.ProductApp.Commands;
using Application.ProductApp.Interfaces;
using Application.shared.Interfaces;
using Application.shared.Models;

namespace Application.ProductApp.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, ShopHubResponseModel>
    {
        private IproductService _productService;

        public CreateProductCommandHandler(IproductService productService)
        {
            _productService = productService;
        }

        public async Task<ShopHubResponseModel> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            return await _productService.CreateProductAsync(command);
        }
    }
}
