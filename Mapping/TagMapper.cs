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
    public partial class TagMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTag,Tag> _EntityToDto;
        protected IMappingExpression<Tag,DocEntityTag> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TagMapper()
        {
            CreateMap<DocEntitySet<DocEntityTag>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTag,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTag>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTag.Get(c));
            _EntityToDto = CreateMap<DocEntityTag,Tag>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, "Updated")))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, nameof(DocEntityTag.Name))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, nameof(DocEntityTag.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, nameof(DocEntityTag.ScopesCount))))
                .ForMember(dest => dest.ScopesIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, nameof(DocEntityTag.ScopesIds))))
                .ForMember(dest => dest.URI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, nameof(DocEntityTag.URI))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Tag,DocEntityTag>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
