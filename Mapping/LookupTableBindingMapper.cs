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
    public partial class LookupTableBindingMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityLookupTableBinding,LookupTableBinding> _EntityToDto;
        protected IMappingExpression<LookupTableBinding,DocEntityLookupTableBinding> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupTableBindingMapper()
        {
            CreateMap<DocEntitySet<DocEntityLookupTableBinding>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLookupTableBinding,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLookupTableBinding>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLookupTableBinding.Get(c));
            _EntityToDto = CreateMap<DocEntityLookupTableBinding,LookupTableBinding>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, "Updated")))
                .ForMember(dest => dest.Binding, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Binding))))
                .ForMember(dest => dest.BoundName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.BoundName))))
                .ForMember(dest => dest.LookupTable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.LookupTable))))
                .ForMember(dest => dest.LookupTableId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.LookupTableId))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.ScopeId))))
                .ForMember(dest => dest.Synonyms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Synonyms))))
                .ForMember(dest => dest.SynonymsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.SynonymsCount))))
                .ForMember(dest => dest.SynonymsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.SynonymsIds))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.WorkflowsCount))))
                .ForMember(dest => dest.WorkflowsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.WorkflowsIds))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<LookupTableBinding,DocEntityLookupTableBinding>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
