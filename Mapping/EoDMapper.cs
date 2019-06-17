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
    public partial class EoDMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityEoD,EoD> _EntityToDto;
        protected IMappingExpression<EoD,DocEntityEoD> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoDMapper()
        {
            CreateMap<DocEntitySet<DocEntityEoD>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityEoD,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityEoD>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityEoD.Get(c));
            _EntityToDto = CreateMap<DocEntityEoD,EoD>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<EoD>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<EoD>(c, "Updated")))
                .ForMember(dest => dest.Document, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<EoD>(c, nameof(DocEntityEoD.Document))))
                .ForMember(dest => dest.DocumentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<EoD>(c, nameof(DocEntityEoD.DocumentId))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<EoD>(c, nameof(DocEntityEoD.Status))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<EoD,DocEntityEoD>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
