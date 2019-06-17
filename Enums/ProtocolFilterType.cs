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
    public enum ProtocolFilterTypeEnm
    {
        [EnumMember(Value = DocConstantProtocolFilterType.ATTRIBUTE), SCDescript(DocConstantProtocolFilterType.ATTRIBUTE), SSDescript(DocConstantProtocolFilterType.ATTRIBUTE), SCDisplay(Name = DocConstantProtocolFilterType.ATTRIBUTE)]
        ATTRIBUTE = 9093573,
        [EnumMember(Value = DocConstantProtocolFilterType.ATTRIBUTE_LABEL), SCDescript(DocConstantProtocolFilterType.ATTRIBUTE_LABEL), SSDescript(DocConstantProtocolFilterType.ATTRIBUTE_LABEL), SCDisplay(Name = DocConstantProtocolFilterType.ATTRIBUTE_LABEL)]
        ATTRIBUTE_LABEL = 9093578,
        [EnumMember(Value = DocConstantProtocolFilterType.FIRST_CLASS), SCDescript(DocConstantProtocolFilterType.FIRST_CLASS), SSDescript(DocConstantProtocolFilterType.FIRST_CLASS), SCDisplay(Name = DocConstantProtocolFilterType.FIRST_CLASS)]
        FIRST_CLASS = 9093583
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this ProtocolFilterTypeEnm instance)
        {
            switch(instance)
            {
                case ProtocolFilterTypeEnm.ATTRIBUTE:
                    return DocConstantProtocolFilterType.ATTRIBUTE;
                case ProtocolFilterTypeEnm.ATTRIBUTE_LABEL:
                    return DocConstantProtocolFilterType.ATTRIBUTE_LABEL;
                case ProtocolFilterTypeEnm.FIRST_CLASS:
                    return DocConstantProtocolFilterType.FIRST_CLASS;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this ProtocolFilterTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantProtocolFilterType : IEquatable<DocConstantProtocolFilterType>, IEqualityComparer<DocConstantProtocolFilterType>
    {
        public const string ATTRIBUTE = "Attribute";
        public const string ATTRIBUTE_LABEL = "Attribute Label";
        public const string FIRST_CLASS = "First Class";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantProtocolFilterType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantProtocolFilterType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantProtocolFilterType(string Val) => new DocConstantProtocolFilterType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantProtocolFilterType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantProtocolFilterType(ProtocolFilterTypeEnm Val) => new DocConstantProtocolFilterType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator ProtocolFilterTypeEnm(DocConstantProtocolFilterType item)
        {
            Enum.TryParse<ProtocolFilterTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantProtocolFilterType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantProtocolFilterType x, DocConstantProtocolFilterType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantProtocolFilterType x, DocConstantProtocolFilterType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantProtocolFilterType x, DocConstantProtocolFilterType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantProtocolFilterType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantProtocolFilterType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantProtocolFilterType obj) => obj?.GetHashCode() ?? -17;
    }
}
