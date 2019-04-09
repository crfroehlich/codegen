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
    public abstract partial class DataPropertyBase : Dto<DataProperty>
    {
        public DataPropertyBase() {}

        public DataPropertyBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DataPropertyBase(int? id) : this(DocConvert.ToInt(id)) {}

        public DataPropertyBase(int? pId, bool pAutoCreateMissing, List<Reference> pChildren, int? pChildrenCount, Reference pClass, int? pClassId, string pDescription, string pDisplayName, bool pIsAllowAddInForm, bool pIsAllowCreateInForm, bool pIsAllowEditInForm, bool pIsAllowFreeText, bool pIsAllowRemoveInForm, bool pIsAudited, bool pIsDisplayInForm, bool pIsDisplayInGrid, bool pIsEditColumn, bool pIsInsertOnly, bool pIsJSON, bool pIsLazy, bool pIsNullOnUpgrade, bool pIsReadOnly, bool pIsRelationship, bool pIsRequired, bool pIsRequiredInForm, bool pIsVirtual, string pJsonType, Reference pLookupTableEnum, int? pLookupTableEnumId, string pName, int? pOrder, Reference pOwner, int? pOwnerId, int? pPrecision, OnRemoveAction? pRelationshipOnOwnerRemove, OnRemoveAction? pRelationshipOnTargetRemove, Reference pRelationshipPairTo, int? pRelationshipPairToId, int? pScale, string pSetDefaultValue, Reference pTab, int? pTabId, Reference pTarget, int? pTargetId, string pTargetAlias, DataType? pType, UiType? pUIType) : this(DocConvert.ToInt(pId)) 
        {
            AutoCreateMissing = pAutoCreateMissing;
            Children = pChildren;
            ChildrenCount = pChildrenCount;
            Class = pClass;
            ClassId = pClassId;
            Description = pDescription;
            DisplayName = pDisplayName;
            IsAllowAddInForm = pIsAllowAddInForm;
            IsAllowCreateInForm = pIsAllowCreateInForm;
            IsAllowEditInForm = pIsAllowEditInForm;
            IsAllowFreeText = pIsAllowFreeText;
            IsAllowRemoveInForm = pIsAllowRemoveInForm;
            IsAudited = pIsAudited;
            IsDisplayInForm = pIsDisplayInForm;
            IsDisplayInGrid = pIsDisplayInGrid;
            IsEditColumn = pIsEditColumn;
            IsInsertOnly = pIsInsertOnly;
            IsJSON = pIsJSON;
            IsLazy = pIsLazy;
            IsNullOnUpgrade = pIsNullOnUpgrade;
            IsReadOnly = pIsReadOnly;
            IsRelationship = pIsRelationship;
            IsRequired = pIsRequired;
            IsRequiredInForm = pIsRequiredInForm;
            IsVirtual = pIsVirtual;
            JsonType = pJsonType;
            LookupTableEnum = pLookupTableEnum;
            LookupTableEnumId = pLookupTableEnumId;
            Name = pName;
            Order = pOrder;
            Owner = pOwner;
            OwnerId = pOwnerId;
            Precision = pPrecision;
            RelationshipOnOwnerRemove = pRelationshipOnOwnerRemove;
            RelationshipOnTargetRemove = pRelationshipOnTargetRemove;
            RelationshipPairTo = pRelationshipPairTo;
            RelationshipPairToId = pRelationshipPairToId;
            Scale = pScale;
            SetDefaultValue = pSetDefaultValue;
            Tab = pTab;
            TabId = pTabId;
            Target = pTarget;
            TargetId = pTargetId;
            TargetAlias = pTargetAlias;
            Type = pType;
            UIType = pUIType;
        }

        [ApiMember(Name = nameof(AutoCreateMissing), Description = "bool", IsRequired = false)]
        public bool AutoCreateMissing { get; set; }


        [ApiMember(Name = nameof(Children), Description = "DataProperty", IsRequired = false)]
        public List<Reference> Children { get; set; }
        public int? ChildrenCount { get; set; }


        [ApiMember(Name = nameof(Class), Description = "DataClass", IsRequired = true)]
        public Reference Class { get; set; }
        [ApiMember(Name = nameof(ClassId), Description = "Primary Key of DataClass", IsRequired = false)]
        public int? ClassId { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(DisplayName), Description = "string", IsRequired = false)]
        public string DisplayName { get; set; }


        [ApiMember(Name = nameof(IsAllowAddInForm), Description = "bool", IsRequired = false)]
        public bool IsAllowAddInForm { get; set; }


        [ApiMember(Name = nameof(IsAllowCreateInForm), Description = "bool", IsRequired = false)]
        public bool IsAllowCreateInForm { get; set; }


        [ApiMember(Name = nameof(IsAllowEditInForm), Description = "bool", IsRequired = false)]
        public bool IsAllowEditInForm { get; set; }


        [ApiMember(Name = nameof(IsAllowFreeText), Description = "bool", IsRequired = false)]
        public bool IsAllowFreeText { get; set; }


        [ApiMember(Name = nameof(IsAllowRemoveInForm), Description = "bool", IsRequired = false)]
        public bool IsAllowRemoveInForm { get; set; }


        [ApiMember(Name = nameof(IsAudited), Description = "bool", IsRequired = false)]
        public bool IsAudited { get; set; }


        [ApiMember(Name = nameof(IsDisplayInForm), Description = "bool", IsRequired = false)]
        public bool IsDisplayInForm { get; set; }


        [ApiMember(Name = nameof(IsDisplayInGrid), Description = "bool", IsRequired = false)]
        public bool IsDisplayInGrid { get; set; }


        [ApiMember(Name = nameof(IsEditColumn), Description = "bool", IsRequired = false)]
        public bool IsEditColumn { get; set; }


        [ApiMember(Name = nameof(IsInsertOnly), Description = "bool", IsRequired = false)]
        public bool IsInsertOnly { get; set; }


        [ApiMember(Name = nameof(IsJSON), Description = "bool", IsRequired = false)]
        public bool IsJSON { get; set; }


        [ApiMember(Name = nameof(IsLazy), Description = "bool", IsRequired = false)]
        public bool IsLazy { get; set; }


        [ApiMember(Name = nameof(IsNullOnUpgrade), Description = "bool", IsRequired = false)]
        public bool IsNullOnUpgrade { get; set; }


        [ApiMember(Name = nameof(IsReadOnly), Description = "bool", IsRequired = false)]
        public bool IsReadOnly { get; set; }


        [ApiMember(Name = nameof(IsRelationship), Description = "bool", IsRequired = false)]
        public bool IsRelationship { get; set; }


        [ApiMember(Name = nameof(IsRequired), Description = "bool", IsRequired = false)]
        public bool IsRequired { get; set; }


        [ApiMember(Name = nameof(IsRequiredInForm), Description = "bool", IsRequired = false)]
        public bool IsRequiredInForm { get; set; }


        [ApiMember(Name = nameof(IsVirtual), Description = "bool", IsRequired = false)]
        public bool IsVirtual { get; set; }


        [ApiMember(Name = nameof(JsonType), Description = "string", IsRequired = false)]
        public string JsonType { get; set; }


        [ApiMember(Name = nameof(LookupTableEnum), Description = "LookupTableEnum", IsRequired = false)]
        public Reference LookupTableEnum { get; set; }
        [ApiMember(Name = nameof(LookupTableEnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        public int? LookupTableEnumId { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


        [ApiMember(Name = nameof(Owner), Description = "DataProperty", IsRequired = false)]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of DataProperty", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(Precision), Description = "int?", IsRequired = false)]
        public int? Precision { get; set; }


        [ApiMember(Name = nameof(RelationshipOnOwnerRemove), Description = "OnRemoveAction?", IsRequired = false)]
        public OnRemoveAction? RelationshipOnOwnerRemove { get; set; }


        [ApiMember(Name = nameof(RelationshipOnTargetRemove), Description = "OnRemoveAction?", IsRequired = false)]
        public OnRemoveAction? RelationshipOnTargetRemove { get; set; }


        [ApiMember(Name = nameof(RelationshipPairTo), Description = "DataProperty", IsRequired = false)]
        public Reference RelationshipPairTo { get; set; }
        [ApiMember(Name = nameof(RelationshipPairToId), Description = "Primary Key of DataProperty", IsRequired = false)]
        public int? RelationshipPairToId { get; set; }


        [ApiMember(Name = nameof(Scale), Description = "int?", IsRequired = false)]
        public int? Scale { get; set; }


        [ApiMember(Name = nameof(SetDefaultValue), Description = "string", IsRequired = false)]
        public string SetDefaultValue { get; set; }


        [ApiMember(Name = nameof(Tab), Description = "DataTab", IsRequired = false)]
        public Reference Tab { get; set; }
        [ApiMember(Name = nameof(TabId), Description = "Primary Key of DataTab", IsRequired = false)]
        public int? TabId { get; set; }


        [ApiMember(Name = nameof(Target), Description = "DataClass", IsRequired = false)]
        public Reference Target { get; set; }
        [ApiMember(Name = nameof(TargetId), Description = "Primary Key of DataClass", IsRequired = false)]
        public int? TargetId { get; set; }


        [ApiMember(Name = nameof(TargetAlias), Description = "string", IsRequired = false)]
        public string TargetAlias { get; set; }


        [ApiMember(Name = nameof(Type), Description = "DataType?", IsRequired = false)]
        public DataType? Type { get; set; }


        [ApiMember(Name = nameof(UIType), Description = "UiType?", IsRequired = false)]
        public UiType? UIType { get; set; }



        public void Deconstruct(out bool pAutoCreateMissing, out List<Reference> pChildren, out int? pChildrenCount, out Reference pClass, out int? pClassId, out string pDescription, out string pDisplayName, out bool pIsAllowAddInForm, out bool pIsAllowCreateInForm, out bool pIsAllowEditInForm, out bool pIsAllowFreeText, out bool pIsAllowRemoveInForm, out bool pIsAudited, out bool pIsDisplayInForm, out bool pIsDisplayInGrid, out bool pIsEditColumn, out bool pIsInsertOnly, out bool pIsJSON, out bool pIsLazy, out bool pIsNullOnUpgrade, out bool pIsReadOnly, out bool pIsRelationship, out bool pIsRequired, out bool pIsRequiredInForm, out bool pIsVirtual, out string pJsonType, out Reference pLookupTableEnum, out int? pLookupTableEnumId, out string pName, out int? pOrder, out Reference pOwner, out int? pOwnerId, out int? pPrecision, out OnRemoveAction? pRelationshipOnOwnerRemove, out OnRemoveAction? pRelationshipOnTargetRemove, out Reference pRelationshipPairTo, out int? pRelationshipPairToId, out int? pScale, out string pSetDefaultValue, out Reference pTab, out int? pTabId, out Reference pTarget, out int? pTargetId, out string pTargetAlias, out DataType? pType, out UiType? pUIType)
        {
            pAutoCreateMissing = AutoCreateMissing;
            pChildren = Children;
            pChildrenCount = ChildrenCount;
            pClass = Class;
            pClassId = ClassId;
            pDescription = Description;
            pDisplayName = DisplayName;
            pIsAllowAddInForm = IsAllowAddInForm;
            pIsAllowCreateInForm = IsAllowCreateInForm;
            pIsAllowEditInForm = IsAllowEditInForm;
            pIsAllowFreeText = IsAllowFreeText;
            pIsAllowRemoveInForm = IsAllowRemoveInForm;
            pIsAudited = IsAudited;
            pIsDisplayInForm = IsDisplayInForm;
            pIsDisplayInGrid = IsDisplayInGrid;
            pIsEditColumn = IsEditColumn;
            pIsInsertOnly = IsInsertOnly;
            pIsJSON = IsJSON;
            pIsLazy = IsLazy;
            pIsNullOnUpgrade = IsNullOnUpgrade;
            pIsReadOnly = IsReadOnly;
            pIsRelationship = IsRelationship;
            pIsRequired = IsRequired;
            pIsRequiredInForm = IsRequiredInForm;
            pIsVirtual = IsVirtual;
            pJsonType = JsonType;
            pLookupTableEnum = LookupTableEnum;
            pLookupTableEnumId = LookupTableEnumId;
            pName = Name;
            pOrder = Order;
            pOwner = Owner;
            pOwnerId = OwnerId;
            pPrecision = Precision;
            pRelationshipOnOwnerRemove = RelationshipOnOwnerRemove;
            pRelationshipOnTargetRemove = RelationshipOnTargetRemove;
            pRelationshipPairTo = RelationshipPairTo;
            pRelationshipPairToId = RelationshipPairToId;
            pScale = Scale;
            pSetDefaultValue = SetDefaultValue;
            pTab = Tab;
            pTabId = TabId;
            pTarget = Target;
            pTargetId = TargetId;
            pTargetAlias = TargetAlias;
            pType = Type;
            pUIType = UIType;
        }

        //Not ready until C# v8.?
        //public DataPropertyBase With(int? pId = Id, bool pAutoCreateMissing = AutoCreateMissing, List<Reference> pChildren = Children, int? pChildrenCount = ChildrenCount, Reference pClass = Class, int? pClassId = ClassId, string pDescription = Description, string pDisplayName = DisplayName, bool pIsAllowAddInForm = IsAllowAddInForm, bool pIsAllowCreateInForm = IsAllowCreateInForm, bool pIsAllowEditInForm = IsAllowEditInForm, bool pIsAllowFreeText = IsAllowFreeText, bool pIsAllowRemoveInForm = IsAllowRemoveInForm, bool pIsAudited = IsAudited, bool pIsDisplayInForm = IsDisplayInForm, bool pIsDisplayInGrid = IsDisplayInGrid, bool pIsEditColumn = IsEditColumn, bool pIsInsertOnly = IsInsertOnly, bool pIsJSON = IsJSON, bool pIsLazy = IsLazy, bool pIsNullOnUpgrade = IsNullOnUpgrade, bool pIsReadOnly = IsReadOnly, bool pIsRelationship = IsRelationship, bool pIsRequired = IsRequired, bool pIsRequiredInForm = IsRequiredInForm, bool pIsVirtual = IsVirtual, string pJsonType = JsonType, Reference pLookupTableEnum = LookupTableEnum, int? pLookupTableEnumId = LookupTableEnumId, string pName = Name, int? pOrder = Order, Reference pOwner = Owner, int? pOwnerId = OwnerId, int? pPrecision = Precision, OnRemoveAction? pRelationshipOnOwnerRemove = RelationshipOnOwnerRemove, OnRemoveAction? pRelationshipOnTargetRemove = RelationshipOnTargetRemove, Reference pRelationshipPairTo = RelationshipPairTo, int? pRelationshipPairToId = RelationshipPairToId, int? pScale = Scale, string pSetDefaultValue = SetDefaultValue, Reference pTab = Tab, int? pTabId = TabId, Reference pTarget = Target, int? pTargetId = TargetId, string pTargetAlias = TargetAlias, DataType? pType = Type, UiType? pUIType = UIType) => 
        //	new DataPropertyBase(pId, pAutoCreateMissing, pChildren, pChildrenCount, pClass, pClassId, pDescription, pDisplayName, pIsAllowAddInForm, pIsAllowCreateInForm, pIsAllowEditInForm, pIsAllowFreeText, pIsAllowRemoveInForm, pIsAudited, pIsDisplayInForm, pIsDisplayInGrid, pIsEditColumn, pIsInsertOnly, pIsJSON, pIsLazy, pIsNullOnUpgrade, pIsReadOnly, pIsRelationship, pIsRequired, pIsRequiredInForm, pIsVirtual, pJsonType, pLookupTableEnum, pLookupTableEnumId, pName, pOrder, pOwner, pOwnerId, pPrecision, pRelationshipOnOwnerRemove, pRelationshipOnTargetRemove, pRelationshipPairTo, pRelationshipPairToId, pScale, pSetDefaultValue, pTab, pTabId, pTarget, pTargetId, pTargetAlias, pType, pUIType);

    }

    [Route("/dataproperty/{Id}", "GET, PATCH, PUT")]
    public partial class DataProperty : DataPropertyBase, IReturn<DataProperty>, IDto, ICloneable
    {
        public DataProperty()
        {
            _Constructor();
        }

        public DataProperty(int? id) : base(DocConvert.ToInt(id)) {}
        public DataProperty(int id) : base(id) {}
        public DataProperty(int? pId, bool pAutoCreateMissing, List<Reference> pChildren, int? pChildrenCount, Reference pClass, int? pClassId, string pDescription, string pDisplayName, bool pIsAllowAddInForm, bool pIsAllowCreateInForm, bool pIsAllowEditInForm, bool pIsAllowFreeText, bool pIsAllowRemoveInForm, bool pIsAudited, bool pIsDisplayInForm, bool pIsDisplayInGrid, bool pIsEditColumn, bool pIsInsertOnly, bool pIsJSON, bool pIsLazy, bool pIsNullOnUpgrade, bool pIsReadOnly, bool pIsRelationship, bool pIsRequired, bool pIsRequiredInForm, bool pIsVirtual, string pJsonType, Reference pLookupTableEnum, int? pLookupTableEnumId, string pName, int? pOrder, Reference pOwner, int? pOwnerId, int? pPrecision, OnRemoveAction? pRelationshipOnOwnerRemove, OnRemoveAction? pRelationshipOnTargetRemove, Reference pRelationshipPairTo, int? pRelationshipPairToId, int? pScale, string pSetDefaultValue, Reference pTab, int? pTabId, Reference pTarget, int? pTargetId, string pTargetAlias, DataType? pType, UiType? pUIType) : 
            base(pId, pAutoCreateMissing, pChildren, pChildrenCount, pClass, pClassId, pDescription, pDisplayName, pIsAllowAddInForm, pIsAllowCreateInForm, pIsAllowEditInForm, pIsAllowFreeText, pIsAllowRemoveInForm, pIsAudited, pIsDisplayInForm, pIsDisplayInGrid, pIsEditColumn, pIsInsertOnly, pIsJSON, pIsLazy, pIsNullOnUpgrade, pIsReadOnly, pIsRelationship, pIsRequired, pIsRequiredInForm, pIsVirtual, pJsonType, pLookupTableEnum, pLookupTableEnumId, pName, pOrder, pOwner, pOwnerId, pPrecision, pRelationshipOnOwnerRemove, pRelationshipOnTargetRemove, pRelationshipPairTo, pRelationshipPairToId, pScale, pSetDefaultValue, pTab, pTabId, pTarget, pTargetId, pTargetAlias, pType, pUIType) { }
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<DataProperty>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AutoCreateMissing),nameof(Children),nameof(ChildrenCount),nameof(Class),nameof(ClassId),nameof(Created),nameof(CreatorId),nameof(Description),nameof(DisplayName),nameof(Gestalt),nameof(IsAllowAddInForm),nameof(IsAllowCreateInForm),nameof(IsAllowEditInForm),nameof(IsAllowFreeText),nameof(IsAllowRemoveInForm),nameof(IsAudited),nameof(IsDisplayInForm),nameof(IsDisplayInGrid),nameof(IsEditColumn),nameof(IsInsertOnly),nameof(IsJSON),nameof(IsLazy),nameof(IsNullOnUpgrade),nameof(IsReadOnly),nameof(IsRelationship),nameof(IsRequired),nameof(IsRequiredInForm),nameof(IsVirtual),nameof(JsonType),nameof(Locked),nameof(LookupTableEnum),nameof(LookupTableEnumId),nameof(Name),nameof(Order),nameof(Owner),nameof(OwnerId),nameof(Precision),nameof(RelationshipOnOwnerRemove),nameof(RelationshipOnTargetRemove),nameof(RelationshipPairTo),nameof(RelationshipPairToId),nameof(Scale),nameof(SetDefaultValue),nameof(Tab),nameof(TabId),nameof(Target),nameof(TargetAlias),nameof(TargetId),nameof(Type),nameof(UIType),nameof(Updated),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocPermissionFactory.RemoveNonEssentialFields(Fields);
                }
                return _VisibleFields;
            }
            set
            {
                _VisibleFields = Fields;
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<DataProperty>();
    }
    
    public partial class DataPropertySearchBase : Search<DataProperty>
    {
        public int? Id { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> AutoCreateMissing { get; set; }
        public List<int> ChildrenIds { get; set; }
        public Reference Class { get; set; }
        public List<int> ClassIds { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsAllowAddInForm { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsAllowCreateInForm { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsAllowEditInForm { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsAllowFreeText { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsAllowRemoveInForm { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsAudited { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsDisplayInForm { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsDisplayInGrid { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsEditColumn { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsInsertOnly { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsJSON { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsLazy { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsNullOnUpgrade { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsReadOnly { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsRelationship { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsRequired { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsRequiredInForm { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsVirtual { get; set; }
        public string JsonType { get; set; }
        public Reference LookupTableEnum { get; set; }
        public List<int> LookupTableEnumIds { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public int? Precision { get; set; }
        public OnRemoveAction? RelationshipOnOwnerRemove { get; set; }
        public OnRemoveAction? RelationshipOnTargetRemove { get; set; }
        public Reference RelationshipPairTo { get; set; }
        public List<int> RelationshipPairToIds { get; set; }
        public int? Scale { get; set; }
        public string SetDefaultValue { get; set; }
        public Reference Tab { get; set; }
        public List<int> TabIds { get; set; }
        public Reference Target { get; set; }
        public List<int> TargetIds { get; set; }
        public string TargetAlias { get; set; }
        public DataType? Type { get; set; }
        public UiType? UIType { get; set; }
    }

    [Route("/dataproperty", "GET")]
    [Route("/dataproperty/version", "GET, POST")]
    [Route("/dataproperty/search", "GET, POST, DELETE")]
    public partial class DataPropertySearch : DataPropertySearchBase
    {
    }

    public class DataPropertyFullTextSearch
    {
        public DataPropertyFullTextSearch() {}
        private DataPropertySearch _request;
        public DataPropertyFullTextSearch(DataPropertySearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Updated))); }

        public bool doAutoCreateMissing { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.AutoCreateMissing))); }
        public bool doChildren { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Children))); }
        public bool doClass { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Class))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Description))); }
        public bool doDisplayName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.DisplayName))); }
        public bool doIsAllowAddInForm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsAllowAddInForm))); }
        public bool doIsAllowCreateInForm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsAllowCreateInForm))); }
        public bool doIsAllowEditInForm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsAllowEditInForm))); }
        public bool doIsAllowFreeText { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsAllowFreeText))); }
        public bool doIsAllowRemoveInForm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsAllowRemoveInForm))); }
        public bool doIsAudited { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsAudited))); }
        public bool doIsDisplayInForm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsDisplayInForm))); }
        public bool doIsDisplayInGrid { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsDisplayInGrid))); }
        public bool doIsEditColumn { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsEditColumn))); }
        public bool doIsInsertOnly { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsInsertOnly))); }
        public bool doIsJSON { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsJSON))); }
        public bool doIsLazy { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsLazy))); }
        public bool doIsNullOnUpgrade { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsNullOnUpgrade))); }
        public bool doIsReadOnly { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsReadOnly))); }
        public bool doIsRelationship { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsRelationship))); }
        public bool doIsRequired { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsRequired))); }
        public bool doIsRequiredInForm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsRequiredInForm))); }
        public bool doIsVirtual { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.IsVirtual))); }
        public bool doJsonType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.JsonType))); }
        public bool doLookupTableEnum { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.LookupTableEnum))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Name))); }
        public bool doOrder { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Order))); }
        public bool doOwner { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Owner))); }
        public bool doPrecision { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Precision))); }
        public bool doRelationshipOnOwnerRemove { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.RelationshipOnOwnerRemove))); }
        public bool doRelationshipOnTargetRemove { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.RelationshipOnTargetRemove))); }
        public bool doRelationshipPairTo { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.RelationshipPairTo))); }
        public bool doScale { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Scale))); }
        public bool doSetDefaultValue { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.SetDefaultValue))); }
        public bool doTab { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Tab))); }
        public bool doTarget { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Target))); }
        public bool doTargetAlias { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.TargetAlias))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.Type))); }
        public bool doUIType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataProperty.UIType))); }
    }

    [Route("/dataproperty/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DataPropertyBatch : List<DataProperty> { }

    [Route("/dataproperty/{Id}/{Junction}/version", "GET, POST")]
    [Route("/dataproperty/{Id}/{Junction}", "GET, POST, DELETE")]
    public class DataPropertyJunction : DataPropertySearchBase {}


}
