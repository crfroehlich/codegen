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

namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValueTypeEnm
    {
        [EnumMember(Value = DocConstantValueType.ASSOCIATIONMEASURE)]
        ASSOCIATIONMEASURE,
        [EnumMember(Value = DocConstantValueType.BOOLEAN)]
        BOOLEAN,
        [EnumMember(Value = DocConstantValueType.CALENDARDATE)]
        CALENDARDATE,
        [EnumMember(Value = DocConstantValueType.CALENDARDATES)]
        CALENDARDATES,
        [EnumMember(Value = DocConstantValueType.CONTACT)]
        CONTACT,
        [EnumMember(Value = DocConstantValueType.DATETIME)]
        DATETIME,
        [EnumMember(Value = DocConstantValueType.DATETIMERANGE)]
        DATETIMERANGE,
        [EnumMember(Value = DocConstantValueType.DECIMAL)]
        DECIMAL,
        [EnumMember(Value = DocConstantValueType.DECIMALRANGE)]
        DECIMALRANGE,
        [EnumMember(Value = DocConstantValueType.DESIGNNESTEDSTUDYIDLINK)]
        DESIGNNESTEDSTUDYIDLINK,
        [EnumMember(Value = DocConstantValueType.EVENTCOUNTS)]
        EVENTCOUNTS,
        [EnumMember(Value = DocConstantValueType.FACILITY)]
        FACILITY,
        [EnumMember(Value = DocConstantValueType.FIXEDDOSEINTERVENTION)]
        FIXEDDOSEINTERVENTION,
        [EnumMember(Value = DocConstantValueType.FLAG)]
        FLAG,
        [EnumMember(Value = DocConstantValueType.FUNDING)]
        FUNDING,
        [EnumMember(Value = DocConstantValueType.INTEGER)]
        INTEGER,
        [EnumMember(Value = DocConstantValueType.INTERVAL)]
        INTERVAL,
        [EnumMember(Value = DocConstantValueType.INTERVALS)]
        INTERVALS,
        [EnumMember(Value = DocConstantValueType.LOOKUP)]
        LOOKUP,
        [EnumMember(Value = DocConstantValueType.MEMO)]
        MEMO,
        [EnumMember(Value = DocConstantValueType.NPERSONS)]
        NPERSONS,
        [EnumMember(Value = DocConstantValueType.PARTICIPANT)]
        PARTICIPANT,
        [EnumMember(Value = DocConstantValueType.PARTICIPANTS)]
        PARTICIPANTS,
        [EnumMember(Value = DocConstantValueType.POPULATIONANALYZED)]
        POPULATIONANALYZED,
        [EnumMember(Value = DocConstantValueType.PVALUE)]
        PVALUE,
        [EnumMember(Value = DocConstantValueType.RATE)]
        RATE,
        [EnumMember(Value = DocConstantValueType.SETTINGLOCATION)]
        SETTINGLOCATION,
        [EnumMember(Value = DocConstantValueType.SETTINGLOCATIONTOTAL)]
        SETTINGLOCATIONTOTAL,
        [EnumMember(Value = DocConstantValueType.STUDYDOC)]
        STUDYDOC,
        [EnumMember(Value = DocConstantValueType.STUDYOBJECTIVE)]
        STUDYOBJECTIVE,
        [EnumMember(Value = DocConstantValueType.STUDYREFERENCE)]
        STUDYREFERENCE,
        [EnumMember(Value = DocConstantValueType.SUBGROUPDESCRIPTOR)]
        SUBGROUPDESCRIPTOR,
        [EnumMember(Value = DocConstantValueType.TIMEPOINT)]
        TIMEPOINT,
        [EnumMember(Value = DocConstantValueType.TIMEPOINTS)]
        TIMEPOINTS,
        [EnumMember(Value = DocConstantValueType.UNCOLLECTEDVALUE)]
        UNCOLLECTEDVALUE,
        [EnumMember(Value = DocConstantValueType.UNITRANGE)]
        UNITRANGE,
        [EnumMember(Value = DocConstantValueType.UNITS)]
        UNITS,
        [EnumMember(Value = DocConstantValueType.UNITSRANGE)]
        UNITSRANGE,
        [EnumMember(Value = DocConstantValueType.UNITVALUE)]
        UNITVALUE,
        [EnumMember(Value = DocConstantValueType.YESNONA)]
        YESNONA
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ValueTypeEnm instance)
        {
            switch(instance) 
            {
                case ValueTypeEnm.ASSOCIATIONMEASURE:
                    return DocConstantValueType.ASSOCIATIONMEASURE;
                case ValueTypeEnm.BOOLEAN:
                    return DocConstantValueType.BOOLEAN;
                case ValueTypeEnm.CALENDARDATE:
                    return DocConstantValueType.CALENDARDATE;
                case ValueTypeEnm.CALENDARDATES:
                    return DocConstantValueType.CALENDARDATES;
                case ValueTypeEnm.CONTACT:
                    return DocConstantValueType.CONTACT;
                case ValueTypeEnm.DATETIME:
                    return DocConstantValueType.DATETIME;
                case ValueTypeEnm.DATETIMERANGE:
                    return DocConstantValueType.DATETIMERANGE;
                case ValueTypeEnm.DECIMAL:
                    return DocConstantValueType.DECIMAL;
                case ValueTypeEnm.DECIMALRANGE:
                    return DocConstantValueType.DECIMALRANGE;
                case ValueTypeEnm.DESIGNNESTEDSTUDYIDLINK:
                    return DocConstantValueType.DESIGNNESTEDSTUDYIDLINK;
                case ValueTypeEnm.EVENTCOUNTS:
                    return DocConstantValueType.EVENTCOUNTS;
                case ValueTypeEnm.FACILITY:
                    return DocConstantValueType.FACILITY;
                case ValueTypeEnm.FIXEDDOSEINTERVENTION:
                    return DocConstantValueType.FIXEDDOSEINTERVENTION;
                case ValueTypeEnm.FLAG:
                    return DocConstantValueType.FLAG;
                case ValueTypeEnm.FUNDING:
                    return DocConstantValueType.FUNDING;
                case ValueTypeEnm.INTEGER:
                    return DocConstantValueType.INTEGER;
                case ValueTypeEnm.INTERVAL:
                    return DocConstantValueType.INTERVAL;
                case ValueTypeEnm.INTERVALS:
                    return DocConstantValueType.INTERVALS;
                case ValueTypeEnm.LOOKUP:
                    return DocConstantValueType.LOOKUP;
                case ValueTypeEnm.MEMO:
                    return DocConstantValueType.MEMO;
                case ValueTypeEnm.NPERSONS:
                    return DocConstantValueType.NPERSONS;
                case ValueTypeEnm.PARTICIPANT:
                    return DocConstantValueType.PARTICIPANT;
                case ValueTypeEnm.PARTICIPANTS:
                    return DocConstantValueType.PARTICIPANTS;
                case ValueTypeEnm.POPULATIONANALYZED:
                    return DocConstantValueType.POPULATIONANALYZED;
                case ValueTypeEnm.PVALUE:
                    return DocConstantValueType.PVALUE;
                case ValueTypeEnm.RATE:
                    return DocConstantValueType.RATE;
                case ValueTypeEnm.SETTINGLOCATION:
                    return DocConstantValueType.SETTINGLOCATION;
                case ValueTypeEnm.SETTINGLOCATIONTOTAL:
                    return DocConstantValueType.SETTINGLOCATIONTOTAL;
                case ValueTypeEnm.STUDYDOC:
                    return DocConstantValueType.STUDYDOC;
                case ValueTypeEnm.STUDYOBJECTIVE:
                    return DocConstantValueType.STUDYOBJECTIVE;
                case ValueTypeEnm.STUDYREFERENCE:
                    return DocConstantValueType.STUDYREFERENCE;
                case ValueTypeEnm.SUBGROUPDESCRIPTOR:
                    return DocConstantValueType.SUBGROUPDESCRIPTOR;
                case ValueTypeEnm.TIMEPOINT:
                    return DocConstantValueType.TIMEPOINT;
                case ValueTypeEnm.TIMEPOINTS:
                    return DocConstantValueType.TIMEPOINTS;
                case ValueTypeEnm.UNCOLLECTEDVALUE:
                    return DocConstantValueType.UNCOLLECTEDVALUE;
                case ValueTypeEnm.UNITRANGE:
                    return DocConstantValueType.UNITRANGE;
                case ValueTypeEnm.UNITS:
                    return DocConstantValueType.UNITS;
                case ValueTypeEnm.UNITSRANGE:
                    return DocConstantValueType.UNITSRANGE;
                case ValueTypeEnm.UNITVALUE:
                    return DocConstantValueType.UNITVALUE;
                case ValueTypeEnm.YESNONA:
                    return DocConstantValueType.YESNONA;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantValueType : IEquatable<DocConstantValueType>, IEqualityComparer<DocConstantValueType>
    {
        public const string ASSOCIATIONMEASURE = "AssociationMeasure";
        public const string BOOLEAN = "Boolean";
        public const string CALENDARDATE = "CalendarDate";
        public const string CALENDARDATES = "CalendarDates";
        public const string CONTACT = "Contact";
        public const string DATETIME = "DateTime";
        public const string DATETIMERANGE = "DateTimeRange";
        public const string DECIMAL = "Decimal";
        public const string DECIMALRANGE = "DecimalRange";
        public const string DESIGNNESTEDSTUDYIDLINK = "DesignNestedStudyIdLink";
        public const string EVENTCOUNTS = "EventCounts";
        public const string FACILITY = "Facility";
        public const string FIXEDDOSEINTERVENTION = "FixedDoseIntervention";
        public const string FLAG = "Flag";
        public const string FUNDING = "Funding";
        public const string INTEGER = "Integer";
        public const string INTERVAL = "Interval";
        public const string INTERVALS = "Intervals";
        public const string LOOKUP = "Lookup";
        public const string MEMO = "Memo";
        public const string NPERSONS = "NPersons";
        public const string PARTICIPANT = "Participant";
        public const string PARTICIPANTS = "Participants";
        public const string POPULATIONANALYZED = "PopulationAnalyzed";
        public const string PVALUE = "PValue";
        public const string RATE = "Rate";
        public const string SETTINGLOCATION = "SettingLocation";
        public const string SETTINGLOCATIONTOTAL = "SettingLocationTotal";
        public const string STUDYDOC = "StudyDoc";
        public const string STUDYOBJECTIVE = "StudyObjective";
        public const string STUDYREFERENCE = "StudyReference";
        public const string SUBGROUPDESCRIPTOR = "SubgroupDescriptor";
        public const string TIMEPOINT = "Timepoint";
        public const string TIMEPOINTS = "Timepoints";
        public const string UNCOLLECTEDVALUE = "UncollectedValue";
        public const string UNITRANGE = "UnitRange";
        public const string UNITS = "Units";
        public const string UNITSRANGE = "UnitsRange";
        public const string UNITVALUE = "UnitValue";
        public const string YESNONA = "YesNoNa";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantValueType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantValueType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantValueType(string Val) => new DocConstantValueType(Val);

        public static implicit operator string(DocConstantValueType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantValueType obj) => this == obj;

        public static bool operator ==(DocConstantValueType x, DocConstantValueType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantValueType x, DocConstantValueType y) => x == y;
        
        public static bool operator !=(DocConstantValueType x, DocConstantValueType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantValueType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantValueType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantValueType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
