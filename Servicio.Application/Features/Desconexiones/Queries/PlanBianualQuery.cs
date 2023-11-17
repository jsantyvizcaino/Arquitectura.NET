using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Servicio.Application.DTOs.Planbianual;

namespace Servicio.Application.Features.Desconexiones.Queries
{
    public class PlanBianualQuery : IRequest<PlanBianualDto>
    {
        public int Id { get; set; }

        public PlanBianualQuery(int id)
        {
            Id = id;
        }

    }
}
