using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Servicio.Infrestructure.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Infrestructure.Extensions
{
    public static class ExtensionServicios
    {        
     
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
