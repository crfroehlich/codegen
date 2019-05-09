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
    public abstract partial class LookupTableBase : Dto<LookupTable>
    {
        public LookupTableBase() {}

        public LookupTableBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public LookupTableBase(int? id) : this(DocConvert.ToInt(id)) {}

        public LookupTableBase(int? pId, List<Reference> pBindings, int? pBindingsCount, List<Reference> pCategories, int? pCategoriesCount, List<Reference> pDocuments, int? pDocumentsCount, Reference pEnum, int? pEnumId, string pName) : this(DocConvert.ToInt(pId)) 
        {
            Bindings = pBindings;
            BindingsCount = pBindingsCount;
            Categories = pCategories;
            CategoriesCount = pCategoriesCount;
            Documents = pDocuments;
            DocumentsCount = pDocumentsCount;
            Enum = pEnum;
            EnumId = pEnumId;
            Name = pName;
        }

        [ApiMember(Name = nameof(Bindings), Description = "LookupTableBinding", IsRequired = false)]
        public List<Reference> Bindings { get; set; }
        public int? BindingsCount { get; set; }


        [ApiMember(Name = nameof(Categories), Description = "LookupCategory", IsRequired = false)]
        public List<Reference> Categories { get; set; }
        public int? CategoriesCount { get; set; }


        [ApiMember(Name = nameof(Documents), Description = "Document", IsRequired = false)]
        public List<Reference> Documents { get; set; }
        public int? DocumentsCount { get; set; }


        [ApiMember(Name = nameof(Enum), Description = "LookupTableEnum", IsRequired = true)]
        public Reference Enum { get; set; }
        [ApiMember(Name = nameof(EnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        public int? EnumId { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }



        public void Deconstruct(out List<Reference> pBindings, out int? pBindingsCount, out List<Reference> pCategories, out int? pCategoriesCount, out List<Reference> pDocuments, out int? pDocumentsCount, out Reference pEnum, out int? pEnumId, out string pName)
        {
            pBindings = Bindings;
            pBindingsCount = BindingsCount;
            pCategories = Categories;
            pCategoriesCount = CategoriesCount;
            pDocuments = Documents;
            pDocumentsCount = DocumentsCount;
            pEnum = Enum;
            pEnumId = EnumId;
            pName = Name;
        }

        //Not ready until C# v8.?
        //public LookupTableBase With(int? pId = Id, List<Reference> pBindings = Bindings, int? pBindingsCount = BindingsCount, List<Reference> pCategories = Categories, int? pCategoriesCount = CategoriesCount, List<Reference> pDocuments = Documents, int? pDocumentsCount = DocumentsCount, Reference pEnum = Enum, int? pEnumId = EnumId, string pName = Name) => 
        //	new LookupTableBase(pId, pBindings, pBindingsCount, pCategories, pCategoriesCount, pDocuments, pDocumentsCount, pEnum, pEnumId, pName);

    }

    [Route("/lookuptable", "POST")]
    [Route("/lookuptable/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class LookupTable : LookupTableBase, IReturn<LookupTable>, IDto, ICloneable
    {
        public LookupTable()
        {
            _Constructor();
        }

        public LookupTable(int? id) : base(DocConvert.ToInt(id)) {}
        public LookupTable(int id) : base(id) {}
        public LookupTable(int? pId, List<Reference> pBindings, int? pBindingsCount, List<Reference> pCategories, int? pCategoriesCount, List<Reference> pDocuments, int? pDocumentsCount, Reference pEnum, int? pEnumId, string pName) : 
            base(pId, pBindings, pBindingsCount, pCategories, pCategoriesCount, pDocuments, pDocumentsCount, pEnum, pEnumId, pName) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<LookupTable>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Bindings),nameof(BindingsCount),nameof(Categories),nameof(CategoriesCount),nameof(Created),nameof(CreatorId),nameof(Documents),nameof(DocumentsCount),nameof(Enum),nameof(EnumId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Updated),nameof(VersionNo)})]
        public new List<string> Select
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

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Bindings), nameof(BindingsCount), nameof(Categories), nameof(CategoriesCount), nameof(Documents), nameof(DocumentsCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<LookupTable>();
    }
    
    [Route("/lookuptable/{Id}/copy", "POST")]
    public partial class LookupTableCopy : LookupTable {}
    public partial class LookupTableSearchBase : Search<LookupTable>
    {
        public int? Id { get; set; }
        public List<int> BindingsIds { get; set; }
        public List<int> CategoriesIds { get; set; }
        public List<int> DocumentsIds { get; set; }
        public Reference Enum { get; set; }
        public List<int> EnumIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"AmPersonCount",@"App",@"ArmPopulationAge",@"ArmPopulationN",@"AssociationMeasure",@"AttributeCategory",@"AttributeType",@"BroadcastStatus",@"BroadcastType",@"ConfidenceInterval",@"Conjunction",@"DatabaseType",@"DataHubSearchCategory",@"DataHubSource",@"DefaultTimeUnit",@"DefaultUnitType",@"Directionality",@"DocumentSetType",@"DocumentType",@"DosageProtocol",@"DosageType",@"EoDStatus",@"EqualityOperator",@"ErrorMessage",@"ExternalKey",@"Feature",@"FieldType",@"ForeignKeyStatus",@"FqReferenceStatus",@"Help",@"ImportStatus",@"IncidenceRateType",@"InstitutionType",@"IntegrationName",@"IntegrationPropertyName",@"InterventionLineOfTreatment",@"InterventionMedium",@"InterventionProvider",@"InterventionRoute",@"InterventionSchedule",@"InterventionStageSetting",@"InterventionType",@"Job",@"JunctionType",@"LookupTable",@"LookupType",@"ManualizedTreatment",@"MeanCalculationType",@"MeanRangeType",@"MeanVariableType",@"MeanVarianceType",@"MethodOfAnalysis",@"ModelName",@"OutcomeCategory",@"OutcomeType",@"Permission",@"PopulationType",@"PrevalenceType",@"ProtocolFilterOwner",@"ProtocolFilterType",@"ProtocolType",@"PublicationPoolStudies",@"PubType",@"Question",@"QuestionCategory",@"QuestionType",@"QueueChannel",@"Randomization",@"RangeType",@"Rating",@"ReasonRejected",@"RecruitmentMethod",@"RepresentativeSample",@"ResponsesCollectedBy",@"ResultsCategory",@"RiskOfBiasAssessment",@"Scope",@"SettingType",@"StatisticalSignificance",@"StatisticalTest",@"StatsRecordName",@"Status",@"StratificationType",@"StudyAllocattionMethod",@"StudyBias",@"StudyBlindingMethod",@"StudyCompliance",@"StudyDesign",@"StudyDocumentType",@"StudyFunding",@"StudyGroupType",@"StudyImportLocation",@"StudyImportType",@"StudyNGA",@"StudyObjective",@"StudyPhaseNames",@"StudyPurpose",@"StudyRandomizationMethod",@"StudyType",@"StudyTypeHarmEtiology",@"StudyTypeTherapy",@"StudyYears",@"TaskType",@"TermClassification",@"TermSection",@"TimeCardStatus",@"TimepointType",@"UnitsOfMeasure",@"UnitType",@"UserEmployeeType",@"UserPayrollStatus",@"UserPayrollType",@"UserType",@"ValueStatus",@"ValueType",@"VariableRule",@"VariableType",@"Workflow",@"WorkflowStatus",@"YesNoNa"})]
        public List<string> EnumNames { get; set; }
        public string Name { get; set; }
    }

    [Route("/lookuptable", "GET")]
    [Route("/lookuptable/version", "GET, POST")]
    [Route("/lookuptable/search", "GET, POST, DELETE")]
    public partial class LookupTableSearch : LookupTableSearchBase
    {
    }

    public class LookupTableFullTextSearch
    {
        public LookupTableFullTextSearch() {}
        private LookupTableSearch _request;
        public LookupTableFullTextSearch(LookupTableSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Updated))); }

        public bool doBindings { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Bindings))); }
        public bool doCategories { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Categories))); }
        public bool doDocuments { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Documents))); }
        public bool doEnum { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Enum))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Name))); }
    }

    [Route("/lookuptable/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LookupTableBatch : List<LookupTable> { }

    [Route("/lookuptable/{Id}/{Junction}/version", "GET, POST")]
    [Route("/lookuptable/{Id}/{Junction}", "GET, POST, DELETE")]
    public class LookupTableJunction : LookupTableSearchBase {}


}
