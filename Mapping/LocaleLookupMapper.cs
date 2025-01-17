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
    public partial class LocaleLookupMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityLocaleLookup,LocaleLookup> _EntityToDto;
        protected IMappingExpression<LocaleLookup,DocEntityLocaleLookup> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LocaleLookupMapper()
        {
            CreateMap<DocEntitySet<DocEntityLocaleLookup>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLocaleLookup,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLocaleLookup>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLocaleLookup.Get(c));
            _EntityToDto = CreateMap<DocEntityLocaleLookup,LocaleLookup>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, "Updated")))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, nameof(DocEntityLocaleLookup.Data))))
                .ForMember(dest => dest.IpAddress, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, nameof(DocEntityLocaleLookup.IpAddress))))
                .ForMember(dest => dest.Locale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, nameof(DocEntityLocaleLookup.Locale))))
                .ForMember(dest => dest.LocaleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, nameof(DocEntityLocaleLookup.LocaleId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<LocaleLookup,DocEntityLocaleLookup>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
