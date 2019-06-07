
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
    public enum ConfidenceIntervalEnm
    {
        [EnumMember(Value = DocConstantConfidenceInterval.P90), SCDescript(DocConstantConfidenceInterval.P90), SSDescript(DocConstantConfidenceInterval.P90), SCDisplay(Name = DocConstantConfidenceInterval.P90)]
        P90 = 557,
        [EnumMember(Value = DocConstantConfidenceInterval.P92_5), SCDescript(DocConstantConfidenceInterval.P92_5), SSDescript(DocConstantConfidenceInterval.P92_5), SCDisplay(Name = DocConstantConfidenceInterval.P92_5)]
        P92_5 = 562,
        [EnumMember(Value = DocConstantConfidenceInterval.P95), SCDescript(DocConstantConfidenceInterval.P95), SSDescript(DocConstantConfidenceInterval.P95), SCDisplay(Name = DocConstantConfidenceInterval.P95)]
        P95 = 567,
        [EnumMember(Value = DocConstantConfidenceInterval.P97_5), SCDescript(DocConstantConfidenceInterval.P97_5), SSDescript(DocConstantConfidenceInterval.P97_5), SCDisplay(Name = DocConstantConfidenceInterval.P97_5)]
        P97_5 = 572,
        [EnumMember(Value = DocConstantConfidenceInterval.P99), SCDescript(DocConstantConfidenceInterval.P99), SSDescript(DocConstantConfidenceInterval.P99), SCDisplay(Name = DocConstantConfidenceInterval.P99)]
        P99 = 577
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ConfidenceIntervalEnm instance)
        {
            switch(instance)
            {
                case ConfidenceIntervalEnm.P90:
                    return DocConstantConfidenceInterval.P90;
                case ConfidenceIntervalEnm.P92_5:
                    return DocConstantConfidenceInterval.P92_5;
                case ConfidenceIntervalEnm.P95:
                    return DocConstantConfidenceInterval.P95;
                case ConfidenceIntervalEnm.P97_5:
                    return DocConstantConfidenceInterval.P97_5;
                case ConfidenceIntervalEnm.P99:
                    return DocConstantConfidenceInterval.P99;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this ConfidenceIntervalEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantConfidenceInterval : IEquatable<DocConstantConfidenceInterval>, IEqualityComparer<DocConstantConfidenceInterval>
    {
        public const string P90 = "90%";
        public const string P92_5 = "92.5%";
        public const string P95 = "95%";
        public const string P97_5 = "97.5%";
        public const string P99 = "99%";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantConfidenceInterval).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantConfidenceInterval(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantConfidenceInterval(string Val) => new DocConstantConfidenceInterval(Val);

        public static implicit operator string(DocConstantConfidenceInterval item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantConfidenceInterval(ConfidenceIntervalEnm Val) => new DocConstantConfidenceInterval(Val.ToEnumString());

        public static explicit operator ConfidenceIntervalEnm(DocConstantConfidenceInterval item)
        {
            Enum.TryParse<ConfidenceIntervalEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantConfidenceInterval obj) => this == obj;

        public static bool operator ==(DocConstantConfidenceInterval x, DocConstantConfidenceInterval y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantConfidenceInterval x, DocConstantConfidenceInterval y) => x == y;
        
        public static bool operator !=(DocConstantConfidenceInterval x, DocConstantConfidenceInterval y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantConfidenceInterval))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantConfidenceInterval) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantConfidenceInterval obj) => obj?.GetHashCode() ?? -17;

    }
}
