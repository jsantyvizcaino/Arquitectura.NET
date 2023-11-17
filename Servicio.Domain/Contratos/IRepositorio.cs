using Servicio.Domain.Entities.Abstract;

namespace Servicio.Domain.Contratos
{
    public interface IRepositorio<T, TIdentificador> where T : EntidadBase<TIdentificador>
    {
        IUnidadDeTrabajo UnidadDeTrabajo { get; }
    }
}
