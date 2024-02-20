using Application.ProductApp.Commands;
using Application.ProductApp.Interfaces;
using Application.ProductApp.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers.ProductController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ICommandDispatcher _commandDispatcher;
        IQueryDispatcher _queryDispatcher;

        IproductService _productService;


        public ProductController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IproductService productService)
        {

            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _productService = productService;
        }


        [HttpGet("GetProducts")]
        public async Task<ShopHubResponseModel> GetProducts([FromBody] GetProductsQuery query)
        {
            return await _queryDispatcher.DispatchAsync<GetProductsQuery>(query);
        }


        [HttpGet("GetProductById")]
        public async Task<ShopHubResponseModel> GetProductById([FromQuery] string id)
        {
            var result = await _productService.GetProductByIdAsync(id);
            return result;
        }

        [HttpGet("GetCategoryById")]
        public async Task<ShopHubResponseModel> GetCategoryById([FromQuery] string id)
        {
            var result = await _productService.GetProductCategoryByIdAsync(id);
            return result;
        }

        [HttpPost]
        public async Task<ShopHubResponseModel> Post([FromBody] CreateProductCommand command)
        {
            var result = await _commandDispatcher.SendLocalAsync<CreateProductCommand>(command);

            return result;
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("CreateProductCategory")]
        public async Task<ShopHubResponseModel> CreateProductCategory([FromBody] CreateProductCategoryCommand command)
        {
            var result = await _commandDispatcher.SendLocalAsync<CreateProductCategoryCommand>(command);

            return result;
        }

        [HttpPost("CreateProductBrand")]
        public async Task<ShopHubResponseModel> CreateProductBrand([FromBody] CreateProductBrandCommand command)
        {
            var result = await _commandDispatcher.SendLocalAsync<CreateProductBrandCommand>(command);

            return result;
        }
    }
}
