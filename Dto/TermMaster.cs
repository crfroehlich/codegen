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
    public abstract partial class TermMasterBase : Dto<TermMaster>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMasterBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMasterBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMasterBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMasterBase(int? pId, string pBioPortal, List<TermCategory> pCategories, int? pCategoriesCount, string pCUI, Reference pEnum, int? pEnumId, string pMedDRA, string pName, string pRxNorm, string pSNOWMED, List<Reference> pSynonyms, int? pSynonymsCount, string pTUI, string pURI) : this(DocConvert.ToInt(pId)) 
        {
            BioPortal = pBioPortal;
            Categories = pCategories;
            CategoriesCount = pCategoriesCount;
            CUI = pCUI;
            Enum = pEnum;
            EnumId = pEnumId;
            MedDRA = pMedDRA;
            Name = pName;
            RxNorm = pRxNorm;
            SNOWMED = pSNOWMED;
            Synonyms = pSynonyms;
            SynonymsCount = pSynonymsCount;
            TUI = pTUI;
            URI = pURI;
        }

        [ApiMember(Name = nameof(BioPortal), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string BioPortal { get; set; }
        [ApiMember(Name = nameof(BioPortalIds), Description = "BioPortal Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> BioPortalIds { get; set; }
        [ApiMember(Name = nameof(BioPortalCount), Description = "BioPortal Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? BioPortalCount { get; set; }

        [ApiMember(Name = nameof(Categories), Description = "TermCategory", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<TermCategory> Categories { get; set; }
        [ApiMember(Name = nameof(CategoriesIds), Description = "TermCategory Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> CategoriesIds { get; set; }
        [ApiMember(Name = nameof(CategoriesCount), Description = "TermCategory Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? CategoriesCount { get; set; }

        [ApiMember(Name = nameof(CUI), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string CUI { get; set; }
        [ApiMember(Name = nameof(CUIIds), Description = "CUI Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> CUIIds { get; set; }
        [ApiMember(Name = nameof(CUICount), Description = "CUI Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? CUICount { get; set; }

        [ApiMember(Name = nameof(Enum), Description = "LookupTableEnum", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Enum { get; set; }
        [ApiMember(Name = nameof(EnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? EnumId { get; set; }

        [ApiMember(Name = nameof(MedDRA), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string MedDRA { get; set; }
        [ApiMember(Name = nameof(MedDRAIds), Description = "MedDRA Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> MedDRAIds { get; set; }
        [ApiMember(Name = nameof(MedDRACount), Description = "MedDRA Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? MedDRACount { get; set; }

        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Name { get; set; }
        [ApiMember(Name = nameof(NameIds), Description = "Name Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> NameIds { get; set; }
        [ApiMember(Name = nameof(NameCount), Description = "Name Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? NameCount { get; set; }

        [ApiMember(Name = nameof(RxNorm), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string RxNorm { get; set; }
        [ApiMember(Name = nameof(RxNormIds), Description = "RxNorm Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> RxNormIds { get; set; }
        [ApiMember(Name = nameof(RxNormCount), Description = "RxNorm Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? RxNormCount { get; set; }

        [ApiMember(Name = nameof(SNOWMED), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string SNOWMED { get; set; }
        [ApiMember(Name = nameof(SNOWMEDIds), Description = "SNOWMED Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> SNOWMEDIds { get; set; }
        [ApiMember(Name = nameof(SNOWMEDCount), Description = "SNOWMED Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? SNOWMEDCount { get; set; }

        [ApiMember(Name = nameof(Synonyms), Description = "TermSynonym", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Synonyms { get; set; }
        [ApiMember(Name = nameof(SynonymsIds), Description = "TermSynonym Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> SynonymsIds { get; set; }
        [ApiMember(Name = nameof(SynonymsCount), Description = "TermSynonym Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? SynonymsCount { get; set; }

        [ApiMember(Name = nameof(TUI), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string TUI { get; set; }
        [ApiMember(Name = nameof(TUIIds), Description = "TUI Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> TUIIds { get; set; }
        [ApiMember(Name = nameof(TUICount), Description = "TUI Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? TUICount { get; set; }

        [ApiMember(Name = nameof(URI), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string URI { get; set; }
        [ApiMember(Name = nameof(URIIds), Description = "URI Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> URIIds { get; set; }
        [ApiMember(Name = nameof(URICount), Description = "URI Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? URICount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out string pBioPortal, out List<TermCategory> pCategories, out int? pCategoriesCount, out string pCUI, out Reference pEnum, out int? pEnumId, out string pMedDRA, out string pName, out string pRxNorm, out string pSNOWMED, out List<Reference> pSynonyms, out int? pSynonymsCount, out string pTUI, out string pURI)
        {
            pBioPortal = BioPortal;
            pCategories = Categories;
            pCategoriesCount = CategoriesCount;
            pCUI = CUI;
            pEnum = Enum;
            pEnumId = EnumId;
            pMedDRA = MedDRA;
            pName = Name;
            pRxNorm = RxNorm;
            pSNOWMED = SNOWMED;
            pSynonyms = Synonyms;
            pSynonymsCount = SynonymsCount;
            pTUI = TUI;
            pURI = URI;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public TermMasterBase With(int? pId = Id, string pBioPortal = BioPortal, List<TermCategory> pCategories = Categories, int? pCategoriesCount = CategoriesCount, string pCUI = CUI, Reference pEnum = Enum, int? pEnumId = EnumId, string pMedDRA = MedDRA, string pName = Name, string pRxNorm = RxNorm, string pSNOWMED = SNOWMED, List<Reference> pSynonyms = Synonyms, int? pSynonymsCount = SynonymsCount, string pTUI = TUI, string pURI = URI) => 
        //	new TermMasterBase(pId, pBioPortal, pCategories, pCategoriesCount, pCUI, pEnum, pEnumId, pMedDRA, pName, pRxNorm, pSNOWMED, pSynonyms, pSynonymsCount, pTUI, pURI);

    }


    [Route("/termmaster", "POST")]
    [Route("/termmaster/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class TermMaster : TermMasterBase, IReturn<TermMaster>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMaster() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMaster(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMaster(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMaster(int? pId, string pBioPortal, List<TermCategory> pCategories, int? pCategoriesCount, string pCUI, Reference pEnum, int? pEnumId, string pMedDRA, string pName, string pRxNorm, string pSNOWMED, List<Reference> pSynonyms, int? pSynonymsCount, string pTUI, string pURI) :
            base(pId, pBioPortal, pCategories, pCategoriesCount, pCUI, pEnum, pEnumId, pMedDRA, pName, pRxNorm, pSNOWMED, pSynonyms, pSynonymsCount, pTUI, pURI) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<TermMaster>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(BioPortal),nameof(Categories),nameof(CategoriesCount),nameof(Created),nameof(CreatorId),nameof(CUI),nameof(Enum),nameof(EnumId),nameof(Gestalt),nameof(Locked),nameof(MedDRA),nameof(Name),nameof(RxNorm),nameof(SNOWMED),nameof(Synonyms),nameof(SynonymsCount),nameof(TUI),nameof(Updated),nameof(URI),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<TermMaster>("TermMaster",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Categories), nameof(CategoriesCount), nameof(CategoriesIds), nameof(Synonyms), nameof(SynonymsCount), nameof(SynonymsIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<TermMaster>();

    }
    

    [Route("/termmaster/{Id}/copy", "POST")]
    public partial class TermMasterCopy : TermMaster {}

    public partial class TermMasterSearchBase : Search<TermMaster>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public string BioPortal { get; set; }
        public List<string> BioPortals { get; set; }
        public List<int> CategoriesIds { get; set; }
        public string CUI { get; set; }
        public List<string> CUIs { get; set; }
        public Reference Enum { get; set; }
        public List<int> EnumIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"AmPersonCount",@"App",@"ArmPopulationAge",@"ArmPopulationN",@"AssociationMeasure",@"AttributeCategory",@"AttributeType",@"BroadcastStatus",@"BroadcastType",@"ConfidenceInterval",@"Conjunction",@"DatabaseType",@"DataHubSearchCategory",@"DataHubSource",@"DefaultTimeUnit",@"DefaultUnitType",@"Directionality",@"DocumentSetType",@"DocumentType",@"DosageProtocol",@"DosageType",@"EoDStatus",@"EqualityOperator",@"ErrorMessage",@"ExternalKey",@"Feature",@"FieldType",@"FileRights",@"FileSource",@"FileType",@"ForeignKeyStatus",@"FqReferenceStatus",@"Help",@"ImportStatus",@"IncidenceRateType",@"InstitutionType",@"IntegrationName",@"IntegrationPropertyName",@"InterventionLineOfTreatment",@"InterventionMedium",@"InterventionProvider",@"InterventionRoute",@"InterventionSchedule",@"InterventionStageSetting",@"InterventionType",@"Job",@"JunctionType",@"LookupTable",@"LookupType",@"ManualizedTreatment",@"MeanCalculationType",@"MeanRangeType",@"MeanVariableType",@"MeanVarianceType",@"MethodOfAnalysis",@"ModelName",@"OutcomeCategory",@"OutcomeType",@"Permission",@"PopulationType",@"PrevalenceType",@"ProtocolFilterOwner",@"ProtocolFilterType",@"ProtocolType",@"PublicationPoolStudies",@"PubType",@"Question",@"QuestionCategory",@"QuestionType",@"QueueChannel",@"Randomization",@"RangeType",@"Rating",@"ReasonRejected",@"ReconciliationStatus",@"RecruitmentMethod",@"RepresentativeSample",@"ResponsesCollectedBy",@"ResultsCategory",@"RiskOfBiasAssessment",@"Scope",@"SettingType",@"StatisticalSignificance",@"StatisticalTest",@"StatsRecordName",@"Status",@"StratificationType",@"StudyAllocattionMethod",@"StudyBias",@"StudyBlindingMethod",@"StudyCompliance",@"StudyDesign",@"StudyDocumentType",@"StudyFunding",@"StudyGroupType",@"StudyImportLocation",@"StudyImportType",@"StudyNGA",@"StudyObjective",@"StudyPhaseNames",@"StudyPurpose",@"StudyRandomizationMethod",@"StudyType",@"StudyTypeHarmEtiology",@"StudyTypeTherapy",@"StudyYears",@"TaskType",@"TermClassification",@"TermSection",@"TimeCardStatus",@"TimepointType",@"UnitsOfMeasure",@"UnitType",@"UserEmployeeType",@"UserPayrollStatus",@"UserPayrollType",@"UserType",@"ValueStatus",@"ValueType",@"VariableRule",@"VariableType",@"Workflow",@"WorkflowStatus",@"YesNoNa"})]
        public List<string> EnumNames { get; set; }
        public string MedDRA { get; set; }
        public List<string> MedDRAs { get; set; }
        public string Name { get; set; }
        public List<string> Names { get; set; }
        public string RxNorm { get; set; }
        public List<string> RxNorms { get; set; }
        public string SNOWMED { get; set; }
        public List<string> SNOWMEDs { get; set; }
        public List<int> SynonymsIds { get; set; }
        public string TUI { get; set; }
        public List<string> TUIs { get; set; }
        public string URI { get; set; }
        public List<string> URIs { get; set; }
    }


    [Route("/termmaster", "GET")]
    [Route("/termmaster/version", "GET, POST")]
    [Route("/termmaster/search", "GET, POST, DELETE")]

    public partial class TermMasterSearch : TermMasterSearchBase
    {
    }

    public class TermMasterFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMasterFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private TermMasterSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermMasterFullTextSearch(TermMasterSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Updated))); }

        public bool doBioPortal { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.BioPortal))); }
        public bool doCategories { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Categories))); }
        public bool doCUI { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.CUI))); }
        public bool doEnum { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Enum))); }
        public bool doMedDRA { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.MedDRA))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Name))); }
        public bool doRxNorm { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.RxNorm))); }
        public bool doSNOWMED { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.SNOWMED))); }
        public bool doSynonyms { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Synonyms))); }
        public bool doTUI { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.TUI))); }
        public bool doURI { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.URI))); }
    }


    [Route("/termmaster/batch", "DELETE, PATCH, POST, PUT")]

    public partial class TermMasterBatch : List<TermMaster> { }


    [Route("/termmaster/{Id}/{Junction}/version", "GET, POST")]
    [Route("/termmaster/{Id}/{Junction}", "GET, POST, DELETE")]
    public class TermMasterJunction : TermMasterSearchBase {}



}
