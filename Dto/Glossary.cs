
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
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
    public abstract partial class GlossaryBase : Dto<Glossary>
    {
        public GlossaryBase() {}

        public GlossaryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public GlossaryBase(int? id) : this(DocConvert.ToInt(id)) {}

        public GlossaryBase(int? pId, string pDefinition, Reference pEnum, int? pEnumId, string pIcon, Reference pPage, int? pPageId, Reference pTerm, int? pTermId) : this(DocConvert.ToInt(pId)) 
        {
            Definition = pDefinition;
            Enum = pEnum;
            EnumId = pEnumId;
            Icon = pIcon;
            Page = pPage;
            PageId = pPageId;
            Term = pTerm;
            TermId = pTermId;
        }

        [ApiMember(Name = nameof(Definition), Description = "string", IsRequired = false)]
        public string Definition { get; set; }
        public List<int> DefinitionIds { get; set; }
        public int? DefinitionCount { get; set; }


        [ApiMember(Name = nameof(Enum), Description = "LookupTableEnum", IsRequired = true)]
        public Reference Enum { get; set; }
        [ApiMember(Name = nameof(EnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        public int? EnumId { get; set; }


        [ApiMember(Name = nameof(Icon), Description = "string", IsRequired = false)]
        public string Icon { get; set; }
        public List<int> IconIds { get; set; }
        public int? IconCount { get; set; }


        [ApiMember(Name = nameof(Page), Description = "Page", IsRequired = false)]
        public Reference Page { get; set; }
        [ApiMember(Name = nameof(PageId), Description = "Primary Key of Page", IsRequired = false)]
        public int? PageId { get; set; }


        [ApiMember(Name = nameof(Term), Description = "TermMaster", IsRequired = true)]
        public Reference Term { get; set; }
        [ApiMember(Name = nameof(TermId), Description = "Primary Key of TermMaster", IsRequired = false)]
        public int? TermId { get; set; }



        public void Deconstruct(out string pDefinition, out Reference pEnum, out int? pEnumId, out string pIcon, out Reference pPage, out int? pPageId, out Reference pTerm, out int? pTermId)
        {
            pDefinition = Definition;
            pEnum = Enum;
            pEnumId = EnumId;
            pIcon = Icon;
            pPage = Page;
            pPageId = PageId;
            pTerm = Term;
            pTermId = TermId;
        }

        //Not ready until C# v8.?
        //public GlossaryBase With(int? pId = Id, string pDefinition = Definition, Reference pEnum = Enum, int? pEnumId = EnumId, string pIcon = Icon, Reference pPage = Page, int? pPageId = PageId, Reference pTerm = Term, int? pTermId = TermId) => 
        //	new GlossaryBase(pId, pDefinition, pEnum, pEnumId, pIcon, pPage, pPageId, pTerm, pTermId);

    }


    [Route("/glossary", "POST")]
    [Route("/glossary/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Glossary : GlossaryBase, IReturn<Glossary>, IDto, ICloneable
    {
        public Glossary() => _Constructor();

        public Glossary(int? id) : base(DocConvert.ToInt(id)) {}
        public Glossary(int id) : base(id) {}
        public Glossary(int? pId, string pDefinition, Reference pEnum, int? pEnumId, string pIcon, Reference pPage, int? pPageId, Reference pTerm, int? pTermId) :
            base(pId, pDefinition, pEnum, pEnumId, pIcon, pPage, pPageId, pTerm, pTermId) { }

        public static List<string> Fields => DocTools.Fields<Glossary>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Definition),nameof(Enum),nameof(EnumId),nameof(Gestalt),nameof(Icon),nameof(Locked),nameof(Page),nameof(PageId),nameof(Term),nameof(TermId),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Glossary>("Glossary",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        public object Clone() => this.Copy<Glossary>();

    }
    

    [Route("/glossary/{Id}/copy", "POST")]
    public partial class GlossaryCopy : Glossary {}

    public partial class GlossarySearchBase : Search<Glossary>
    {
        public int? Id { get; set; }
        public string Definition { get; set; }
        public Reference Enum { get; set; }
        public List<int> EnumIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"AmPersonCount",@"App",@"ArmPopulationAge",@"ArmPopulationN",@"AssociationMeasure",@"AttributeCategory",@"AttributeType",@"BroadcastStatus",@"BroadcastType",@"ConfidenceInterval",@"Conjunction",@"DatabaseType",@"DataHubSearchCategory",@"DataHubSource",@"DefaultTimeUnit",@"DefaultUnitType",@"Directionality",@"DocumentSetType",@"DocumentType",@"DosageProtocol",@"DosageType",@"EoDStatus",@"EqualityOperator",@"ErrorMessage",@"ExternalKey",@"Feature",@"FieldType",@"FileRights",@"FileSource",@"FileType",@"ForeignKeyStatus",@"FqReferenceStatus",@"Help",@"ImportStatus",@"IncidenceRateType",@"InstitutionType",@"IntegrationName",@"IntegrationPropertyName",@"InterventionLineOfTreatment",@"InterventionMedium",@"InterventionProvider",@"InterventionRoute",@"InterventionSchedule",@"InterventionStageSetting",@"InterventionType",@"Job",@"JunctionType",@"LookupTable",@"LookupType",@"ManualizedTreatment",@"MeanCalculationType",@"MeanRangeType",@"MeanVariableType",@"MeanVarianceType",@"MethodOfAnalysis",@"ModelName",@"OutcomeCategory",@"OutcomeType",@"Permission",@"PopulationType",@"PrevalenceType",@"ProtocolFilterOwner",@"ProtocolFilterType",@"ProtocolType",@"PublicationPoolStudies",@"PubType",@"Question",@"QuestionCategory",@"QuestionType",@"QueueChannel",@"Randomization",@"RangeType",@"Rating",@"ReasonRejected",@"ReconciliationStatus",@"RecruitmentMethod",@"RepresentativeSample",@"ResponsesCollectedBy",@"ResultsCategory",@"RiskOfBiasAssessment",@"Scope",@"SettingType",@"StatisticalSignificance",@"StatisticalTest",@"StatsRecordName",@"Status",@"StratificationType",@"StudyAllocattionMethod",@"StudyBias",@"StudyBlindingMethod",@"StudyCompliance",@"StudyDesign",@"StudyDocumentType",@"StudyFunding",@"StudyGroupType",@"StudyImportLocation",@"StudyImportType",@"StudyNGA",@"StudyObjective",@"StudyPhaseNames",@"StudyPurpose",@"StudyRandomizationMethod",@"StudyType",@"StudyTypeHarmEtiology",@"StudyTypeTherapy",@"StudyYears",@"TaskType",@"TermClassification",@"TermSection",@"TimeCardStatus",@"TimepointType",@"UnitsOfMeasure",@"UnitType",@"UserEmployeeType",@"UserPayrollStatus",@"UserPayrollType",@"UserType",@"ValueStatus",@"ValueType",@"VariableRule",@"VariableType",@"Workflow",@"WorkflowStatus",@"YesNoNa"})]
        public List<string> EnumNames { get; set; }
        public string Icon { get; set; }
        public Reference Page { get; set; }
        public List<int> PageIds { get; set; }
        public Reference Term { get; set; }
        public List<int> TermIds { get; set; }
    }


    [Route("/glossary", "GET")]
    [Route("/glossary/version", "GET, POST")]
    [Route("/glossary/search", "GET, POST, DELETE")]

    public partial class GlossarySearch : GlossarySearchBase
    {
    }

    public class GlossaryFullTextSearch
    {
        public GlossaryFullTextSearch() {}
        private GlossarySearch _request;
        public GlossaryFullTextSearch(GlossarySearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Updated))); }

        public bool doDefinition { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Definition))); }
        public bool doEnum { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Enum))); }
        public bool doIcon { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Icon))); }
        public bool doPage { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Page))); }
        public bool doTerm { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Term))); }
    }


    [Route("/glossary/batch", "DELETE, PATCH, POST, PUT")]

    public partial class GlossaryBatch : List<Glossary> { }


}
