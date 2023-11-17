namespace Servicio.Domain.Entities.Abstract
{
    public abstract class EntidadBase<TIdentificador>
    {
        public virtual TIdentificador Id { get; set; }

        public EntidadBase(TIdentificador id)
        {
            Id = id;
        }
    }
}
