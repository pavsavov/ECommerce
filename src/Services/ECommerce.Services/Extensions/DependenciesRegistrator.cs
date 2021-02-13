using AutoMapper;
using ECommerce.DataAccess;
using ECommerce.Repositories;
using ECommerce.Repositories.Authors;
using ECommerce.Repositories.Base;
using ECommerce.Repositories.Books;
using ECommerce.Repository.Base;
using ECommerce.Services.Authors;
using ECommerce.Services.AutoMapper;
using ECommerce.Services.Base;
using ECommerce.Services.Books;
using ECommerce.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Services.Extensions
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
            //Db context
            services.AddScoped<ECommerceDbContext>();
            
            //repository dependencies
            services.AddTransient(typeof(IBookRepository), typeof(BookRepository));
            services.AddTransient(typeof(IAuthorRepository), typeof(AuthorRepository));        

            //service dependencies
            //services.AddTransient(typeof(IBaseService), typeof(BaseService));
            services.AddTransient(typeof(IBookService), typeof(BookService));
            services.AddTransient(typeof(IAuthorService), typeof(AuthorService));
            //services.AddTransient(typeof(IMapper), typeof(Auto));

            /*Registration of types which implement IMapFrom <> and IMapTo<> interfaces
  assemblies in order to be mapped automatically by convention.
  This way creating profiles is not needed.*/
            //Example:
            //AutoMapperConfig.RegisterMappings(
            //    typeof(BookViewModel).Assembly || typeof(SomeViewModel).GetTypeInfo().Assembly
            //    typeof(SomeServiceModel).Assembly
            //    );
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
            //TODO: Create a common  constants project where this and other magic strings will be moved to.
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return options;
        }
    }
}
