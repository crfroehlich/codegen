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
    public partial class TermMasterMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTermMaster,TermMaster> _EntityToDto;
        protected IMappingExpression<TermMaster,DocEntityTermMaster> _DtoToEntity;

        public TermMasterMapper()
        {
            CreateMap<DocEntitySet<DocEntityTermMaster>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTermMaster,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTermMaster>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTermMaster.Get(c));
            _EntityToDto = CreateMap<DocEntityTermMaster,TermMaster>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, "Updated")))
                .ForMember(dest => dest.BioPortal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.BioPortal))))
                .ForMember(dest => dest.Categories, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.Categories))))
                .ForMember(dest => dest.CategoriesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.CategoriesCount))))
                .ForMember(dest => dest.CategoriesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.CategoriesIds))))
                .ForMember(dest => dest.CUI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.CUI))))
                .ForMember(dest => dest.Enum, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.Enum))))
                .ForMember(dest => dest.EnumId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.EnumId))))
                .ForMember(dest => dest.MedDRA, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.MedDRA))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.Name))))
                .ForMember(dest => dest.RxNorm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.RxNorm))))
                .ForMember(dest => dest.SNOWMED, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.SNOWMED))))
                .ForMember(dest => dest.Synonyms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.Synonyms))))
                .ForMember(dest => dest.SynonymsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.SynonymsCount))))
                .ForMember(dest => dest.SynonymsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.SynonymsIds))))
                .ForMember(dest => dest.TUI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.TUI))))
                .ForMember(dest => dest.URI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermMaster>(c, nameof(DocEntityTermMaster.URI))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<TermMaster,DocEntityTermMaster>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
