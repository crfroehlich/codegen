
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;

using AutoMapper;

using Services.Core;
using Services.Dto;
namespace Services.Schema
{
    public partial class DefaultMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDefault,Default> _EntityToDto;
        protected IMappingExpression<Default,DocEntityDefault> _DtoToEntity;

        public DefaultMapper()
        {
            CreateMap<DocEntitySet<DocEntityDefault>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDefault,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDefault>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDefault.Get(c));
            _EntityToDto = CreateMap<DocEntityDefault,Default>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, "Updated")))
                .ForMember(dest => dest.DiseaseState, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.DiseaseState))))
                .ForMember(dest => dest.DiseaseStateId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.DiseaseStateId))))
                .ForMember(dest => dest.Role, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.Role))))
                .ForMember(dest => dest.RoleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.RoleId))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.ScopeId))))
                .ForMember(dest => dest.TherapeuticArea, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.TherapeuticArea))))
                .ForMember(dest => dest.TherapeuticAreaId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.TherapeuticAreaId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Default,DocEntityDefault>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
