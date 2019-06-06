
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
    public enum DirectionalityEnm
    {
        [EnumMember(Value = DocConstantDirectionality.NA), SCDescript(DocConstantDirectionality.NA), SSDescript(DocConstantDirectionality.NA), SCDisplay(Name = DocConstantDirectionality.NA)]
        NA = 90640168,
        [EnumMember(Value = DocConstantDirectionality.NEG), SCDescript(DocConstantDirectionality.NEG), SSDescript(DocConstantDirectionality.NEG), SCDisplay(Name = DocConstantDirectionality.NEG)]
        NEG = 90640167,
        [EnumMember(Value = DocConstantDirectionality.POS), SCDescript(DocConstantDirectionality.POS), SSDescript(DocConstantDirectionality.POS), SCDisplay(Name = DocConstantDirectionality.POS)]
        POS = 90640166
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this DirectionalityEnm instance)
        {
            switch(instance)
            {
                case DirectionalityEnm.NA:
                    return DocConstantDirectionality.NA;
                case DirectionalityEnm.NEG:
                    return DocConstantDirectionality.NEG;
                case DirectionalityEnm.POS:
                    return DocConstantDirectionality.POS;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this DirectionalityEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantDirectionality : IEquatable<DocConstantDirectionality>, IEqualityComparer<DocConstantDirectionality>
    {
        public const string NA = "N/A";
        public const string NEG = "NEG";
        public const string POS = "POS";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantDirectionality).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantDirectionality(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantDirectionality(string Val) => new DocConstantDirectionality(Val);

        public static implicit operator string(DocConstantDirectionality item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantDirectionality(DirectionalityEnm Val) => new DocConstantDirectionality(Val.ToEnumString());

        public static explicit operator DirectionalityEnm(DocConstantDirectionality item)
        {
            Enum.TryParse<DirectionalityEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantDirectionality obj) => this == obj;

        public static bool operator ==(DocConstantDirectionality x, DocConstantDirectionality y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantDirectionality x, DocConstantDirectionality y) => x == y;
        
        public static bool operator !=(DocConstantDirectionality x, DocConstantDirectionality y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantDirectionality))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDirectionality) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantDirectionality obj) => obj?.GetHashCode() ?? -17;

    }
}
