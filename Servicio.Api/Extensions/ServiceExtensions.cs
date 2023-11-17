using Microsoft.AspNetCore.Mvc;

namespace Servicio.Api.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// AddApiVersioningExtension
        /// </summary>
        /// <param name="services"></param>
        public static void AddApiVersioningExtension(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }
    }
}
