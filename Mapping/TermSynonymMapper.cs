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
    public partial class TermSynonymMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTermSynonym,TermSynonym> _EntityToDto;
        protected IMappingExpression<TermSynonym,DocEntityTermSynonym> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermSynonymMapper()
        {
            CreateMap<DocEntitySet<DocEntityTermSynonym>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTermSynonym,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTermSynonym>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTermSynonym.Get(c));
            _EntityToDto = CreateMap<DocEntityTermSynonym,TermSynonym>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, "Updated")))
                .ForMember(dest => dest.Approved, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Approved))))
                .ForMember(dest => dest.Bindings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Bindings))))
                .ForMember(dest => dest.BindingsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.BindingsCount))))
                .ForMember(dest => dest.BindingsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.BindingsIds))))
                .ForMember(dest => dest.Master, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Master))))
                .ForMember(dest => dest.MasterId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.MasterId))))
                .ForMember(dest => dest.Preferred, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Preferred))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.ScopeId))))
                .ForMember(dest => dest.Synonym, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Synonym))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<TermSynonym,DocEntityTermSynonym>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
