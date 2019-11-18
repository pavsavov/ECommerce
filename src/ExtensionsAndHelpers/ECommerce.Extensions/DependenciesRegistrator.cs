using ECommerce.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        public static IServiceCollection Registrator(this IServiceCollection services)
        {
            services.AddTransient<ECommerceDbContext>();
            return services;
        }

        /// <summary>
        /// Public access to Application's DbContext configuration builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddECommerceDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ECommerceDbContext>(options => options.DbContextConfigurationBuilder(configuration));

            return services;
        }

        /// <summary>
        /// Confiugre DbContext
        /// </summary>
        /// <param name="options">DbContextOptionsBuilder</param>
        /// <param name="configuration">custom configuration for the ContextBuilder</param>
        /// <returns></returns>
        private static DbContextOptionsBuilder DbContextConfigurationBuilder(this DbContextOptionsBuilder options, IConfiguration configuration)
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return options;
        }
    }
}
