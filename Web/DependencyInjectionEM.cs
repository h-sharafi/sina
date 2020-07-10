using Microsoft.Extensions.DependencyInjection;
using Application.Service;
using Application;
using Domain;

namespace Election
{
    public static class DependencyInjectionEM
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
