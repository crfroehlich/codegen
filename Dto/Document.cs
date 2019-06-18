//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;


namespace Services.Dto
{
    public abstract partial class DocumentBase : Dto<Document>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentBase(int? pId, string pAbstract, string pAccessionID, string pAcronym, string pArticleId, string pAuthors, string pCochraneID, string pCorporateAuthor, string pCountry, string pCustomData, DatabaseTypeEnm? pDatabaseType, List<Reference> pDocumentSets, int? pDocumentSetsCount, DocumentTypeEnm? pDocumentType, string pDOI, string pEmbaseAccessionNumber, string pEmtree, string pErrataText, string pFullText, string pFullTextURL, Reference pImport, int? pImportId, StudyImportTypeEnm? pImportType, string pInstitution, string pISSN, string pIssue, string pJournalTitle, DateTime? pLegacySync, List<Reference> pLookupTables, int? pLookupTablesCount, int? pMedlineID, string pMeSH, string pPages, char? pParentChildStatus, int? pParentID, string pPublicationDate, int? pPublicationYear, string pPubType, Reference pReconciliation, int? pReconciliationId, int? pReferenceStudy, string pSecondarySourceID, string pSource, string pStorageModel, string pSupplementalFiles, string pTaStudyDesign, string pTitle, short? pTrialOutcome, List<Reference> pVariableData, int? pVariableDataCount, string pVolume) : this(DocConvert.ToInt(pId)) 
        {
            Abstract = pAbstract;
            AccessionID = pAccessionID;
            Acronym = pAcronym;
            ArticleId = pArticleId;
            Authors = pAuthors;
            CochraneID = pCochraneID;
            CorporateAuthor = pCorporateAuthor;
            Country = pCountry;
            CustomData = pCustomData;
            DatabaseType = pDatabaseType;
            DocumentSets = pDocumentSets;
            DocumentSetsCount = pDocumentSetsCount;
            DocumentType = pDocumentType;
            DOI = pDOI;
            EmbaseAccessionNumber = pEmbaseAccessionNumber;
            Emtree = pEmtree;
            ErrataText = pErrataText;
            FullText = pFullText;
            FullTextURL = pFullTextURL;
            Import = pImport;
            ImportId = pImportId;
            ImportType = pImportType;
            Institution = pInstitution;
            ISSN = pISSN;
            Issue = pIssue;
            JournalTitle = pJournalTitle;
            LegacySync = pLegacySync;
            LookupTables = pLookupTables;
            LookupTablesCount = pLookupTablesCount;
            MedlineID = pMedlineID;
            MeSH = pMeSH;
            Pages = pPages;
            ParentChildStatus = pParentChildStatus;
            ParentID = pParentID;
            PublicationDate = pPublicationDate;
            PublicationYear = pPublicationYear;
            PubType = pPubType;
            Reconciliation = pReconciliation;
            ReconciliationId = pReconciliationId;
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Abstract { get; set; }


        [ApiMember(Name = nameof(AccessionID), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string AccessionID { get; set; }


        [ApiMember(Name = nameof(Acronym), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Acronym { get; set; }


        [ApiMember(Name = nameof(ArticleId), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string ArticleId { get; set; }


        [ApiMember(Name = nameof(Authors), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Authors { get; set; }


        [ApiMember(Name = nameof(CochraneID), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string CochraneID { get; set; }


        [ApiMember(Name = nameof(CorporateAuthor), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string CorporateAuthor { get; set; }


        [ApiMember(Name = nameof(Country), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Country { get; set; }


        [ApiMember(Name = nameof(CustomData), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string CustomData { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"ASCO",@"ClinicalTrials.gov",@"Cochrane",@"Embase",@"IOVS",@"Manual Entry",@"MEDLINE",@"Northern Light"})]
        [ApiMember(Name = nameof(DatabaseType), Description = "DatabaseTypeEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseTypeEnm? DatabaseType { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> DocumentSets { get; set; }
        [ApiMember(Name = nameof(DocumentSetsIds), Description = "DocumentSet Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DocumentSetsIds { get; set; }
        [ApiMember(Name = nameof(DocumentSetsCount), Description = "DocumentSet Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DocumentSetsCount { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"CTG",@"Data Hub",@"DOC Extract",@"DOC Library",@"PubMed"})]
        [ApiMember(Name = nameof(DocumentType), Description = "DocumentTypeEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentTypeEnm? DocumentType { get; set; }


        [ApiMember(Name = nameof(DOI), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string DOI { get; set; }


        [ApiMember(Name = nameof(EmbaseAccessionNumber), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string EmbaseAccessionNumber { get; set; }


        [ApiMember(Name = nameof(Emtree), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Emtree { get; set; }


        [ApiMember(Name = nameof(ErrataText), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string ErrataText { get; set; }


        [ApiMember(Name = nameof(FullText), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string FullText { get; set; }


        [ApiMember(Name = nameof(FullTextURL), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string FullTextURL { get; set; }


        [ApiMember(Name = nameof(Import), Description = "ImportData", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Import { get; set; }
        [ApiMember(Name = nameof(ImportId), Description = "Primary Key of ImportData", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ImportId { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"ClinicalTrials.gov",@"Extract",@"Legacy"})]
        [ApiMember(Name = nameof(ImportType), Description = "StudyImportTypeEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyImportTypeEnm? ImportType { get; set; }


        [ApiMember(Name = nameof(Institution), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Institution { get; set; }


        [ApiMember(Name = nameof(ISSN), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string ISSN { get; set; }


        [ApiMember(Name = nameof(Issue), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Issue { get; set; }


        [ApiMember(Name = nameof(JournalTitle), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string JournalTitle { get; set; }


        [ApiMember(Name = nameof(LegacySync), Description = "DateTime?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime? LegacySync { get; set; }


        [ApiMember(Name = nameof(LookupTables), Description = "LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> LookupTables { get; set; }
        [ApiMember(Name = nameof(LookupTablesIds), Description = "LookupTable Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> LookupTablesIds { get; set; }
        [ApiMember(Name = nameof(LookupTablesCount), Description = "LookupTable Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? LookupTablesCount { get; set; }


        [ApiMember(Name = nameof(MedlineID), Description = "int?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? MedlineID { get; set; }


        [ApiMember(Name = nameof(MeSH), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string MeSH { get; set; }


        [ApiMember(Name = nameof(Pages), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Pages { get; set; }


        [ApiMember(Name = nameof(ParentChildStatus), Description = "char?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public char? ParentChildStatus { get; set; }


        [ApiMember(Name = nameof(ParentID), Description = "int?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ParentID { get; set; }


        [ApiMember(Name = nameof(PublicationDate), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string PublicationDate { get; set; }


        [ApiMember(Name = nameof(PublicationYear), Description = "int?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? PublicationYear { get; set; }


        [ApiMember(Name = nameof(PubType), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string PubType { get; set; }


        [ApiMember(Name = nameof(Reconciliation), Description = "ReconcileDocument", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Reconciliation { get; set; }
        [ApiMember(Name = nameof(ReconciliationId), Description = "Primary Key of ReconcileDocument", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ReconciliationId { get; set; }


        [ApiMember(Name = nameof(ReferenceStudy), Description = "int?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ReferenceStudy { get; set; }


        [ApiMember(Name = nameof(SecondarySourceID), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string SecondarySourceID { get; set; }


        [ApiMember(Name = nameof(Source), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Source { get; set; }


        [ApiMember(Name = nameof(StorageModel), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string StorageModel { get; set; }


        [ApiMember(Name = nameof(SupplementalFiles), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string SupplementalFiles { get; set; }


        [ApiMember(Name = nameof(TaStudyDesign), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string TaStudyDesign { get; set; }


        [ApiMember(Name = nameof(Title), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Title { get; set; }


        [ApiMember(Name = nameof(TrialOutcome), Description = "short?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public short? TrialOutcome { get; set; }


        [ApiMember(Name = nameof(VariableData), Description = "VariableInstance", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> VariableData { get; set; }
        [ApiMember(Name = nameof(VariableDataIds), Description = "VariableInstance Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> VariableDataIds { get; set; }
        [ApiMember(Name = nameof(VariableDataCount), Description = "VariableInstance Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? VariableDataCount { get; set; }


        [ApiMember(Name = nameof(Volume), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Volume { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out string pAbstract, out string pAccessionID, out string pAcronym, out string pArticleId, out string pAuthors, out string pCochraneID, out string pCorporateAuthor, out string pCountry, out string pCustomData, out DatabaseTypeEnm? pDatabaseType, out List<Reference> pDocumentSets, out int? pDocumentSetsCount, out DocumentTypeEnm? pDocumentType, out string pDOI, out string pEmbaseAccessionNumber, out string pEmtree, out string pErrataText, out string pFullText, out string pFullTextURL, out Reference pImport, out int? pImportId, out StudyImportTypeEnm? pImportType, out string pInstitution, out string pISSN, out string pIssue, out string pJournalTitle, out DateTime? pLegacySync, out List<Reference> pLookupTables, out int? pLookupTablesCount, out int? pMedlineID, out string pMeSH, out string pPages, out char? pParentChildStatus, out int? pParentID, out string pPublicationDate, out int? pPublicationYear, out string pPubType, out Reference pReconciliation, out int? pReconciliationId, out int? pReferenceStudy, out string pSecondarySourceID, out string pSource, out string pStorageModel, out string pSupplementalFiles, out string pTaStudyDesign, out string pTitle, out short? pTrialOutcome, out List<Reference> pVariableData, out int? pVariableDataCount, out string pVolume)
        {
            pAbstract = Abstract;
            pAccessionID = AccessionID;
            pAcronym = Acronym;
            pArticleId = ArticleId;
            pAuthors = Authors;
            pCochraneID = CochraneID;
            pCorporateAuthor = CorporateAuthor;
            pCountry = Country;
            pCustomData = CustomData;
            pDatabaseType = DatabaseType;
            pDocumentSets = DocumentSets;
            pDocumentSetsCount = DocumentSetsCount;
            pDocumentType = DocumentType;
            pDOI = DOI;
            pEmbaseAccessionNumber = EmbaseAccessionNumber;
            pEmtree = Emtree;
            pErrataText = ErrataText;
            pFullText = FullText;
            pFullTextURL = FullTextURL;
            pImport = Import;
            pImportId = ImportId;
            pImportType = ImportType;
            pInstitution = Institution;
            pISSN = ISSN;
            pIssue = Issue;
            pJournalTitle = JournalTitle;
            pLegacySync = LegacySync;
            pLookupTables = LookupTables;
            pLookupTablesCount = LookupTablesCount;
            pMedlineID = MedlineID;
            pMeSH = MeSH;
            pPages = Pages;
            pParentChildStatus = ParentChildStatus;
            pParentID = ParentID;
            pPublicationDate = PublicationDate;
            pPublicationYear = PublicationYear;
            pPubType = PubType;
            pReconciliation = Reconciliation;
            pReconciliationId = ReconciliationId;
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
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public DocumentBase With(int? pId = Id, string pAbstract = Abstract, string pAccessionID = AccessionID, string pAcronym = Acronym, string pArticleId = ArticleId, string pAuthors = Authors, string pCochraneID = CochraneID, string pCorporateAuthor = CorporateAuthor, string pCountry = Country, string pCustomData = CustomData, DatabaseTypeEnm? pDatabaseType = DatabaseType, List<Reference> pDocumentSets = DocumentSets, int? pDocumentSetsCount = DocumentSetsCount, DocumentTypeEnm? pDocumentType = DocumentType, string pDOI = DOI, string pEmbaseAccessionNumber = EmbaseAccessionNumber, string pEmtree = Emtree, string pErrataText = ErrataText, string pFullText = FullText, string pFullTextURL = FullTextURL, Reference pImport = Import, int? pImportId = ImportId, StudyImportTypeEnm? pImportType = ImportType, string pInstitution = Institution, string pISSN = ISSN, string pIssue = Issue, string pJournalTitle = JournalTitle, DateTime? pLegacySync = LegacySync, List<Reference> pLookupTables = LookupTables, int? pLookupTablesCount = LookupTablesCount, int? pMedlineID = MedlineID, string pMeSH = MeSH, string pPages = Pages, char? pParentChildStatus = ParentChildStatus, int? pParentID = ParentID, string pPublicationDate = PublicationDate, int? pPublicationYear = PublicationYear, string pPubType = PubType, Reference pReconciliation = Reconciliation, int? pReconciliationId = ReconciliationId, int? pReferenceStudy = ReferenceStudy, string pSecondarySourceID = SecondarySourceID, string pSource = Source, string pStorageModel = StorageModel, string pSupplementalFiles = SupplementalFiles, string pTaStudyDesign = TaStudyDesign, string pTitle = Title, short? pTrialOutcome = TrialOutcome, List<Reference> pVariableData = VariableData, int? pVariableDataCount = VariableDataCount, string pVolume = Volume) => 
        //	new DocumentBase(pId, pAbstract, pAccessionID, pAcronym, pArticleId, pAuthors, pCochraneID, pCorporateAuthor, pCountry, pCustomData, pDatabaseType, pDocumentSets, pDocumentSetsCount, pDocumentType, pDOI, pEmbaseAccessionNumber, pEmtree, pErrataText, pFullText, pFullTextURL, pImport, pImportId, pImportType, pInstitution, pISSN, pIssue, pJournalTitle, pLegacySync, pLookupTables, pLookupTablesCount, pMedlineID, pMeSH, pPages, pParentChildStatus, pParentID, pPublicationDate, pPublicationYear, pPubType, pReconciliation, pReconciliationId, pReferenceStudy, pSecondarySourceID, pSource, pStorageModel, pSupplementalFiles, pTaStudyDesign, pTitle, pTrialOutcome, pVariableData, pVariableDataCount, pVolume);

    }


    [Route("/document", "POST")]
    [Route("/document/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Document : DocumentBase, IReturn<Document>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Document() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Document(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Document(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Document(int? pId, string pAbstract, string pAccessionID, string pAcronym, string pArticleId, string pAuthors, string pCochraneID, string pCorporateAuthor, string pCountry, string pCustomData, DatabaseTypeEnm? pDatabaseType, List<Reference> pDocumentSets, int? pDocumentSetsCount, DocumentTypeEnm? pDocumentType, string pDOI, string pEmbaseAccessionNumber, string pEmtree, string pErrataText, string pFullText, string pFullTextURL, Reference pImport, int? pImportId, StudyImportTypeEnm? pImportType, string pInstitution, string pISSN, string pIssue, string pJournalTitle, DateTime? pLegacySync, List<Reference> pLookupTables, int? pLookupTablesCount, int? pMedlineID, string pMeSH, string pPages, char? pParentChildStatus, int? pParentID, string pPublicationDate, int? pPublicationYear, string pPubType, Reference pReconciliation, int? pReconciliationId, int? pReferenceStudy, string pSecondarySourceID, string pSource, string pStorageModel, string pSupplementalFiles, string pTaStudyDesign, string pTitle, short? pTrialOutcome, List<Reference> pVariableData, int? pVariableDataCount, string pVolume) :
            base(pId, pAbstract, pAccessionID, pAcronym, pArticleId, pAuthors, pCochraneID, pCorporateAuthor, pCountry, pCustomData, pDatabaseType, pDocumentSets, pDocumentSetsCount, pDocumentType, pDOI, pEmbaseAccessionNumber, pEmtree, pErrataText, pFullText, pFullTextURL, pImport, pImportId, pImportType, pInstitution, pISSN, pIssue, pJournalTitle, pLegacySync, pLookupTables, pLookupTablesCount, pMedlineID, pMeSH, pPages, pParentChildStatus, pParentID, pPublicationDate, pPublicationYear, pPubType, pReconciliation, pReconciliationId, pReferenceStudy, pSecondarySourceID, pSource, pStorageModel, pSupplementalFiles, pTaStudyDesign, pTitle, pTrialOutcome, pVariableData, pVariableDataCount, pVolume) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<Document>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Abstract),nameof(AccessionID),nameof(Acronym),nameof(ArticleId),nameof(Authors),nameof(CochraneID),nameof(CorporateAuthor),nameof(Country),nameof(Created),nameof(CreatorId),nameof(CustomData),nameof(DatabaseType),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(DocumentType),nameof(DOI),nameof(EmbaseAccessionNumber),nameof(Emtree),nameof(ErrataText),nameof(FullText),nameof(FullTextURL),nameof(Gestalt),nameof(Import),nameof(ImportId),nameof(ImportType),nameof(Institution),nameof(ISSN),nameof(Issue),nameof(JournalTitle),nameof(LegacySync),nameof(Locked),nameof(LookupTables),nameof(LookupTablesCount),nameof(MedlineID),nameof(MeSH),nameof(Pages),nameof(ParentChildStatus),nameof(ParentID),nameof(PublicationDate),nameof(PublicationYear),nameof(PubType),nameof(Reconciliation),nameof(ReconciliationId),nameof(ReferenceStudy),nameof(SecondarySourceID),nameof(Source),nameof(StorageModel),nameof(SupplementalFiles),nameof(TaStudyDesign),nameof(Title),nameof(TrialOutcome),nameof(Updated),nameof(VariableData),nameof(VariableDataCount),nameof(VersionNo),nameof(Volume)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocWebSession.GetTypeSelect(this);

                }
                return _Select;
            }
            set
            {

                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<Document>("Document",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(DocumentSets), nameof(DocumentSetsCount), nameof(DocumentSetsIds), nameof(LookupTables), nameof(LookupTablesCount), nameof(LookupTablesIds), nameof(VariableData), nameof(VariableDataCount), nameof(VariableDataIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<Document>();

    }
    

    [Route("/document/{Id}/copy", "POST")]
    public partial class DocumentCopy : Document {}

    public partial class DocumentSearchBase : Search<Document>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public string Abstract { get; set; }
        public List<string> Abstracts { get; set; }
        public string AccessionID { get; set; }
        public List<string> AccessionIDs { get; set; }
        public string Acronym { get; set; }
        public List<string> Acronyms { get; set; }
        public string ArticleId { get; set; }
        public List<string> ArticleIds { get; set; }
        public string Authors { get; set; }
        public List<string> Authorss { get; set; }
        public string CochraneID { get; set; }
        public List<string> CochraneIDs { get; set; }
        public string CorporateAuthor { get; set; }
        public List<string> CorporateAuthors { get; set; }
        public string Country { get; set; }
        public List<string> Countrys { get; set; }
        public string CustomData { get; set; }
        public List<string> CustomDatas { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"ASCO",@"ClinicalTrials.gov",@"Cochrane",@"Embase",@"IOVS",@"Manual Entry",@"MEDLINE",@"Northern Light"})]
        public DatabaseTypeEnm? DatabaseType { get; set; }
        public List<DatabaseTypeEnm?> DatabaseTypes { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"CTG",@"Data Hub",@"DOC Extract",@"DOC Library",@"PubMed"})]
        public DocumentTypeEnm? DocumentType { get; set; }
        public List<DocumentTypeEnm?> DocumentTypes { get; set; }
        public string DOI { get; set; }
        public List<string> DOIs { get; set; }
        public string EmbaseAccessionNumber { get; set; }
        public List<string> EmbaseAccessionNumbers { get; set; }
        public string Emtree { get; set; }
        public List<string> Emtrees { get; set; }
        public string ErrataText { get; set; }
        public List<string> ErrataTexts { get; set; }
        public string FullText { get; set; }
        public List<string> FullTexts { get; set; }
        public string FullTextURL { get; set; }
        public List<string> FullTextURLs { get; set; }
        public Reference Import { get; set; }
        public List<int> ImportIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"ClinicalTrials.gov",@"Extract",@"Legacy"})]
        public StudyImportTypeEnm? ImportType { get; set; }
        public List<StudyImportTypeEnm?> ImportTypes { get; set; }
        public string Institution { get; set; }
        public List<string> Institutions { get; set; }
        public string ISSN { get; set; }
        public List<string> ISSNs { get; set; }
        public string Issue { get; set; }
        public List<string> Issues { get; set; }
        public string JournalTitle { get; set; }
        public List<string> JournalTitles { get; set; }
        public DateTime? LegacySync { get; set; }
        public DateTime? LegacySyncAfter { get; set; }
        public DateTime? LegacySyncBefore { get; set; }
        public List<int> LookupTablesIds { get; set; }
        public int? MedlineID { get; set; }
        public string MeSH { get; set; }
        public List<string> MeSHs { get; set; }
        public string Pages { get; set; }
        public List<string> Pagess { get; set; }
        public char? ParentChildStatus { get; set; }
        public int? ParentID { get; set; }
        public string PublicationDate { get; set; }
        public List<string> PublicationDates { get; set; }
        public int? PublicationYear { get; set; }
        public string PubType { get; set; }
        public List<string> PubTypes { get; set; }
        public Reference Reconciliation { get; set; }
        public List<int> ReconciliationIds { get; set; }
        public int? ReferenceStudy { get; set; }
        public string SecondarySourceID { get; set; }
        public List<string> SecondarySourceIDs { get; set; }
        public string Source { get; set; }
        public List<string> Sources { get; set; }
        public string StorageModel { get; set; }
        public List<string> StorageModels { get; set; }
        public string SupplementalFiles { get; set; }
        public List<string> SupplementalFiless { get; set; }
        public string TaStudyDesign { get; set; }
        public List<string> TaStudyDesigns { get; set; }
        public string Title { get; set; }
        public List<string> Titles { get; set; }
        public short? TrialOutcome { get; set; }
        public List<int> VariableDataIds { get; set; }
        public string Volume { get; set; }
        public List<string> Volumes { get; set; }
    }


    [Route("/document", "GET")]
    [Route("/document/version", "GET, POST")]
    [Route("/document/search", "GET, POST, DELETE")]

    public partial class DocumentSearch : DocumentSearchBase
    {
    }

    public class DocumentFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocumentSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentFullTextSearch(DocumentSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Updated))); }

        public bool doAbstract { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Abstract))); }
        public bool doAccessionID { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.AccessionID))); }
        public bool doAcronym { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Acronym))); }
        public bool doArticleId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.ArticleId))); }
        public bool doAuthors { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Authors))); }
        public bool doCochraneID { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.CochraneID))); }
        public bool doCorporateAuthor { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.CorporateAuthor))); }
        public bool doCountry { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Country))); }
        public bool doCustomData { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.CustomData))); }
        public bool doDatabaseType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.DatabaseType))); }
        public bool doDocumentSets { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.DocumentSets))); }
        public bool doDocumentType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.DocumentType))); }
        public bool doDOI { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.DOI))); }
        public bool doEmbaseAccessionNumber { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.EmbaseAccessionNumber))); }
        public bool doEmtree { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Emtree))); }
        public bool doErrataText { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.ErrataText))); }
        public bool doFullText { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.FullText))); }
        public bool doFullTextURL { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.FullTextURL))); }
        public bool doImport { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Import))); }
        public bool doImportType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.ImportType))); }
        public bool doInstitution { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Institution))); }
        public bool doISSN { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.ISSN))); }
        public bool doIssue { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Issue))); }
        public bool doJournalTitle { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.JournalTitle))); }
        public bool doLegacySync { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.LegacySync))); }
        public bool doLookupTables { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.LookupTables))); }
        public bool doMedlineID { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.MedlineID))); }
        public bool doMeSH { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.MeSH))); }
        public bool doPages { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Pages))); }
        public bool doParentChildStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.ParentChildStatus))); }
        public bool doParentID { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.ParentID))); }
        public bool doPublicationDate { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.PublicationDate))); }
        public bool doPublicationYear { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.PublicationYear))); }
        public bool doPubType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.PubType))); }
        public bool doReconciliation { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Reconciliation))); }
        public bool doReferenceStudy { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.ReferenceStudy))); }
        public bool doSecondarySourceID { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.SecondarySourceID))); }
        public bool doSource { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Source))); }
        public bool doStorageModel { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.StorageModel))); }
        public bool doSupplementalFiles { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.SupplementalFiles))); }
        public bool doTaStudyDesign { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.TaStudyDesign))); }
        public bool doTitle { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Title))); }
        public bool doTrialOutcome { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.TrialOutcome))); }
        public bool doVariableData { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.VariableData))); }
        public bool doVolume { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Document.Volume))); }
    }


    [Route("/document/batch", "DELETE, PATCH, POST, PUT")]

    public partial class DocumentBatch : List<Document> { }


    [Route("/document/{Id}/{Junction}/version", "GET, POST")]
    [Route("/document/{Id}/{Junction}", "GET, POST, DELETE")]
    public class DocumentJunction : DocumentSearchBase {}



}
