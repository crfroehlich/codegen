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
    public enum StudyBlindingMethodEnm
    {
        [EnumMember(Value = DocConstantStudyBlindingMethod.DOUBLE_BLIND), SCDescript(DocConstantStudyBlindingMethod.DOUBLE_BLIND), SSDescript(DocConstantStudyBlindingMethod.DOUBLE_BLIND), SCDisplay(Name = DocConstantStudyBlindingMethod.DOUBLE_BLIND)]
        DOUBLE_BLIND = 3117,
        [EnumMember(Value = DocConstantStudyBlindingMethod.OPEN_BLINDED_ENDPOINT), SCDescript(DocConstantStudyBlindingMethod.OPEN_BLINDED_ENDPOINT), SSDescript(DocConstantStudyBlindingMethod.OPEN_BLINDED_ENDPOINT), SCDisplay(Name = DocConstantStudyBlindingMethod.OPEN_BLINDED_ENDPOINT)]
        OPEN_BLINDED_ENDPOINT = 3122,
        [EnumMember(Value = DocConstantStudyBlindingMethod.OPEN_NO_BLINDING), SCDescript(DocConstantStudyBlindingMethod.OPEN_NO_BLINDING), SSDescript(DocConstantStudyBlindingMethod.OPEN_NO_BLINDING), SCDisplay(Name = DocConstantStudyBlindingMethod.OPEN_NO_BLINDING)]
        OPEN_NO_BLINDING = 3127,
        [EnumMember(Value = DocConstantStudyBlindingMethod.SINGLE_BLIND), SCDescript(DocConstantStudyBlindingMethod.SINGLE_BLIND), SSDescript(DocConstantStudyBlindingMethod.SINGLE_BLIND), SCDisplay(Name = DocConstantStudyBlindingMethod.SINGLE_BLIND)]
        SINGLE_BLIND = 3132
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyBlindingMethodEnm instance)
        {
            switch(instance)
            {
                case StudyBlindingMethodEnm.DOUBLE_BLIND:
                    return DocConstantStudyBlindingMethod.DOUBLE_BLIND;
                case StudyBlindingMethodEnm.OPEN_BLINDED_ENDPOINT:
                    return DocConstantStudyBlindingMethod.OPEN_BLINDED_ENDPOINT;
                case StudyBlindingMethodEnm.OPEN_NO_BLINDING:
                    return DocConstantStudyBlindingMethod.OPEN_NO_BLINDING;
                case StudyBlindingMethodEnm.SINGLE_BLIND:
                    return DocConstantStudyBlindingMethod.SINGLE_BLIND;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyBlindingMethodEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantStudyBlindingMethod : IEquatable<DocConstantStudyBlindingMethod>, IEqualityComparer<DocConstantStudyBlindingMethod>
    {
        public const string DOUBLE_BLIND = "Double Blind";
        public const string OPEN_BLINDED_ENDPOINT = "Open Blinded Endpoint";
        public const string OPEN_NO_BLINDING = "Open/No Blinding";
        public const string SINGLE_BLIND = "Single Blind";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyBlindingMethod).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantStudyBlindingMethod(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantStudyBlindingMethod(string Val) => new DocConstantStudyBlindingMethod(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantStudyBlindingMethod item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantStudyBlindingMethod(StudyBlindingMethodEnm Val) => new DocConstantStudyBlindingMethod(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator StudyBlindingMethodEnm(DocConstantStudyBlindingMethod item)
        {
            Enum.TryParse<StudyBlindingMethodEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyBlindingMethod obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantStudyBlindingMethod x, DocConstantStudyBlindingMethod y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyBlindingMethod x, DocConstantStudyBlindingMethod y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantStudyBlindingMethod x, DocConstantStudyBlindingMethod y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyBlindingMethod))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyBlindingMethod) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantStudyBlindingMethod obj) => obj?.GetHashCode() ?? -17;
    }
}
