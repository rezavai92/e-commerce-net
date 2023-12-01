using Application.shared.Models;
using Application.UAM.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        ISender _sender;

        public UserManagementController(ISender sender)
        {
            _sender = sender;
        }

        // GET: api/<UserManagement>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserManagement>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserManagement>
        [HttpPost]
        public async Task<ActionResult<ShopHubResponseModel>> Post([FromBody] CreateUserCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        // PUT api/<UserManagement>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserManagement>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
