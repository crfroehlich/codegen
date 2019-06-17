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
    public partial class LookupCategoryMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityLookupCategory,LookupCategory> _EntityToDto;
        protected IMappingExpression<LookupCategory,DocEntityLookupCategory> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategoryMapper()
        {
            CreateMap<DocEntitySet<DocEntityLookupCategory>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLookupCategory,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLookupCategory>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLookupCategory.Get(c));
            _EntityToDto = CreateMap<DocEntityLookupCategory,LookupCategory>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, "Updated")))
                .ForMember(dest => dest.Category, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.Category))))
                .ForMember(dest => dest.Enum, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.Enum))))
                .ForMember(dest => dest.EnumId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.EnumId))))
                .ForMember(dest => dest.Lookups, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.Lookups))))
                .ForMember(dest => dest.LookupsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.LookupsCount))))
                .ForMember(dest => dest.LookupsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.LookupsIds))))
                .ForMember(dest => dest.ParentCategory, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.ParentCategory))))
                .ForMember(dest => dest.ParentCategoryId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.ParentCategoryId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<LookupCategory,DocEntityLookupCategory>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
