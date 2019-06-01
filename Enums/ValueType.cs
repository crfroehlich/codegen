
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
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;

using ServiceStack;

using SCDescript = System.ComponentModel.DescriptionAttribute;
using SCDisplay = System.ComponentModel.DataAnnotations.DisplayAttribute;
using SSDescript = ServiceStack.DataAnnotations.DescriptionAttribute;
namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValueTypeEnm
    {
        [EnumMember(Value = DocConstantValueType.ASSOCIATIONMEASURE), SCDescript(DocConstantValueType.ASSOCIATIONMEASURE), SSDescript(DocConstantValueType.ASSOCIATIONMEASURE), SCDisplay(Name = DocConstantValueType.ASSOCIATIONMEASURE)]
        ASSOCIATIONMEASURE = 4763,
        [EnumMember(Value = DocConstantValueType.BOOLEAN), SCDescript(DocConstantValueType.BOOLEAN), SSDescript(DocConstantValueType.BOOLEAN), SCDisplay(Name = DocConstantValueType.BOOLEAN)]
        BOOLEAN = 4768,
        [EnumMember(Value = DocConstantValueType.CALENDARDATE), SCDescript(DocConstantValueType.CALENDARDATE), SSDescript(DocConstantValueType.CALENDARDATE), SCDisplay(Name = DocConstantValueType.CALENDARDATE)]
        CALENDARDATE = 96669231,
        [EnumMember(Value = DocConstantValueType.CALENDARDATES), SCDescript(DocConstantValueType.CALENDARDATES), SSDescript(DocConstantValueType.CALENDARDATES), SCDisplay(Name = DocConstantValueType.CALENDARDATES)]
        CALENDARDATES = 96669232,
        [EnumMember(Value = DocConstantValueType.CONTACT), SCDescript(DocConstantValueType.CONTACT), SSDescript(DocConstantValueType.CONTACT), SCDisplay(Name = DocConstantValueType.CONTACT)]
        CONTACT = 146157851,
        [EnumMember(Value = DocConstantValueType.DATETIME), SCDescript(DocConstantValueType.DATETIME), SSDescript(DocConstantValueType.DATETIME), SCDisplay(Name = DocConstantValueType.DATETIME)]
        DATETIME = 4773,
        [EnumMember(Value = DocConstantValueType.DATETIMERANGE), SCDescript(DocConstantValueType.DATETIMERANGE), SSDescript(DocConstantValueType.DATETIMERANGE), SCDisplay(Name = DocConstantValueType.DATETIMERANGE)]
        DATETIMERANGE = 46350624,
        [EnumMember(Value = DocConstantValueType.DECIMAL), SCDescript(DocConstantValueType.DECIMAL), SSDescript(DocConstantValueType.DECIMAL), SCDisplay(Name = DocConstantValueType.DECIMAL)]
        DECIMAL = 4778,
        [EnumMember(Value = DocConstantValueType.DECIMALRANGE), SCDescript(DocConstantValueType.DECIMALRANGE), SSDescript(DocConstantValueType.DECIMALRANGE), SCDisplay(Name = DocConstantValueType.DECIMALRANGE)]
        DECIMALRANGE = 4783,
        [EnumMember(Value = DocConstantValueType.DESIGNNESTEDSTUDYIDLINK), SCDescript(DocConstantValueType.DESIGNNESTEDSTUDYIDLINK), SSDescript(DocConstantValueType.DESIGNNESTEDSTUDYIDLINK), SCDisplay(Name = DocConstantValueType.DESIGNNESTEDSTUDYIDLINK)]
        DESIGNNESTEDSTUDYIDLINK = 67058545,
        [EnumMember(Value = DocConstantValueType.EVENTCOUNTS), SCDescript(DocConstantValueType.EVENTCOUNTS), SSDescript(DocConstantValueType.EVENTCOUNTS), SCDisplay(Name = DocConstantValueType.EVENTCOUNTS)]
        EVENTCOUNTS = 146157852,
        [EnumMember(Value = DocConstantValueType.FACILITY), SCDescript(DocConstantValueType.FACILITY), SSDescript(DocConstantValueType.FACILITY), SCDisplay(Name = DocConstantValueType.FACILITY)]
        FACILITY = 146157853,
        [EnumMember(Value = DocConstantValueType.FIXEDDOSEINTERVENTION), SCDescript(DocConstantValueType.FIXEDDOSEINTERVENTION), SSDescript(DocConstantValueType.FIXEDDOSEINTERVENTION), SCDisplay(Name = DocConstantValueType.FIXEDDOSEINTERVENTION)]
        FIXEDDOSEINTERVENTION = 74232450,
        [EnumMember(Value = DocConstantValueType.FLAG), SCDescript(DocConstantValueType.FLAG), SSDescript(DocConstantValueType.FLAG), SCDisplay(Name = DocConstantValueType.FLAG)]
        FLAG = 23807267,
        [EnumMember(Value = DocConstantValueType.FUNDING), SCDescript(DocConstantValueType.FUNDING), SSDescript(DocConstantValueType.FUNDING), SCDisplay(Name = DocConstantValueType.FUNDING)]
        FUNDING = 4793,
        [EnumMember(Value = DocConstantValueType.INTEGER), SCDescript(DocConstantValueType.INTEGER), SSDescript(DocConstantValueType.INTEGER), SCDisplay(Name = DocConstantValueType.INTEGER)]
        INTEGER = 4798,
        [EnumMember(Value = DocConstantValueType.INTERVAL), SCDescript(DocConstantValueType.INTERVAL), SSDescript(DocConstantValueType.INTERVAL), SCDisplay(Name = DocConstantValueType.INTERVAL)]
        INTERVAL = 4803,
        [EnumMember(Value = DocConstantValueType.INTERVALS), SCDescript(DocConstantValueType.INTERVALS), SSDescript(DocConstantValueType.INTERVALS), SCDisplay(Name = DocConstantValueType.INTERVALS)]
        INTERVALS = 96669233,
        [EnumMember(Value = DocConstantValueType.LOOKUP), SCDescript(DocConstantValueType.LOOKUP), SSDescript(DocConstantValueType.LOOKUP), SCDisplay(Name = DocConstantValueType.LOOKUP)]
        LOOKUP = 4808,
        [EnumMember(Value = DocConstantValueType.MEMO), SCDescript(DocConstantValueType.MEMO), SSDescript(DocConstantValueType.MEMO), SCDisplay(Name = DocConstantValueType.MEMO)]
        MEMO = 4813,
        [EnumMember(Value = DocConstantValueType.NPERSONS), SCDescript(DocConstantValueType.NPERSONS), SSDescript(DocConstantValueType.NPERSONS), SCDisplay(Name = DocConstantValueType.NPERSONS)]
        NPERSONS = 4818,
        [EnumMember(Value = DocConstantValueType.PARTICIPANT), SCDescript(DocConstantValueType.PARTICIPANT), SSDescript(DocConstantValueType.PARTICIPANT), SCDisplay(Name = DocConstantValueType.PARTICIPANT)]
        PARTICIPANT = 4823,
        [EnumMember(Value = DocConstantValueType.PARTICIPANTS), SCDescript(DocConstantValueType.PARTICIPANTS), SSDescript(DocConstantValueType.PARTICIPANTS), SCDisplay(Name = DocConstantValueType.PARTICIPANTS)]
        PARTICIPANTS = 4828,
        [EnumMember(Value = DocConstantValueType.POPULATIONANALYZED), SCDescript(DocConstantValueType.POPULATIONANALYZED), SSDescript(DocConstantValueType.POPULATIONANALYZED), SCDisplay(Name = DocConstantValueType.POPULATIONANALYZED)]
        POPULATIONANALYZED = 146157854,
        [EnumMember(Value = DocConstantValueType.PVALUE), SCDescript(DocConstantValueType.PVALUE), SSDescript(DocConstantValueType.PVALUE), SCDisplay(Name = DocConstantValueType.PVALUE)]
        PVALUE = 4833,
        [EnumMember(Value = DocConstantValueType.RATE), SCDescript(DocConstantValueType.RATE), SSDescript(DocConstantValueType.RATE), SCDisplay(Name = DocConstantValueType.RATE)]
        RATE = 4838,
        [EnumMember(Value = DocConstantValueType.SETTINGLOCATION), SCDescript(DocConstantValueType.SETTINGLOCATION), SSDescript(DocConstantValueType.SETTINGLOCATION), SCDisplay(Name = DocConstantValueType.SETTINGLOCATION)]
        SETTINGLOCATION = 4843,
        [EnumMember(Value = DocConstantValueType.SETTINGLOCATIONTOTAL), SCDescript(DocConstantValueType.SETTINGLOCATIONTOTAL), SSDescript(DocConstantValueType.SETTINGLOCATIONTOTAL), SCDisplay(Name = DocConstantValueType.SETTINGLOCATIONTOTAL)]
        SETTINGLOCATIONTOTAL = 4848,
        [EnumMember(Value = DocConstantValueType.STUDYDOC), SCDescript(DocConstantValueType.STUDYDOC), SSDescript(DocConstantValueType.STUDYDOC), SCDisplay(Name = DocConstantValueType.STUDYDOC)]
        STUDYDOC = 146157855,
        [EnumMember(Value = DocConstantValueType.STUDYOBJECTIVE), SCDescript(DocConstantValueType.STUDYOBJECTIVE), SSDescript(DocConstantValueType.STUDYOBJECTIVE), SCDisplay(Name = DocConstantValueType.STUDYOBJECTIVE)]
        STUDYOBJECTIVE = 67058546,
        [EnumMember(Value = DocConstantValueType.STUDYREFERENCE), SCDescript(DocConstantValueType.STUDYREFERENCE), SSDescript(DocConstantValueType.STUDYREFERENCE), SCDisplay(Name = DocConstantValueType.STUDYREFERENCE)]
        STUDYREFERENCE = 146157856,
        [EnumMember(Value = DocConstantValueType.SUBGROUPDESCRIPTOR), SCDescript(DocConstantValueType.SUBGROUPDESCRIPTOR), SSDescript(DocConstantValueType.SUBGROUPDESCRIPTOR), SCDisplay(Name = DocConstantValueType.SUBGROUPDESCRIPTOR)]
        SUBGROUPDESCRIPTOR = 4853,
        [EnumMember(Value = DocConstantValueType.TIMEPOINT), SCDescript(DocConstantValueType.TIMEPOINT), SSDescript(DocConstantValueType.TIMEPOINT), SCDisplay(Name = DocConstantValueType.TIMEPOINT)]
        TIMEPOINT = 4858,
        [EnumMember(Value = DocConstantValueType.TIMEPOINTS), SCDescript(DocConstantValueType.TIMEPOINTS), SSDescript(DocConstantValueType.TIMEPOINTS), SCDisplay(Name = DocConstantValueType.TIMEPOINTS)]
        TIMEPOINTS = 96669234,
        [EnumMember(Value = DocConstantValueType.UNCOLLECTEDVALUE), SCDescript(DocConstantValueType.UNCOLLECTEDVALUE), SSDescript(DocConstantValueType.UNCOLLECTEDVALUE), SCDisplay(Name = DocConstantValueType.UNCOLLECTEDVALUE)]
        UNCOLLECTEDVALUE = 4863,
        [EnumMember(Value = DocConstantValueType.UNITRANGE), SCDescript(DocConstantValueType.UNITRANGE), SSDescript(DocConstantValueType.UNITRANGE), SCDisplay(Name = DocConstantValueType.UNITRANGE)]
        UNITRANGE = 4868,
        [EnumMember(Value = DocConstantValueType.UNITS), SCDescript(DocConstantValueType.UNITS), SSDescript(DocConstantValueType.UNITS), SCDisplay(Name = DocConstantValueType.UNITS)]
        UNITS = 4873,
        [EnumMember(Value = DocConstantValueType.UNITSRANGE), SCDescript(DocConstantValueType.UNITSRANGE), SSDescript(DocConstantValueType.UNITSRANGE), SCDisplay(Name = DocConstantValueType.UNITSRANGE)]
        UNITSRANGE = 4878,
        [EnumMember(Value = DocConstantValueType.UNITVALUE), SCDescript(DocConstantValueType.UNITVALUE), SSDescript(DocConstantValueType.UNITVALUE), SCDisplay(Name = DocConstantValueType.UNITVALUE)]
        UNITVALUE = 4883,
        [EnumMember(Value = DocConstantValueType.YESNONA), SCDescript(DocConstantValueType.YESNONA), SSDescript(DocConstantValueType.YESNONA), SCDisplay(Name = DocConstantValueType.YESNONA)]
        YESNONA = 4893
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

        public static string ToEnumString(this ValueTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
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
        
        public static explicit operator DocConstantValueType(ValueTypeEnm Val) => new DocConstantValueType(Val.ToEnumString());

        public static explicit operator ValueTypeEnm(DocConstantValueType item)
        {
            Enum.TryParse<ValueTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

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
