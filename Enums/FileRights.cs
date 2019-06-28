//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
    public enum FileRightsEnm
    {
        [EnumMember(Value = DocConstantFileRights.FREE), SCDescript(DocConstantFileRights.FREE), SSDescript(DocConstantFileRights.FREE), SCDisplay(Name = DocConstantFileRights.FREE)]
        FREE = 156369070,
        [EnumMember(Value = DocConstantFileRights.RESTRICTED), SCDescript(DocConstantFileRights.RESTRICTED), SSDescript(DocConstantFileRights.RESTRICTED), SCDisplay(Name = DocConstantFileRights.RESTRICTED)]
        RESTRICTED = 156369071
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this FileRightsEnm instance)
        {
            switch(instance)
            {
                case FileRightsEnm.FREE:
                    return DocConstantFileRights.FREE;
                case FileRightsEnm.RESTRICTED:
                    return DocConstantFileRights.RESTRICTED;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this FileRightsEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantFileRights : IEquatable<DocConstantFileRights>, IEqualityComparer<DocConstantFileRights>
    {
        public const string FREE = "Free";
        public const string RESTRICTED = "Restricted";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantFileRights).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantFileRights(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantFileRights(string Val) => new DocConstantFileRights(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantFileRights item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantFileRights(FileRightsEnm Val) => new DocConstantFileRights(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator FileRightsEnm(DocConstantFileRights item)
        {
            Enum.TryParse<FileRightsEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantFileRights obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantFileRights x, DocConstantFileRights y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantFileRights x, DocConstantFileRights y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantFileRights x, DocConstantFileRights y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantFileRights))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantFileRights) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantFileRights obj) => obj?.GetHashCode() ?? -17;
    }
}