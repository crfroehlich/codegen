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
    public abstract partial class LookupCategoryBase : Dto<LookupCategory>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategoryBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategoryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategoryBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategoryBase(int? pId, string pCategory, Reference pEnum, int? pEnumId, List<Reference> pLookups, int? pLookupsCount, Reference pParentCategory, int? pParentCategoryId) : this(DocConvert.ToInt(pId)) 
        {
            Category = pCategory;
            Enum = pEnum;
            EnumId = pEnumId;
            Lookups = pLookups;
            LookupsCount = pLookupsCount;
            ParentCategory = pParentCategory;
            ParentCategoryId = pParentCategoryId;
        }

        [ApiMember(Name = nameof(Category), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Category { get; set; }


        [ApiMember(Name = nameof(Enum), Description = "LookupTableEnum", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Enum { get; set; }
        [ApiMember(Name = nameof(EnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? EnumId { get; set; }


        [ApiMember(Name = nameof(Lookups), Description = "LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Lookups { get; set; }
        [ApiMember(Name = nameof(LookupsIds), Description = "LookupTable Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> LookupsIds { get; set; }
        [ApiMember(Name = nameof(LookupsCount), Description = "LookupTable Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? LookupsCount { get; set; }


        [ApiMember(Name = nameof(ParentCategory), Description = "LookupCategory", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference ParentCategory { get; set; }
        [ApiMember(Name = nameof(ParentCategoryId), Description = "Primary Key of LookupCategory", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ParentCategoryId { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out string pCategory, out Reference pEnum, out int? pEnumId, out List<Reference> pLookups, out int? pLookupsCount, out Reference pParentCategory, out int? pParentCategoryId)
        {
            pCategory = Category;
            pEnum = Enum;
            pEnumId = EnumId;
            pLookups = Lookups;
            pLookupsCount = LookupsCount;
            pParentCategory = ParentCategory;
            pParentCategoryId = ParentCategoryId;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public LookupCategoryBase With(int? pId = Id, string pCategory = Category, Reference pEnum = Enum, int? pEnumId = EnumId, List<Reference> pLookups = Lookups, int? pLookupsCount = LookupsCount, Reference pParentCategory = ParentCategory, int? pParentCategoryId = ParentCategoryId) => 
        //	new LookupCategoryBase(pId, pCategory, pEnum, pEnumId, pLookups, pLookupsCount, pParentCategory, pParentCategoryId);

    }


    [Route("/lookupcategory", "POST")]
    [Route("/lookupcategory/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class LookupCategory : LookupCategoryBase, IReturn<LookupCategory>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategory() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategory(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategory(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategory(int? pId, string pCategory, Reference pEnum, int? pEnumId, List<Reference> pLookups, int? pLookupsCount, Reference pParentCategory, int? pParentCategoryId) :
            base(pId, pCategory, pEnum, pEnumId, pLookups, pLookupsCount, pParentCategory, pParentCategoryId) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<LookupCategory>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Category),nameof(Created),nameof(CreatorId),nameof(Enum),nameof(EnumId),nameof(Gestalt),nameof(Locked),nameof(Lookups),nameof(LookupsCount),nameof(ParentCategory),nameof(ParentCategoryId),nameof(Updated),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocPermissionFactory.RemoveNonEssentialFields(Fields);

                }
                return _Select;
            }
            set
            {

                _Select = Fields;

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Lookups), nameof(LookupsCount), nameof(LookupsIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<LookupCategory>();

    }
    

    [Route("/lookupcategory/{Id}/copy", "POST")]
    public partial class LookupCategoryCopy : LookupCategory {}

    public partial class LookupCategorySearchBase : Search<LookupCategory>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public string Category { get; set; }
        public List<string> Categorys { get; set; }
        public Reference Enum { get; set; }
        public List<int> EnumIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"AmPersonCount",@"App",@"ArmPopulationAge",@"ArmPopulationN",@"AssociationMeasure",@"AttributeCategory",@"AttributeType",@"BroadcastStatus",@"BroadcastType",@"ConfidenceInterval",@"Conjunction",@"DatabaseType",@"DataHubSearchCategory",@"DataHubSource",@"DefaultTimeUnit",@"DefaultUnitType",@"Directionality",@"DocumentSetType",@"DocumentType",@"DosageProtocol",@"DosageType",@"EoDStatus",@"EqualityOperator",@"ErrorMessage",@"ExternalKey",@"Feature",@"FieldType",@"FileRights",@"FileSource",@"FileType",@"ForeignKeyStatus",@"FqReferenceStatus",@"Help",@"ImportStatus",@"IncidenceRateType",@"InstitutionType",@"IntegrationName",@"IntegrationPropertyName",@"InterventionLineOfTreatment",@"InterventionMedium",@"InterventionProvider",@"InterventionRoute",@"InterventionSchedule",@"InterventionStageSetting",@"InterventionType",@"Job",@"JunctionType",@"LookupTable",@"LookupType",@"ManualizedTreatment",@"MeanCalculationType",@"MeanRangeType",@"MeanVariableType",@"MeanVarianceType",@"MethodOfAnalysis",@"ModelName",@"OutcomeCategory",@"OutcomeType",@"Permission",@"PopulationType",@"PrevalenceType",@"ProtocolFilterOwner",@"ProtocolFilterType",@"ProtocolType",@"PublicationPoolStudies",@"PubType",@"Question",@"QuestionCategory",@"QuestionType",@"QueueChannel",@"Randomization",@"RangeType",@"Rating",@"ReasonRejected",@"ReconciliationStatus",@"RecruitmentMethod",@"RepresentativeSample",@"ResponsesCollectedBy",@"ResultsCategory",@"RiskOfBiasAssessment",@"Scope",@"SettingType",@"StatisticalSignificance",@"StatisticalTest",@"StatsRecordName",@"Status",@"StratificationType",@"StudyAllocattionMethod",@"StudyBias",@"StudyBlindingMethod",@"StudyCompliance",@"StudyDesign",@"StudyDocumentType",@"StudyFunding",@"StudyGroupType",@"StudyImportLocation",@"StudyImportType",@"StudyNGA",@"StudyObjective",@"StudyPhaseNames",@"StudyPurpose",@"StudyRandomizationMethod",@"StudyType",@"StudyTypeHarmEtiology",@"StudyTypeTherapy",@"StudyYears",@"TaskType",@"TermClassification",@"TermSection",@"TimeCardStatus",@"TimepointType",@"UnitsOfMeasure",@"UnitType",@"UserEmployeeType",@"UserPayrollStatus",@"UserPayrollType",@"UserType",@"ValueStatus",@"ValueType",@"VariableRule",@"VariableType",@"Workflow",@"WorkflowStatus",@"YesNoNa"})]
        public List<string> EnumNames { get; set; }
        public List<int> LookupsIds { get; set; }
        public Reference ParentCategory { get; set; }
        public List<int> ParentCategoryIds { get; set; }
    }


    [Route("/lookupcategory", "GET")]
    [Route("/lookupcategory/version", "GET, POST")]
    [Route("/lookupcategory/search", "GET, POST, DELETE")]

    public partial class LookupCategorySearch : LookupCategorySearchBase
    {
    }

    public class LookupCategoryFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategoryFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private LookupCategorySearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupCategoryFullTextSearch(LookupCategorySearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Updated))); }

        public bool doCategory { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Category))); }
        public bool doEnum { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Enum))); }
        public bool doLookups { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Lookups))); }
        public bool doParentCategory { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.ParentCategory))); }
    }


    [Route("/lookupcategory/batch", "DELETE, PATCH, POST, PUT")]

    public partial class LookupCategoryBatch : List<LookupCategory> { }


    [Route("/lookupcategory/{Id}/{Junction}/version", "GET, POST")]
    [Route("/lookupcategory/{Id}/{Junction}", "GET, POST, DELETE")]
    public class LookupCategoryJunction : LookupCategorySearchBase {}



}
