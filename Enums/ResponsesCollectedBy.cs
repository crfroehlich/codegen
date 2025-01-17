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
    public enum ResponsesCollectedByEnm
    {
        [EnumMember(Value = DocConstantResponsesCollectedBy.CLINICAL_CARE_PROVIDER), SCDescript(DocConstantResponsesCollectedBy.CLINICAL_CARE_PROVIDER), SSDescript(DocConstantResponsesCollectedBy.CLINICAL_CARE_PROVIDER), SCDisplay(Name = DocConstantResponsesCollectedBy.CLINICAL_CARE_PROVIDER)]
        CLINICAL_CARE_PROVIDER = 2812,
        [EnumMember(Value = DocConstantResponsesCollectedBy.LABORATORY_TECH), SCDescript(DocConstantResponsesCollectedBy.LABORATORY_TECH), SSDescript(DocConstantResponsesCollectedBy.LABORATORY_TECH), SCDisplay(Name = DocConstantResponsesCollectedBy.LABORATORY_TECH)]
        LABORATORY_TECH = 2817,
        [EnumMember(Value = DocConstantResponsesCollectedBy.MULTIPLE), SCDescript(DocConstantResponsesCollectedBy.MULTIPLE), SSDescript(DocConstantResponsesCollectedBy.MULTIPLE), SCDisplay(Name = DocConstantResponsesCollectedBy.MULTIPLE)]
        MULTIPLE = 2822,
        [EnumMember(Value = DocConstantResponsesCollectedBy.NR), SCDescript(DocConstantResponsesCollectedBy.NR), SSDescript(DocConstantResponsesCollectedBy.NR), SCDisplay(Name = DocConstantResponsesCollectedBy.NR)]
        NR = 2827,
        [EnumMember(Value = DocConstantResponsesCollectedBy.OBSERVE), SCDescript(DocConstantResponsesCollectedBy.OBSERVE), SSDescript(DocConstantResponsesCollectedBy.OBSERVE), SCDisplay(Name = DocConstantResponsesCollectedBy.OBSERVE)]
        OBSERVE = 2832,
        [EnumMember(Value = DocConstantResponsesCollectedBy.PAID_CAREGIVER_STAFF), SCDescript(DocConstantResponsesCollectedBy.PAID_CAREGIVER_STAFF), SSDescript(DocConstantResponsesCollectedBy.PAID_CAREGIVER_STAFF), SCDisplay(Name = DocConstantResponsesCollectedBy.PAID_CAREGIVER_STAFF)]
        PAID_CAREGIVER_STAFF = 2837,
        [EnumMember(Value = DocConstantResponsesCollectedBy.RESEARCHER), SCDescript(DocConstantResponsesCollectedBy.RESEARCHER), SSDescript(DocConstantResponsesCollectedBy.RESEARCHER), SCDisplay(Name = DocConstantResponsesCollectedBy.RESEARCHER)]
        RESEARCHER = 2842,
        [EnumMember(Value = DocConstantResponsesCollectedBy.SELF), SCDescript(DocConstantResponsesCollectedBy.SELF), SSDescript(DocConstantResponsesCollectedBy.SELF), SCDisplay(Name = DocConstantResponsesCollectedBy.SELF)]
        SELF = 2847,
        [EnumMember(Value = DocConstantResponsesCollectedBy.STUDY_INVESTIGATOR), SCDescript(DocConstantResponsesCollectedBy.STUDY_INVESTIGATOR), SSDescript(DocConstantResponsesCollectedBy.STUDY_INVESTIGATOR), SCDisplay(Name = DocConstantResponsesCollectedBy.STUDY_INVESTIGATOR)]
        STUDY_INVESTIGATOR = 2852,
        [EnumMember(Value = DocConstantResponsesCollectedBy.SURGEON), SCDescript(DocConstantResponsesCollectedBy.SURGEON), SSDescript(DocConstantResponsesCollectedBy.SURGEON), SCDisplay(Name = DocConstantResponsesCollectedBy.SURGEON)]
        SURGEON = 2857,
        [EnumMember(Value = DocConstantResponsesCollectedBy.TEACHER), SCDescript(DocConstantResponsesCollectedBy.TEACHER), SSDescript(DocConstantResponsesCollectedBy.TEACHER), SCDisplay(Name = DocConstantResponsesCollectedBy.TEACHER)]
        TEACHER = 2862,
        [EnumMember(Value = DocConstantResponsesCollectedBy.UNCLEAR), SCDescript(DocConstantResponsesCollectedBy.UNCLEAR), SSDescript(DocConstantResponsesCollectedBy.UNCLEAR), SCDisplay(Name = DocConstantResponsesCollectedBy.UNCLEAR)]
        UNCLEAR = 2867,
        [EnumMember(Value = DocConstantResponsesCollectedBy.UNPAID_CAREGIVER_FAMILY), SCDescript(DocConstantResponsesCollectedBy.UNPAID_CAREGIVER_FAMILY), SSDescript(DocConstantResponsesCollectedBy.UNPAID_CAREGIVER_FAMILY), SCDisplay(Name = DocConstantResponsesCollectedBy.UNPAID_CAREGIVER_FAMILY)]
        UNPAID_CAREGIVER_FAMILY = 2872
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this ResponsesCollectedByEnm instance)
        {
            switch(instance)
            {
                case ResponsesCollectedByEnm.CLINICAL_CARE_PROVIDER:
                    return DocConstantResponsesCollectedBy.CLINICAL_CARE_PROVIDER;
                case ResponsesCollectedByEnm.LABORATORY_TECH:
                    return DocConstantResponsesCollectedBy.LABORATORY_TECH;
                case ResponsesCollectedByEnm.MULTIPLE:
                    return DocConstantResponsesCollectedBy.MULTIPLE;
                case ResponsesCollectedByEnm.NR:
                    return DocConstantResponsesCollectedBy.NR;
                case ResponsesCollectedByEnm.OBSERVE:
                    return DocConstantResponsesCollectedBy.OBSERVE;
                case ResponsesCollectedByEnm.PAID_CAREGIVER_STAFF:
                    return DocConstantResponsesCollectedBy.PAID_CAREGIVER_STAFF;
                case ResponsesCollectedByEnm.RESEARCHER:
                    return DocConstantResponsesCollectedBy.RESEARCHER;
                case ResponsesCollectedByEnm.SELF:
                    return DocConstantResponsesCollectedBy.SELF;
                case ResponsesCollectedByEnm.STUDY_INVESTIGATOR:
                    return DocConstantResponsesCollectedBy.STUDY_INVESTIGATOR;
                case ResponsesCollectedByEnm.SURGEON:
                    return DocConstantResponsesCollectedBy.SURGEON;
                case ResponsesCollectedByEnm.TEACHER:
                    return DocConstantResponsesCollectedBy.TEACHER;
                case ResponsesCollectedByEnm.UNCLEAR:
                    return DocConstantResponsesCollectedBy.UNCLEAR;
                case ResponsesCollectedByEnm.UNPAID_CAREGIVER_FAMILY:
                    return DocConstantResponsesCollectedBy.UNPAID_CAREGIVER_FAMILY;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this ResponsesCollectedByEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantResponsesCollectedBy : IEquatable<DocConstantResponsesCollectedBy>, IEqualityComparer<DocConstantResponsesCollectedBy>
    {
        public const string CLINICAL_CARE_PROVIDER = "Clinician/Care Provider";
        public const string LABORATORY_TECH = "Laboratory Tech";
        public const string MULTIPLE = "Multiple";
        public const string NR = "NR";
        public const string OBSERVE = "Observer";
        public const string PAID_CAREGIVER_STAFF = "Paid caregiver/Staff";
        public const string RESEARCHER = "Researcher";
        public const string SELF = "Self";
        public const string STUDY_INVESTIGATOR = "Study Investigator";
        public const string SURGEON = "Surgeon";
        public const string TEACHER = "Teacher";
        public const string UNCLEAR = "Unclear";
        public const string UNPAID_CAREGIVER_FAMILY = "Unpaid caregiver/Family";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantResponsesCollectedBy).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantResponsesCollectedBy(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantResponsesCollectedBy(string Val) => new DocConstantResponsesCollectedBy(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantResponsesCollectedBy item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantResponsesCollectedBy(ResponsesCollectedByEnm Val) => new DocConstantResponsesCollectedBy(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator ResponsesCollectedByEnm(DocConstantResponsesCollectedBy item)
        {
            Enum.TryParse<ResponsesCollectedByEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantResponsesCollectedBy obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantResponsesCollectedBy x, DocConstantResponsesCollectedBy y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantResponsesCollectedBy x, DocConstantResponsesCollectedBy y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantResponsesCollectedBy x, DocConstantResponsesCollectedBy y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantResponsesCollectedBy))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantResponsesCollectedBy) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantResponsesCollectedBy obj) => obj?.GetHashCode() ?? -17;
    }
}
