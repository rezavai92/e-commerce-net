using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;

namespace Application.ProductApp.Commands
{
    public class CreateProductBrandCommand : ICommand<ShopHubResponseModel>
    {
        public required string Name { get; set; }
        public required string Country { get; set; }
    }
}
