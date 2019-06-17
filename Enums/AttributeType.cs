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
    public enum AttributeTypeEnm
    {
        [EnumMember(Value = DocConstantAttributeType.CHANGE), SCDescript(DocConstantAttributeType.CHANGE), SSDescript(DocConstantAttributeType.CHANGE), SCDisplay(Name = DocConstantAttributeType.CHANGE)]
        CHANGE = 322,
        [EnumMember(Value = DocConstantAttributeType.DURATION), SCDescript(DocConstantAttributeType.DURATION), SSDescript(DocConstantAttributeType.DURATION), SCDisplay(Name = DocConstantAttributeType.DURATION)]
        DURATION = 327,
        [EnumMember(Value = DocConstantAttributeType.NOT_IN_STUDY), SCDescript(DocConstantAttributeType.NOT_IN_STUDY), SSDescript(DocConstantAttributeType.NOT_IN_STUDY), SCDisplay(Name = DocConstantAttributeType.NOT_IN_STUDY)]
        NOT_IN_STUDY = 332,
        [EnumMember(Value = DocConstantAttributeType.PERCENT_CHANGE), SCDescript(DocConstantAttributeType.PERCENT_CHANGE), SSDescript(DocConstantAttributeType.PERCENT_CHANGE), SCDisplay(Name = DocConstantAttributeType.PERCENT_CHANGE)]
        PERCENT_CHANGE = 337,
        [EnumMember(Value = DocConstantAttributeType.STANDARD), SCDescript(DocConstantAttributeType.STANDARD), SSDescript(DocConstantAttributeType.STANDARD), SCDisplay(Name = DocConstantAttributeType.STANDARD)]
        STANDARD = 342,
        [EnumMember(Value = DocConstantAttributeType.TIME_SINCE), SCDescript(DocConstantAttributeType.TIME_SINCE), SSDescript(DocConstantAttributeType.TIME_SINCE), SCDisplay(Name = DocConstantAttributeType.TIME_SINCE)]
        TIME_SINCE = 347,
        [EnumMember(Value = DocConstantAttributeType.TIME_TO), SCDescript(DocConstantAttributeType.TIME_TO), SSDescript(DocConstantAttributeType.TIME_TO), SCDisplay(Name = DocConstantAttributeType.TIME_TO)]
        TIME_TO = 352
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this AttributeTypeEnm instance)
        {
            switch(instance)
            {
                case AttributeTypeEnm.CHANGE:
                    return DocConstantAttributeType.CHANGE;
                case AttributeTypeEnm.DURATION:
                    return DocConstantAttributeType.DURATION;
                case AttributeTypeEnm.NOT_IN_STUDY:
                    return DocConstantAttributeType.NOT_IN_STUDY;
                case AttributeTypeEnm.PERCENT_CHANGE:
                    return DocConstantAttributeType.PERCENT_CHANGE;
                case AttributeTypeEnm.STANDARD:
                    return DocConstantAttributeType.STANDARD;
                case AttributeTypeEnm.TIME_SINCE:
                    return DocConstantAttributeType.TIME_SINCE;
                case AttributeTypeEnm.TIME_TO:
                    return DocConstantAttributeType.TIME_TO;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this AttributeTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantAttributeType : IEquatable<DocConstantAttributeType>, IEqualityComparer<DocConstantAttributeType>
    {
        public const string CHANGE = "Change";
        public const string DURATION = "Duration";
        public const string NOT_IN_STUDY = "Not In Study";
        public const string PERCENT_CHANGE = "% Change";
        public const string STANDARD = "Standard";
        public const string TIME_SINCE = "Time Since";
        public const string TIME_TO = "Time To";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantAttributeType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantAttributeType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantAttributeType(string Val) => new DocConstantAttributeType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantAttributeType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantAttributeType(AttributeTypeEnm Val) => new DocConstantAttributeType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator AttributeTypeEnm(DocConstantAttributeType item)
        {
            Enum.TryParse<AttributeTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantAttributeType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantAttributeType x, DocConstantAttributeType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantAttributeType x, DocConstantAttributeType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantAttributeType x, DocConstantAttributeType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantAttributeType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantAttributeType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantAttributeType obj) => obj?.GetHashCode() ?? -17;
    }
}
