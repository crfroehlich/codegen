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
    public enum TimepointTypeEnm
    {
        [EnumMember(Value = DocConstantTimepointType.AFTER), SCDescript(DocConstantTimepointType.AFTER), SSDescript(DocConstantTimepointType.AFTER), SCDisplay(Name = DocConstantTimepointType.AFTER)]
        AFTER = 10709242,
        [EnumMember(Value = DocConstantTimepointType.AVERAGE), SCDescript(DocConstantTimepointType.AVERAGE), SSDescript(DocConstantTimepointType.AVERAGE), SCDisplay(Name = DocConstantTimepointType.AVERAGE)]
        AVERAGE = 3813,
        [EnumMember(Value = DocConstantTimepointType.BEFORE), SCDescript(DocConstantTimepointType.BEFORE), SSDescript(DocConstantTimepointType.BEFORE), SCDisplay(Name = DocConstantTimepointType.BEFORE)]
        BEFORE = 11793786,
        [EnumMember(Value = DocConstantTimepointType.DURATION), SCDescript(DocConstantTimepointType.DURATION), SSDescript(DocConstantTimepointType.DURATION), SCDisplay(Name = DocConstantTimepointType.DURATION)]
        DURATION = 3818,
        [EnumMember(Value = DocConstantTimepointType.DURING), SCDescript(DocConstantTimepointType.DURING), SSDescript(DocConstantTimepointType.DURING), SCDisplay(Name = DocConstantTimepointType.DURING)]
        DURING = 11793791,
        [EnumMember(Value = DocConstantTimepointType.MAX_RANGE), SCDescript(DocConstantTimepointType.MAX_RANGE), SSDescript(DocConstantTimepointType.MAX_RANGE), SCDisplay(Name = DocConstantTimepointType.MAX_RANGE)]
        MAX_RANGE = 3823,
        [EnumMember(Value = DocConstantTimepointType.MAXIMUM), SCDescript(DocConstantTimepointType.MAXIMUM), SSDescript(DocConstantTimepointType.MAXIMUM), SCDisplay(Name = DocConstantTimepointType.MAXIMUM)]
        MAXIMUM = 3828,
        [EnumMember(Value = DocConstantTimepointType.MEAN), SCDescript(DocConstantTimepointType.MEAN), SSDescript(DocConstantTimepointType.MEAN), SCDisplay(Name = DocConstantTimepointType.MEAN)]
        MEAN = 3833,
        [EnumMember(Value = DocConstantTimepointType.MEDIAN), SCDescript(DocConstantTimepointType.MEDIAN), SSDescript(DocConstantTimepointType.MEDIAN), SCDisplay(Name = DocConstantTimepointType.MEDIAN)]
        MEDIAN = 3838,
        [EnumMember(Value = DocConstantTimepointType.NA), SCDescript(DocConstantTimepointType.NA), SSDescript(DocConstantTimepointType.NA), SCDisplay(Name = DocConstantTimepointType.NA)]
        NA = 3843,
        [EnumMember(Value = DocConstantTimepointType.NONE), SCDescript(DocConstantTimepointType.NONE), SSDescript(DocConstantTimepointType.NONE), SCDisplay(Name = DocConstantTimepointType.NONE)]
        NONE = 3848,
        [EnumMember(Value = DocConstantTimepointType.NR), SCDescript(DocConstantTimepointType.NR), SSDescript(DocConstantTimepointType.NR), SCDisplay(Name = DocConstantTimepointType.NR)]
        NR = 3853,
        [EnumMember(Value = DocConstantTimepointType.TIME_ZERO), SCDescript(DocConstantTimepointType.TIME_ZERO), SSDescript(DocConstantTimepointType.TIME_ZERO), SCDisplay(Name = DocConstantTimepointType.TIME_ZERO)]
        TIME_ZERO = 3858,
        [EnumMember(Value = DocConstantTimepointType.TOTAL), SCDescript(DocConstantTimepointType.TOTAL), SSDescript(DocConstantTimepointType.TOTAL), SCDisplay(Name = DocConstantTimepointType.TOTAL)]
        TOTAL = 3863,
        [EnumMember(Value = DocConstantTimepointType.VARIES), SCDescript(DocConstantTimepointType.VARIES), SSDescript(DocConstantTimepointType.VARIES), SCDisplay(Name = DocConstantTimepointType.VARIES)]
        VARIES = 9377173
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this TimepointTypeEnm instance)
        {
            switch(instance)
            {
                case TimepointTypeEnm.AFTER:
                    return DocConstantTimepointType.AFTER;
                case TimepointTypeEnm.AVERAGE:
                    return DocConstantTimepointType.AVERAGE;
                case TimepointTypeEnm.BEFORE:
                    return DocConstantTimepointType.BEFORE;
                case TimepointTypeEnm.DURATION:
                    return DocConstantTimepointType.DURATION;
                case TimepointTypeEnm.DURING:
                    return DocConstantTimepointType.DURING;
                case TimepointTypeEnm.MAX_RANGE:
                    return DocConstantTimepointType.MAX_RANGE;
                case TimepointTypeEnm.MAXIMUM:
                    return DocConstantTimepointType.MAXIMUM;
                case TimepointTypeEnm.MEAN:
                    return DocConstantTimepointType.MEAN;
                case TimepointTypeEnm.MEDIAN:
                    return DocConstantTimepointType.MEDIAN;
                case TimepointTypeEnm.NA:
                    return DocConstantTimepointType.NA;
                case TimepointTypeEnm.NONE:
                    return DocConstantTimepointType.NONE;
                case TimepointTypeEnm.NR:
                    return DocConstantTimepointType.NR;
                case TimepointTypeEnm.TIME_ZERO:
                    return DocConstantTimepointType.TIME_ZERO;
                case TimepointTypeEnm.TOTAL:
                    return DocConstantTimepointType.TOTAL;
                case TimepointTypeEnm.VARIES:
                    return DocConstantTimepointType.VARIES;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this TimepointTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantTimepointType : IEquatable<DocConstantTimepointType>, IEqualityComparer<DocConstantTimepointType>
    {
        public const string AFTER = "After";
        public const string AVERAGE = "Average";
        public const string BEFORE = "Before";
        public const string DURATION = "Duration";
        public const string DURING = "During";
        public const string MAX_RANGE = "Max Range";
        public const string MAXIMUM = "Maximum";
        public const string MEAN = "Mean";
        public const string MEDIAN = "Median";
        public const string NA = "N/A";
        public const string NONE = "None";
        public const string NR = "Not Reported";
        public const string TIME_ZERO = "Time Zero";
        public const string TOTAL = "Total";
        public const string VARIES = "Varies";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantTimepointType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantTimepointType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantTimepointType(string Val) => new DocConstantTimepointType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantTimepointType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantTimepointType(TimepointTypeEnm Val) => new DocConstantTimepointType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator TimepointTypeEnm(DocConstantTimepointType item)
        {
            Enum.TryParse<TimepointTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantTimepointType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantTimepointType x, DocConstantTimepointType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantTimepointType x, DocConstantTimepointType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantTimepointType x, DocConstantTimepointType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantTimepointType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantTimepointType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantTimepointType obj) => obj?.GetHashCode() ?? -17;
    }
}
