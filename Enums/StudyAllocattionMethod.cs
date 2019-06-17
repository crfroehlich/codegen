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
    public enum StudyAllocattionMethodEnm
    {
        [EnumMember(Value = DocConstantStudyAllocattionMethod.OPAQUE_ENVELOPES), SCDescript(DocConstantStudyAllocattionMethod.OPAQUE_ENVELOPES), SSDescript(DocConstantStudyAllocattionMethod.OPAQUE_ENVELOPES), SCDisplay(Name = DocConstantStudyAllocattionMethod.OPAQUE_ENVELOPES)]
        OPAQUE_ENVELOPES = 3072,
        [EnumMember(Value = DocConstantStudyAllocattionMethod.RANDOM_NUMBER_GENERATOR), SCDescript(DocConstantStudyAllocattionMethod.RANDOM_NUMBER_GENERATOR), SSDescript(DocConstantStudyAllocattionMethod.RANDOM_NUMBER_GENERATOR), SCDisplay(Name = DocConstantStudyAllocattionMethod.RANDOM_NUMBER_GENERATOR)]
        RANDOM_NUMBER_GENERATOR = 3077,
        [EnumMember(Value = DocConstantStudyAllocattionMethod.ROLLING_DICE), SCDescript(DocConstantStudyAllocattionMethod.ROLLING_DICE), SSDescript(DocConstantStudyAllocattionMethod.ROLLING_DICE), SCDisplay(Name = DocConstantStudyAllocattionMethod.ROLLING_DICE)]
        ROLLING_DICE = 3082,
        [EnumMember(Value = DocConstantStudyAllocattionMethod.SEQUENCE_ALLOCATION), SCDescript(DocConstantStudyAllocattionMethod.SEQUENCE_ALLOCATION), SSDescript(DocConstantStudyAllocattionMethod.SEQUENCE_ALLOCATION), SCDisplay(Name = DocConstantStudyAllocattionMethod.SEQUENCE_ALLOCATION)]
        SEQUENCE_ALLOCATION = 3087
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyAllocattionMethodEnm instance)
        {
            switch(instance)
            {
                case StudyAllocattionMethodEnm.OPAQUE_ENVELOPES:
                    return DocConstantStudyAllocattionMethod.OPAQUE_ENVELOPES;
                case StudyAllocattionMethodEnm.RANDOM_NUMBER_GENERATOR:
                    return DocConstantStudyAllocattionMethod.RANDOM_NUMBER_GENERATOR;
                case StudyAllocattionMethodEnm.ROLLING_DICE:
                    return DocConstantStudyAllocattionMethod.ROLLING_DICE;
                case StudyAllocattionMethodEnm.SEQUENCE_ALLOCATION:
                    return DocConstantStudyAllocattionMethod.SEQUENCE_ALLOCATION;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyAllocattionMethodEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantStudyAllocattionMethod : IEquatable<DocConstantStudyAllocattionMethod>, IEqualityComparer<DocConstantStudyAllocattionMethod>
    {
        public const string OPAQUE_ENVELOPES = "Opaque Envelopes";
        public const string RANDOM_NUMBER_GENERATOR = "Random Number Generator";
        public const string ROLLING_DICE = "Rolling Dice";
        public const string SEQUENCE_ALLOCATION = "Sequence Allocation";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyAllocattionMethod).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantStudyAllocattionMethod(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantStudyAllocattionMethod(string Val) => new DocConstantStudyAllocattionMethod(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantStudyAllocattionMethod item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantStudyAllocattionMethod(StudyAllocattionMethodEnm Val) => new DocConstantStudyAllocattionMethod(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator StudyAllocattionMethodEnm(DocConstantStudyAllocattionMethod item)
        {
            Enum.TryParse<StudyAllocattionMethodEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyAllocattionMethod obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantStudyAllocattionMethod x, DocConstantStudyAllocattionMethod y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyAllocattionMethod x, DocConstantStudyAllocattionMethod y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantStudyAllocattionMethod x, DocConstantStudyAllocattionMethod y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyAllocattionMethod))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyAllocattionMethod) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantStudyAllocattionMethod obj) => obj?.GetHashCode() ?? -17;
    }
}
