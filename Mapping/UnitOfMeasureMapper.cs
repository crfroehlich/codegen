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
    public partial class UnitOfMeasureMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUnitOfMeasure,UnitOfMeasure> _EntityToDto;
        protected IMappingExpression<UnitOfMeasure,DocEntityUnitOfMeasure> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitOfMeasureMapper()
        {
            CreateMap<DocEntitySet<DocEntityUnitOfMeasure>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUnitOfMeasure,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUnitOfMeasure>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUnitOfMeasure.Get(c));
            _EntityToDto = CreateMap<DocEntityUnitOfMeasure,UnitOfMeasure>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, "Updated")))
                .ForMember(dest => dest.IsSI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, nameof(DocEntityUnitOfMeasure.IsSI))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, nameof(DocEntityUnitOfMeasure.Name))))
                .ForMember(dest => dest.NameId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, nameof(DocEntityUnitOfMeasure.NameId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, nameof(DocEntityUnitOfMeasure.Type))))
                .ForMember(dest => dest.Type_Id, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, nameof(DocEntityUnitOfMeasure.Type_Id))))
                .ForMember(dest => dest.Unit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, nameof(DocEntityUnitOfMeasure.Unit))))
                .ForMember(dest => dest.UnitId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitOfMeasure>(c, nameof(DocEntityUnitOfMeasure.UnitId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<UnitOfMeasure,DocEntityUnitOfMeasure>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
