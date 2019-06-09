
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
    public partial class MeanRangesMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityMeanRanges,MeanRanges> _EntityToDto;
        protected IMappingExpression<MeanRanges,DocEntityMeanRanges> _DtoToEntity;

        public MeanRangesMapper()
        {
            CreateMap<DocEntitySet<DocEntityMeanRanges>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityMeanRanges,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityMeanRanges>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityMeanRanges.Get(c));
            _EntityToDto = CreateMap<DocEntityMeanRanges,MeanRanges>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRanges>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRanges>(c, "Updated")))
                .ForMember(dest => dest.Ranges, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRanges>(c, nameof(DocEntityMeanRanges.Ranges))))
                .ForMember(dest => dest.RangesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRanges>(c, nameof(DocEntityMeanRanges.RangesCount))))
                .ForMember(dest => dest.RangesIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRanges>(c, nameof(DocEntityMeanRanges.RangesIds))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<MeanRanges,DocEntityMeanRanges>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
