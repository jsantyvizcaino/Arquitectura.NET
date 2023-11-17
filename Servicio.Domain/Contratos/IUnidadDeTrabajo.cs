using System;
using System.Threading;
using System.Threading.Tasks;

namespace Servicio.Domain.Contratos
{
    public interface IUnidadDeTrabajo : IDisposable
    {
        Task<int> AlmacenarEntidades(CancellationToken tokenDeCancelacion = default);
    }
}
