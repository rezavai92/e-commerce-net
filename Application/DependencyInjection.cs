using Application.Blog.Interfaces;
using Application.Blog.Services;
using Application.shared.Interfaces;
using Application.UAM.Handlers.CommandHandlers;
using Application.UAM.Interfaces;
using Application.UAM.Services;
using FluentValidation;
using MediatR;
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

            services.AddTransient<IUamService,UamService>();
            services.AddTransient<IBlogService,BlogService>();
         
            

            return services;
        }
    }
}