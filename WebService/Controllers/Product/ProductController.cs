using Application.ProductApp.Commands;
using Application.ProductApp.Interfaces;
using Application.ProductApp.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;
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
        public async Task<ActionResult<ShopHubResponseModel>> GetProducts([FromBody] GetProductsQuery query)
        {
            return await _queryDispatcher.DispatchAsync<GetProductsQuery>(query);
        }


        [HttpGet]
        public async Task<ActionResult<ShopHubResponseModel>> Get([FromQuery] string id)
        {
            var result = _productService.GetProductByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ShopHubResponseModel>> Post([FromBody] CreateProductCommand command)
        {
            var result = await _commandDispatcher.SendLocalAsync<CreateProductCommand>(command);

            return Ok(result);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }
}
