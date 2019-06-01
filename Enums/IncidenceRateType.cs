
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
    public enum IncidenceRateTypeEnm
    {
        [EnumMember(Value = DocConstantIncidenceRateType.COUNT), SCDescript(DocConstantIncidenceRateType.COUNT), SSDescript(DocConstantIncidenceRateType.COUNT), SCDisplay(Name = DocConstantIncidenceRateType.COUNT)]
        COUNT = 21514013,
        [EnumMember(Value = DocConstantIncidenceRateType.PERSONS), SCDescript(DocConstantIncidenceRateType.PERSONS), SSDescript(DocConstantIncidenceRateType.PERSONS), SCDisplay(Name = DocConstantIncidenceRateType.PERSONS)]
        PERSONS = 21514018
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this IncidenceRateTypeEnm instance)
        {
            switch(instance)
            {
                case IncidenceRateTypeEnm.COUNT:
                    return DocConstantIncidenceRateType.COUNT;
                case IncidenceRateTypeEnm.PERSONS:
                    return DocConstantIncidenceRateType.PERSONS;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this IncidenceRateTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantIncidenceRateType : IEquatable<DocConstantIncidenceRateType>, IEqualityComparer<DocConstantIncidenceRateType>
    {
        public const string COUNT = "Count";
        public const string PERSONS = "Persons";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantIncidenceRateType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantIncidenceRateType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantIncidenceRateType(string Val) => new DocConstantIncidenceRateType(Val);

        public static implicit operator string(DocConstantIncidenceRateType item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantIncidenceRateType(IncidenceRateTypeEnm Val) => new DocConstantIncidenceRateType(Val.ToEnumString());

        public static explicit operator IncidenceRateTypeEnm(DocConstantIncidenceRateType item)
        {
            Enum.TryParse<IncidenceRateTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantIncidenceRateType obj) => this == obj;

        public static bool operator ==(DocConstantIncidenceRateType x, DocConstantIncidenceRateType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantIncidenceRateType x, DocConstantIncidenceRateType y) => x == y;
        
        public static bool operator !=(DocConstantIncidenceRateType x, DocConstantIncidenceRateType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantIncidenceRateType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantIncidenceRateType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantIncidenceRateType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
