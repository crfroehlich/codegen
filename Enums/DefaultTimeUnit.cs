
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
    public enum DefaultTimeUnitEnm
    {
        [EnumMember(Value = DocConstantDefaultTimeUnit.DAYS), SCDescript(DocConstantDefaultTimeUnit.DAYS), SSDescript(DocConstantDefaultTimeUnit.DAYS), SCDisplay(Name = DocConstantDefaultTimeUnit.DAYS)]
        DAYS = 682,
        [EnumMember(Value = DocConstantDefaultTimeUnit.HOURS), SCDescript(DocConstantDefaultTimeUnit.HOURS), SSDescript(DocConstantDefaultTimeUnit.HOURS), SCDisplay(Name = DocConstantDefaultTimeUnit.HOURS)]
        HOURS = 687,
        [EnumMember(Value = DocConstantDefaultTimeUnit.MINUTES), SCDescript(DocConstantDefaultTimeUnit.MINUTES), SSDescript(DocConstantDefaultTimeUnit.MINUTES), SCDisplay(Name = DocConstantDefaultTimeUnit.MINUTES)]
        MINUTES = 692,
        [EnumMember(Value = DocConstantDefaultTimeUnit.SECONDS), SCDescript(DocConstantDefaultTimeUnit.SECONDS), SSDescript(DocConstantDefaultTimeUnit.SECONDS), SCDisplay(Name = DocConstantDefaultTimeUnit.SECONDS)]
        SECONDS = 697,
        [EnumMember(Value = DocConstantDefaultTimeUnit.STUDY_SET_DEFAULT), SCDescript(DocConstantDefaultTimeUnit.STUDY_SET_DEFAULT), SSDescript(DocConstantDefaultTimeUnit.STUDY_SET_DEFAULT), SCDisplay(Name = DocConstantDefaultTimeUnit.STUDY_SET_DEFAULT)]
        STUDY_SET_DEFAULT = 702,
        [EnumMember(Value = DocConstantDefaultTimeUnit.WEEKS), SCDescript(DocConstantDefaultTimeUnit.WEEKS), SSDescript(DocConstantDefaultTimeUnit.WEEKS), SCDisplay(Name = DocConstantDefaultTimeUnit.WEEKS)]
        WEEKS = 707,
        [EnumMember(Value = DocConstantDefaultTimeUnit.YEARS), SCDescript(DocConstantDefaultTimeUnit.YEARS), SSDescript(DocConstantDefaultTimeUnit.YEARS), SCDisplay(Name = DocConstantDefaultTimeUnit.YEARS)]
        YEARS = 712
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this DefaultTimeUnitEnm instance)
        {
            switch(instance)
            {
                case DefaultTimeUnitEnm.DAYS:
                    return DocConstantDefaultTimeUnit.DAYS;
                case DefaultTimeUnitEnm.HOURS:
                    return DocConstantDefaultTimeUnit.HOURS;
                case DefaultTimeUnitEnm.MINUTES:
                    return DocConstantDefaultTimeUnit.MINUTES;
                case DefaultTimeUnitEnm.SECONDS:
                    return DocConstantDefaultTimeUnit.SECONDS;
                case DefaultTimeUnitEnm.STUDY_SET_DEFAULT:
                    return DocConstantDefaultTimeUnit.STUDY_SET_DEFAULT;
                case DefaultTimeUnitEnm.WEEKS:
                    return DocConstantDefaultTimeUnit.WEEKS;
                case DefaultTimeUnitEnm.YEARS:
                    return DocConstantDefaultTimeUnit.YEARS;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this DefaultTimeUnitEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantDefaultTimeUnit : IEquatable<DocConstantDefaultTimeUnit>, IEqualityComparer<DocConstantDefaultTimeUnit>
    {
        public const string DAYS = "d";
        public const string HOURS = "h";
        public const string MINUTES = "m";
        public const string SECONDS = "s";
        public const string STUDY_SET_DEFAULT = "Study Set Default";
        public const string WEEKS = "wk";
        public const string YEARS = "yr";

        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantDefaultTimeUnit).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantDefaultTimeUnit(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantDefaultTimeUnit(string Val) => new DocConstantDefaultTimeUnit(Val);

        public static implicit operator string(DocConstantDefaultTimeUnit item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantDefaultTimeUnit(DefaultTimeUnitEnm Val) => new DocConstantDefaultTimeUnit(Val.ToEnumString());

        public static explicit operator DefaultTimeUnitEnm(DocConstantDefaultTimeUnit item)
        {
            Enum.TryParse<DefaultTimeUnitEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        public bool Equals(DocConstantDefaultTimeUnit obj) => this == obj;

        public static bool operator ==(DocConstantDefaultTimeUnit x, DocConstantDefaultTimeUnit y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantDefaultTimeUnit x, DocConstantDefaultTimeUnit y) => x == y;
        
        public static bool operator !=(DocConstantDefaultTimeUnit x, DocConstantDefaultTimeUnit y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantDefaultTimeUnit))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDefaultTimeUnit) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantDefaultTimeUnit obj) => obj?.GetHashCode() ?? -17;
    }
}
