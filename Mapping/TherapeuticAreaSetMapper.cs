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
    public partial class TherapeuticAreaSetMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTherapeuticAreaSet,TherapeuticAreaSet> _EntityToDto;
        protected IMappingExpression<TherapeuticAreaSet,DocEntityTherapeuticAreaSet> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TherapeuticAreaSetMapper()
        {
            CreateMap<DocEntitySet<DocEntityTherapeuticAreaSet>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTherapeuticAreaSet,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTherapeuticAreaSet>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTherapeuticAreaSet.Get(c));
            _EntityToDto = CreateMap<DocEntityTherapeuticAreaSet,TherapeuticAreaSet>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TherapeuticAreaSet>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TherapeuticAreaSet>(c, "Updated")))

                .MaxDepth(2);
            _DtoToEntity = CreateMap<TherapeuticAreaSet,DocEntityTherapeuticAreaSet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
