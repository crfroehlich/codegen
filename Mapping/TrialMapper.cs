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
    public partial class TrialMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTrial,Trial> _EntityToDto;
        protected IMappingExpression<Trial,DocEntityTrial> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TrialMapper()
        {
            CreateMap<DocEntitySet<DocEntityTrial>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTrial,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTrial>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTrial.Get(c));
            _EntityToDto = CreateMap<DocEntityTrial,Trial>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Trial>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Trial>(c, "Updated")))
                .ForMember(dest => dest.Documents, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Trial>(c, nameof(DocEntityTrial.Documents))))
                .ForMember(dest => dest.DocumentsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Trial>(c, nameof(DocEntityTrial.DocumentsCount))))
                .ForMember(dest => dest.DocumentsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Trial>(c, nameof(DocEntityTrial.DocumentsIds))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Trial>(c, nameof(DocEntityTrial.Name))))
                .ForMember(dest => dest.Parent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Trial>(c, nameof(DocEntityTrial.Parent))))
                .ForMember(dest => dest.ParentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Trial>(c, nameof(DocEntityTrial.ParentId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Trial,DocEntityTrial>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
