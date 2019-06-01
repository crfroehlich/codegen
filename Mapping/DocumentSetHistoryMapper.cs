
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
    public partial class DocumentSetHistoryMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDocumentSetHistory,DocumentSetHistory> _EntityToDto;
        protected IMappingExpression<DocumentSetHistory,DocEntityDocumentSetHistory> _DtoToEntity;

        public DocumentSetHistoryMapper()
        {
            CreateMap<DocEntitySet<DocEntityDocumentSetHistory>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDocumentSetHistory,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDocumentSetHistory>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDocumentSetHistory.Get(c));
            _EntityToDto = CreateMap<DocEntityDocumentSetHistory,DocumentSetHistory>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSetHistory>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSetHistory>(c, "Updated")))
                .ForMember(dest => dest.DocumentSet, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSetHistory>(c, nameof(DocEntityDocumentSetHistory.DocumentSet))))
                .ForMember(dest => dest.DocumentSetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSetHistory>(c, nameof(DocEntityDocumentSetHistory.DocumentSetId))))
                .ForMember(dest => dest.EvidencePortalID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSetHistory>(c, nameof(DocEntityDocumentSetHistory.EvidencePortalID))))
                .ForMember(dest => dest.FqId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSetHistory>(c, nameof(DocEntityDocumentSetHistory.FqId))))
                .ForMember(dest => dest.StudyCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSetHistory>(c, nameof(DocEntityDocumentSetHistory.StudyCount))))
                .ForMember(dest => dest.StudyCountFQ, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSetHistory>(c, nameof(DocEntityDocumentSetHistory.StudyCountFQ))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<DocumentSetHistory,DocEntityDocumentSetHistory>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
