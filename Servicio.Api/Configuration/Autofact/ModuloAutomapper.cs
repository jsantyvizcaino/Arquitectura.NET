using Autofac;
using AutoMapper;
using Servicio.Application.Mapper;
using System.Reflection;
using Module = Autofac.Module;

namespace Servicio.Api.Configuration.Autofact
{
    public class ModuloAutomapper : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(Assembly.GetExecutingAssembly(),
                    Assembly.GetAssembly(typeof(PerfilMapeo)));
            })).AsSelf().SingleInstance();

           


            builder.Register(t =>
            {
                var context = t.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            }).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
