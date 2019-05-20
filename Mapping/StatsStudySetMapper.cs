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
    public partial class StatsStudySetMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityStatsStudySet,StatsStudySet> _EntityToDto;
        protected IMappingExpression<StatsStudySet,DocEntityStatsStudySet> _DtoToEntity;

        public StatsStudySetMapper()
        {
            CreateMap<DocEntitySet<DocEntityStatsStudySet>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityStatsStudySet,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityStatsStudySet>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityStatsStudySet.Get(c));
            _EntityToDto = CreateMap<DocEntityStatsStudySet,StatsStudySet>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, "Updated")))
                .ForMember(dest => dest.BoundTerms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.BoundTerms))))
                .ForMember(dest => dest.Characteristics, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Characteristics))))
                .ForMember(dest => dest.DataPoints, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DataPoints))))
                .ForMember(dest => dest.DesignCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DesignCount))))
                .ForMember(dest => dest.DesignList, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DesignList))))
                .ForMember(dest => dest.DocumentSet, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DocumentSet))))
                .ForMember(dest => dest.DocumentSetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DocumentSetId))))
                .ForMember(dest => dest.Interventions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Interventions))))
                .ForMember(dest => dest.Outcomes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Outcomes))))
                .ForMember(dest => dest.OutcomesReported, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.OutcomesReported))))
                .ForMember(dest => dest.Records, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Records))))
                .ForMember(dest => dest.RecordsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.RecordsCount))))
                .ForMember(dest => dest.Stat, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Stat))))
                .ForMember(dest => dest.StatId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.StatId))))
                .ForMember(dest => dest.Studies, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Studies))))
                .ForMember(dest => dest.TypeCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.TypeCount))))
                .ForMember(dest => dest.TypeList, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.TypeList))))
                .ForMember(dest => dest.UnboundTerms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.UnboundTerms))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<StatsStudySet,DocEntityStatsStudySet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
