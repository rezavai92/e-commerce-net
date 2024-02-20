using Application.Blog.Interfaces;
using Application.Blog.Services;
using Application.ProductApp.Interfaces;
using Application.ProductApp.Services;

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddMediatR((config) => config.RegisterServicesFromAssemblies(assembly));

            services.AddAutoMapper(assembly);

            services.AddValidatorsFromAssembly(assembly);

            //    services.AddSingleton(typeof(CreateUserCommandHandler));

            
            services.AddTransient<IBlogService, BlogService>();
            services.AddTransient<IproductService, ProductService>();




            return services;
        }
    }
}