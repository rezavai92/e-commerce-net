using Application.ProductApp.Interfaces;
using Application.shared.Interfaces;
using Domain.Interfaces;
using Infrastructure.Logging;
using Infrastructure.Mediators;
using Infrastructure.Repository;
using Infrastructure.RestCommunication;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure
{
    public static class DependencyInjection
    {
      
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddHttpClient();
     //       services.AddTransient(typeof(GenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IProductRepository, ProductRepository>() ;
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>() ;
            services.AddTransient<IProductBrandRepository, ProductBrandRepository>() ;
            services.AddTransient<IFeatureRoleMapRepository,FeatureRoleMapRepository>() ;
            services.AddTransient<IFeatureEndpointMapRepository,FeatureEndpointMapRepository>() ;
          
            services.AddTransient<ICommandDispatcher, CommandDispatcher>();
            
            services.AddTransient<IQueryDispatcher, QueryDispatcher>();
            services.AddTransient<IRestCommunicationService, RestCommunicationService>();
            services.AddSingleton(typeof(IPlatformLogger<>), typeof(PlatformLoggerService<>));
            return services;
        }

       
    }

   
}