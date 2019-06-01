
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
    public partial class RatingMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityRating,Rating> _EntityToDto;
        protected IMappingExpression<Rating,DocEntityRating> _DtoToEntity;

        public RatingMapper()
        {
            CreateMap<DocEntitySet<DocEntityRating>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityRating,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityRating>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityRating.Get(c));
            _EntityToDto = CreateMap<DocEntityRating,Rating>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Rating>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Rating>(c, "Updated")))
                .ForMember(dest => dest.Document, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Rating>(c, nameof(DocEntityRating.Document))))
                .ForMember(dest => dest.DocumentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Rating>(c, nameof(DocEntityRating.DocumentId))))
                .ForMember(dest => dest.Rating, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Rating>(c, nameof(DocEntityRating.Rating))))
                .ForMember(dest => dest.ReasonRejected, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Rating>(c, nameof(DocEntityRating.ReasonRejected))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Rating,DocEntityRating>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
