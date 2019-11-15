using ECommerce.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace ExtensionsAndHelpers.ECommerce.Extensions
{
    /// <summary>
    /// This static class holds extensions methods for registering dependencies to the built-in DI container of .NET CORE
    /// </summary>
    public static class DependenciesRegistrator
    {
        /// <summary>
        /// Register Dependencies with their lifespan
        /// </summary>
        /// <param name="services">IServiceCollection abstraction</param>
        /// <returns></returns>
        public static IServiceCollection DependenciesRegistrator(this IServiceCollection services)
        {
            services.AddTransient<ECommerceDbContext>();

            return services;
        }

    }
}
