
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
    public enum SettingTypeEnm
    {
        [EnumMember(Value = DocConstantSettingType.CRIMINAL_JUSTICE_SYSTEM), SCDescript(DocConstantSettingType.CRIMINAL_JUSTICE_SYSTEM), SSDescript(DocConstantSettingType.CRIMINAL_JUSTICE_SYSTEM), SCDisplay(Name = DocConstantSettingType.CRIMINAL_JUSTICE_SYSTEM)]
        CRIMINAL_JUSTICE_SYSTEM = 2887,
        [EnumMember(Value = DocConstantSettingType.EDUCATION_SYSTEM), SCDescript(DocConstantSettingType.EDUCATION_SYSTEM), SSDescript(DocConstantSettingType.EDUCATION_SYSTEM), SCDisplay(Name = DocConstantSettingType.EDUCATION_SYSTEM)]
        EDUCATION_SYSTEM = 2892,
        [EnumMember(Value = DocConstantSettingType.HOME), SCDescript(DocConstantSettingType.HOME), SSDescript(DocConstantSettingType.HOME), SCDisplay(Name = DocConstantSettingType.HOME)]
        HOME = 2897,
        [EnumMember(Value = DocConstantSettingType.INPATIENT), SCDescript(DocConstantSettingType.INPATIENT), SSDescript(DocConstantSettingType.INPATIENT), SCDisplay(Name = DocConstantSettingType.INPATIENT)]
        INPATIENT = 2902,
        [EnumMember(Value = DocConstantSettingType.MIXED), SCDescript(DocConstantSettingType.MIXED), SSDescript(DocConstantSettingType.MIXED), SCDisplay(Name = DocConstantSettingType.MIXED)]
        MIXED = 2907,
        [EnumMember(Value = DocConstantSettingType.NA), SCDescript(DocConstantSettingType.NA), SSDescript(DocConstantSettingType.NA), SCDisplay(Name = DocConstantSettingType.NA)]
        NA = 2912,
        [EnumMember(Value = DocConstantSettingType.NR), SCDescript(DocConstantSettingType.NR), SSDescript(DocConstantSettingType.NR), SCDisplay(Name = DocConstantSettingType.NR)]
        NR = 2917,
        [EnumMember(Value = DocConstantSettingType.OTHER), SCDescript(DocConstantSettingType.OTHER), SSDescript(DocConstantSettingType.OTHER), SCDisplay(Name = DocConstantSettingType.OTHER)]
        OTHER = 2922,
        [EnumMember(Value = DocConstantSettingType.OUTPATIENT), SCDescript(DocConstantSettingType.OUTPATIENT), SSDescript(DocConstantSettingType.OUTPATIENT), SCDisplay(Name = DocConstantSettingType.OUTPATIENT)]
        OUTPATIENT = 2927,
        [EnumMember(Value = DocConstantSettingType.SURVEY), SCDescript(DocConstantSettingType.SURVEY), SSDescript(DocConstantSettingType.SURVEY), SCDisplay(Name = DocConstantSettingType.SURVEY)]
        SURVEY = 2932,
        [EnumMember(Value = DocConstantSettingType.UNCLEAR), SCDescript(DocConstantSettingType.UNCLEAR), SSDescript(DocConstantSettingType.UNCLEAR), SCDisplay(Name = DocConstantSettingType.UNCLEAR)]
        UNCLEAR = 2937
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this SettingTypeEnm instance)
        {
            switch(instance)
            {
                case SettingTypeEnm.CRIMINAL_JUSTICE_SYSTEM:
                    return DocConstantSettingType.CRIMINAL_JUSTICE_SYSTEM;
                case SettingTypeEnm.EDUCATION_SYSTEM:
                    return DocConstantSettingType.EDUCATION_SYSTEM;
                case SettingTypeEnm.HOME:
                    return DocConstantSettingType.HOME;
                case SettingTypeEnm.INPATIENT:
                    return DocConstantSettingType.INPATIENT;
                case SettingTypeEnm.MIXED:
                    return DocConstantSettingType.MIXED;
                case SettingTypeEnm.NA:
                    return DocConstantSettingType.NA;
                case SettingTypeEnm.NR:
                    return DocConstantSettingType.NR;
                case SettingTypeEnm.OTHER:
                    return DocConstantSettingType.OTHER;
                case SettingTypeEnm.OUTPATIENT:
                    return DocConstantSettingType.OUTPATIENT;
                case SettingTypeEnm.SURVEY:
                    return DocConstantSettingType.SURVEY;
                case SettingTypeEnm.UNCLEAR:
                    return DocConstantSettingType.UNCLEAR;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this SettingTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantSettingType : IEquatable<DocConstantSettingType>, IEqualityComparer<DocConstantSettingType>
    {
        public const string CRIMINAL_JUSTICE_SYSTEM = "Criminal Justice System";
        public const string EDUCATION_SYSTEM = "Education System";
        public const string HOME = "Home";
        public const string INPATIENT = "Inpatient";
        public const string MIXED = "Mixed";
        public const string NA = "N/A";
        public const string NR = "NR";
        public const string OTHER = "Other";
        public const string OUTPATIENT = "Outpatient";
        public const string SURVEY = "Survey";
        public const string UNCLEAR = "Unclear";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantSettingType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantSettingType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantSettingType(string Val) => new DocConstantSettingType(Val);

        public static implicit operator string(DocConstantSettingType item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantSettingType(SettingTypeEnm Val) => new DocConstantSettingType(Val.ToEnumString());

        public static explicit operator SettingTypeEnm(DocConstantSettingType item)
        {
            Enum.TryParse<SettingTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantSettingType obj) => this == obj;

        public static bool operator ==(DocConstantSettingType x, DocConstantSettingType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantSettingType x, DocConstantSettingType y) => x == y;
        
        public static bool operator !=(DocConstantSettingType x, DocConstantSettingType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantSettingType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantSettingType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantSettingType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
