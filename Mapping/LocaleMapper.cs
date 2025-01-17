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
    public partial class LocaleMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityLocale,Locale> _EntityToDto;
        protected IMappingExpression<Locale,DocEntityLocale> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LocaleMapper()
        {
            CreateMap<DocEntitySet<DocEntityLocale>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLocale,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLocale>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLocale.Get(c));
            _EntityToDto = CreateMap<DocEntityLocale,Locale>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Locale>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Locale>(c, "Updated")))
                .ForMember(dest => dest.Country, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Locale>(c, nameof(DocEntityLocale.Country))))
                .ForMember(dest => dest.Language, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Locale>(c, nameof(DocEntityLocale.Language))))
                .ForMember(dest => dest.TimeZone, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Locale>(c, nameof(DocEntityLocale.TimeZone))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Locale,DocEntityLocale>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
