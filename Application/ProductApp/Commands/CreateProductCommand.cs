using Application.shared.Interfaces;
using Application.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductApp.Commands
{
    public class CreateProductCommand : ICommand<ShopHubResponseModel>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public string CategoryId { get; set; }
        public double Price { get; set; }
        public string PrimaryImageUrl { get; set; }
        public IEnumerable<string> SecondaryImageUrls { get; set; } = Enumerable.Empty<string>();
        
    }
}
