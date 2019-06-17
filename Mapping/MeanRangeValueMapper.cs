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
    public partial class MeanRangeValueMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityMeanRangeValue,MeanRangeValue> _EntityToDto;
        protected IMappingExpression<MeanRangeValue,DocEntityMeanRangeValue> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public MeanRangeValueMapper()
        {
            CreateMap<DocEntitySet<DocEntityMeanRangeValue>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityMeanRangeValue,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityMeanRangeValue>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityMeanRangeValue.Get(c));
            _EntityToDto = CreateMap<DocEntityMeanRangeValue,MeanRangeValue>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, "Updated")))
                .ForMember(dest => dest.MeanVarianceType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.MeanVarianceType))))
                .ForMember(dest => dest.MeanVarianceTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.MeanVarianceTypeId))))
                .ForMember(dest => dest.MidSpread, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.MidSpread))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Order))))
                .ForMember(dest => dest.Owners, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Owners))))
                .ForMember(dest => dest.OwnersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.OwnersCount))))
                .ForMember(dest => dest.OwnersIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.OwnersIds))))
                .ForMember(dest => dest.Percent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Percent))))
                .ForMember(dest => dest.PercentLow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.PercentLow))))
                .ForMember(dest => dest.Range, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Range))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Type))))
                .ForMember(dest => dest.Type_Id, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Type_Id))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<MeanRangeValue,DocEntityMeanRangeValue>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
