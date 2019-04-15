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
    public abstract partial class AttributeBase : Dto<Attribute>
    {
        public AttributeBase() {}

        public AttributeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public AttributeBase(int? id) : this(DocConvert.ToInt(id)) {}

        public AttributeBase(int? pId, Reference pAttributeName, int? pAttributeNameId, Reference pAttributeType, int? pAttributeTypeId, AttributeInterval pInterval, int? pIntervalId, bool pIsCharacteristic, bool pIsOutcome, bool? pIsPositive, string pUniqueKey) : this(DocConvert.ToInt(pId)) 
        {
            AttributeName = pAttributeName;
            AttributeNameId = pAttributeNameId;
            AttributeType = pAttributeType;
            AttributeTypeId = pAttributeTypeId;
            Interval = pInterval;
            IntervalId = pIntervalId;
            IsCharacteristic = pIsCharacteristic;
            IsOutcome = pIsOutcome;
            IsPositive = pIsPositive;
            UniqueKey = pUniqueKey;
        }

        [ApiMember(Name = nameof(AttributeName), Description = "LookupTable", IsRequired = true)]
        public Reference AttributeName { get; set; }
        [ApiMember(Name = nameof(AttributeNameId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? AttributeNameId { get; set; }


        [ApiMember(Name = nameof(AttributeType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Change",@"Duration",@"Not In Study",@"% Change",@"Standard",@"Time Since",@"Time To"})]
        public Reference AttributeType { get; set; }
        [ApiMember(Name = nameof(AttributeTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? AttributeTypeId { get; set; }


        [ApiMember(Name = nameof(Interval), Description = "AttributeInterval", IsRequired = true)]
        public AttributeInterval Interval { get; set; }
        [ApiMember(Name = nameof(IntervalId), Description = "Primary Key of AttributeInterval", IsRequired = false)]
        public int? IntervalId { get; set; }


        [ApiMember(Name = nameof(IsCharacteristic), Description = "bool", IsRequired = false)]
        public bool IsCharacteristic { get; set; }


        [ApiMember(Name = nameof(IsOutcome), Description = "bool", IsRequired = false)]
        public bool IsOutcome { get; set; }


        [ApiMember(Name = nameof(IsPositive), Description = "bool?", IsRequired = false)]
        public bool? IsPositive { get; set; }


        [ApiMember(Name = nameof(UniqueKey), Description = "string", IsRequired = false)]
        public string UniqueKey { get; set; }



        public void Deconstruct(out Reference pAttributeName, out int? pAttributeNameId, out Reference pAttributeType, out int? pAttributeTypeId, out AttributeInterval pInterval, out int? pIntervalId, out bool pIsCharacteristic, out bool pIsOutcome, out bool? pIsPositive, out string pUniqueKey)
        {
            pAttributeName = AttributeName;
            pAttributeNameId = AttributeNameId;
            pAttributeType = AttributeType;
            pAttributeTypeId = AttributeTypeId;
            pInterval = Interval;
            pIntervalId = IntervalId;
            pIsCharacteristic = IsCharacteristic;
            pIsOutcome = IsOutcome;
            pIsPositive = IsPositive;
            pUniqueKey = UniqueKey;
        }

        //Not ready until C# v8.?
        //public AttributeBase With(int? pId = Id, Reference pAttributeName = AttributeName, int? pAttributeNameId = AttributeNameId, Reference pAttributeType = AttributeType, int? pAttributeTypeId = AttributeTypeId, AttributeInterval pInterval = Interval, int? pIntervalId = IntervalId, bool pIsCharacteristic = IsCharacteristic, bool pIsOutcome = IsOutcome, bool? pIsPositive = IsPositive, string pUniqueKey = UniqueKey) => 
        //	new AttributeBase(pId, pAttributeName, pAttributeNameId, pAttributeType, pAttributeTypeId, pInterval, pIntervalId, pIsCharacteristic, pIsOutcome, pIsPositive, pUniqueKey);

    }

    [Route("/attribute", "POST")]
    [Route("/attribute/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Attribute : AttributeBase, IReturn<Attribute>, IDto, ICloneable
    {
        public Attribute()
        {
            _Constructor();
        }

        public Attribute(int? id) : base(DocConvert.ToInt(id)) {}
        public Attribute(int id) : base(id) {}
        public Attribute(int? pId, Reference pAttributeName, int? pAttributeNameId, Reference pAttributeType, int? pAttributeTypeId, AttributeInterval pInterval, int? pIntervalId, bool pIsCharacteristic, bool pIsOutcome, bool? pIsPositive, string pUniqueKey) : 
            base(pId, pAttributeName, pAttributeNameId, pAttributeType, pAttributeTypeId, pInterval, pIntervalId, pIsCharacteristic, pIsOutcome, pIsPositive, pUniqueKey) { }
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

        public static List<string> Fields => DocTools.Fields<Attribute>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AttributeName),nameof(AttributeNameId),nameof(AttributeType),nameof(AttributeTypeId),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Interval),nameof(IntervalId),nameof(IsCharacteristic),nameof(IsOutcome),nameof(IsPositive),nameof(Locked),nameof(UniqueKey),nameof(Updated),nameof(VersionNo)})]
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

        public object Clone() => this.Copy<Attribute>();
    }
    
    [Route("/attribute/{Id}/copy", "POST")]
    public partial class AttributeCopy : Attribute {}
    public partial class AttributeSearchBase : Search<Attribute>
    {
        public int? Id { get; set; }
        public Reference AttributeName { get; set; }
        public List<int> AttributeNameIds { get; set; }
        public List<string> AttributeNameNames { get; set; }
        public Reference AttributeType { get; set; }
        public List<int> AttributeTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Change",@"Duration",@"Not In Study",@"% Change",@"Standard",@"Time Since",@"Time To"})]
        public List<string> AttributeTypeNames { get; set; }
        public Reference Interval { get; set; }
        public List<int> IntervalIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsCharacteristic { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsOutcome { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false", "null"})]
        public List<bool?> IsPositive { get; set; }
        public string UniqueKey { get; set; }
    }

    [Route("/attribute", "GET")]
    [Route("/attribute/version", "GET, POST")]
    [Route("/attribute/search", "GET, POST, DELETE")]
    public partial class AttributeSearch : AttributeSearchBase
    {
    }

    public class AttributeFullTextSearch
    {
        public AttributeFullTextSearch() {}
        private AttributeSearch _request;
        public AttributeFullTextSearch(AttributeSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.Updated))); }

        public bool doAttributeName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.AttributeName))); }
        public bool doAttributeType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.AttributeType))); }
        public bool doInterval { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.Interval))); }
        public bool doIsCharacteristic { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.IsCharacteristic))); }
        public bool doIsOutcome { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.IsOutcome))); }
        public bool doIsPositive { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.IsPositive))); }
        public bool doUniqueKey { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.UniqueKey))); }
        public bool doValueType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Attribute.ValueType))); }
    }

    [Route("/attribute/batch", "DELETE, PATCH, POST, PUT")]
    public partial class AttributeBatch : List<Attribute> { }

}
