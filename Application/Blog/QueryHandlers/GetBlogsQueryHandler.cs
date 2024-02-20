using Application.Blog.Interfaces;
using Application.Blog.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blog.QueryHandlers
{
    internal class GetBlogsQueryHandler : IQueryHandler<GetBlogsQuery,ShopHubResponseModel>
    {
        private IBlogService _blogService;

        public GetBlogsQueryHandler(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<ShopHubResponseModel> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
 

            return await  _blogService.GetBlogsAsync();
           
        }
    }
}
