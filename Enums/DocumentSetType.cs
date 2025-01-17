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
    public enum DocumentSetTypeEnm
    {
        [EnumMember(Value = DocConstantDocumentSetType.DATA_SET), SCDescript(DocConstantDocumentSetType.DATA_SET), SSDescript(DocConstantDocumentSetType.DATA_SET), SCDisplay(Name = DocConstantDocumentSetType.DATA_SET)]
        DATA_SET = 41789739,
        [EnumMember(Value = DocConstantDocumentSetType.DISEASE_STATE), SCDescript(DocConstantDocumentSetType.DISEASE_STATE), SSDescript(DocConstantDocumentSetType.DISEASE_STATE), SCDisplay(Name = DocConstantDocumentSetType.DISEASE_STATE)]
        DISEASE_STATE = 41790593,
        [EnumMember(Value = DocConstantDocumentSetType.GLOBAL), SCDescript(DocConstantDocumentSetType.GLOBAL), SSDescript(DocConstantDocumentSetType.GLOBAL), SCDisplay(Name = DocConstantDocumentSetType.GLOBAL)]
        GLOBAL = 41790600,
        [EnumMember(Value = DocConstantDocumentSetType.LIBRARY), SCDescript(DocConstantDocumentSetType.LIBRARY), SSDescript(DocConstantDocumentSetType.LIBRARY), SCDisplay(Name = DocConstantDocumentSetType.LIBRARY)]
        LIBRARY = 150784620,
        [EnumMember(Value = DocConstantDocumentSetType.SERVE_PORTAL), SCDescript(DocConstantDocumentSetType.SERVE_PORTAL), SSDescript(DocConstantDocumentSetType.SERVE_PORTAL), SCDisplay(Name = DocConstantDocumentSetType.SERVE_PORTAL)]
        SERVE_PORTAL = 146157828,
        [EnumMember(Value = DocConstantDocumentSetType.THERAPEUTIC_AREA), SCDescript(DocConstantDocumentSetType.THERAPEUTIC_AREA), SSDescript(DocConstantDocumentSetType.THERAPEUTIC_AREA), SCDisplay(Name = DocConstantDocumentSetType.THERAPEUTIC_AREA)]
        THERAPEUTIC_AREA = 41790607
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this DocumentSetTypeEnm instance)
        {
            switch(instance)
            {
                case DocumentSetTypeEnm.DATA_SET:
                    return DocConstantDocumentSetType.DATA_SET;
                case DocumentSetTypeEnm.DISEASE_STATE:
                    return DocConstantDocumentSetType.DISEASE_STATE;
                case DocumentSetTypeEnm.GLOBAL:
                    return DocConstantDocumentSetType.GLOBAL;
                case DocumentSetTypeEnm.LIBRARY:
                    return DocConstantDocumentSetType.LIBRARY;
                case DocumentSetTypeEnm.SERVE_PORTAL:
                    return DocConstantDocumentSetType.SERVE_PORTAL;
                case DocumentSetTypeEnm.THERAPEUTIC_AREA:
                    return DocConstantDocumentSetType.THERAPEUTIC_AREA;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this DocumentSetTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantDocumentSetType : IEquatable<DocConstantDocumentSetType>, IEqualityComparer<DocConstantDocumentSetType>
    {
        public const string DATA_SET = "Data Set";
        public const string DISEASE_STATE = "Disease State";
        public const string GLOBAL = "Global";
        public const string LIBRARY = "Library";
        public const string SERVE_PORTAL = "SERVE Portal";
        public const string THERAPEUTIC_AREA = "Therapeutic Area";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantDocumentSetType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantDocumentSetType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantDocumentSetType(string Val) => new DocConstantDocumentSetType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantDocumentSetType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantDocumentSetType(DocumentSetTypeEnm Val) => new DocConstantDocumentSetType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocumentSetTypeEnm(DocConstantDocumentSetType item)
        {
            Enum.TryParse<DocumentSetTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantDocumentSetType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantDocumentSetType x, DocConstantDocumentSetType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantDocumentSetType x, DocConstantDocumentSetType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantDocumentSetType x, DocConstantDocumentSetType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantDocumentSetType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDocumentSetType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantDocumentSetType obj) => obj?.GetHashCode() ?? -17;
    }
}
