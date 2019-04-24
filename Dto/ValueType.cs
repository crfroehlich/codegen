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
    public abstract partial class ValueTypeBase : Dto<ValueType>
    {
        public ValueTypeBase() {}

        public ValueTypeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ValueTypeBase(int? id) : this(DocConvert.ToInt(id)) {}

        public ValueTypeBase(int? pId, Reference pFieldType, int? pFieldTypeId, Reference pName, int? pNameId) : this(DocConvert.ToInt(pId)) 
        {
            FieldType = pFieldType;
            FieldTypeId = pFieldTypeId;
            Name = pName;
            NameId = pNameId;
        }

        [ApiMember(Name = nameof(FieldType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Binary",@"Continuous",@"Count",@"Individual",@"Kaplan-Meier",@"Range",@"Rate",@"Yes/No/Na"})]
        public Reference FieldType { get; set; }
        [ApiMember(Name = nameof(FieldTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? FieldTypeId { get; set; }


        [ApiMember(Name = nameof(Name), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"AssociationMeasure",@"Boolean",@"CalendarDate",@"CalendarDates",@"Contact",@"DateTime",@"DateTimeRange",@"Decimal",@"DecimalRange",@"DesignNestedStudyIdLink",@"EventCounts",@"Facility",@"FixedDoseIntervention",@"Flag",@"Funding",@"Integer",@"Interval",@"Intervals",@"Lookup",@"Memo",@"NPersons",@"Participant",@"Participants",@"PopulationAnalyzed",@"PValue",@"Rate",@"SettingLocation",@"SettingLocationTotal",@"StudyDoc",@"StudyObjective",@"StudyReference",@"SubgroupDescriptor",@"Timepoint",@"Timepoints",@"UncollectedValue",@"UnitRange",@"Units",@"UnitsRange",@"UnitValue",@"YesNoNa"})]
        public Reference Name { get; set; }
        [ApiMember(Name = nameof(NameId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? NameId { get; set; }



        public void Deconstruct(out Reference pFieldType, out int? pFieldTypeId, out Reference pName, out int? pNameId)
        {
            pFieldType = FieldType;
            pFieldTypeId = FieldTypeId;
            pName = Name;
            pNameId = NameId;
        }

        //Not ready until C# v8.?
        //public ValueTypeBase With(int? pId = Id, Reference pFieldType = FieldType, int? pFieldTypeId = FieldTypeId, Reference pName = Name, int? pNameId = NameId) => 
        //	new ValueTypeBase(pId, pFieldType, pFieldTypeId, pName, pNameId);

    }

    [Route("/valuetype/{Id}", "GET")]
    public partial class ValueType : ValueTypeBase, IReturn<ValueType>, IDto, ICloneable
    {
        public ValueType()
        {
            _Constructor();
        }

        public ValueType(int? id) : base(DocConvert.ToInt(id)) {}
        public ValueType(int id) : base(id) {}
        public ValueType(int? pId, Reference pFieldType, int? pFieldTypeId, Reference pName, int? pNameId) : 
            base(pId, pFieldType, pFieldTypeId, pName, pNameId) { }
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

        public static List<string> Fields => DocTools.Fields<ValueType>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(FieldType),nameof(FieldTypeId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(NameId),nameof(Updated),nameof(VersionNo)})]
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

        public object Clone() => this.Copy<ValueType>();
    }
    
    public partial class ValueTypeSearchBase : Search<ValueType>
    {
        public int? Id { get; set; }
        public Reference FieldType { get; set; }
        public List<int> FieldTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Binary",@"Continuous",@"Count",@"Individual",@"Kaplan-Meier",@"Range",@"Rate",@"Yes/No/Na"})]
        public List<string> FieldTypeNames { get; set; }
        public Reference Name { get; set; }
        public List<int> NameIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"AssociationMeasure",@"Boolean",@"CalendarDate",@"CalendarDates",@"Contact",@"DateTime",@"DateTimeRange",@"Decimal",@"DecimalRange",@"DesignNestedStudyIdLink",@"EventCounts",@"Facility",@"FixedDoseIntervention",@"Flag",@"Funding",@"Integer",@"Interval",@"Intervals",@"Lookup",@"Memo",@"NPersons",@"Participant",@"Participants",@"PopulationAnalyzed",@"PValue",@"Rate",@"SettingLocation",@"SettingLocationTotal",@"StudyDoc",@"StudyObjective",@"StudyReference",@"SubgroupDescriptor",@"Timepoint",@"Timepoints",@"UncollectedValue",@"UnitRange",@"Units",@"UnitsRange",@"UnitValue",@"YesNoNa"})]
        public List<string> NameNames { get; set; }
    }

    [Route("/valuetype", "GET")]
    [Route("/valuetype/version", "GET, POST")]
    [Route("/valuetype/search", "GET, POST, DELETE")]
    public partial class ValueTypeSearch : ValueTypeSearchBase
    {
    }

    public class ValueTypeFullTextSearch
    {
        public ValueTypeFullTextSearch() {}
        private ValueTypeSearch _request;
        public ValueTypeFullTextSearch(ValueTypeSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ValueType.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ValueType.Updated))); }

        public bool doFieldType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ValueType.FieldType))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ValueType.Name))); }
    }

    public partial class ValueTypeBatch : List<ValueType> { }

}
