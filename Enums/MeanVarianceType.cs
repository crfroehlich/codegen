
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
    public enum MeanVarianceTypeEnm
    {
        [EnumMember(Value = DocConstantMeanVarianceType.CV), SCDescript(DocConstantMeanVarianceType.CV), SSDescript(DocConstantMeanVarianceType.CV), SCDisplay(Name = DocConstantMeanVarianceType.CV)]
        CV = 95113988,
        [EnumMember(Value = DocConstantMeanVarianceType.IQR_DIFFERENCE), SCDescript(DocConstantMeanVarianceType.IQR_DIFFERENCE), SSDescript(DocConstantMeanVarianceType.IQR_DIFFERENCE), SCDisplay(Name = DocConstantMeanVarianceType.IQR_DIFFERENCE)]
        IQR_DIFFERENCE = 17618177,
        [EnumMember(Value = DocConstantMeanVarianceType.SD), SCDescript(DocConstantMeanVarianceType.SD), SSDescript(DocConstantMeanVarianceType.SD), SCDisplay(Name = DocConstantMeanVarianceType.SD)]
        SD = 2172,
        [EnumMember(Value = DocConstantMeanVarianceType.SE), SCDescript(DocConstantMeanVarianceType.SE), SSDescript(DocConstantMeanVarianceType.SE), SCDisplay(Name = DocConstantMeanVarianceType.SE)]
        SE = 2177,
        [EnumMember(Value = DocConstantMeanVarianceType.SEMI_IQR), SCDescript(DocConstantMeanVarianceType.SEMI_IQR), SSDescript(DocConstantMeanVarianceType.SEMI_IQR), SCDisplay(Name = DocConstantMeanVarianceType.SEMI_IQR)]
        SEMI_IQR = 2182,
        [EnumMember(Value = DocConstantMeanVarianceType.UNKNOWN), SCDescript(DocConstantMeanVarianceType.UNKNOWN), SSDescript(DocConstantMeanVarianceType.UNKNOWN), SCDisplay(Name = DocConstantMeanVarianceType.UNKNOWN)]
        UNKNOWN = 2187
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this MeanVarianceTypeEnm instance)
        {
            switch(instance)
            {
                case MeanVarianceTypeEnm.CV:
                    return DocConstantMeanVarianceType.CV;
                case MeanVarianceTypeEnm.IQR_DIFFERENCE:
                    return DocConstantMeanVarianceType.IQR_DIFFERENCE;
                case MeanVarianceTypeEnm.SD:
                    return DocConstantMeanVarianceType.SD;
                case MeanVarianceTypeEnm.SE:
                    return DocConstantMeanVarianceType.SE;
                case MeanVarianceTypeEnm.SEMI_IQR:
                    return DocConstantMeanVarianceType.SEMI_IQR;
                case MeanVarianceTypeEnm.UNKNOWN:
                    return DocConstantMeanVarianceType.UNKNOWN;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this MeanVarianceTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantMeanVarianceType : IEquatable<DocConstantMeanVarianceType>, IEqualityComparer<DocConstantMeanVarianceType>
    {
        public const string CV = "CV";
        public const string IQR_DIFFERENCE = "IQR Difference";
        public const string SD = "SD";
        public const string SE = "SE";
        public const string SEMI_IQR = "Semi IQR";
        public const string UNKNOWN = "Unknown";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantMeanVarianceType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantMeanVarianceType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantMeanVarianceType(string Val) => new DocConstantMeanVarianceType(Val);

        public static implicit operator string(DocConstantMeanVarianceType item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantMeanVarianceType(MeanVarianceTypeEnm Val) => new DocConstantMeanVarianceType(Val.ToEnumString());

        public static explicit operator MeanVarianceTypeEnm(DocConstantMeanVarianceType item)
        {
            Enum.TryParse<MeanVarianceTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantMeanVarianceType obj) => this == obj;

        public static bool operator ==(DocConstantMeanVarianceType x, DocConstantMeanVarianceType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantMeanVarianceType x, DocConstantMeanVarianceType y) => x == y;
        
        public static bool operator !=(DocConstantMeanVarianceType x, DocConstantMeanVarianceType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantMeanVarianceType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantMeanVarianceType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantMeanVarianceType obj) => obj?.GetHashCode() ?? -17;

    }
}
