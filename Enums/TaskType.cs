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
    public enum TaskTypeEnm
    {
        [EnumMember(Value = DocConstantTaskType.DOCUMENT_ADJUDICATION), SCDescript(DocConstantTaskType.DOCUMENT_ADJUDICATION), SSDescript(DocConstantTaskType.DOCUMENT_ADJUDICATION), SCDisplay(Name = DocConstantTaskType.DOCUMENT_ADJUDICATION)]
        DOCUMENT_ADJUDICATION = 150785334,
        [EnumMember(Value = DocConstantTaskType.DOCUMENT_RATING), SCDescript(DocConstantTaskType.DOCUMENT_RATING), SSDescript(DocConstantTaskType.DOCUMENT_RATING), SCDisplay(Name = DocConstantTaskType.DOCUMENT_RATING)]
        DOCUMENT_RATING = 150785333,
        [EnumMember(Value = DocConstantTaskType.DOCUMENT_SEARCH_RECONCILIATION), SCDescript(DocConstantTaskType.DOCUMENT_SEARCH_RECONCILIATION), SSDescript(DocConstantTaskType.DOCUMENT_SEARCH_RECONCILIATION), SCDisplay(Name = DocConstantTaskType.DOCUMENT_SEARCH_RECONCILIATION)]
        DOCUMENT_SEARCH_RECONCILIATION = 157821102,
        [EnumMember(Value = DocConstantTaskType.EVIDENCE_ON_DEMAND), SCDescript(DocConstantTaskType.EVIDENCE_ON_DEMAND), SSDescript(DocConstantTaskType.EVIDENCE_ON_DEMAND), SCDisplay(Name = DocConstantTaskType.EVIDENCE_ON_DEMAND)]
        EVIDENCE_ON_DEMAND = 96669235
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this TaskTypeEnm instance)
        {
            switch(instance)
            {
                case TaskTypeEnm.DOCUMENT_ADJUDICATION:
                    return DocConstantTaskType.DOCUMENT_ADJUDICATION;
                case TaskTypeEnm.DOCUMENT_RATING:
                    return DocConstantTaskType.DOCUMENT_RATING;
                case TaskTypeEnm.DOCUMENT_SEARCH_RECONCILIATION:
                    return DocConstantTaskType.DOCUMENT_SEARCH_RECONCILIATION;
                case TaskTypeEnm.EVIDENCE_ON_DEMAND:
                    return DocConstantTaskType.EVIDENCE_ON_DEMAND;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this TaskTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantTaskType : IEquatable<DocConstantTaskType>, IEqualityComparer<DocConstantTaskType>
    {
        public const string DOCUMENT_ADJUDICATION = "Document Adjudication";
        public const string DOCUMENT_RATING = "Document Rating";
        public const string DOCUMENT_SEARCH_RECONCILIATION = "Document Search Reconciliation";
        public const string EVIDENCE_ON_DEMAND = "Evidence on Demand";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantTaskType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantTaskType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantTaskType(string Val) => new DocConstantTaskType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantTaskType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantTaskType(TaskTypeEnm Val) => new DocConstantTaskType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator TaskTypeEnm(DocConstantTaskType item)
        {
            Enum.TryParse<TaskTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantTaskType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantTaskType x, DocConstantTaskType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantTaskType x, DocConstantTaskType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantTaskType x, DocConstantTaskType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantTaskType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantTaskType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantTaskType obj) => obj?.GetHashCode() ?? -17;
    }
}
