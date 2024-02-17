using Application.Blog.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers
{
    public class BlogController : Controller
    {
       private IQueryDispatcher _queryDispatcher;

        public BlogController( IQueryDispatcher queryDispatcher)
        {
           
            _queryDispatcher = queryDispatcher;
        }
        [HttpGet("getposts")]
        public async Task<ShopHubResponseModel> GetBlogs()
        {
            var query = new GetBlogsQuery();
            var response = await _queryDispatcher.DispatchAsync<GetBlogsQuery,ShopHubResponseModel>(query);

            return response;
        }
    }
}
