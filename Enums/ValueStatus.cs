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
    public enum ValueStatusEnm
    {
        [EnumMember(Value = DocConstantValueStatus.COLLECTED), SCDescript(DocConstantValueStatus.COLLECTED), SSDescript(DocConstantValueStatus.COLLECTED), SCDisplay(Name = DocConstantValueStatus.COLLECTED)]
        COLLECTED = 4743,
        [EnumMember(Value = DocConstantValueStatus.NOT_AVAILABLE), SCDescript(DocConstantValueStatus.NOT_AVAILABLE), SSDescript(DocConstantValueStatus.NOT_AVAILABLE), SCDisplay(Name = DocConstantValueStatus.NOT_AVAILABLE)]
        NOT_AVAILABLE = 146157850,
        [EnumMember(Value = DocConstantValueStatus.NOT_COLLECTED), SCDescript(DocConstantValueStatus.NOT_COLLECTED), SSDescript(DocConstantValueStatus.NOT_COLLECTED), SCDisplay(Name = DocConstantValueStatus.NOT_COLLECTED)]
        NOT_COLLECTED = 4748,
        [EnumMember(Value = DocConstantValueStatus.NOT_REPORTED), SCDescript(DocConstantValueStatus.NOT_REPORTED), SSDescript(DocConstantValueStatus.NOT_REPORTED), SCDisplay(Name = DocConstantValueStatus.NOT_REPORTED)]
        NOT_REPORTED = 4753,
        [EnumMember(Value = DocConstantValueStatus.REQUESTED), SCDescript(DocConstantValueStatus.REQUESTED), SSDescript(DocConstantValueStatus.REQUESTED), SCDisplay(Name = DocConstantValueStatus.REQUESTED)]
        REQUESTED = 4758
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ValueStatusEnm instance)
        {
            switch(instance)
            {
                case ValueStatusEnm.COLLECTED:
                    return DocConstantValueStatus.COLLECTED;
                case ValueStatusEnm.NOT_AVAILABLE:
                    return DocConstantValueStatus.NOT_AVAILABLE;
                case ValueStatusEnm.NOT_COLLECTED:
                    return DocConstantValueStatus.NOT_COLLECTED;
                case ValueStatusEnm.NOT_REPORTED:
                    return DocConstantValueStatus.NOT_REPORTED;
                case ValueStatusEnm.REQUESTED:
                    return DocConstantValueStatus.REQUESTED;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this ValueStatusEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantValueStatus : IEquatable<DocConstantValueStatus>, IEqualityComparer<DocConstantValueStatus>
    {
        public const string COLLECTED = "Collected";
        public const string NOT_AVAILABLE = "Not Available";
        public const string NOT_COLLECTED = "Not Collected";
        public const string NOT_REPORTED = "Not Reported";
        public const string REQUESTED = "Requested";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantValueStatus).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantValueStatus(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantValueStatus(string Val) => new DocConstantValueStatus(Val);

        public static implicit operator string(DocConstantValueStatus item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantValueStatus(ValueStatusEnm Val) => new DocConstantValueStatus(Val.ToEnumString());

        public static explicit operator ValueStatusEnm(DocConstantValueStatus item)
        {
            Enum.TryParse<ValueStatusEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantValueStatus obj) => this == obj;

        public static bool operator ==(DocConstantValueStatus x, DocConstantValueStatus y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantValueStatus x, DocConstantValueStatus y) => x == y;
        
        public static bool operator !=(DocConstantValueStatus x, DocConstantValueStatus y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantValueStatus))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantValueStatus) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantValueStatus obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
