using AutoMapper;
using Servicio.Application.DTOs.Planbianual;
using Servicio.Domain.Entities;

namespace Servicio.Application.Mapper
{
    public class PerfilMapeo : Profile
    {
        public PerfilMapeo()
        {
            #region Plan Bianual
            CreateMap<PbPlanBianual, PlanBianualDto>()
                .ForMember(obj => obj.Id, ent => ent.MapFrom(t => t.Id))
                .ForMember(obj => obj.Codigo, ent => ent.MapFrom(t => t.Codigo))
                .ForMember(obj => obj.IdEmpresa, ent => ent.MapFrom(t => t.IdEmpresa))
                .ForMember(obj => obj.IdUnidadNegocio, ent => ent.MapFrom(t => t.IdUnidadNegocio))
                .ForMember(obj => obj.IdUsuarioCreacion, ent => ent.MapFrom(t => t.IdUsuarioCreacion))
                .ForMember(obj => obj.FechaCreacion, ent => ent.MapFrom(t => t.PbFechaCreacion))
                .ForMember(obj => obj.Modificado, ent => ent.MapFrom(t => t.PbModificado))
                .ForMember(obj => obj.PlanesRevisados, ent => ent.MapFrom(t => t.PbPlanesRevisados))
                .ForMember(obj => obj.FechaEnvio, ent => ent.MapFrom(t => t.PbFechaEnvio))
                .ForMember(obj => obj.FechaModificacion, ent => ent.MapFrom(t => t.PbFechaModificacion))
                .ForMember(obj => obj.FechaRevision, ent => ent.MapFrom(t => t.PbFechaRevision))
                .ForMember(obj => obj.UsuarioAprobacion, ent => ent.MapFrom(t => t.PbUsuarioAprobacion));



            CreateMap<PlanBianualDto, PbPlanBianual>()
                .ForMember(obj => obj.Id, ent => ent.MapFrom(t => t.Id))
                .ForMember(obj => obj.Codigo, ent => ent.MapFrom(t => t.Codigo))
                .ForMember(obj => obj.IdEmpresa, ent => ent.MapFrom(t => t.IdEmpresa))
                .ForMember(obj => obj.IdUnidadNegocio, ent => ent.MapFrom(t => t.IdUnidadNegocio))
                .ForMember(obj => obj.IdUsuarioCreacion, ent => ent.MapFrom(t => t.IdUsuarioCreacion))
                .ForMember(obj => obj.PbFechaCreacion, ent => ent.MapFrom(t => t.FechaCreacion))
                .ForMember(obj => obj.PbModificado, ent => ent.MapFrom(t => t.Modificado))
                .ForMember(obj => obj.PbPlanesRevisados, ent => ent.MapFrom(t => t.PlanesRevisados))
                .ForMember(obj => obj.PbFechaEnvio, ent => ent.MapFrom(t => t.FechaEnvio))
                .ForMember(obj => obj.PbFechaModificacion, ent => ent.MapFrom(t => t.FechaModificacion))
                .ForMember(obj => obj.PbFechaRevision, ent => ent.MapFrom(t => t.FechaRevision))
                .ForMember(obj => obj.PbUsuarioAprobacion, ent => ent.MapFrom(t => t.UsuarioAprobacion));
            #endregion
        }
    }
}
