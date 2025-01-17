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
    public partial class MeanVarianceValueMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityMeanVarianceValue,MeanVarianceValue> _EntityToDto;
        protected IMappingExpression<MeanVarianceValue,DocEntityMeanVarianceValue> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public MeanVarianceValueMapper()
        {
            CreateMap<DocEntitySet<DocEntityMeanVarianceValue>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityMeanVarianceValue,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityMeanVarianceValue>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityMeanVarianceValue.Get(c));
            _EntityToDto = CreateMap<DocEntityMeanVarianceValue,MeanVarianceValue>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, "Updated")))
                .ForMember(dest => dest.MeanVariance, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.MeanVariance))))
                .ForMember(dest => dest.MeanVarianceRange, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.MeanVarianceRange))))
                .ForMember(dest => dest.MeanVarianceType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.MeanVarianceType))))
                .ForMember(dest => dest.MeanVarianceTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.MeanVarianceTypeId))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.Order))))
                .ForMember(dest => dest.Owners, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.Owners))))
                .ForMember(dest => dest.OwnersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.OwnersCount))))
                .ForMember(dest => dest.OwnersIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.OwnersIds))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<MeanVarianceValue,DocEntityMeanVarianceValue>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
