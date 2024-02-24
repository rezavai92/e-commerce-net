using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;

namespace Application.ProductApp.Queries
{
    public class GetProductsQuery : IQuery<ShopHubResponseModel>
    {
        public List<string>? CategoryIds { get; set; } = new List<string>();
        public List<string>? BrandIds { get; set; } = new List<string>();
        public double? MinimumPrice { get; set; }
        public double? MaximumPrice { get; set; }
        public string? SearchKey { get; set; } = string.Empty;
        public int? PageNo { get; set; } = 0;
        public int? PageSize { get; set; } = 10;
        public bool? IsAscendingSort { get; set; } = false;
        public string? SortBy { get; set; } = nameof(EntityBase.CreatedOn);
    }
}
