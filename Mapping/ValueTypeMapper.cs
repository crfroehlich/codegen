
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
    public partial class ValueTypeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityValueType,ValueType> _EntityToDto;
        protected IMappingExpression<ValueType,DocEntityValueType> _DtoToEntity;

        public ValueTypeMapper()
        {
            CreateMap<DocEntitySet<DocEntityValueType>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityValueType,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityValueType>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityValueType.Get(c));
            _EntityToDto = CreateMap<DocEntityValueType,ValueType>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, "Updated")))
                .ForMember(dest => dest.FieldType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, nameof(DocEntityValueType.FieldType))))
                .ForMember(dest => dest.FieldTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, nameof(DocEntityValueType.FieldTypeId))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, nameof(DocEntityValueType.Name))))
                .ForMember(dest => dest.NameId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, nameof(DocEntityValueType.NameId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<ValueType,DocEntityValueType>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
