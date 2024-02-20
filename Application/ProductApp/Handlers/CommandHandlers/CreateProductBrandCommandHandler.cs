using Application.ProductApp.Commands;
using Application.ProductApp.Interfaces;
using Application.shared.Interfaces;
using Application.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductApp.Handlers.CommandHandlers
{
    public class CreateProductBrandCommandHandler : ICommandHandler<CreateProductBrandCommand, ShopHubResponseModel>
    {
        private IproductService _productService;

        public CreateProductBrandCommandHandler(IproductService productService)
        {
            _productService = productService;
        }

        public async Task<ShopHubResponseModel> Handle(CreateProductBrandCommand command, CancellationToken cancellationToken)
        {
            var res = await _productService.CreateProductBrandAsync(command);

            return res;
        }
    }
}
