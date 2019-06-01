
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
    public partial class TermCategoryMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTermCategory,TermCategory> _EntityToDto;
        protected IMappingExpression<TermCategory,DocEntityTermCategory> _DtoToEntity;

        public TermCategoryMapper()
        {
            CreateMap<DocEntitySet<DocEntityTermCategory>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTermCategory,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTermCategory>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTermCategory.Get(c));
            _EntityToDto = CreateMap<DocEntityTermCategory,TermCategory>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, "Updated")))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.Name))))
                .ForMember(dest => dest.NameId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.NameId))))
                .ForMember(dest => dest.ParentCategory, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.ParentCategory))))
                .ForMember(dest => dest.ParentCategoryId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.ParentCategoryId))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.ScopeId))))
                .ForMember(dest => dest.Terms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.Terms))))
                .ForMember(dest => dest.TermsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.TermsCount))))
                .ForMember(dest => dest.TermsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.TermsIds))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<TermCategory,DocEntityTermCategory>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
