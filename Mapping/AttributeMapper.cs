
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
    public partial class AttributeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityAttribute,Attribute> _EntityToDto;
        protected IMappingExpression<Attribute,DocEntityAttribute> _DtoToEntity;

        public AttributeMapper()
        {
            CreateMap<DocEntitySet<DocEntityAttribute>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityAttribute,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityAttribute>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityAttribute.Get(c));
            _EntityToDto = CreateMap<DocEntityAttribute,Attribute>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, "Updated")))
                .ForMember(dest => dest.AttributeName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeName))))
                .ForMember(dest => dest.AttributeNameId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeNameId))))
                .ForMember(dest => dest.AttributeType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeType))))
                .ForMember(dest => dest.AttributeTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeTypeId))))
                .ForMember(dest => dest.Interval, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.Interval))))
                .ForMember(dest => dest.IntervalId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IntervalId))))
                .ForMember(dest => dest.IsCharacteristic, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsCharacteristic))))
                .ForMember(dest => dest.IsOutcome, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsOutcome))))
                .ForMember(dest => dest.IsPositive, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsPositive))))
                .ForMember(dest => dest.UniqueKey, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.UniqueKey))))
                .ForMember(dest => dest.ValueType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.ValueType))))
                .ForMember(dest => dest.ValueTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.ValueTypeId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Attribute,DocEntityAttribute>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
