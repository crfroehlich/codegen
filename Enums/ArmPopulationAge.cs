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
    public enum ArmPopulationAgeEnm
    {
        [EnumMember(Value = DocConstantArmPopulationAge.MEAN_RANGE), SCDescript(DocConstantArmPopulationAge.MEAN_RANGE), SSDescript(DocConstantArmPopulationAge.MEAN_RANGE), SCDisplay(Name = DocConstantArmPopulationAge.MEAN_RANGE)]
        MEAN_RANGE = 153,
        [EnumMember(Value = DocConstantArmPopulationAge.MEAN_SD), SCDescript(DocConstantArmPopulationAge.MEAN_SD), SSDescript(DocConstantArmPopulationAge.MEAN_SD), SCDisplay(Name = DocConstantArmPopulationAge.MEAN_SD)]
        MEAN_SD = 158,
        [EnumMember(Value = DocConstantArmPopulationAge.MEAN_SE), SCDescript(DocConstantArmPopulationAge.MEAN_SE), SSDescript(DocConstantArmPopulationAge.MEAN_SE), SCDisplay(Name = DocConstantArmPopulationAge.MEAN_SE)]
        MEAN_SE = 163,
        [EnumMember(Value = DocConstantArmPopulationAge.MEDIAN_RANGE), SCDescript(DocConstantArmPopulationAge.MEDIAN_RANGE), SSDescript(DocConstantArmPopulationAge.MEDIAN_RANGE), SCDisplay(Name = DocConstantArmPopulationAge.MEDIAN_RANGE)]
        MEDIAN_RANGE = 168,
        [EnumMember(Value = DocConstantArmPopulationAge.MEDIAN_SD), SCDescript(DocConstantArmPopulationAge.MEDIAN_SD), SSDescript(DocConstantArmPopulationAge.MEDIAN_SD), SCDisplay(Name = DocConstantArmPopulationAge.MEDIAN_SD)]
        MEDIAN_SD = 173,
        [EnumMember(Value = DocConstantArmPopulationAge.MEDIAN_SE), SCDescript(DocConstantArmPopulationAge.MEDIAN_SE), SSDescript(DocConstantArmPopulationAge.MEDIAN_SE), SCDisplay(Name = DocConstantArmPopulationAge.MEDIAN_SE)]
        MEDIAN_SE = 178
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ArmPopulationAgeEnm instance)
        {
            switch(instance)
            {
                case ArmPopulationAgeEnm.MEAN_RANGE:
                    return DocConstantArmPopulationAge.MEAN_RANGE;
                case ArmPopulationAgeEnm.MEAN_SD:
                    return DocConstantArmPopulationAge.MEAN_SD;
                case ArmPopulationAgeEnm.MEAN_SE:
                    return DocConstantArmPopulationAge.MEAN_SE;
                case ArmPopulationAgeEnm.MEDIAN_RANGE:
                    return DocConstantArmPopulationAge.MEDIAN_RANGE;
                case ArmPopulationAgeEnm.MEDIAN_SD:
                    return DocConstantArmPopulationAge.MEDIAN_SD;
                case ArmPopulationAgeEnm.MEDIAN_SE:
                    return DocConstantArmPopulationAge.MEDIAN_SE;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this ArmPopulationAgeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantArmPopulationAge : IEquatable<DocConstantArmPopulationAge>, IEqualityComparer<DocConstantArmPopulationAge>
    {
        public const string MEAN_RANGE = "Mean (Range)";
        public const string MEAN_SD = "Mean +/- SD";
        public const string MEAN_SE = "Mean +/- SE";
        public const string MEDIAN_RANGE = "Median (Range)";
        public const string MEDIAN_SD = "Median +/- SD";
        public const string MEDIAN_SE = "Median +/- SE";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantArmPopulationAge).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantArmPopulationAge(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantArmPopulationAge(string Val) => new DocConstantArmPopulationAge(Val);

        public static implicit operator string(DocConstantArmPopulationAge item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantArmPopulationAge(ArmPopulationAgeEnm Val) => new DocConstantArmPopulationAge(Val.ToEnumString());

        public static explicit operator ArmPopulationAgeEnm(DocConstantArmPopulationAge item)
        {
            Enum.TryParse<ArmPopulationAgeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantArmPopulationAge obj) => this == obj;

        public static bool operator ==(DocConstantArmPopulationAge x, DocConstantArmPopulationAge y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantArmPopulationAge x, DocConstantArmPopulationAge y) => x == y;
        
        public static bool operator !=(DocConstantArmPopulationAge x, DocConstantArmPopulationAge y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantArmPopulationAge))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantArmPopulationAge) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantArmPopulationAge obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
