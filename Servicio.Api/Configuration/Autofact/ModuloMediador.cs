using Autofac;
using MediatR;
using Servicio.Infrestructure.Behaivors;
using Module = Autofac.Module;
using System.Reflection;
using Servicio.Application.Features.Desconexiones.Queries;

namespace Servicio.Api.Configuration.Autofact
{
    public class ModuloMediador : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly)
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(PlanesBianualQuery).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IRequestHandler<,>));

            //builder.RegisterAssemblyTypes(typeof(VerificarDiasModificacionEliminacionServicio).GetTypeInfo().Assembly)
            //    .AsClosedTypesOf(typeof(IRequestHandler<,>));

          

            builder.RegisterGeneric(typeof(ValidadorPipelineBahavior<,>))
                .As(typeof(IPipelineBehavior<,>));

            _ = builder.Register<ServiceFactory>(context =>
            {
                var componentContext = context.Resolve<IComponentContext>();
                return type =>
                {
                    object? @object;
                    return componentContext.TryResolve(type, out @object) ? @object : new object();
                };
            });
        }
    }
}
