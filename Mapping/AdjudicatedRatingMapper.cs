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
    public partial class AdjudicatedRatingMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityAdjudicatedRating,AdjudicatedRating> _EntityToDto;
        protected IMappingExpression<AdjudicatedRating,DocEntityAdjudicatedRating> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AdjudicatedRatingMapper()
        {
            CreateMap<DocEntitySet<DocEntityAdjudicatedRating>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityAdjudicatedRating,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityAdjudicatedRating>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityAdjudicatedRating.Get(c));
            _EntityToDto = CreateMap<DocEntityAdjudicatedRating,AdjudicatedRating>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AdjudicatedRating>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AdjudicatedRating>(c, "Updated")))
                .ForMember(dest => dest.Document, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AdjudicatedRating>(c, nameof(DocEntityAdjudicatedRating.Document))))
                .ForMember(dest => dest.DocumentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AdjudicatedRating>(c, nameof(DocEntityAdjudicatedRating.DocumentId))))
                .ForMember(dest => dest.Rating, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AdjudicatedRating>(c, nameof(DocEntityAdjudicatedRating.Rating))))
                .ForMember(dest => dest.ReasonRejected, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AdjudicatedRating>(c, nameof(DocEntityAdjudicatedRating.ReasonRejected))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<AdjudicatedRating,DocEntityAdjudicatedRating>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
