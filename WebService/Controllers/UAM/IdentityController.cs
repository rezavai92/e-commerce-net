using Application.Identity.Commands;
using Application.shared.Interfaces;
using Application.shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers.UAM
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : Controller
    {

        ICommandDispatcher _commandDispatcher;
        IQueryDispatcher _queryDispatcher;

        public IdentityController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpPost("register")]
        public async Task<ShopHubResponseModel> Register([FromBody] RegisterUserCommand command)
        {
            var response = await _commandDispatcher.SendLocalAsync(command);

            return response;
        }

        [HttpPost("login")]
        public async Task<ShopHubResponseModel> Login([FromBody] LoginUserCommand command)
        {
            var response = await _commandDispatcher.SendLocalAsync(command);

            return response;
        }
    }
}
