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
    public partial class DocumentMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDocument,Document> _EntityToDto;
        protected IMappingExpression<Document,DocEntityDocument> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentMapper()
        {
            CreateMap<DocEntitySet<DocEntityDocument>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDocument,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDocument>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDocument.Get(c));
            _EntityToDto = CreateMap<DocEntityDocument,Document>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, "Updated")))
                .ForMember(dest => dest.Abstract, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Abstract))))
                .ForMember(dest => dest.AccessionID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.AccessionID))))
                .ForMember(dest => dest.Acronym, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Acronym))))
                .ForMember(dest => dest.ArticleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ArticleId))))
                .ForMember(dest => dest.Authors, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Authors))))
                .ForMember(dest => dest.CochraneID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.CochraneID))))
                .ForMember(dest => dest.CorporateAuthor, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.CorporateAuthor))))
                .ForMember(dest => dest.Country, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Country))))
                .ForMember(dest => dest.CustomData, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.CustomData))))
                .ForMember(dest => dest.DatabaseType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DatabaseType))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DocumentSetsCount))))
                .ForMember(dest => dest.DocumentSetsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DocumentSetsIds))))
                .ForMember(dest => dest.DocumentType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DocumentType))))
                .ForMember(dest => dest.DOI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DOI))))
                .ForMember(dest => dest.EmbaseAccessionNumber, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.EmbaseAccessionNumber))))
                .ForMember(dest => dest.Emtree, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Emtree))))
                .ForMember(dest => dest.ErrataText, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ErrataText))))
                .ForMember(dest => dest.FullText, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.FullText))))
                .ForMember(dest => dest.FullTextURL, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.FullTextURL))))
                .ForMember(dest => dest.Import, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Import))))
                .ForMember(dest => dest.ImportId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ImportId))))
                .ForMember(dest => dest.ImportType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ImportType))))
                .ForMember(dest => dest.Institution, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Institution))))
                .ForMember(dest => dest.ISSN, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ISSN))))
                .ForMember(dest => dest.Issue, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Issue))))
                .ForMember(dest => dest.JournalTitle, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.JournalTitle))))
                .ForMember(dest => dest.LegacySync, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.LegacySync))))
                .ForMember(dest => dest.LookupTables, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.LookupTables))))
                .ForMember(dest => dest.LookupTablesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.LookupTablesCount))))
                .ForMember(dest => dest.LookupTablesIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.LookupTablesIds))))
                .ForMember(dest => dest.MedlineID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.MedlineID))))
                .ForMember(dest => dest.MeSH, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.MeSH))))
                .ForMember(dest => dest.Metadata, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Metadata))))
                .ForMember(dest => dest.Pages, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Pages))))
                .ForMember(dest => dest.ParentChildStatus, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ParentChildStatus))))
                .ForMember(dest => dest.ParentID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ParentID))))
                .ForMember(dest => dest.PublicationDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.PublicationDate))))
                .ForMember(dest => dest.PublicationYear, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.PublicationYear))))
                .ForMember(dest => dest.PubType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.PubType))))
                .ForMember(dest => dest.Reconciliation, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Reconciliation))))
                .ForMember(dest => dest.ReconciliationId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ReconciliationId))))
                .ForMember(dest => dest.ReferenceStudy, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ReferenceStudy))))
                .ForMember(dest => dest.SecondarySourceID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.SecondarySourceID))))
                .ForMember(dest => dest.Source, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Source))))
                .ForMember(dest => dest.StorageModel, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.StorageModel))))
                .ForMember(dest => dest.SupplementalFiles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.SupplementalFiles))))
                .ForMember(dest => dest.TaStudyDesign, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.TaStudyDesign))))
                .ForMember(dest => dest.Title, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Title))))
                .ForMember(dest => dest.Trial, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Trial))))
                .ForMember(dest => dest.TrialCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.TrialCount))))
                .ForMember(dest => dest.TrialIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.TrialIds))))
                .ForMember(dest => dest.TrialOutcome, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.TrialOutcome))))
                .ForMember(dest => dest.VariableData, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.VariableData))))
                .ForMember(dest => dest.VariableDataCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.VariableDataCount))))
                .ForMember(dest => dest.VariableDataIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.VariableDataIds))))
                .ForMember(dest => dest.Volume, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Volume))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Document,DocEntityDocument>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
