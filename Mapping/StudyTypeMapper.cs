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
    public partial class StudyTypeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityStudyType,StudyType> _EntityToDto;
        protected IMappingExpression<StudyType,DocEntityStudyType> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyTypeMapper()
        {
            CreateMap<DocEntitySet<DocEntityStudyType>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityStudyType,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityStudyType>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityStudyType.Get(c));
            _EntityToDto = CreateMap<DocEntityStudyType,StudyType>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StudyType>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StudyType>(c, "Updated")))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StudyType>(c, nameof(DocEntityStudyType.Type))))
                .ForMember(dest => dest.Type_Id, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StudyType>(c, nameof(DocEntityStudyType.Type_Id))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<StudyType,DocEntityStudyType>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
