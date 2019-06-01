
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
    public enum OutcomeTypeEnm
    {
        [EnumMember(Value = DocConstantOutcomeType.BINARY), SCDescript(DocConstantOutcomeType.BINARY), SSDescript(DocConstantOutcomeType.BINARY), SCDisplay(Name = DocConstantOutcomeType.BINARY)]
        BINARY = 2687,
        [EnumMember(Value = DocConstantOutcomeType.CONTINUOUS), SCDescript(DocConstantOutcomeType.CONTINUOUS), SSDescript(DocConstantOutcomeType.CONTINUOUS), SCDisplay(Name = DocConstantOutcomeType.CONTINUOUS)]
        CONTINUOUS = 2692,
        [EnumMember(Value = DocConstantOutcomeType.PRIMARY_ENDPOINT_OUTCOME), SCDescript(DocConstantOutcomeType.PRIMARY_ENDPOINT_OUTCOME), SSDescript(DocConstantOutcomeType.PRIMARY_ENDPOINT_OUTCOME), SCDisplay(Name = DocConstantOutcomeType.PRIMARY_ENDPOINT_OUTCOME)]
        PRIMARY_ENDPOINT_OUTCOME = 2697,
        [EnumMember(Value = DocConstantOutcomeType.SECONDARY_ENDPOINT_OUTCOME), SCDescript(DocConstantOutcomeType.SECONDARY_ENDPOINT_OUTCOME), SSDescript(DocConstantOutcomeType.SECONDARY_ENDPOINT_OUTCOME), SCDisplay(Name = DocConstantOutcomeType.SECONDARY_ENDPOINT_OUTCOME)]
        SECONDARY_ENDPOINT_OUTCOME = 2702,
        [EnumMember(Value = DocConstantOutcomeType.TERTIARY_ENDPOINT_OUTCOME), SCDescript(DocConstantOutcomeType.TERTIARY_ENDPOINT_OUTCOME), SSDescript(DocConstantOutcomeType.TERTIARY_ENDPOINT_OUTCOME), SCDisplay(Name = DocConstantOutcomeType.TERTIARY_ENDPOINT_OUTCOME)]
        TERTIARY_ENDPOINT_OUTCOME = 2707
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this OutcomeTypeEnm instance)
        {
            switch(instance)
            {
                case OutcomeTypeEnm.BINARY:
                    return DocConstantOutcomeType.BINARY;
                case OutcomeTypeEnm.CONTINUOUS:
                    return DocConstantOutcomeType.CONTINUOUS;
                case OutcomeTypeEnm.PRIMARY_ENDPOINT_OUTCOME:
                    return DocConstantOutcomeType.PRIMARY_ENDPOINT_OUTCOME;
                case OutcomeTypeEnm.SECONDARY_ENDPOINT_OUTCOME:
                    return DocConstantOutcomeType.SECONDARY_ENDPOINT_OUTCOME;
                case OutcomeTypeEnm.TERTIARY_ENDPOINT_OUTCOME:
                    return DocConstantOutcomeType.TERTIARY_ENDPOINT_OUTCOME;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this OutcomeTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantOutcomeType : IEquatable<DocConstantOutcomeType>, IEqualityComparer<DocConstantOutcomeType>
    {
        public const string BINARY = "Binary";
        public const string CONTINUOUS = "Continuous";
        public const string PRIMARY_ENDPOINT_OUTCOME = "Primary Endpoint/Outcome";
        public const string SECONDARY_ENDPOINT_OUTCOME = "Secondary Endpoint/Outcome";
        public const string TERTIARY_ENDPOINT_OUTCOME = "Tertiary Endpoint/Outcome";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantOutcomeType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantOutcomeType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantOutcomeType(string Val) => new DocConstantOutcomeType(Val);

        public static implicit operator string(DocConstantOutcomeType item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantOutcomeType(OutcomeTypeEnm Val) => new DocConstantOutcomeType(Val.ToEnumString());

        public static explicit operator OutcomeTypeEnm(DocConstantOutcomeType item)
        {
            Enum.TryParse<OutcomeTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantOutcomeType obj) => this == obj;

        public static bool operator ==(DocConstantOutcomeType x, DocConstantOutcomeType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantOutcomeType x, DocConstantOutcomeType y) => x == y;
        
        public static bool operator !=(DocConstantOutcomeType x, DocConstantOutcomeType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantOutcomeType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantOutcomeType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantOutcomeType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
