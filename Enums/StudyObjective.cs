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
    public enum StudyObjectiveEnm
    {
        [EnumMember(Value = DocConstantStudyObjective.OTHERS), SCDescript(DocConstantStudyObjective.OTHERS), SSDescript(DocConstantStudyObjective.OTHERS), SCDisplay(Name = DocConstantStudyObjective.OTHERS)]
        OTHERS = 3473,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_EFFICACY_OUTCOME), SCDescript(DocConstantStudyObjective.PRIMARY_EFFICACY_OUTCOME), SSDescript(DocConstantStudyObjective.PRIMARY_EFFICACY_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.PRIMARY_EFFICACY_OUTCOME)]
        PRIMARY_EFFICACY_OUTCOME = 3478,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_ENDPOINT), SCDescript(DocConstantStudyObjective.PRIMARY_ENDPOINT), SSDescript(DocConstantStudyObjective.PRIMARY_ENDPOINT), SCDisplay(Name = DocConstantStudyObjective.PRIMARY_ENDPOINT)]
        PRIMARY_ENDPOINT = 3483,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_ENDPOINT_OUTCOME), SCDescript(DocConstantStudyObjective.PRIMARY_ENDPOINT_OUTCOME), SSDescript(DocConstantStudyObjective.PRIMARY_ENDPOINT_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.PRIMARY_ENDPOINT_OUTCOME)]
        PRIMARY_ENDPOINT_OUTCOME = 3488,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_OBJECTIVE), SCDescript(DocConstantStudyObjective.PRIMARY_OBJECTIVE), SSDescript(DocConstantStudyObjective.PRIMARY_OBJECTIVE), SCDisplay(Name = DocConstantStudyObjective.PRIMARY_OBJECTIVE)]
        PRIMARY_OBJECTIVE = 3493,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_SAFETY_OUTCOME), SCDescript(DocConstantStudyObjective.PRIMARY_SAFETY_OUTCOME), SSDescript(DocConstantStudyObjective.PRIMARY_SAFETY_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.PRIMARY_SAFETY_OUTCOME)]
        PRIMARY_SAFETY_OUTCOME = 3498,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_EFFICACY_OUTCOME), SCDescript(DocConstantStudyObjective.SECONDARY_EFFICACY_OUTCOME), SSDescript(DocConstantStudyObjective.SECONDARY_EFFICACY_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.SECONDARY_EFFICACY_OUTCOME)]
        SECONDARY_EFFICACY_OUTCOME = 3503,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_ENDPOINT), SCDescript(DocConstantStudyObjective.SECONDARY_ENDPOINT), SSDescript(DocConstantStudyObjective.SECONDARY_ENDPOINT), SCDisplay(Name = DocConstantStudyObjective.SECONDARY_ENDPOINT)]
        SECONDARY_ENDPOINT = 3508,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_ENDPOINT_OUTCOME), SCDescript(DocConstantStudyObjective.SECONDARY_ENDPOINT_OUTCOME), SSDescript(DocConstantStudyObjective.SECONDARY_ENDPOINT_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.SECONDARY_ENDPOINT_OUTCOME)]
        SECONDARY_ENDPOINT_OUTCOME = 3513,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_OBJECTIVE), SCDescript(DocConstantStudyObjective.SECONDARY_OBJECTIVE), SSDescript(DocConstantStudyObjective.SECONDARY_OBJECTIVE), SCDisplay(Name = DocConstantStudyObjective.SECONDARY_OBJECTIVE)]
        SECONDARY_OBJECTIVE = 3518,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_SAFETY_OUTCOME), SCDescript(DocConstantStudyObjective.SECONDARY_SAFETY_OUTCOME), SSDescript(DocConstantStudyObjective.SECONDARY_SAFETY_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.SECONDARY_SAFETY_OUTCOME)]
        SECONDARY_SAFETY_OUTCOME = 3523,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_AIM), SCDescript(DocConstantStudyObjective.STUDY_AIM), SSDescript(DocConstantStudyObjective.STUDY_AIM), SCDisplay(Name = DocConstantStudyObjective.STUDY_AIM)]
        STUDY_AIM = 3528,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_HYPOTHESIS), SCDescript(DocConstantStudyObjective.STUDY_HYPOTHESIS), SSDescript(DocConstantStudyObjective.STUDY_HYPOTHESIS), SCDisplay(Name = DocConstantStudyObjective.STUDY_HYPOTHESIS)]
        STUDY_HYPOTHESIS = 3533,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_OBJECTIVE), SCDescript(DocConstantStudyObjective.STUDY_OBJECTIVE), SSDescript(DocConstantStudyObjective.STUDY_OBJECTIVE), SCDisplay(Name = DocConstantStudyObjective.STUDY_OBJECTIVE)]
        STUDY_OBJECTIVE = 3538,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_PURPOSE), SCDescript(DocConstantStudyObjective.STUDY_PURPOSE), SSDescript(DocConstantStudyObjective.STUDY_PURPOSE), SCDisplay(Name = DocConstantStudyObjective.STUDY_PURPOSE)]
        STUDY_PURPOSE = 3543,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_QUESTION), SCDescript(DocConstantStudyObjective.STUDY_QUESTION), SSDescript(DocConstantStudyObjective.STUDY_QUESTION), SCDisplay(Name = DocConstantStudyObjective.STUDY_QUESTION)]
        STUDY_QUESTION = 3548,
        [EnumMember(Value = DocConstantStudyObjective.TERIARY_ENDPOINT), SCDescript(DocConstantStudyObjective.TERIARY_ENDPOINT), SSDescript(DocConstantStudyObjective.TERIARY_ENDPOINT), SCDisplay(Name = DocConstantStudyObjective.TERIARY_ENDPOINT)]
        TERIARY_ENDPOINT = 3553,
        [EnumMember(Value = DocConstantStudyObjective.TERTIARY_EFFICACY_OUTCOME), SCDescript(DocConstantStudyObjective.TERTIARY_EFFICACY_OUTCOME), SSDescript(DocConstantStudyObjective.TERTIARY_EFFICACY_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.TERTIARY_EFFICACY_OUTCOME)]
        TERTIARY_EFFICACY_OUTCOME = 3558,
        [EnumMember(Value = DocConstantStudyObjective.TERTIARY_ENDPOINT_OUTCOME), SCDescript(DocConstantStudyObjective.TERTIARY_ENDPOINT_OUTCOME), SSDescript(DocConstantStudyObjective.TERTIARY_ENDPOINT_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.TERTIARY_ENDPOINT_OUTCOME)]
        TERTIARY_ENDPOINT_OUTCOME = 3563,
        [EnumMember(Value = DocConstantStudyObjective.TERTIARY_OBJECTIVE), SCDescript(DocConstantStudyObjective.TERTIARY_OBJECTIVE), SSDescript(DocConstantStudyObjective.TERTIARY_OBJECTIVE), SCDisplay(Name = DocConstantStudyObjective.TERTIARY_OBJECTIVE)]
        TERTIARY_OBJECTIVE = 3568,
        [EnumMember(Value = DocConstantStudyObjective.TERTIARY_SAFETY_OUTCOME), SCDescript(DocConstantStudyObjective.TERTIARY_SAFETY_OUTCOME), SSDescript(DocConstantStudyObjective.TERTIARY_SAFETY_OUTCOME), SCDisplay(Name = DocConstantStudyObjective.TERTIARY_SAFETY_OUTCOME)]
        TERTIARY_SAFETY_OUTCOME = 3573
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyObjectiveEnm instance)
        {
            switch(instance)
            {
                case StudyObjectiveEnm.OTHERS:
                    return DocConstantStudyObjective.OTHERS;
                case StudyObjectiveEnm.PRIMARY_EFFICACY_OUTCOME:
                    return DocConstantStudyObjective.PRIMARY_EFFICACY_OUTCOME;
                case StudyObjectiveEnm.PRIMARY_ENDPOINT:
                    return DocConstantStudyObjective.PRIMARY_ENDPOINT;
                case StudyObjectiveEnm.PRIMARY_ENDPOINT_OUTCOME:
                    return DocConstantStudyObjective.PRIMARY_ENDPOINT_OUTCOME;
                case StudyObjectiveEnm.PRIMARY_OBJECTIVE:
                    return DocConstantStudyObjective.PRIMARY_OBJECTIVE;
                case StudyObjectiveEnm.PRIMARY_SAFETY_OUTCOME:
                    return DocConstantStudyObjective.PRIMARY_SAFETY_OUTCOME;
                case StudyObjectiveEnm.SECONDARY_EFFICACY_OUTCOME:
                    return DocConstantStudyObjective.SECONDARY_EFFICACY_OUTCOME;
                case StudyObjectiveEnm.SECONDARY_ENDPOINT:
                    return DocConstantStudyObjective.SECONDARY_ENDPOINT;
                case StudyObjectiveEnm.SECONDARY_ENDPOINT_OUTCOME:
                    return DocConstantStudyObjective.SECONDARY_ENDPOINT_OUTCOME;
                case StudyObjectiveEnm.SECONDARY_OBJECTIVE:
                    return DocConstantStudyObjective.SECONDARY_OBJECTIVE;
                case StudyObjectiveEnm.SECONDARY_SAFETY_OUTCOME:
                    return DocConstantStudyObjective.SECONDARY_SAFETY_OUTCOME;
                case StudyObjectiveEnm.STUDY_AIM:
                    return DocConstantStudyObjective.STUDY_AIM;
                case StudyObjectiveEnm.STUDY_HYPOTHESIS:
                    return DocConstantStudyObjective.STUDY_HYPOTHESIS;
                case StudyObjectiveEnm.STUDY_OBJECTIVE:
                    return DocConstantStudyObjective.STUDY_OBJECTIVE;
                case StudyObjectiveEnm.STUDY_PURPOSE:
                    return DocConstantStudyObjective.STUDY_PURPOSE;
                case StudyObjectiveEnm.STUDY_QUESTION:
                    return DocConstantStudyObjective.STUDY_QUESTION;
                case StudyObjectiveEnm.TERIARY_ENDPOINT:
                    return DocConstantStudyObjective.TERIARY_ENDPOINT;
                case StudyObjectiveEnm.TERTIARY_EFFICACY_OUTCOME:
                    return DocConstantStudyObjective.TERTIARY_EFFICACY_OUTCOME;
                case StudyObjectiveEnm.TERTIARY_ENDPOINT_OUTCOME:
                    return DocConstantStudyObjective.TERTIARY_ENDPOINT_OUTCOME;
                case StudyObjectiveEnm.TERTIARY_OBJECTIVE:
                    return DocConstantStudyObjective.TERTIARY_OBJECTIVE;
                case StudyObjectiveEnm.TERTIARY_SAFETY_OUTCOME:
                    return DocConstantStudyObjective.TERTIARY_SAFETY_OUTCOME;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyObjectiveEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantStudyObjective : IEquatable<DocConstantStudyObjective>, IEqualityComparer<DocConstantStudyObjective>
    {
        public const string OTHERS = "Others";
        public const string PRIMARY_EFFICACY_OUTCOME = "Primary Efficacy Outcome";
        public const string PRIMARY_ENDPOINT = "Primary Endpoint";
        public const string PRIMARY_ENDPOINT_OUTCOME = "Primary Endpoint/Outcome";
        public const string PRIMARY_OBJECTIVE = "Primary Objective";
        public const string PRIMARY_SAFETY_OUTCOME = "Primary Safety Outcome";
        public const string SECONDARY_EFFICACY_OUTCOME = "Secondary Efficacy Outcome";
        public const string SECONDARY_ENDPOINT = "Secondary Endpoint";
        public const string SECONDARY_ENDPOINT_OUTCOME = "Secondary Endpoint/Outcome";
        public const string SECONDARY_OBJECTIVE = "Secondary Objective";
        public const string SECONDARY_SAFETY_OUTCOME = "Secondary Safety Outcome";
        public const string STUDY_AIM = "Study Aim";
        public const string STUDY_HYPOTHESIS = "Study Hypothesis";
        public const string STUDY_OBJECTIVE = "Study Objective";
        public const string STUDY_PURPOSE = "Study Purpose";
        public const string STUDY_QUESTION = "Study Question";
        public const string TERIARY_ENDPOINT = "Tertiary Endpoint";
        public const string TERTIARY_EFFICACY_OUTCOME = "Tertiary Efficacy Outcome";
        public const string TERTIARY_ENDPOINT_OUTCOME = "Tertiary Endpoint/Outcome";
        public const string TERTIARY_OBJECTIVE = "Tertiary Objective";
        public const string TERTIARY_SAFETY_OUTCOME = "Tertiary Safety Outcome";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyObjective).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantStudyObjective(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantStudyObjective(string Val) => new DocConstantStudyObjective(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantStudyObjective item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantStudyObjective(StudyObjectiveEnm Val) => new DocConstantStudyObjective(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator StudyObjectiveEnm(DocConstantStudyObjective item)
        {
            Enum.TryParse<StudyObjectiveEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyObjective obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantStudyObjective x, DocConstantStudyObjective y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyObjective x, DocConstantStudyObjective y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantStudyObjective x, DocConstantStudyObjective y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyObjective))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyObjective) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantStudyObjective obj) => obj?.GetHashCode() ?? -17;
    }
}
