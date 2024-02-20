using Application.shared.Interfaces;
using Application.shared.Models;

namespace Application.ProductApp.Commands
{
    public class CreateProductCategoryCommand : ICommand<ShopHubResponseModel>
    {
        public required string Title { get; set; }
        public string? Alias { get; set; }
    }
}
