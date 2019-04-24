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
    public abstract partial class DataClassBase : Dto<DataClass>
    {
        public DataClassBase() {}

        public DataClassBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DataClassBase(int? id) : this(DocConvert.ToInt(id)) {}

        public DataClassBase(int? pId, bool pAllowDelete, bool pAllVisibleFieldsByDefault, int? pCacheDuration, int? pClassId, List<Reference> pCustomCollections, int? pCustomCollectionsCount, bool pDELETE, string pDescription, List<Reference> pDontFlattenProperties, int? pDontFlattenPropertiesCount, string pDtoSuffix, bool pFlattenReferences, bool pGET, List<Reference> pIgnoreProps, int? pIgnorePropsCount, bool pIsInsertOnly, bool pIsReadOnly, string pName, bool pPATCH, bool pPOST, List<DataProperty> pProperties, int? pPropertiesCount, bool pPUT, List<DataTab> pTabs, int? pTabsCount) : this(DocConvert.ToInt(pId)) 
        {
            AllowDelete = pAllowDelete;
            AllVisibleFieldsByDefault = pAllVisibleFieldsByDefault;
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
        public bool AllowDelete { get; set; }


        [ApiMember(Name = nameof(AllVisibleFieldsByDefault), Description = "bool", IsRequired = false)]
        public bool AllVisibleFieldsByDefault { get; set; }


        [ApiMember(Name = nameof(CacheDuration), Description = "int?", IsRequired = false)]
        public int? CacheDuration { get; set; }


        [ApiMember(Name = nameof(ClassId), Description = "int?", IsRequired = true)]
        public int? ClassId { get; set; }


        [ApiMember(Name = nameof(CustomCollections), Description = "DataProperty", IsRequired = false)]
        public List<Reference> CustomCollections { get; set; }
        public int? CustomCollectionsCount { get; set; }


        [ApiMember(Name = nameof(DELETE), Description = "bool", IsRequired = false)]
        public bool DELETE { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(DontFlattenProperties), Description = "DataProperty", IsRequired = false)]
        public List<Reference> DontFlattenProperties { get; set; }
        public int? DontFlattenPropertiesCount { get; set; }


        [ApiMember(Name = nameof(DtoSuffix), Description = "string", IsRequired = false)]
        public string DtoSuffix { get; set; }


        [ApiMember(Name = nameof(FlattenReferences), Description = "bool", IsRequired = false)]
        public bool FlattenReferences { get; set; }


        [ApiMember(Name = nameof(GET), Description = "bool", IsRequired = false)]
        public bool GET { get; set; }


        [ApiMember(Name = nameof(IgnoreProps), Description = "DataProperty", IsRequired = false)]
        public List<Reference> IgnoreProps { get; set; }
        public int? IgnorePropsCount { get; set; }


        [ApiMember(Name = nameof(IsInsertOnly), Description = "bool", IsRequired = false)]
        public bool IsInsertOnly { get; set; }


        [ApiMember(Name = nameof(IsReadOnly), Description = "bool", IsRequired = false)]
        public bool IsReadOnly { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(PATCH), Description = "bool", IsRequired = false)]
        public bool PATCH { get; set; }


        [ApiMember(Name = nameof(POST), Description = "bool", IsRequired = false)]
        public bool POST { get; set; }


        [ApiMember(Name = nameof(Properties), Description = "DataProperty", IsRequired = false)]
        public List<DataProperty> Properties { get; set; }
        public int? PropertiesCount { get; set; }


        [ApiMember(Name = nameof(PUT), Description = "bool", IsRequired = false)]
        public bool PUT { get; set; }


        [ApiMember(Name = nameof(Tabs), Description = "DataTab", IsRequired = false)]
        public List<DataTab> Tabs { get; set; }
        public int? TabsCount { get; set; }



        public void Deconstruct(out bool pAllowDelete, out bool pAllVisibleFieldsByDefault, out int? pCacheDuration, out int? pClassId, out List<Reference> pCustomCollections, out int? pCustomCollectionsCount, out bool pDELETE, out string pDescription, out List<Reference> pDontFlattenProperties, out int? pDontFlattenPropertiesCount, out string pDtoSuffix, out bool pFlattenReferences, out bool pGET, out List<Reference> pIgnoreProps, out int? pIgnorePropsCount, out bool pIsInsertOnly, out bool pIsReadOnly, out string pName, out bool pPATCH, out bool pPOST, out List<DataProperty> pProperties, out int? pPropertiesCount, out bool pPUT, out List<DataTab> pTabs, out int? pTabsCount)
        {
            pAllowDelete = AllowDelete;
            pAllVisibleFieldsByDefault = AllVisibleFieldsByDefault;
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
        //public DataClassBase With(int? pId = Id, bool pAllowDelete = AllowDelete, bool pAllVisibleFieldsByDefault = AllVisibleFieldsByDefault, int? pCacheDuration = CacheDuration, int? pClassId = ClassId, List<Reference> pCustomCollections = CustomCollections, int? pCustomCollectionsCount = CustomCollectionsCount, bool pDELETE = DELETE, string pDescription = Description, List<Reference> pDontFlattenProperties = DontFlattenProperties, int? pDontFlattenPropertiesCount = DontFlattenPropertiesCount, string pDtoSuffix = DtoSuffix, bool pFlattenReferences = FlattenReferences, bool pGET = GET, List<Reference> pIgnoreProps = IgnoreProps, int? pIgnorePropsCount = IgnorePropsCount, bool pIsInsertOnly = IsInsertOnly, bool pIsReadOnly = IsReadOnly, string pName = Name, bool pPATCH = PATCH, bool pPOST = POST, List<DataProperty> pProperties = Properties, int? pPropertiesCount = PropertiesCount, bool pPUT = PUT, List<DataTab> pTabs = Tabs, int? pTabsCount = TabsCount) => 
        //	new DataClassBase(pId, pAllowDelete, pAllVisibleFieldsByDefault, pCacheDuration, pClassId, pCustomCollections, pCustomCollectionsCount, pDELETE, pDescription, pDontFlattenProperties, pDontFlattenPropertiesCount, pDtoSuffix, pFlattenReferences, pGET, pIgnoreProps, pIgnorePropsCount, pIsInsertOnly, pIsReadOnly, pName, pPATCH, pPOST, pProperties, pPropertiesCount, pPUT, pTabs, pTabsCount);

    }

    [Route("/dataclass/{Id}", "GET, PATCH, PUT")]
    public partial class DataClass : DataClassBase, IReturn<DataClass>, IDto, ICloneable
    {
        public DataClass()
        {
            _Constructor();
        }

        public DataClass(int? id) : base(DocConvert.ToInt(id)) {}
        public DataClass(int id) : base(id) {}
        public DataClass(int? pId, bool pAllowDelete, bool pAllVisibleFieldsByDefault, int? pCacheDuration, int? pClassId, List<Reference> pCustomCollections, int? pCustomCollectionsCount, bool pDELETE, string pDescription, List<Reference> pDontFlattenProperties, int? pDontFlattenPropertiesCount, string pDtoSuffix, bool pFlattenReferences, bool pGET, List<Reference> pIgnoreProps, int? pIgnorePropsCount, bool pIsInsertOnly, bool pIsReadOnly, string pName, bool pPATCH, bool pPOST, List<DataProperty> pProperties, int? pPropertiesCount, bool pPUT, List<DataTab> pTabs, int? pTabsCount) : 
            base(pId, pAllowDelete, pAllVisibleFieldsByDefault, pCacheDuration, pClassId, pCustomCollections, pCustomCollectionsCount, pDELETE, pDescription, pDontFlattenProperties, pDontFlattenPropertiesCount, pDtoSuffix, pFlattenReferences, pGET, pIgnoreProps, pIgnorePropsCount, pIsInsertOnly, pIsReadOnly, pName, pPATCH, pPOST, pProperties, pPropertiesCount, pPUT, pTabs, pTabsCount) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<DataClass>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AllowDelete),nameof(AllVisibleFieldsByDefault),nameof(CacheDuration),nameof(ClassId),nameof(Created),nameof(CreatorId),nameof(CustomCollections),nameof(CustomCollectionsCount),nameof(DELETE),nameof(Description),nameof(DontFlattenProperties),nameof(DontFlattenPropertiesCount),nameof(DtoSuffix),nameof(FlattenReferences),nameof(Gestalt),nameof(GET),nameof(IgnoreProps),nameof(IgnorePropsCount),nameof(IsInsertOnly),nameof(IsReadOnly),nameof(Locked),nameof(Name),nameof(PATCH),nameof(POST),nameof(Properties),nameof(PropertiesCount),nameof(PUT),nameof(Tabs),nameof(TabsCount),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<DataClass>("DataClass",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(CustomCollections), nameof(CustomCollectionsCount), nameof(DontFlattenProperties), nameof(DontFlattenPropertiesCount), nameof(IgnoreProps), nameof(IgnorePropsCount), nameof(Properties), nameof(PropertiesCount), nameof(Tabs), nameof(TabsCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<DataClass>();
    }
    
    public partial class DataClassSearchBase : Search<DataClass>
    {
        public int? Id { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> AllowDelete { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> AllVisibleFieldsByDefault { get; set; }
        public int? CacheDuration { get; set; }
        public int? ClassId { get; set; }
        public List<int> CustomCollectionsIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> DELETE { get; set; }
        public string Description { get; set; }
        public List<int> DontFlattenPropertiesIds { get; set; }
        public string DtoSuffix { get; set; }
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
        public DataClassFullTextSearch() {}
        private DataClassSearch _request;
        public DataClassFullTextSearch(DataClassSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Updated))); }

        public bool doAllowDelete { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.AllowDelete))); }
        public bool doAllVisibleFieldsByDefault { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.AllVisibleFieldsByDefault))); }
        public bool doCacheDuration { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.CacheDuration))); }
        public bool doClassId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.ClassId))); }
        public bool doCustomCollections { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.CustomCollections))); }
        public bool doDELETE { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.DELETE))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Description))); }
        public bool doDontFlattenProperties { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.DontFlattenProperties))); }
        public bool doDtoSuffix { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.DtoSuffix))); }
        public bool doFlattenReferences { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.FlattenReferences))); }
        public bool doGET { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.GET))); }
        public bool doIgnoreProps { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.IgnoreProps))); }
        public bool doIsInsertOnly { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.IsInsertOnly))); }
        public bool doIsReadOnly { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.IsReadOnly))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Name))); }
        public bool doPATCH { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.PATCH))); }
        public bool doPOST { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.POST))); }
        public bool doProperties { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Properties))); }
        public bool doPUT { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.PUT))); }
        public bool doTabs { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataClass.Tabs))); }
    }

    [Route("/dataclass/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DataClassBatch : List<DataClass> { }

    [Route("/dataclass/{Id}/{Junction}/version", "GET, POST")]
    [Route("/dataclass/{Id}/{Junction}", "GET, POST, DELETE")]
    public class DataClassJunction : DataClassSearchBase {}


}
