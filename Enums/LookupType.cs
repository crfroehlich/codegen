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
    public enum LookupTypeEnm
    {
        [EnumMember(Value = DocConstantLookupType.CHARACTERISTIC), SCDescript(DocConstantLookupType.CHARACTERISTIC), SSDescript(DocConstantLookupType.CHARACTERISTIC), SCDisplay(Name = DocConstantLookupType.CHARACTERISTIC)]
        CHARACTERISTIC = 46350952,
        [EnumMember(Value = DocConstantLookupType.COMPARATOR), SCDescript(DocConstantLookupType.COMPARATOR), SSDescript(DocConstantLookupType.COMPARATOR), SCDisplay(Name = DocConstantLookupType.COMPARATOR)]
        COMPARATOR = 46350957,
        [EnumMember(Value = DocConstantLookupType.INTERVENTION), SCDescript(DocConstantLookupType.INTERVENTION), SSDescript(DocConstantLookupType.INTERVENTION), SCDisplay(Name = DocConstantLookupType.INTERVENTION)]
        INTERVENTION = 46350962,
        [EnumMember(Value = DocConstantLookupType.OUTCOME), SCDescript(DocConstantLookupType.OUTCOME), SSDescript(DocConstantLookupType.OUTCOME), SCDisplay(Name = DocConstantLookupType.OUTCOME)]
        OUTCOME = 46350967,
        [EnumMember(Value = DocConstantLookupType.STUDY_DESIGN), SCDescript(DocConstantLookupType.STUDY_DESIGN), SSDescript(DocConstantLookupType.STUDY_DESIGN), SCDisplay(Name = DocConstantLookupType.STUDY_DESIGN)]
        STUDY_DESIGN = 46350973,
        [EnumMember(Value = DocConstantLookupType.STUDY_TYPE), SCDescript(DocConstantLookupType.STUDY_TYPE), SSDescript(DocConstantLookupType.STUDY_TYPE), SCDisplay(Name = DocConstantLookupType.STUDY_TYPE)]
        STUDY_TYPE = 46350979
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this LookupTypeEnm instance)
        {
            switch(instance)
            {
                case LookupTypeEnm.CHARACTERISTIC:
                    return DocConstantLookupType.CHARACTERISTIC;
                case LookupTypeEnm.COMPARATOR:
                    return DocConstantLookupType.COMPARATOR;
                case LookupTypeEnm.INTERVENTION:
                    return DocConstantLookupType.INTERVENTION;
                case LookupTypeEnm.OUTCOME:
                    return DocConstantLookupType.OUTCOME;
                case LookupTypeEnm.STUDY_DESIGN:
                    return DocConstantLookupType.STUDY_DESIGN;
                case LookupTypeEnm.STUDY_TYPE:
                    return DocConstantLookupType.STUDY_TYPE;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this LookupTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantLookupType : IEquatable<DocConstantLookupType>, IEqualityComparer<DocConstantLookupType>
    {
        public const string CHARACTERISTIC = "Characteristic";
        public const string COMPARATOR = "Comparator";
        public const string INTERVENTION = "Intervention";
        public const string OUTCOME = "Outcome";
        public const string STUDY_DESIGN = "Study Design";
        public const string STUDY_TYPE = "Study Type";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantLookupType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantLookupType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantLookupType(string Val) => new DocConstantLookupType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantLookupType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantLookupType(LookupTypeEnm Val) => new DocConstantLookupType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator LookupTypeEnm(DocConstantLookupType item)
        {
            Enum.TryParse<LookupTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantLookupType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantLookupType x, DocConstantLookupType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantLookupType x, DocConstantLookupType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantLookupType x, DocConstantLookupType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantLookupType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantLookupType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantLookupType obj) => obj?.GetHashCode() ?? -17;
    }
}
