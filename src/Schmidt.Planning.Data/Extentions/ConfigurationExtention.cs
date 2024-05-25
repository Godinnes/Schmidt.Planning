using Microsoft.Extensions.DependencyInjection;
using Schmidt.Planning.Data.Services;

namespace Schmidt.Planning.Data
{
    public static class ConfigurationExtention
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            return services
                .AddScoped<IUserRepository, UserRepository>();
        }
    }
}
