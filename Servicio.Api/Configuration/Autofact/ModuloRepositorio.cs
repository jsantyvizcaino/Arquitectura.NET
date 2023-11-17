using Ardalis.Specification;
using Autofac;
using Servicio.Domain.Contratos.Entidades;
using Servicio.Domain.Contratos.StoreProcedure;
using Servicio.Infrestructure.Repositorios;
using Servicio.Infrestructure.Repositorios.Entidades;
using Servicio.Infrestructure.Repositorios.StoreProcedure;

namespace Servicio.Api.Configuration.Autofact
{
    public class ModuloRepositorio : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SpecificationEvaluatorPersonalizado>()
            .As<ISpecificationEvaluator>().InstancePerLifetimeScope();


            builder.RegisterType<BusquedaManiobrasRepositorio>().As<IBusquedaManiobrasRepositorio>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PbPlanBianualRepositorio>().As<IPbPlanBianualRepositorio>().
                InstancePerLifetimeScope();


            
            
            
            


        }
    }
}
