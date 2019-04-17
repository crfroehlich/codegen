//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Dto.Security;
using Services.Enums;
using Services.Models;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.DOCUMENT)]
    public partial class DocEntityDocument : DocEntityBase
    {
        private const string DOCUMENT_CACHE = "DocumentCache";
        public const string TABLE_NAME = DocConstantModelName.DOCUMENT;
        
        #region Constructor
        public DocEntityDocument(Session session) : base(session) {}

        public DocEntityDocument() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Document());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityDocument GetDocument(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetDocument(reference.Id) : null;
        }

        public static DocEntityDocument GetDocument(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDocument>.GetFromCache(primaryKey, DOCUMENT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDocument>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDocument>.UpdateCache(ret.Id, ret, DOCUMENT_CACHE);
                    DocEntityThreadCache<DocEntityDocument>.UpdateCache(ret.Hash, ret, DOCUMENT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDocument GetDocument(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDocument>.GetFromCache(hash, DOCUMENT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDocument>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDocument>.UpdateCache(ret.Id, ret, DOCUMENT_CACHE);
                    DocEntityThreadCache<DocEntityDocument>.UpdateCache(ret.Hash, ret, DOCUMENT_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Length = int.MaxValue, LazyLoad = true)]
        [FieldMapping(nameof(Abstract))]
        public string Abstract { get; set; }


        [Field()]
        [FieldMapping(nameof(AccessionID))]
        public string AccessionID { get; set; }


        [Field()]
        [FieldMapping(nameof(Acronym))]
        public string Acronym { get; set; }


        [Field()]
        [FieldMapping(nameof(Authors))]
        public string Authors { get; set; }


        [Field()]
        [FieldMapping(nameof(CochraneID))]
        public string CochraneID { get; set; }


        [Field()]
        [FieldMapping(nameof(CorporateAuthor))]
        public string CorporateAuthor { get; set; }


        [Field()]
        [FieldMapping(nameof(Country))]
        public string Country { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(CustomData))]
        public string CustomData { get; set; }


        [Field()]
        [FieldMapping(nameof(DatabaseType))]
        public DocEntityLookupTable DatabaseType { get; set; }
        public int? DatabaseTypeId { get { return DatabaseType?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DocumentSets))]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DocumentType))]
        public DocEntityLookupTable DocumentType { get; set; }
        public int? DocumentTypeId { get { return DocumentType?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DOI))]
        public string DOI { get; set; }


        [Field()]
        [FieldMapping(nameof(EmbaseAccessionNumber))]
        public string EmbaseAccessionNumber { get; set; }


        [Field()]
        [FieldMapping(nameof(Emtree))]
        public string Emtree { get; set; }


        [Field()]
        [FieldMapping(nameof(ErrataText))]
        public string ErrataText { get; set; }


        [Field()]
        [FieldMapping(nameof(FullText))]
        public string FullText { get; set; }


        [Field()]
        [FieldMapping(nameof(FullTextURL))]
        public string FullTextURL { get; set; }


        [Field()]
        [FieldMapping(nameof(Import))]
        public DocEntityImportData Import { get; set; }
        public int? ImportId { get { return Import?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(ImportType))]
        public DocEntityLookupTable ImportType { get; set; }
        public int? ImportTypeId { get { return ImportType?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Institution))]
        public string Institution { get; set; }


        [Field()]
        [FieldMapping(nameof(ISSN))]
        public string ISSN { get; set; }


        [Field()]
        [FieldMapping(nameof(Issue))]
        public string Issue { get; set; }


        [Field()]
        [FieldMapping(nameof(JournalTitle))]
        public string JournalTitle { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(LegacyModel))]
        public string LegacyModel { get; set; }


        [Field()]
        [FieldMapping(nameof(LegacySync))]
        public DateTime? LegacySync { get; set; }


        [Field()]
        [FieldMapping(nameof(LookupTables))]
        public DocEntitySet<DocEntityLookupTable> LookupTables { get; private set; }


        public int? LookupTablesCount { get { return LookupTables.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(MedlineID))]
        public int? MedlineID { get; set; }


        [Field()]
        [FieldMapping(nameof(MeSH))]
        public string MeSH { get; set; }


        [Field()]
        [FieldMapping(nameof(NonDigitizedDocumentSets))]
        public DocEntitySet<DocEntityDocumentSet> NonDigitizedDocumentSets { get; private set; }


        public int? NonDigitizedDocumentSetsCount { get { return NonDigitizedDocumentSets.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Pages))]
        public string Pages { get; set; }


        [Field()]
        [FieldMapping(nameof(ParentChildStatus))]
        public char? ParentChildStatus { get; set; }


        [Field()]
        [FieldMapping(nameof(ParentID))]
        public int? ParentID { get; set; }


        [Field()]
        [FieldMapping(nameof(PublicationDate))]
        public string PublicationDate { get; set; }


        [Field()]
        [FieldMapping(nameof(PublicationYear))]
        public int? PublicationYear { get; set; }


        [Field()]
        [FieldMapping(nameof(PubType))]
        public string PubType { get; set; }


        [Field()]
        [FieldMapping(nameof(ReferenceStudy))]
        public int ReferenceStudy { get; set; }


        [Field()]
        [FieldMapping(nameof(SecondarySourceID))]
        public string SecondarySourceID { get; set; }


        [Field()]
        [FieldMapping(nameof(Source))]
        public string Source { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(StorageModel))]
        public string StorageModel { get; set; }


        [Field(DefaultValue = "{}", Length = int.MaxValue)]
        [FieldMapping(nameof(SupplementalFiles))]
        public string SupplementalFiles { get; set; }


        [Field()]
        [FieldMapping(nameof(TaStudyDesign))]
        public string TaStudyDesign { get; set; }


        [Field()]
        [FieldMapping(nameof(Title))]
        public string Title { get; set; }


        [Field()]
        [FieldMapping(nameof(TrialOutcome))]
        public short? TrialOutcome { get; set; }


        [Field()]
        [FieldMapping(nameof(VariableData))]
        [Association(PairTo = nameof(DocEntityVariableInstance.Document), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityVariableInstance> VariableData { get; private set; }


        public int? VariableDataCount { get { return VariableData.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Volume))]
        public string Volume { get; set; }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindDocuments";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {

            base.OnRemoving();
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"Document requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            AccessionID = AccessionID?.TrimAndPruneSpaces();
            Acronym = Acronym?.TrimAndPruneSpaces();
            Authors = Authors?.TrimAndPruneSpaces();
            CochraneID = CochraneID?.TrimAndPruneSpaces();
            CorporateAuthor = CorporateAuthor?.TrimAndPruneSpaces();
            Country = Country?.TrimAndPruneSpaces();
            DOI = DOI?.TrimAndPruneSpaces();
            EmbaseAccessionNumber = EmbaseAccessionNumber?.TrimAndPruneSpaces();
            Emtree = Emtree?.TrimAndPruneSpaces();
            ErrataText = ErrataText?.TrimAndPruneSpaces();
            FullText = FullText?.TrimAndPruneSpaces();
            FullTextURL = FullTextURL?.TrimAndPruneSpaces();
            Institution = Institution?.TrimAndPruneSpaces();
            ISSN = ISSN?.TrimAndPruneSpaces();
            Issue = Issue?.TrimAndPruneSpaces();
            JournalTitle = JournalTitle?.TrimAndPruneSpaces();
            MeSH = MeSH?.TrimAndPruneSpaces();
            Pages = Pages?.TrimAndPruneSpaces();
            PublicationDate = PublicationDate?.TrimAndPruneSpaces();
            PubType = PubType?.TrimAndPruneSpaces();
            SecondarySourceID = SecondarySourceID?.TrimAndPruneSpaces();
            Source = Source?.TrimAndPruneSpaces();
            TaStudyDesign = TaStudyDesign?.TrimAndPruneSpaces();
            Title = Title?.TrimAndPruneSpaces();
            Volume = Volume?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();
            DocCacheClient.RemoveById(Id);
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(null != DatabaseType && DatabaseType?.Enum?.Name != "DatabaseType")
                {
                    isValid = false;
                    message += " DatabaseType is a " + DatabaseType?.Enum?.Name + ", but must be a DatabaseType.";
                }
                if(null != DocumentType && DocumentType?.Enum?.Name != "DocumentType")
                {
                    isValid = false;
                    message += " DocumentType is a " + DocumentType?.Enum?.Name + ", but must be a DocumentType.";
                }
                if(null != ImportType && ImportType?.Enum?.Name != "StudyImportType")
                {
                    isValid = false;
                    message += " ImportType is a " + ImportType?.Enum?.Name + ", but must be a StudyImportType.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Document ToDto() => Mapper.Map<DocEntityDocument, Document>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityDocument, bool>> DocumentIgnoreArchived() => d => d.Archived == false;
    }

    public partial class DocumentMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDocument,Document> _EntityToDto;
        protected IMappingExpression<Document,DocEntityDocument> _DtoToEntity;

        public DocumentMapper()
        {
            CreateMap<DocEntitySet<DocEntityDocument>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDocument,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDocument>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDocument.GetDocument(c));
            _EntityToDto = CreateMap<DocEntityDocument,Document>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, "Updated")))
                .ForMember(dest => dest.Abstract, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Abstract))))
                .ForMember(dest => dest.AccessionID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.AccessionID))))
                .ForMember(dest => dest.Acronym, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Acronym))))
                .ForMember(dest => dest.Authors, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Authors))))
                .ForMember(dest => dest.CochraneID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.CochraneID))))
                .ForMember(dest => dest.CorporateAuthor, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.CorporateAuthor))))
                .ForMember(dest => dest.Country, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Country))))
                .ForMember(dest => dest.CustomData, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.CustomData))))
                .ForMember(dest => dest.DatabaseType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DatabaseType))))
                .ForMember(dest => dest.DatabaseTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DatabaseTypeId))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DocumentSetsCount))))
                .ForMember(dest => dest.DocumentType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DocumentType))))
                .ForMember(dest => dest.DocumentTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DocumentTypeId))))
                .ForMember(dest => dest.DOI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.DOI))))
                .ForMember(dest => dest.EmbaseAccessionNumber, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.EmbaseAccessionNumber))))
                .ForMember(dest => dest.Emtree, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Emtree))))
                .ForMember(dest => dest.ErrataText, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ErrataText))))
                .ForMember(dest => dest.FullText, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.FullText))))
                .ForMember(dest => dest.FullTextURL, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.FullTextURL))))
                .ForMember(dest => dest.Import, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Import))))
                .ForMember(dest => dest.ImportId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ImportId))))
                .ForMember(dest => dest.ImportType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ImportType))))
                .ForMember(dest => dest.ImportTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ImportTypeId))))
                .ForMember(dest => dest.Institution, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Institution))))
                .ForMember(dest => dest.ISSN, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ISSN))))
                .ForMember(dest => dest.Issue, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Issue))))
                .ForMember(dest => dest.JournalTitle, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.JournalTitle))))
                .ForMember(dest => dest.LegacyModel, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.LegacyModel))))
                .ForMember(dest => dest.LegacySync, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.LegacySync))))
                .ForMember(dest => dest.LookupTables, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.LookupTables))))
                .ForMember(dest => dest.LookupTablesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.LookupTablesCount))))
                .ForMember(dest => dest.MedlineID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.MedlineID))))
                .ForMember(dest => dest.MeSH, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.MeSH))))
                .ForMember(dest => dest.NonDigitizedDocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.NonDigitizedDocumentSets))))
                .ForMember(dest => dest.NonDigitizedDocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.NonDigitizedDocumentSetsCount))))
                .ForMember(dest => dest.Pages, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Pages))))
                .ForMember(dest => dest.ParentChildStatus, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ParentChildStatus))))
                .ForMember(dest => dest.ParentID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ParentID))))
                .ForMember(dest => dest.PublicationDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.PublicationDate))))
                .ForMember(dest => dest.PublicationYear, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.PublicationYear))))
                .ForMember(dest => dest.PubType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.PubType))))
                .ForMember(dest => dest.ReferenceStudy, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.ReferenceStudy))))
                .ForMember(dest => dest.SecondarySourceID, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.SecondarySourceID))))
                .ForMember(dest => dest.Source, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Source))))
                .ForMember(dest => dest.StorageModel, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.StorageModel))))
                .ForMember(dest => dest.SupplementalFiles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.SupplementalFiles))))
                .ForMember(dest => dest.TaStudyDesign, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.TaStudyDesign))))
                .ForMember(dest => dest.Title, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Title))))
                .ForMember(dest => dest.TrialOutcome, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.TrialOutcome))))
                .ForMember(dest => dest.VariableData, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.VariableData))))
                .ForMember(dest => dest.VariableDataCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.VariableDataCount))))
                .ForMember(dest => dest.Volume, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Document>(c, nameof(DocEntityDocument.Volume))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Document,DocEntityDocument>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
