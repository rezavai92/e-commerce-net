using Application.Blog.Interfaces;
using Application.Blog.Models;
using Application.shared.Configurations;
using Application.shared.Interfaces;
using Application.shared.Models;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blog.Services
{
    public class BlogService : IBlogService
    {
       
        private IRestCommunicationService _restClient;

        private IConfiguration _configruation;


        public BlogService(IRestCommunicationService restClient, IConfiguration configruation)
        {
            _restClient = restClient;
            _configruation = configruation;
        }

        private Uri PrepareBlogUri()
        {
            var uriConfig = _configruation.GetSection("ExternalUrls").Get<ExternalUrlConfiguration>();
                
            var getBlogsUrl = $"{uriConfig?.JsonPlaceHolder}/posts";
            var uri = new Uri(getBlogsUrl);
            
            return uri;
        }
        public async Task<ShopHubResponseModel> GetBlogsAsync()
        {
            var response = new ShopHubResponseModel();
            try
            {
               
                var cts = new CancellationTokenSource();
                var blogResponse = await _restClient.GetAsync<List<BlogResponseDto>>(PrepareBlogUri(), cts.Token);

                response.SetSuccess(blogResponse);

            }
            catch(Exception ex)
            {
                response.SetError(HttpStatusCode.InternalServerError,ex.Message);
            }
           

            return response;
        }
    }
}
