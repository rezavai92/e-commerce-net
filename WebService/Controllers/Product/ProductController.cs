using Application.Blog.Interfaces;
using Application.ProductApp.Commands;
using Application.ProductApp.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using Application.shared.Queries;
using Application.UAM.Commands;
using Application.UAM.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ICommandDispatcher _commandDispatcher;
        IQueryDispatcher _queryDispatcher;


        public ProductController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
        
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

     
        [HttpGet]
        public async Task<ActionResult<ShopHubResponseModel>> GetProducts([FromQuery] GetProductsQuery query)
        {
            return await _queryDispatcher.DispatchAsync<GetProductsQuery>(query);
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopHubResponseModel>> Get([FromRoute] string id)
        {
            var query = new GenericGetByIdQuery { ItemId = id };
            var result = await _queryDispatcher.DispatchAsync<GenericGetByIdQuery>(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ShopHubResponseModel>> Post([FromBody] CreateProductCommand command)
        {
            var result = await _commandDispatcher.SendLocalAsync< CreateProductCommand>(command);

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
