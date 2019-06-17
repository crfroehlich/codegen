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
    public partial class AttributeIntervalMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityAttributeInterval,AttributeInterval> _EntityToDto;
        protected IMappingExpression<AttributeInterval,DocEntityAttributeInterval> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AttributeIntervalMapper()
        {
            CreateMap<DocEntitySet<DocEntityAttributeInterval>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityAttributeInterval,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityAttributeInterval>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityAttributeInterval.Get(c));
            _EntityToDto = CreateMap<DocEntityAttributeInterval,AttributeInterval>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AttributeInterval>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AttributeInterval>(c, "Updated")))
                .ForMember(dest => dest.Interval, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AttributeInterval>(c, nameof(DocEntityAttributeInterval.Interval))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<AttributeInterval,DocEntityAttributeInterval>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
