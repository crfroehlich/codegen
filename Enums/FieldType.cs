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
    public enum FieldTypeEnm
    {
        [EnumMember(Value = DocConstantFieldType.BINARY), SCDescript(DocConstantFieldType.BINARY), SSDescript(DocConstantFieldType.BINARY), SCDisplay(Name = DocConstantFieldType.BINARY)]
        BINARY = 1027,
        [EnumMember(Value = DocConstantFieldType.CONTINUOUS), SCDescript(DocConstantFieldType.CONTINUOUS), SSDescript(DocConstantFieldType.CONTINUOUS), SCDisplay(Name = DocConstantFieldType.CONTINUOUS)]
        CONTINUOUS = 1032,
        [EnumMember(Value = DocConstantFieldType.COUNT), SCDescript(DocConstantFieldType.COUNT), SSDescript(DocConstantFieldType.COUNT), SCDisplay(Name = DocConstantFieldType.COUNT)]
        COUNT = 1037,
        [EnumMember(Value = DocConstantFieldType.INDIVIDUAL), SCDescript(DocConstantFieldType.INDIVIDUAL), SSDescript(DocConstantFieldType.INDIVIDUAL), SCDisplay(Name = DocConstantFieldType.INDIVIDUAL)]
        INDIVIDUAL = 14739713,
        [EnumMember(Value = DocConstantFieldType.KAPLAN_MEIER), SCDescript(DocConstantFieldType.KAPLAN_MEIER), SSDescript(DocConstantFieldType.KAPLAN_MEIER), SCDisplay(Name = DocConstantFieldType.KAPLAN_MEIER)]
        KAPLAN_MEIER = 77893240,
        [EnumMember(Value = DocConstantFieldType.RANGE), SCDescript(DocConstantFieldType.RANGE), SSDescript(DocConstantFieldType.RANGE), SCDisplay(Name = DocConstantFieldType.RANGE)]
        RANGE = 1042,
        [EnumMember(Value = DocConstantFieldType.RATE), SCDescript(DocConstantFieldType.RATE), SSDescript(DocConstantFieldType.RATE), SCDisplay(Name = DocConstantFieldType.RATE)]
        RATE = 25812406,
        [EnumMember(Value = DocConstantFieldType.YES_NO_NA), SCDescript(DocConstantFieldType.YES_NO_NA), SSDescript(DocConstantFieldType.YES_NO_NA), SCDisplay(Name = DocConstantFieldType.YES_NO_NA)]
        YES_NO_NA = 1047
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this FieldTypeEnm instance)
        {
            switch(instance)
            {
                case FieldTypeEnm.BINARY:
                    return DocConstantFieldType.BINARY;
                case FieldTypeEnm.CONTINUOUS:
                    return DocConstantFieldType.CONTINUOUS;
                case FieldTypeEnm.COUNT:
                    return DocConstantFieldType.COUNT;
                case FieldTypeEnm.INDIVIDUAL:
                    return DocConstantFieldType.INDIVIDUAL;
                case FieldTypeEnm.KAPLAN_MEIER:
                    return DocConstantFieldType.KAPLAN_MEIER;
                case FieldTypeEnm.RANGE:
                    return DocConstantFieldType.RANGE;
                case FieldTypeEnm.RATE:
                    return DocConstantFieldType.RATE;
                case FieldTypeEnm.YES_NO_NA:
                    return DocConstantFieldType.YES_NO_NA;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this FieldTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantFieldType : IEquatable<DocConstantFieldType>, IEqualityComparer<DocConstantFieldType>
    {
        public const string BINARY = "Binary";
        public const string CONTINUOUS = "Continuous";
        public const string COUNT = "Count";
        public const string INDIVIDUAL = "Individual";
        public const string KAPLAN_MEIER = "Kaplan-Meier";
        public const string RANGE = "Range";
        public const string RATE = "Rate";
        public const string YES_NO_NA = "Yes/No/Na";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantFieldType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantFieldType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantFieldType(string Val) => new DocConstantFieldType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantFieldType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantFieldType(FieldTypeEnm Val) => new DocConstantFieldType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator FieldTypeEnm(DocConstantFieldType item)
        {
            Enum.TryParse<FieldTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantFieldType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantFieldType x, DocConstantFieldType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantFieldType x, DocConstantFieldType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantFieldType x, DocConstantFieldType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantFieldType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantFieldType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantFieldType obj) => obj?.GetHashCode() ?? -17;
    }
}
