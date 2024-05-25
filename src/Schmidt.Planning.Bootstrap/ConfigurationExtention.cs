using Microsoft.Extensions.DependencyInjection;
using Schmidt.Planning.Data;
using Schmidt.Planning.Application;

namespace Schmidt.Planning.Bootstrap
{
    public static class ConfigurationExtention
    {
        public static IServiceCollection AddPlanning(this IServiceCollection service)
        {
            service.AddDatabase();
            service.AddApplication();
            return service;
        }
    }
}
