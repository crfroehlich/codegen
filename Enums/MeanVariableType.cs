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
    public enum MeanVariableTypeEnm
    {
        [EnumMember(Value = DocConstantMeanVariableType.AVERAGE), SCDescript(DocConstantMeanVariableType.AVERAGE), SSDescript(DocConstantMeanVariableType.AVERAGE), SCDisplay(Name = DocConstantMeanVariableType.AVERAGE)]
        AVERAGE = 2137,
        [EnumMember(Value = DocConstantMeanVariableType.ESTIMATED_PROPORTION), SCDescript(DocConstantMeanVariableType.ESTIMATED_PROPORTION), SSDescript(DocConstantMeanVariableType.ESTIMATED_PROPORTION), SCDisplay(Name = DocConstantMeanVariableType.ESTIMATED_PROPORTION)]
        ESTIMATED_PROPORTION = 2162,
        [EnumMember(Value = DocConstantMeanVariableType.FIXED), SCDescript(DocConstantMeanVariableType.FIXED), SSDescript(DocConstantMeanVariableType.FIXED), SCDisplay(Name = DocConstantMeanVariableType.FIXED)]
        FIXED = 2142,
        [EnumMember(Value = DocConstantMeanVariableType.FLEX), SCDescript(DocConstantMeanVariableType.FLEX), SSDescript(DocConstantMeanVariableType.FLEX), SCDisplay(Name = DocConstantMeanVariableType.FLEX)]
        FLEX = 2147,
        [EnumMember(Value = DocConstantMeanVariableType.MEAN), SCDescript(DocConstantMeanVariableType.MEAN), SSDescript(DocConstantMeanVariableType.MEAN), SCDisplay(Name = DocConstantMeanVariableType.MEAN)]
        MEAN = 2152,
        [EnumMember(Value = DocConstantMeanVariableType.MEDIAN), SCDescript(DocConstantMeanVariableType.MEDIAN), SSDescript(DocConstantMeanVariableType.MEDIAN), SCDisplay(Name = DocConstantMeanVariableType.MEDIAN)]
        MEDIAN = 2157,
        [EnumMember(Value = DocConstantMeanVariableType.RATIO), SCDescript(DocConstantMeanVariableType.RATIO), SSDescript(DocConstantMeanVariableType.RATIO), SCDisplay(Name = DocConstantMeanVariableType.RATIO)]
        RATIO = 2167
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this MeanVariableTypeEnm instance)
        {
            switch(instance)
            {
                case MeanVariableTypeEnm.AVERAGE:
                    return DocConstantMeanVariableType.AVERAGE;
                case MeanVariableTypeEnm.ESTIMATED_PROPORTION:
                    return DocConstantMeanVariableType.ESTIMATED_PROPORTION;
                case MeanVariableTypeEnm.FIXED:
                    return DocConstantMeanVariableType.FIXED;
                case MeanVariableTypeEnm.FLEX:
                    return DocConstantMeanVariableType.FLEX;
                case MeanVariableTypeEnm.MEAN:
                    return DocConstantMeanVariableType.MEAN;
                case MeanVariableTypeEnm.MEDIAN:
                    return DocConstantMeanVariableType.MEDIAN;
                case MeanVariableTypeEnm.RATIO:
                    return DocConstantMeanVariableType.RATIO;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this MeanVariableTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantMeanVariableType : IEquatable<DocConstantMeanVariableType>, IEqualityComparer<DocConstantMeanVariableType>
    {
        public const string AVERAGE = "Average";
        public const string ESTIMATED_PROPORTION = "Estimated Proportion";
        public const string FIXED = "Fixed";
        public const string FLEX = "Flex";
        public const string MEAN = "Mean";
        public const string MEDIAN = "Median";
        public const string RATIO = "Ratio";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantMeanVariableType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantMeanVariableType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantMeanVariableType(string Val) => new DocConstantMeanVariableType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantMeanVariableType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantMeanVariableType(MeanVariableTypeEnm Val) => new DocConstantMeanVariableType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator MeanVariableTypeEnm(DocConstantMeanVariableType item)
        {
            Enum.TryParse<MeanVariableTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantMeanVariableType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantMeanVariableType x, DocConstantMeanVariableType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantMeanVariableType x, DocConstantMeanVariableType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantMeanVariableType x, DocConstantMeanVariableType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantMeanVariableType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantMeanVariableType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantMeanVariableType obj) => obj?.GetHashCode() ?? -17;
    }
}
