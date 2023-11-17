using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.OData.Extensions;

namespace Servicio.Infrestructure.FiltrosAccion
{
    public class RespuestaOdataActionFilter: ActionFilterAttribute
    {
        /// <summary>
        /// OnActionExecuting
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        /// <summary>
        /// OnActionExecuted
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add("RegistrosTotales",
                context.HttpContext.Request.ODataFeature()?.TotalCount?.ToString());
            base.OnActionExecuted(context);
        }
    }
}
