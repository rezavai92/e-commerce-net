using Application.ProductApp.Commands;
using Application.ProductApp.Interfaces;
using Application.ProductApp.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductBrandController : Controller
    {
        IproductService _productService;
        ICommandDispatcher _commandDispatcher;
        IQueryDispatcher _queryDispatcher;

        public ProductBrandController(IproductService productService, ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _productService = productService;
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpPost("CreateProductBrand")]
        public async Task<ShopHubResponseModel> CreateProductBrand([FromBody] CreateProductBrandCommand command)
        {
            var result = await _commandDispatcher.SendLocalAsync<CreateProductBrandCommand>(command);

            return result;
        }

        [HttpGet("GetBrandById")]
        public async Task<ShopHubResponseModel> GetCategoryById([FromQuery] string id)
        {
            var result = await _productService.GetProductBrandByIdAsync(id);
            return result;
        }


        [HttpGet("GetBrands")]
        public async Task<ShopHubResponseModel> GetCategoryById()
        {
            return await _productService.GetProductBrandsAsync(new GetAllProductBrandQuery());

        }
    }
}
