using MediatR;
using Microsoft.AspNetCore.OData.Query;
using Servicio.Application.DTOs.Planbianual;

namespace Servicio.Application.Features.Desconexiones.Queries
{
    public class PlanesBianualQuery : IRequest<IReadOnlyCollection<PlanBianualDto>>
    {
        #region

        public ODataQueryOptions<PlanBianualDto> Filtros { get; set; }

        public PlanesBianualQuery(ODataQueryOptions<PlanBianualDto> filtros)
        {
            Filtros = filtros;
        }


        #endregion

    }
}
