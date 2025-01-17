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
    public abstract partial class DataClassBase : Dto<DataClass>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClassBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClassBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClassBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClassBase(int? pId, bool pAllowDelete, bool pAllSelectByDefault, ModelNameEnm? pBase, int? pCacheDuration, int? pClassId, List<Reference> pCustomCollections, int? pCustomCollectionsCount, bool pDELETE, string pDescription, List<Reference> pDontFlattenProperties, int? pDontFlattenPropertiesCount, string pDtoSuffix, bool pFlattenReferences, bool pGET, List<Reference> pIgnoreProps, int? pIgnorePropsCount, bool pIsInsertOnly, bool pIsReadOnly, string pName, bool pPATCH, bool pPOST, List<DataProperty> pProperties, int? pPropertiesCount, bool pPUT, List<DataTab> pTabs, int? pTabsCount) : this(DocConvert.ToInt(pId)) 
        {
            AllowDelete = pAllowDelete;
            AllSelectByDefault = pAllSelectByDefault;
            Base = pBase;
            CacheDuration = pCacheDuration;
            ClassId = pClassId;
            CustomCollections = pCustomCollections;
            CustomCollectionsCount = pCustomCollectionsCount;
            DELETE = pDELETE;
            Description = pDescription;
            DontFlattenProperties = pDontFlattenProperties;
            DontFlattenPropertiesCount = pDontFlattenPropertiesCount;
            DtoSuffix = pDtoSuffix;
            FlattenReferences = pFlattenReferences;
            GET = pGET;
            IgnoreProps = pIgnoreProps;
            IgnorePropsCount = pIgnorePropsCount;
            IsInsertOnly = pIsInsertOnly;
            IsReadOnly = pIsReadOnly;
            Name = pName;
            PATCH = pPATCH;
            POST = pPOST;
            Properties = pProperties;
            PropertiesCount = pPropertiesCount;
            PUT = pPUT;
            Tabs = pTabs;
            TabsCount = pTabsCount;
        }

        [ApiMember(Name = nameof(AllowDelete), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool AllowDelete { get; set; }


        [ApiMember(Name = nameof(AllSelectByDefault), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool AllSelectByDefault { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"AdjudicatedRating",@"App",@"Attribute",@"AttributeInterval",@"AuditDelta",@"AuditRecord",@"BackgroundTask",@"BackgroundTaskHistory",@"BackgroundTaskItem",@"Broadcast",@"Client",@"Comment",@"DatabaseVersion",@"DataClass",@"DataProperty",@"DataSet",@"DataTab",@"DateTime",@"Default",@"DiseaseStateSet",@"Division",@"Document",@"DocumentSet",@"DocumentSetHistory",@"Entities",@"EoD",@"Event",@"Favorite",@"FeatureSet",@"File",@"Glossary",@"Help",@"History",@"Impersonation",@"ImportData",@"Interval",@"Junction",@"LibrarySet",@"Locale",@"LocaleLookup",@"LookupCategory",@"LookupTable",@"LookupTableBinding",@"LookupTableEnum",@"MeanRanges",@"MeanRangeValue",@"MeanVariances",@"MeanVarianceValue",@"Page",@"Project",@"QueueChannel",@"Rating",@"ReconcileDocument",@"Role",@"Scope",@"ServePortalSet",@"Stats",@"StatsRecord",@"StatsStudySet",@"StudyDesign",@"StudyType",@"Tag",@"Task",@"Team",@"TermCategory",@"TermMaster",@"TermSynonym",@"TherapeuticAreaSet",@"TimeCard",@"TimePoint",@"Trial",@"UnitConversionRules",@"UnitOfMeasure",@"Units",@"UnitValue",@"Update",@"User",@"UserRequest",@"UserSession",@"UserType",@"ValueType",@"VariableInstance",@"VariableRule",@"Workflow"})]
        [ApiMember(Name = nameof(Base), Description = "ModelNameEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ModelNameEnm? Base { get; set; }


        [ApiMember(Name = nameof(CacheDuration), Description = "int?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? CacheDuration { get; set; }


        [ApiMember(Name = nameof(ClassId), Description = "int?", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ClassId { get; set; }


        [ApiMember(Name = nameof(CustomCollections), Description = "DataProperty", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> CustomCollections { get; set; }
        [ApiMember(Name = nameof(CustomCollectionsIds), Description = "DataProperty Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> CustomCollectionsIds { get; set; }
        [ApiMember(Name = nameof(CustomCollectionsCount), Description = "DataProperty Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? CustomCollectionsCount { get; set; }


        [ApiMember(Name = nameof(DELETE), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool DELETE { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Description { get; set; }


        [ApiMember(Name = nameof(DontFlattenProperties), Description = "DataProperty", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> DontFlattenProperties { get; set; }
        [ApiMember(Name = nameof(DontFlattenPropertiesIds), Description = "DataProperty Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DontFlattenPropertiesIds { get; set; }
        [ApiMember(Name = nameof(DontFlattenPropertiesCount), Description = "DataProperty Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DontFlattenPropertiesCount { get; set; }


        [ApiMember(Name = nameof(DtoSuffix), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string DtoSuffix { get; set; }


        [ApiMember(Name = nameof(FlattenReferences), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool FlattenReferences { get; set; }


        [ApiMember(Name = nameof(GET), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool GET { get; set; }


        [ApiMember(Name = nameof(IgnoreProps), Description = "DataProperty", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> IgnoreProps { get; set; }
        [ApiMember(Name = nameof(IgnorePropsIds), Description = "DataProperty Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> IgnorePropsIds { get; set; }
        [ApiMember(Name = nameof(IgnorePropsCount), Description = "DataProperty Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? IgnorePropsCount { get; set; }


        [ApiMember(Name = nameof(IsInsertOnly), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool IsInsertOnly { get; set; }


        [ApiMember(Name = nameof(IsReadOnly), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool IsReadOnly { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Name { get; set; }


        [ApiMember(Name = nameof(PATCH), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool PATCH { get; set; }


        [ApiMember(Name = nameof(POST), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool POST { get; set; }


        [ApiMember(Name = nameof(Properties), Description = "DataProperty", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<DataProperty> Properties { get; set; }
        [ApiMember(Name = nameof(PropertiesIds), Description = "DataProperty Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> PropertiesIds { get; set; }
        [ApiMember(Name = nameof(PropertiesCount), Description = "DataProperty Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? PropertiesCount { get; set; }


        [ApiMember(Name = nameof(PUT), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool PUT { get; set; }


        [ApiMember(Name = nameof(Tabs), Description = "DataTab", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<DataTab> Tabs { get; set; }
        [ApiMember(Name = nameof(TabsIds), Description = "DataTab Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> TabsIds { get; set; }
        [ApiMember(Name = nameof(TabsCount), Description = "DataTab Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? TabsCount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out bool pAllowDelete, out bool pAllSelectByDefault, out ModelNameEnm? pBase, out int? pCacheDuration, out int? pClassId, out List<Reference> pCustomCollections, out int? pCustomCollectionsCount, out bool pDELETE, out string pDescription, out List<Reference> pDontFlattenProperties, out int? pDontFlattenPropertiesCount, out string pDtoSuffix, out bool pFlattenReferences, out bool pGET, out List<Reference> pIgnoreProps, out int? pIgnorePropsCount, out bool pIsInsertOnly, out bool pIsReadOnly, out string pName, out bool pPATCH, out bool pPOST, out List<DataProperty> pProperties, out int? pPropertiesCount, out bool pPUT, out List<DataTab> pTabs, out int? pTabsCount)
        {
            pAllowDelete = AllowDelete;
            pAllSelectByDefault = AllSelectByDefault;
            pBase = Base;
            pCacheDuration = CacheDuration;
            pClassId = ClassId;
            pCustomCollections = CustomCollections;
            pCustomCollectionsCount = CustomCollectionsCount;
            pDELETE = DELETE;
            pDescription = Description;
            pDontFlattenProperties = DontFlattenProperties;
            pDontFlattenPropertiesCount = DontFlattenPropertiesCount;
            pDtoSuffix = DtoSuffix;
            pFlattenReferences = FlattenReferences;
            pGET = GET;
            pIgnoreProps = IgnoreProps;
            pIgnorePropsCount = IgnorePropsCount;
            pIsInsertOnly = IsInsertOnly;
            pIsReadOnly = IsReadOnly;
            pName = Name;
            pPATCH = PATCH;
            pPOST = POST;
            pProperties = Properties;
            pPropertiesCount = PropertiesCount;
            pPUT = PUT;
            pTabs = Tabs;
            pTabsCount = TabsCount;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public DataClassBase With(int? pId = Id, bool pAllowDelete = AllowDelete, bool pAllSelectByDefault = AllSelectByDefault, ModelNameEnm? pBase = Base, int? pCacheDuration = CacheDuration, int? pClassId = ClassId, List<Reference> pCustomCollections = CustomCollections, int? pCustomCollectionsCount = CustomCollectionsCount, bool pDELETE = DELETE, string pDescription = Description, List<Reference> pDontFlattenProperties = DontFlattenProperties, int? pDontFlattenPropertiesCount = DontFlattenPropertiesCount, string pDtoSuffix = DtoSuffix, bool pFlattenReferences = FlattenReferences, bool pGET = GET, List<Reference> pIgnoreProps = IgnoreProps, int? pIgnorePropsCount = IgnorePropsCount, bool pIsInsertOnly = IsInsertOnly, bool pIsReadOnly = IsReadOnly, string pName = Name, bool pPATCH = PATCH, bool pPOST = POST, List<DataProperty> pProperties = Properties, int? pPropertiesCount = PropertiesCount, bool pPUT = PUT, List<DataTab> pTabs = Tabs, int? pTabsCount = TabsCount) => 
        //	new DataClassBase(pId, pAllowDelete, pAllSelectByDefault, pBase, pCacheDuration, pClassId, pCustomCollections, pCustomCollectionsCount, pDELETE, pDescription, pDontFlattenProperties, pDontFlattenPropertiesCount, pDtoSuffix, pFlattenReferences, pGET, pIgnoreProps, pIgnorePropsCount, pIsInsertOnly, pIsReadOnly, pName, pPATCH, pPOST, pProperties, pPropertiesCount, pPUT, pTabs, pTabsCount);

    }


    [Route("/dataclass/{Id}", "GET, PATCH, PUT")]

    public partial class DataClass : DataClassBase, IReturn<DataClass>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClass() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClass(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClass(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClass(int? pId, bool pAllowDelete, bool pAllSelectByDefault, ModelNameEnm? pBase, int? pCacheDuration, int? pClassId, List<Reference> pCustomCollections, int? pCustomCollectionsCount, bool pDELETE, string pDescription, List<Reference> pDontFlattenProperties, int? pDontFlattenPropertiesCount, string pDtoSuffix, bool pFlattenReferences, bool pGET, List<Reference> pIgnoreProps, int? pIgnorePropsCount, bool pIsInsertOnly, bool pIsReadOnly, string pName, bool pPATCH, bool pPOST, List<DataProperty> pProperties, int? pPropertiesCount, bool pPUT, List<DataTab> pTabs, int? pTabsCount) :
            base(pId, pAllowDelete, pAllSelectByDefault, pBase, pCacheDuration, pClassId, pCustomCollections, pCustomCollectionsCount, pDELETE, pDescription, pDontFlattenProperties, pDontFlattenPropertiesCount, pDtoSuffix, pFlattenReferences, pGET, pIgnoreProps, pIgnorePropsCount, pIsInsertOnly, pIsReadOnly, pName, pPATCH, pPOST, pProperties, pPropertiesCount, pPUT, pTabs, pTabsCount) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<DataClass>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AllowDelete),nameof(AllSelectByDefault),nameof(Base),nameof(CacheDuration),nameof(ClassId),nameof(Created),nameof(CreatorId),nameof(CustomCollections),nameof(CustomCollectionsCount),nameof(DELETE),nameof(Description),nameof(DontFlattenProperties),nameof(DontFlattenPropertiesCount),nameof(DtoSuffix),nameof(FlattenReferences),nameof(Gestalt),nameof(GET),nameof(IgnoreProps),nameof(IgnorePropsCount),nameof(IsInsertOnly),nameof(IsReadOnly),nameof(Locked),nameof(Name),nameof(PATCH),nameof(POST),nameof(Properties),nameof(PropertiesCount),nameof(PUT),nameof(Tabs),nameof(TabsCount),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<DataClass>("DataClass",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(CustomCollections), nameof(CustomCollectionsCount), nameof(CustomCollectionsIds), nameof(DontFlattenProperties), nameof(DontFlattenPropertiesCount), nameof(DontFlattenPropertiesIds), nameof(IgnoreProps), nameof(IgnorePropsCount), nameof(IgnorePropsIds), nameof(Properties), nameof(PropertiesCount), nameof(PropertiesIds), nameof(Tabs), nameof(TabsCount), nameof(TabsIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<DataClass>();

    }
    

    public partial class DataClassSearchBase : Search<DataClass>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> AllowDelete { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> AllSelectByDefault { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"AdjudicatedRating",@"App",@"Attribute",@"AttributeInterval",@"AuditDelta",@"AuditRecord",@"BackgroundTask",@"BackgroundTaskHistory",@"BackgroundTaskItem",@"Broadcast",@"Client",@"Comment",@"DatabaseVersion",@"DataClass",@"DataProperty",@"DataSet",@"DataTab",@"DateTime",@"Default",@"DiseaseStateSet",@"Division",@"Document",@"DocumentSet",@"DocumentSetHistory",@"Entities",@"EoD",@"Event",@"Favorite",@"FeatureSet",@"File",@"Glossary",@"Help",@"History",@"Impersonation",@"ImportData",@"Interval",@"Junction",@"LibrarySet",@"Locale",@"LocaleLookup",@"LookupCategory",@"LookupTable",@"LookupTableBinding",@"LookupTableEnum",@"MeanRanges",@"MeanRangeValue",@"MeanVariances",@"MeanVarianceValue",@"Page",@"Project",@"QueueChannel",@"Rating",@"ReconcileDocument",@"Role",@"Scope",@"ServePortalSet",@"Stats",@"StatsRecord",@"StatsStudySet",@"StudyDesign",@"StudyType",@"Tag",@"Task",@"Team",@"TermCategory",@"TermMaster",@"TermSynonym",@"TherapeuticAreaSet",@"TimeCard",@"TimePoint",@"Trial",@"UnitConversionRules",@"UnitOfMeasure",@"Units",@"UnitValue",@"Update",@"User",@"UserRequest",@"UserSession",@"UserType",@"ValueType",@"VariableInstance",@"VariableRule",@"Workflow"})]
        public ModelNameEnm? Base { get; set; }
        public List<ModelNameEnm?> Bases { get; set; }
        public int? CacheDuration { get; set; }
        public int? ClassId { get; set; }
        public List<int> CustomCollectionsIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> DELETE { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
        public List<int> DontFlattenPropertiesIds { get; set; }
        public string DtoSuffix { get; set; }
        public List<string> DtoSuffixs { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> FlattenReferences { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> GET { get; set; }
        public List<int> IgnorePropsIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsInsertOnly { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsReadOnly { get; set; }
        public string Name { get; set; }
        public List<string> Names { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> PATCH { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> POST { get; set; }
        public List<int> PropertiesIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> PUT { get; set; }
        public List<int> TabsIds { get; set; }
    }


    [Route("/dataclass", "GET")]
    [Route("/dataclass/version", "GET, POST")]
    [Route("/dataclass/search", "GET, POST, DELETE")]

    public partial class DataClassSearch : DataClassSearchBase
    {
    }

    public class DataClassFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClassFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DataClassSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DataClassFullTextSearch(DataClassSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Updated))); }

        public bool doAllowDelete { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.AllowDelete))); }
        public bool doAllSelectByDefault { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.AllSelectByDefault))); }
        public bool doBase { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Base))); }
        public bool doCacheDuration { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.CacheDuration))); }
        public bool doClassId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.ClassId))); }
        public bool doCustomCollections { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.CustomCollections))); }
        public bool doDELETE { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.DELETE))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Description))); }
        public bool doDontFlattenProperties { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.DontFlattenProperties))); }
        public bool doDtoSuffix { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.DtoSuffix))); }
        public bool doFlattenReferences { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.FlattenReferences))); }
        public bool doGET { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.GET))); }
        public bool doIgnoreProps { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.IgnoreProps))); }
        public bool doIsInsertOnly { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.IsInsertOnly))); }
        public bool doIsReadOnly { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.IsReadOnly))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Name))); }
        public bool doPATCH { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.PATCH))); }
        public bool doPOST { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.POST))); }
        public bool doProperties { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Properties))); }
        public bool doPUT { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.PUT))); }
        public bool doTabs { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Tabs))); }
    }


    [Route("/dataclass/batch", "DELETE, PATCH, POST, PUT")]

    public partial class DataClassBatch : List<DataClass> { }


    [Route("/dataclass/{Id}/{Junction}/version", "GET, POST")]
    [Route("/dataclass/{Id}/{Junction}", "GET, POST, DELETE")]
    public class DataClassJunction : DataClassSearchBase {}



}
