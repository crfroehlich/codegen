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
    public partial class GlossaryMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityGlossary,Glossary> _EntityToDto;
        protected IMappingExpression<Glossary,DocEntityGlossary> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public GlossaryMapper()
        {
            CreateMap<DocEntitySet<DocEntityGlossary>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityGlossary,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityGlossary>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityGlossary.Get(c));
            _EntityToDto = CreateMap<DocEntityGlossary,Glossary>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, "Updated")))
                .ForMember(dest => dest.Definition, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Definition))))
                .ForMember(dest => dest.Enum, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Enum))))
                .ForMember(dest => dest.EnumId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.EnumId))))
                .ForMember(dest => dest.Icon, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Icon))))
                .ForMember(dest => dest.Page, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Page))))
                .ForMember(dest => dest.PageId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.PageId))))
                .ForMember(dest => dest.Term, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Term))))
                .ForMember(dest => dest.TermId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.TermId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Glossary,DocEntityGlossary>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
