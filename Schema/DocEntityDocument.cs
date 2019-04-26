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

        protected override List<string> _visibleFields => __vf ?? (__vf = DocWebSession.GetTypeVisibleFields(new Document()));

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
        public string Abstract { get; set; }


        [Field]
        public string AccessionID { get; set; }


        [Field]
        public string Acronym { get; set; }


        [Field]
        public string Authors { get; set; }


        [Field]
        public string CochraneID { get; set; }


        [Field]
        public string CorporateAuthor { get; set; }


        [Field]
        public string Country { get; set; }


        [Field(Length = int.MaxValue)]
        public string CustomData { get; set; }


        [Field]
        public DocEntityLookupTable DatabaseType { get; set; }
        public int? DatabaseTypeId { get { return DatabaseType?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityLookupTable DocumentType { get; set; }
        public int? DocumentTypeId { get { return DocumentType?.Id; } private set { var noid = value; } }


        [Field]
        public string DOI { get; set; }


        [Field]
        public string EmbaseAccessionNumber { get; set; }


        [Field]
        public string Emtree { get; set; }


        [Field]
        public string ErrataText { get; set; }


        [Field]
        public string FullText { get; set; }


        [Field]
        public string FullTextURL { get; set; }


        [Field]
        public DocEntityImportData Import { get; set; }
        public int? ImportId { get { return Import?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityLookupTable ImportType { get; set; }
        public int? ImportTypeId { get { return ImportType?.Id; } private set { var noid = value; } }


        [Field]
        public string Institution { get; set; }


        [Field]
        public string ISSN { get; set; }


        [Field]
        public string Issue { get; set; }


        [Field]
        public string JournalTitle { get; set; }


        [Field(Length = int.MaxValue)]
        public string LegacyModel { get; set; }


        [Field]
        public DateTime? LegacySync { get; set; }


        [Field]
        public DocEntitySet<DocEntityLookupTable> LookupTables { get; private set; }


        public int? LookupTablesCount { get { return LookupTables.Count(); } private set { var noid = value; } }


        [Field]
        public int? MedlineID { get; set; }


        [Field]
        public string MeSH { get; set; }


        [Field]
        public string Pages { get; set; }


        [Field]
        public char? ParentChildStatus { get; set; }


        [Field]
        public int? ParentID { get; set; }


        [Field]
        public string PublicationDate { get; set; }


        [Field]
        public int? PublicationYear { get; set; }


        [Field]
        public string PubType { get; set; }


        [Field]
        public int ReferenceStudy { get; set; }


        [Field]
        public string SecondarySourceID { get; set; }


        [Field]
        public string Source { get; set; }


        [Field(Length = int.MaxValue)]
        public byte[] StorageModelCompressed { get; set; }

        private string _StorageModel;
        public string StorageModel
        {
            get => _StorageModel ?? (_StorageModel = DocZip.Unzip(StorageModelCompressed));
            set
            {
                _StorageModel = value;
                StorageModelCompressed = DocZip.Zip(_StorageModel);
            }
        }


        [Field(DefaultValue = "{}", Length = int.MaxValue)]
        public string SupplementalFiles { get; set; }


        [Field]
        public string TaStudyDesign { get; set; }


        [Field]
        public string Title { get; set; }


        [Field]
        public short? TrialOutcome { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityVariableInstance.Document), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityVariableInstance> VariableData { get; private set; }


        public int? VariableDataCount { get { return VariableData.Count(); } private set { var noid = value; } }


        [Field]
        public string Volume { get; set; }


        [Field]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
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
}
