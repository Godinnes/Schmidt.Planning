using Microsoft.Extensions.DependencyInjection;
using Schmidt.Planning.Application.Services;

namespace Schmidt.Planning.Application
{
    public static class ConfigurationExtention
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services
                .AddScoped<IUserService, UserService>();
        }
    }
}
