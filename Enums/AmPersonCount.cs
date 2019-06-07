



















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
    public enum AmPersonCountEnm
    {
        [EnumMember(Value = DocConstantAmPersonCount.COUNT), SCDescript(DocConstantAmPersonCount.COUNT), SSDescript(DocConstantAmPersonCount.COUNT), SCDisplay(Name = DocConstantAmPersonCount.COUNT)]
        COUNT = 31621634,
        [EnumMember(Value = DocConstantAmPersonCount.PERSONS), SCDescript(DocConstantAmPersonCount.PERSONS), SSDescript(DocConstantAmPersonCount.PERSONS), SCDisplay(Name = DocConstantAmPersonCount.PERSONS)]
        PERSONS = 31621641
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this AmPersonCountEnm instance)
        {
            switch(instance)
            {
                case AmPersonCountEnm.COUNT:
                    return DocConstantAmPersonCount.COUNT;
                case AmPersonCountEnm.PERSONS:
                    return DocConstantAmPersonCount.PERSONS;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this AmPersonCountEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantAmPersonCount : IEquatable<DocConstantAmPersonCount>, IEqualityComparer<DocConstantAmPersonCount>
    {
        public const string COUNT = "Count";
        public const string PERSONS = "Persons";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantAmPersonCount).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantAmPersonCount(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantAmPersonCount(string Val) => new DocConstantAmPersonCount(Val);

        public static implicit operator string(DocConstantAmPersonCount item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantAmPersonCount(AmPersonCountEnm Val) => new DocConstantAmPersonCount(Val.ToEnumString());

        public static explicit operator AmPersonCountEnm(DocConstantAmPersonCount item)
        {
            Enum.TryParse<AmPersonCountEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantAmPersonCount obj) => this == obj;

        public static bool operator ==(DocConstantAmPersonCount x, DocConstantAmPersonCount y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantAmPersonCount x, DocConstantAmPersonCount y) => x == y;
        
        public static bool operator !=(DocConstantAmPersonCount x, DocConstantAmPersonCount y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantAmPersonCount))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantAmPersonCount) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantAmPersonCount obj) => obj?.GetHashCode() ?? -17;

    }
}
