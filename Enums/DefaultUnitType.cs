
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
    public enum DefaultUnitTypeEnm
    {
        [EnumMember(Value = DocConstantDefaultUnitType.SI), SCDescript(DocConstantDefaultUnitType.SI), SSDescript(DocConstantDefaultUnitType.SI), SCDisplay(Name = DocConstantDefaultUnitType.SI)]
        SI = 717,
        [EnumMember(Value = DocConstantDefaultUnitType.STUDY_SET_DEFAULT), SCDescript(DocConstantDefaultUnitType.STUDY_SET_DEFAULT), SSDescript(DocConstantDefaultUnitType.STUDY_SET_DEFAULT), SCDisplay(Name = DocConstantDefaultUnitType.STUDY_SET_DEFAULT)]
        STUDY_SET_DEFAULT = 722,
        [EnumMember(Value = DocConstantDefaultUnitType.US), SCDescript(DocConstantDefaultUnitType.US), SSDescript(DocConstantDefaultUnitType.US), SCDisplay(Name = DocConstantDefaultUnitType.US)]
        US = 727
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this DefaultUnitTypeEnm instance)
        {
            switch(instance)
            {
                case DefaultUnitTypeEnm.SI:
                    return DocConstantDefaultUnitType.SI;
                case DefaultUnitTypeEnm.STUDY_SET_DEFAULT:
                    return DocConstantDefaultUnitType.STUDY_SET_DEFAULT;
                case DefaultUnitTypeEnm.US:
                    return DocConstantDefaultUnitType.US;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this DefaultUnitTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantDefaultUnitType : IEquatable<DocConstantDefaultUnitType>, IEqualityComparer<DocConstantDefaultUnitType>
    {
        public const string SI = "SI";
        public const string STUDY_SET_DEFAULT = "Study Set Default";
        public const string US = "US";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantDefaultUnitType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantDefaultUnitType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantDefaultUnitType(string Val) => new DocConstantDefaultUnitType(Val);

        public static implicit operator string(DocConstantDefaultUnitType item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantDefaultUnitType(DefaultUnitTypeEnm Val) => new DocConstantDefaultUnitType(Val.ToEnumString());

        public static explicit operator DefaultUnitTypeEnm(DocConstantDefaultUnitType item)
        {
            Enum.TryParse<DefaultUnitTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantDefaultUnitType obj) => this == obj;

        public static bool operator ==(DocConstantDefaultUnitType x, DocConstantDefaultUnitType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantDefaultUnitType x, DocConstantDefaultUnitType y) => x == y;
        
        public static bool operator !=(DocConstantDefaultUnitType x, DocConstantDefaultUnitType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantDefaultUnitType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDefaultUnitType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantDefaultUnitType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
