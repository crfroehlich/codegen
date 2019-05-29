
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

namespace Services.Dto
{
    public abstract partial class DocumentBase : Dto<Document>
    {
        public DocumentBase() {}

        public DocumentBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DocumentBase(int? id) : this(DocConvert.ToInt(id)) {}

        public DocumentBase(int? pId, string pAbstract, string pAccessionID, string pAcronym, string pAuthors, string pCochraneID, string pCorporateAuthor, string pCountry, string pCustomData, Reference pDatabaseType, int? pDatabaseTypeId, List<Reference> pDocumentSets, int? pDocumentSetsCount, Reference pDocumentType, int? pDocumentTypeId, string pDOI, string pEmbaseAccessionNumber, string pEmtree, string pErrataText, string pFullText, string pFullTextURL, Reference pImport, int? pImportId, Reference pImportType, int? pImportTypeId, string pInstitution, string pISSN, string pIssue, string pJournalTitle, string pLegacyModel, DateTime? pLegacySync, List<Reference> pLookupTables, int? pLookupTablesCount, int? pMedlineID, string pMeSH, List<Reference> pNonDigitizedDocumentSets, int? pNonDigitizedDocumentSetsCount, string pPages, char? pParentChildStatus, int? pParentID, string pPublicationDate, int? pPublicationYear, string pPubType, int? pReferenceStudy, string pSecondarySourceID, string pSource, string pStorageModel, string pSupplementalFiles, string pTaStudyDesign, string pTitle, short? pTrialOutcome, List<Reference> pVariableData, int? pVariableDataCount, string pVolume) : this(DocConvert.ToInt(pId)) 
        {
            Abstract = pAbstract;
            AccessionID = pAccessionID;
            Acronym = pAcronym;
            Authors = pAuthors;
            CochraneID = pCochraneID;
            CorporateAuthor = pCorporateAuthor;
            Country = pCountry;
            CustomData = pCustomData;
            DatabaseType = pDatabaseType;
            DatabaseTypeId = pDatabaseTypeId;
            DocumentSets = pDocumentSets;
            DocumentSetsCount = pDocumentSetsCount;
            DocumentType = pDocumentType;
            DocumentTypeId = pDocumentTypeId;
            DOI = pDOI;
            EmbaseAccessionNumber = pEmbaseAccessionNumber;
            Emtree = pEmtree;
            ErrataText = pErrataText;
            FullText = pFullText;
            FullTextURL = pFullTextURL;
            Import = pImport;
            ImportId = pImportId;
            ImportType = pImportType;
            ImportTypeId = pImportTypeId;
            Institution = pInstitution;
            ISSN = pISSN;
            Issue = pIssue;
            JournalTitle = pJournalTitle;
            LegacyModel = pLegacyModel;
            LegacySync = pLegacySync;
            LookupTables = pLookupTables;
            LookupTablesCount = pLookupTablesCount;
            MedlineID = pMedlineID;
            MeSH = pMeSH;
            NonDigitizedDocumentSets = pNonDigitizedDocumentSets;
            NonDigitizedDocumentSetsCount = pNonDigitizedDocumentSetsCount;
            Pages = pPages;
            ParentChildStatus = pParentChildStatus;
            ParentID = pParentID;
            PublicationDate = pPublicationDate;
            PublicationYear = pPublicationYear;
            PubType = pPubType;
            ReferenceStudy = pReferenceStudy;
            SecondarySourceID = pSecondarySourceID;
            Source = pSource;
            StorageModel = pStorageModel;
            SupplementalFiles = pSupplementalFiles;
            TaStudyDesign = pTaStudyDesign;
            Title = pTitle;
            TrialOutcome = pTrialOutcome;
            VariableData = pVariableData;
            VariableDataCount = pVariableDataCount;
            Volume = pVolume;
        }

        [ApiMember(Name = nameof(Abstract), Description = "string", IsRequired = false)]
        public string Abstract { get; set; }


        [ApiMember(Name = nameof(AccessionID), Description = "string", IsRequired = false)]
        public string AccessionID { get; set; }


        [ApiMember(Name = nameof(Acronym), Description = "string", IsRequired = false)]
        public string Acronym { get; set; }


        [ApiMember(Name = nameof(Authors), Description = "string", IsRequired = false)]
        public string Authors { get; set; }


        [ApiMember(Name = nameof(CochraneID), Description = "string", IsRequired = false)]
        public string CochraneID { get; set; }


        [ApiMember(Name = nameof(CorporateAuthor), Description = "string", IsRequired = false)]
        public string CorporateAuthor { get; set; }


        [ApiMember(Name = nameof(Country), Description = "string", IsRequired = false)]
        public string Country { get; set; }


        [ApiMember(Name = nameof(CustomData), Description = "string", IsRequired = false)]
        public string CustomData { get; set; }


        [ApiMember(Name = nameof(DatabaseType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"ASCO",@"ClinicalTrials.gov",@"Cochrane",@"Embase",@"IOVS",@"Manual Entry",@"MEDLINE",@"Northern Light"})]
        public Reference DatabaseType { get; set; }
        [ApiMember(Name = nameof(DatabaseTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? DatabaseTypeId { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(DocumentType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"CTG",@"Data Hub",@"DOC Extract",@"DOC Library",@"PubMed"})]
        public Reference DocumentType { get; set; }
        [ApiMember(Name = nameof(DocumentTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? DocumentTypeId { get; set; }


        [ApiMember(Name = nameof(DOI), Description = "string", IsRequired = false)]
        public string DOI { get; set; }


        [ApiMember(Name = nameof(EmbaseAccessionNumber), Description = "string", IsRequired = false)]
        public string EmbaseAccessionNumber { get; set; }


        [ApiMember(Name = nameof(Emtree), Description = "string", IsRequired = false)]
        public string Emtree { get; set; }


        [ApiMember(Name = nameof(ErrataText), Description = "string", IsRequired = false)]
        public string ErrataText { get; set; }


        [ApiMember(Name = nameof(FullText), Description = "string", IsRequired = false)]
        public string FullText { get; set; }


        [ApiMember(Name = nameof(FullTextURL), Description = "string", IsRequired = false)]
        public string FullTextURL { get; set; }


        [ApiMember(Name = nameof(Import), Description = "ImportData", IsRequired = false)]
        public Reference Import { get; set; }
        [ApiMember(Name = nameof(ImportId), Description = "Primary Key of ImportData", IsRequired = false)]
        public int? ImportId { get; set; }


        [ApiMember(Name = nameof(ImportType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"ClinicalTrials.gov",@"Extract",@"Legacy"})]
        public Reference ImportType { get; set; }
        [ApiMember(Name = nameof(ImportTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? ImportTypeId { get; set; }


        [ApiMember(Name = nameof(Institution), Description = "string", IsRequired = false)]
        public string Institution { get; set; }


        [ApiMember(Name = nameof(ISSN), Description = "string", IsRequired = false)]
        public string ISSN { get; set; }


        [ApiMember(Name = nameof(Issue), Description = "string", IsRequired = false)]
        public string Issue { get; set; }


        [ApiMember(Name = nameof(JournalTitle), Description = "string", IsRequired = false)]
        public string JournalTitle { get; set; }


        [ApiMember(Name = nameof(LegacyModel), Description = "string", IsRequired = false)]
        public string LegacyModel { get; set; }


        [ApiMember(Name = nameof(LegacySync), Description = "DateTime?", IsRequired = false)]
        public DateTime? LegacySync { get; set; }


        [ApiMember(Name = nameof(LookupTables), Description = "LookupTable", IsRequired = false)]
        public List<Reference> LookupTables { get; set; }
        public List<int> LookupTablesIds { get; set; }
        public int? LookupTablesCount { get; set; }


        [ApiMember(Name = nameof(MedlineID), Description = "int?", IsRequired = false)]
        public int? MedlineID { get; set; }


        [ApiMember(Name = nameof(MeSH), Description = "string", IsRequired = false)]
        public string MeSH { get; set; }


        [ApiMember(Name = nameof(NonDigitizedDocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> NonDigitizedDocumentSets { get; set; }
        public List<int> NonDigitizedDocumentSetsIds { get; set; }
        public int? NonDigitizedDocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(Pages), Description = "string", IsRequired = false)]
        public string Pages { get; set; }


        [ApiMember(Name = nameof(ParentChildStatus), Description = "char?", IsRequired = false)]
        public char? ParentChildStatus { get; set; }


        [ApiMember(Name = nameof(ParentID), Description = "int?", IsRequired = false)]
        public int? ParentID { get; set; }


        [ApiMember(Name = nameof(PublicationDate), Description = "string", IsRequired = false)]
        public string PublicationDate { get; set; }


        [ApiMember(Name = nameof(PublicationYear), Description = "int?", IsRequired = false)]
        public int? PublicationYear { get; set; }


        [ApiMember(Name = nameof(PubType), Description = "string", IsRequired = false)]
        public string PubType { get; set; }


        [ApiMember(Name = nameof(ReferenceStudy), Description = "int?", IsRequired = false)]
        public int? ReferenceStudy { get; set; }


        [ApiMember(Name = nameof(SecondarySourceID), Description = "string", IsRequired = false)]
        public string SecondarySourceID { get; set; }


        [ApiMember(Name = nameof(Source), Description = "string", IsRequired = false)]
        public string Source { get; set; }


        [ApiMember(Name = nameof(StorageModel), Description = "string", IsRequired = false)]
        public string StorageModel { get; set; }


        [ApiMember(Name = nameof(SupplementalFiles), Description = "string", IsRequired = false)]
        public string SupplementalFiles { get; set; }


        [ApiMember(Name = nameof(TaStudyDesign), Description = "string", IsRequired = false)]
        public string TaStudyDesign { get; set; }


        [ApiMember(Name = nameof(Title), Description = "string", IsRequired = false)]
        public string Title { get; set; }


        [ApiMember(Name = nameof(TrialOutcome), Description = "short?", IsRequired = false)]
        public short? TrialOutcome { get; set; }


        [ApiMember(Name = nameof(VariableData), Description = "VariableInstance", IsRequired = false)]
        public List<Reference> VariableData { get; set; }
        public List<int> VariableDataIds { get; set; }
        public int? VariableDataCount { get; set; }


        [ApiMember(Name = nameof(Volume), Description = "string", IsRequired = false)]
        public string Volume { get; set; }



        public void Deconstruct(out string pAbstract, out string pAccessionID, out string pAcronym, out string pAuthors, out string pCochraneID, out string pCorporateAuthor, out string pCountry, out string pCustomData, out Reference pDatabaseType, out int? pDatabaseTypeId, out List<Reference> pDocumentSets, out int? pDocumentSetsCount, out Reference pDocumentType, out int? pDocumentTypeId, out string pDOI, out string pEmbaseAccessionNumber, out string pEmtree, out string pErrataText, out string pFullText, out string pFullTextURL, out Reference pImport, out int? pImportId, out Reference pImportType, out int? pImportTypeId, out string pInstitution, out string pISSN, out string pIssue, out string pJournalTitle, out string pLegacyModel, out DateTime? pLegacySync, out List<Reference> pLookupTables, out int? pLookupTablesCount, out int? pMedlineID, out string pMeSH, out List<Reference> pNonDigitizedDocumentSets, out int? pNonDigitizedDocumentSetsCount, out string pPages, out char? pParentChildStatus, out int? pParentID, out string pPublicationDate, out int? pPublicationYear, out string pPubType, out int? pReferenceStudy, out string pSecondarySourceID, out string pSource, out string pStorageModel, out string pSupplementalFiles, out string pTaStudyDesign, out string pTitle, out short? pTrialOutcome, out List<Reference> pVariableData, out int? pVariableDataCount, out string pVolume)
        {
            pAbstract = Abstract;
            pAccessionID = AccessionID;
            pAcronym = Acronym;
            pAuthors = Authors;
            pCochraneID = CochraneID;
            pCorporateAuthor = CorporateAuthor;
            pCountry = Country;
            pCustomData = CustomData;
            pDatabaseType = DatabaseType;
            pDatabaseTypeId = DatabaseTypeId;
            pDocumentSets = DocumentSets;
            pDocumentSetsCount = DocumentSetsCount;
            pDocumentType = DocumentType;
            pDocumentTypeId = DocumentTypeId;
            pDOI = DOI;
            pEmbaseAccessionNumber = EmbaseAccessionNumber;
            pEmtree = Emtree;
            pErrataText = ErrataText;
            pFullText = FullText;
            pFullTextURL = FullTextURL;
            pImport = Import;
            pImportId = ImportId;
            pImportType = ImportType;
            pImportTypeId = ImportTypeId;
            pInstitution = Institution;
            pISSN = ISSN;
            pIssue = Issue;
            pJournalTitle = JournalTitle;
            pLegacyModel = LegacyModel;
            pLegacySync = LegacySync;
            pLookupTables = LookupTables;
            pLookupTablesCount = LookupTablesCount;
            pMedlineID = MedlineID;
            pMeSH = MeSH;
            pNonDigitizedDocumentSets = NonDigitizedDocumentSets;
            pNonDigitizedDocumentSetsCount = NonDigitizedDocumentSetsCount;
            pPages = Pages;
            pParentChildStatus = ParentChildStatus;
            pParentID = ParentID;
            pPublicationDate = PublicationDate;
            pPublicationYear = PublicationYear;
            pPubType = PubType;
            pReferenceStudy = ReferenceStudy;
            pSecondarySourceID = SecondarySourceID;
            pSource = Source;
            pStorageModel = StorageModel;
            pSupplementalFiles = SupplementalFiles;
            pTaStudyDesign = TaStudyDesign;
            pTitle = Title;
            pTrialOutcome = TrialOutcome;
            pVariableData = VariableData;
            pVariableDataCount = VariableDataCount;
            pVolume = Volume;
        }

        //Not ready until C# v8.?
        //public DocumentBase With(int? pId = Id, string pAbstract = Abstract, string pAccessionID = AccessionID, string pAcronym = Acronym, string pAuthors = Authors, string pCochraneID = CochraneID, string pCorporateAuthor = CorporateAuthor, string pCountry = Country, string pCustomData = CustomData, Reference pDatabaseType = DatabaseType, int? pDatabaseTypeId = DatabaseTypeId, List<Reference> pDocumentSets = DocumentSets, int? pDocumentSetsCount = DocumentSetsCount, Reference pDocumentType = DocumentType, int? pDocumentTypeId = DocumentTypeId, string pDOI = DOI, string pEmbaseAccessionNumber = EmbaseAccessionNumber, string pEmtree = Emtree, string pErrataText = ErrataText, string pFullText = FullText, string pFullTextURL = FullTextURL, Reference pImport = Import, int? pImportId = ImportId, Reference pImportType = ImportType, int? pImportTypeId = ImportTypeId, string pInstitution = Institution, string pISSN = ISSN, string pIssue = Issue, string pJournalTitle = JournalTitle, string pLegacyModel = LegacyModel, DateTime? pLegacySync = LegacySync, List<Reference> pLookupTables = LookupTables, int? pLookupTablesCount = LookupTablesCount, int? pMedlineID = MedlineID, string pMeSH = MeSH, List<Reference> pNonDigitizedDocumentSets = NonDigitizedDocumentSets, int? pNonDigitizedDocumentSetsCount = NonDigitizedDocumentSetsCount, string pPages = Pages, char? pParentChildStatus = ParentChildStatus, int? pParentID = ParentID, string pPublicationDate = PublicationDate, int? pPublicationYear = PublicationYear, string pPubType = PubType, int? pReferenceStudy = ReferenceStudy, string pSecondarySourceID = SecondarySourceID, string pSource = Source, string pStorageModel = StorageModel, string pSupplementalFiles = SupplementalFiles, string pTaStudyDesign = TaStudyDesign, string pTitle = Title, short? pTrialOutcome = TrialOutcome, List<Reference> pVariableData = VariableData, int? pVariableDataCount = VariableDataCount, string pVolume = Volume) => 
        //	new DocumentBase(pId, pAbstract, pAccessionID, pAcronym, pAuthors, pCochraneID, pCorporateAuthor, pCountry, pCustomData, pDatabaseType, pDatabaseTypeId, pDocumentSets, pDocumentSetsCount, pDocumentType, pDocumentTypeId, pDOI, pEmbaseAccessionNumber, pEmtree, pErrataText, pFullText, pFullTextURL, pImport, pImportId, pImportType, pImportTypeId, pInstitution, pISSN, pIssue, pJournalTitle, pLegacyModel, pLegacySync, pLookupTables, pLookupTablesCount, pMedlineID, pMeSH, pNonDigitizedDocumentSets, pNonDigitizedDocumentSetsCount, pPages, pParentChildStatus, pParentID, pPublicationDate, pPublicationYear, pPubType, pReferenceStudy, pSecondarySourceID, pSource, pStorageModel, pSupplementalFiles, pTaStudyDesign, pTitle, pTrialOutcome, pVariableData, pVariableDataCount, pVolume);

    }


    [Route("/document", "POST")]
    [Route("/document/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Document : DocumentBase, IReturn<Document>, IDto, ICloneable
    {
        public Document()
        {
            _Constructor();
        }

        public Document(int? id) : base(DocConvert.ToInt(id)) {}
        public Document(int id) : base(id) {}
        public Document(int? pId, string pAbstract, string pAccessionID, string pAcronym, string pAuthors, string pCochraneID, string pCorporateAuthor, string pCountry, string pCustomData, Reference pDatabaseType, int? pDatabaseTypeId, List<Reference> pDocumentSets, int? pDocumentSetsCount, Reference pDocumentType, int? pDocumentTypeId, string pDOI, string pEmbaseAccessionNumber, string pEmtree, string pErrataText, string pFullText, string pFullTextURL, Reference pImport, int? pImportId, Reference pImportType, int? pImportTypeId, string pInstitution, string pISSN, string pIssue, string pJournalTitle, string pLegacyModel, DateTime? pLegacySync, List<Reference> pLookupTables, int? pLookupTablesCount, int? pMedlineID, string pMeSH, List<Reference> pNonDigitizedDocumentSets, int? pNonDigitizedDocumentSetsCount, string pPages, char? pParentChildStatus, int? pParentID, string pPublicationDate, int? pPublicationYear, string pPubType, int? pReferenceStudy, string pSecondarySourceID, string pSource, string pStorageModel, string pSupplementalFiles, string pTaStudyDesign, string pTitle, short? pTrialOutcome, List<Reference> pVariableData, int? pVariableDataCount, string pVolume) : 
            base(pId, pAbstract, pAccessionID, pAcronym, pAuthors, pCochraneID, pCorporateAuthor, pCountry, pCustomData, pDatabaseType, pDatabaseTypeId, pDocumentSets, pDocumentSetsCount, pDocumentType, pDocumentTypeId, pDOI, pEmbaseAccessionNumber, pEmtree, pErrataText, pFullText, pFullTextURL, pImport, pImportId, pImportType, pImportTypeId, pInstitution, pISSN, pIssue, pJournalTitle, pLegacyModel, pLegacySync, pLookupTables, pLookupTablesCount, pMedlineID, pMeSH, pNonDigitizedDocumentSets, pNonDigitizedDocumentSetsCount, pPages, pParentChildStatus, pParentID, pPublicationDate, pPublicationYear, pPubType, pReferenceStudy, pSecondarySourceID, pSource, pStorageModel, pSupplementalFiles, pTaStudyDesign, pTitle, pTrialOutcome, pVariableData, pVariableDataCount, pVolume) { }
        #region Fields

        public bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Document>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Abstract),nameof(AccessionID),nameof(Acronym),nameof(Authors),nameof(CochraneID),nameof(CorporateAuthor),nameof(Country),nameof(Created),nameof(CreatorId),nameof(CustomData),nameof(DatabaseType),nameof(DatabaseTypeId),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(DocumentType),nameof(DocumentTypeId),nameof(DOI),nameof(EmbaseAccessionNumber),nameof(Emtree),nameof(ErrataText),nameof(FullText),nameof(FullTextURL),nameof(Gestalt),nameof(Import),nameof(ImportId),nameof(ImportType),nameof(ImportTypeId),nameof(Institution),nameof(ISSN),nameof(Issue),nameof(JournalTitle),nameof(LegacyModel),nameof(LegacySync),nameof(Locked),nameof(LookupTables),nameof(LookupTablesCount),nameof(MedlineID),nameof(MeSH),nameof(NonDigitizedDocumentSets),nameof(NonDigitizedDocumentSetsCount),nameof(Pages),nameof(ParentChildStatus),nameof(ParentID),nameof(PublicationDate),nameof(PublicationYear),nameof(PubType),nameof(ReferenceStudy),nameof(SecondarySourceID),nameof(Source),nameof(StorageModel),nameof(SupplementalFiles),nameof(TaStudyDesign),nameof(Title),nameof(TrialOutcome),nameof(Updated),nameof(VariableData),nameof(VariableDataCount),nameof(VersionNo),nameof(Volume)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {


                    _VisibleFields = DocWebSession.GetTypeVisibleFields(this);

                }
                return _VisibleFields;
            }
            set
            {


                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Document>("Document",exists);

            }
        }

        #endregion Fields

        private List<string> _collections = new List<string>
        {
            nameof(DocumentSets), nameof(DocumentSetsCount), nameof(LookupTables), nameof(LookupTablesCount), nameof(NonDigitizedDocumentSets), nameof(NonDigitizedDocumentSetsCount), nameof(VariableData), nameof(VariableDataCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<Document>();
    }
    

    [Route("/document/{Id}/copy", "POST")]
    public partial class DocumentCopy : Document {}

    public partial class DocumentSearchBase : Search<Document>
    {
        public int? Id { get; set; }
        public string Abstract { get; set; }
        public string AccessionID { get; set; }
        public string Acronym { get; set; }
        public string Authors { get; set; }
        public string CochraneID { get; set; }
        public string CorporateAuthor { get; set; }
        public string Country { get; set; }
        public string CustomData { get; set; }
        public Reference DatabaseType { get; set; }
        public List<int> DatabaseTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"ASCO",@"ClinicalTrials.gov",@"Cochrane",@"Embase",@"IOVS",@"Manual Entry",@"MEDLINE",@"Northern Light"})]
        public List<string> DatabaseTypeNames { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public Reference DocumentType { get; set; }
        public List<int> DocumentTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"CTG",@"Data Hub",@"DOC Extract",@"DOC Library",@"PubMed"})]
        public List<string> DocumentTypeNames { get; set; }
        public string DOI { get; set; }
        public string EmbaseAccessionNumber { get; set; }
        public string Emtree { get; set; }
        public string ErrataText { get; set; }
        public string FullText { get; set; }
        public string FullTextURL { get; set; }
        public Reference Import { get; set; }
        public List<int> ImportIds { get; set; }
        public Reference ImportType { get; set; }
        public List<int> ImportTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"ClinicalTrials.gov",@"Extract",@"Legacy"})]
        public List<string> ImportTypeNames { get; set; }
        public string Institution { get; set; }
        public string ISSN { get; set; }
        public string Issue { get; set; }
        public string JournalTitle { get; set; }
        public string LegacyModel { get; set; }
        public DateTime? LegacySync { get; set; }
        public DateTime? LegacySyncAfter { get; set; }
        public DateTime? LegacySyncBefore { get; set; }
        public List<int> LookupTablesIds { get; set; }
        public int? MedlineID { get; set; }
        public string MeSH { get; set; }
        public List<int> NonDigitizedDocumentSetsIds { get; set; }
        public string Pages { get; set; }
        public char? ParentChildStatus { get; set; }
        public int? ParentID { get; set; }
        public string PublicationDate { get; set; }
        public int? PublicationYear { get; set; }
        public string PubType { get; set; }
        public int? ReferenceStudy { get; set; }
        public string SecondarySourceID { get; set; }
        public string Source { get; set; }
        public string StorageModel { get; set; }
        public string SupplementalFiles { get; set; }
        public string TaStudyDesign { get; set; }
        public string Title { get; set; }
        public short? TrialOutcome { get; set; }
        public List<int> VariableDataIds { get; set; }
        public string Volume { get; set; }
    }


    [Route("/document", "GET")]
    [Route("/document/version", "GET, POST")]
    [Route("/document/search", "GET, POST, DELETE")]

    public partial class DocumentSearch : DocumentSearchBase
    {
    }

    public class DocumentFullTextSearch
    {
        public DocumentFullTextSearch() {}
        private DocumentSearch _request;
        public DocumentFullTextSearch(DocumentSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Updated))); }

        public bool doAbstract { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Abstract))); }
        public bool doAccessionID { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.AccessionID))); }
        public bool doAcronym { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Acronym))); }
        public bool doAuthors { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Authors))); }
        public bool doCochraneID { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.CochraneID))); }
        public bool doCorporateAuthor { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.CorporateAuthor))); }
        public bool doCountry { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Country))); }
        public bool doCustomData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.CustomData))); }
        public bool doDatabaseType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.DatabaseType))); }
        public bool doDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.DocumentSets))); }
        public bool doDocumentType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.DocumentType))); }
        public bool doDOI { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.DOI))); }
        public bool doEmbaseAccessionNumber { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.EmbaseAccessionNumber))); }
        public bool doEmtree { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Emtree))); }
        public bool doErrataText { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.ErrataText))); }
        public bool doFullText { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.FullText))); }
        public bool doFullTextURL { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.FullTextURL))); }
        public bool doImport { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Import))); }
        public bool doImportType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.ImportType))); }
        public bool doInstitution { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Institution))); }
        public bool doISSN { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.ISSN))); }
        public bool doIssue { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Issue))); }
        public bool doJournalTitle { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.JournalTitle))); }
        public bool doLegacyModel { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.LegacyModel))); }
        public bool doLegacySync { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.LegacySync))); }
        public bool doLookupTables { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.LookupTables))); }
        public bool doMedlineID { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.MedlineID))); }
        public bool doMeSH { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.MeSH))); }
        public bool doNonDigitizedDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.NonDigitizedDocumentSets))); }
        public bool doPages { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Pages))); }
        public bool doParentChildStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.ParentChildStatus))); }
        public bool doParentID { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.ParentID))); }
        public bool doPublicationDate { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.PublicationDate))); }
        public bool doPublicationYear { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.PublicationYear))); }
        public bool doPubType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.PubType))); }
        public bool doReferenceStudy { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.ReferenceStudy))); }
        public bool doSecondarySourceID { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.SecondarySourceID))); }
        public bool doSource { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Source))); }
        public bool doStorageModel { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.StorageModel))); }
        public bool doSupplementalFiles { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.SupplementalFiles))); }
        public bool doTaStudyDesign { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.TaStudyDesign))); }
        public bool doTitle { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Title))); }
        public bool doTrialOutcome { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.TrialOutcome))); }
        public bool doVariableData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.VariableData))); }
        public bool doVolume { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Document.Volume))); }
    }


    [Route("/document/batch", "DELETE, PATCH, POST, PUT")]

    public partial class DocumentBatch : List<Document> { }


    [Route("/document/{Id}/{Junction}/version", "GET, POST")]
    [Route("/document/{Id}/{Junction}", "GET, POST, DELETE")]
    public class DocumentJunction : DocumentSearchBase {}



}
