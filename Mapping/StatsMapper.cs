//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.CodeDom.Compiler;
using System.Collections.Generic;

using AutoMapper;

using Services.Core;
using Services.Dto;
namespace Services.Schema
{
    public partial class StatsMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityStats,Stats> _EntityToDto;
        protected IMappingExpression<Stats,DocEntityStats> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StatsMapper()
        {
            CreateMap<DocEntitySet<DocEntityStats>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityStats,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityStats>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityStats.Get(c));
            _EntityToDto = CreateMap<DocEntityStats,Stats>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.AppId))))
                .ForMember(dest => dest.ExternalId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.ExternalId))))
                .ForMember(dest => dest.ExternalType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.ExternalType))))
                .ForMember(dest => dest.ObjectId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.ObjectId))))
                .ForMember(dest => dest.ObjectType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.ObjectType))))
                .ForMember(dest => dest.StudySetStats, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.StudySetStats))))
                .ForMember(dest => dest.StudySetStatsId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.StudySetStatsId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Stats,DocEntityStats>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
