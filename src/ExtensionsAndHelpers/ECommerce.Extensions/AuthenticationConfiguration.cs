using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Extensions
{
    public static class AuthenticationConfiguration
    {
        /// <summary>
        /// Sets authentication middleware for the application
        /// </summary>
        /// <param name="services">app service collection</param>
        /// <returns></returns>
        public static IServiceCollection AddECommerceAuthentication(this IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //TODO:  move Authentication Scheme to a config file. ????????Consider JWT Auth!!!!!!!!!!!!!!
            services.AddAuthentication("BookShopAuth")
                .AddCookie(options => options.CookieAuthenticationConfiguration());

            return services;
        }

        /// <summary>
        /// Register and creates cookie authentication configuration for current application.
        /// </summary>
        /// <param name="options">Options configuration</param>
        /// <returns></returns>
        private static CookieAuthenticationOptions CookieAuthenticationConfiguration(this CookieAuthenticationOptions options)
        {
            //TODO: Set cookie options
            options.LoginPath = "";

            return options;
        }
    }
}
