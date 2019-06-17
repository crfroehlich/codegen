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
    public partial class UnitValueMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUnitValue,UnitValue> _EntityToDto;
        protected IMappingExpression<UnitValue,DocEntityUnitValue> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValueMapper()
        {
            CreateMap<DocEntitySet<DocEntityUnitValue>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUnitValue,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUnitValue>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUnitValue.Get(c));
            _EntityToDto = CreateMap<DocEntityUnitValue,UnitValue>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, "Updated")))
                .ForMember(dest => dest.EqualityOperator, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.EqualityOperator))))
                .ForMember(dest => dest.EqualityOperatorId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.EqualityOperatorId))))
                .ForMember(dest => dest.Multiplier, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Multiplier))))
                .ForMember(dest => dest.Number, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Number))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Order))))
                .ForMember(dest => dest.Owners, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Owners))))
                .ForMember(dest => dest.OwnersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.OwnersCount))))
                .ForMember(dest => dest.OwnersIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.OwnersIds))))
                .ForMember(dest => dest.Unit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Unit))))
                .ForMember(dest => dest.UnitId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.UnitId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<UnitValue,DocEntityUnitValue>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
