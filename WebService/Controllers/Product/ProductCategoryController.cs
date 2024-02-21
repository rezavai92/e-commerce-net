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
    public class ProductCategoryController : Controller
    {
        IproductService _productService;
        ICommandDispatcher _commandDispatcher;
        IQueryDispatcher _queryDispatcher;

        public ProductCategoryController(IproductService productService, ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _productService = productService;
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet("GetCategoryById")]
        public async Task<ShopHubResponseModel> GetCategoryById([FromQuery] string id)
        {
            var result = await _productService.GetProductCategoryByIdAsync(id);
            return result;
        }


        [HttpGet("GetCategories")]
        public async Task<ShopHubResponseModel> GetCategoryById()
        {
            return await _productService.GetProductCategoriesAsync(new GetAllProductCategoryQuery());
           
        }

        [HttpPost("CreateProductCategory")]
        public async Task<ShopHubResponseModel> CreateProductCategory([FromBody] CreateProductCategoryCommand command)
        {
            var result = await _commandDispatcher.SendLocalAsync<CreateProductCategoryCommand>(command);

            return result;
        }
    }
}
