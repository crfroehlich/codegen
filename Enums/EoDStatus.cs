
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
    public enum EoDStatusEnm
    {
        [EnumMember(Value = DocConstantEoDStatus.ACCEPTED), SCDescript(DocConstantEoDStatus.ACCEPTED), SSDescript(DocConstantEoDStatus.ACCEPTED), SCDisplay(Name = DocConstantEoDStatus.ACCEPTED)]
        ACCEPTED = 147180163,
        [EnumMember(Value = DocConstantEoDStatus.COLLECTED), SCDescript(DocConstantEoDStatus.COLLECTED), SSDescript(DocConstantEoDStatus.COLLECTED), SCDisplay(Name = DocConstantEoDStatus.COLLECTED)]
        COLLECTED = 128789899,
        [EnumMember(Value = DocConstantEoDStatus.REJECTED), SCDescript(DocConstantEoDStatus.REJECTED), SSDescript(DocConstantEoDStatus.REJECTED), SCDisplay(Name = DocConstantEoDStatus.REJECTED)]
        REJECTED = 76351815,
        [EnumMember(Value = DocConstantEoDStatus.REQUESTED), SCDescript(DocConstantEoDStatus.REQUESTED), SSDescript(DocConstantEoDStatus.REQUESTED), SCDisplay(Name = DocConstantEoDStatus.REQUESTED)]
        REQUESTED = 128789898,
        [EnumMember(Value = DocConstantEoDStatus.UNAVAILABLE), SCDescript(DocConstantEoDStatus.UNAVAILABLE), SSDescript(DocConstantEoDStatus.UNAVAILABLE), SCDisplay(Name = DocConstantEoDStatus.UNAVAILABLE)]
        UNAVAILABLE = 128789900
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this EoDStatusEnm instance)
        {
            switch(instance)
            {
                case EoDStatusEnm.ACCEPTED:
                    return DocConstantEoDStatus.ACCEPTED;
                case EoDStatusEnm.COLLECTED:
                    return DocConstantEoDStatus.COLLECTED;
                case EoDStatusEnm.REJECTED:
                    return DocConstantEoDStatus.REJECTED;
                case EoDStatusEnm.REQUESTED:
                    return DocConstantEoDStatus.REQUESTED;
                case EoDStatusEnm.UNAVAILABLE:
                    return DocConstantEoDStatus.UNAVAILABLE;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this EoDStatusEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantEoDStatus : IEquatable<DocConstantEoDStatus>, IEqualityComparer<DocConstantEoDStatus>
    {
        public const string ACCEPTED = "Accepted";
        public const string COLLECTED = "Collected";
        public const string REJECTED = "Rejected";
        public const string REQUESTED = "Requested";
        public const string UNAVAILABLE = "Unavailable";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantEoDStatus).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantEoDStatus(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantEoDStatus(string Val) => new DocConstantEoDStatus(Val);

        public static implicit operator string(DocConstantEoDStatus item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantEoDStatus(EoDStatusEnm Val) => new DocConstantEoDStatus(Val.ToEnumString());

        public static explicit operator EoDStatusEnm(DocConstantEoDStatus item)
        {
            Enum.TryParse<EoDStatusEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantEoDStatus obj) => this == obj;

        public static bool operator ==(DocConstantEoDStatus x, DocConstantEoDStatus y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantEoDStatus x, DocConstantEoDStatus y) => x == y;
        
        public static bool operator !=(DocConstantEoDStatus x, DocConstantEoDStatus y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantEoDStatus))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantEoDStatus) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantEoDStatus obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
