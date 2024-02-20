using Application.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blog.Interfaces
{
    public interface IBlogService
    {
        Task<ShopHubResponseModel> GetBlogsAsync();
    }
}
