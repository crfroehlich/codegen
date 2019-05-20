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
    public enum InstitutionTypeEnm
    {
        [EnumMember(Value = DocConstantInstitutionType.ACADEMIC), SCDescript(DocConstantInstitutionType.ACADEMIC), SSDescript(DocConstantInstitutionType.ACADEMIC), SCDisplay(Name = DocConstantInstitutionType.ACADEMIC)]
        ACADEMIC = 1087,
        [EnumMember(Value = DocConstantInstitutionType.COMMERCIAL), SCDescript(DocConstantInstitutionType.COMMERCIAL), SSDescript(DocConstantInstitutionType.COMMERCIAL), SCDisplay(Name = DocConstantInstitutionType.COMMERCIAL)]
        COMMERCIAL = 1092,
        [EnumMember(Value = DocConstantInstitutionType.NA), SCDescript(DocConstantInstitutionType.NA), SSDescript(DocConstantInstitutionType.NA), SCDisplay(Name = DocConstantInstitutionType.NA)]
        NA = 1097,
        [EnumMember(Value = DocConstantInstitutionType.NON_PROFIT), SCDescript(DocConstantInstitutionType.NON_PROFIT), SSDescript(DocConstantInstitutionType.NON_PROFIT), SCDisplay(Name = DocConstantInstitutionType.NON_PROFIT)]
        NON_PROFIT = 1102,
        [EnumMember(Value = DocConstantInstitutionType.UNKNOWN), SCDescript(DocConstantInstitutionType.UNKNOWN), SSDescript(DocConstantInstitutionType.UNKNOWN), SCDisplay(Name = DocConstantInstitutionType.UNKNOWN)]
        UNKNOWN = 1107
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this InstitutionTypeEnm instance)
        {
            switch(instance)
            {
                case InstitutionTypeEnm.ACADEMIC:
                    return DocConstantInstitutionType.ACADEMIC;
                case InstitutionTypeEnm.COMMERCIAL:
                    return DocConstantInstitutionType.COMMERCIAL;
                case InstitutionTypeEnm.NA:
                    return DocConstantInstitutionType.NA;
                case InstitutionTypeEnm.NON_PROFIT:
                    return DocConstantInstitutionType.NON_PROFIT;
                case InstitutionTypeEnm.UNKNOWN:
                    return DocConstantInstitutionType.UNKNOWN;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this InstitutionTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantInstitutionType : IEquatable<DocConstantInstitutionType>, IEqualityComparer<DocConstantInstitutionType>
    {
        public const string ACADEMIC = "Academic";
        public const string COMMERCIAL = "Commercial";
        public const string NA = "N/A";
        public const string NON_PROFIT = "Non-Profit";
        public const string UNKNOWN = "Unknown";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantInstitutionType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantInstitutionType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantInstitutionType(string Val) => new DocConstantInstitutionType(Val);

        public static implicit operator string(DocConstantInstitutionType item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantInstitutionType(InstitutionTypeEnm Val) => new DocConstantInstitutionType(Val.ToEnumString());

        public static explicit operator InstitutionTypeEnm(DocConstantInstitutionType item)
        {
            Enum.TryParse<InstitutionTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantInstitutionType obj) => this == obj;

        public static bool operator ==(DocConstantInstitutionType x, DocConstantInstitutionType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantInstitutionType x, DocConstantInstitutionType y) => x == y;
        
        public static bool operator !=(DocConstantInstitutionType x, DocConstantInstitutionType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantInstitutionType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantInstitutionType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantInstitutionType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
