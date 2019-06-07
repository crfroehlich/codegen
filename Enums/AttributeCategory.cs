
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
    public enum AttributeCategoryEnm
    {
        [EnumMember(Value = DocConstantAttributeCategory.ADVERSE_EVENT), SCDescript(DocConstantAttributeCategory.ADVERSE_EVENT), SSDescript(DocConstantAttributeCategory.ADVERSE_EVENT), SCDisplay(Name = DocConstantAttributeCategory.ADVERSE_EVENT)]
        ADVERSE_EVENT = 11793667,
        [EnumMember(Value = DocConstantAttributeCategory.CLINICAL_OUTCOME), SCDescript(DocConstantAttributeCategory.CLINICAL_OUTCOME), SSDescript(DocConstantAttributeCategory.CLINICAL_OUTCOME), SCDisplay(Name = DocConstantAttributeCategory.CLINICAL_OUTCOME)]
        CLINICAL_OUTCOME = 11793672,
        [EnumMember(Value = DocConstantAttributeCategory.COST_UTILIZATION), SCDescript(DocConstantAttributeCategory.COST_UTILIZATION), SSDescript(DocConstantAttributeCategory.COST_UTILIZATION), SCDisplay(Name = DocConstantAttributeCategory.COST_UTILIZATION)]
        COST_UTILIZATION = 11793677,
        [EnumMember(Value = DocConstantAttributeCategory.DEMOGRAPHICS), SCDescript(DocConstantAttributeCategory.DEMOGRAPHICS), SSDescript(DocConstantAttributeCategory.DEMOGRAPHICS), SCDisplay(Name = DocConstantAttributeCategory.DEMOGRAPHICS)]
        DEMOGRAPHICS = 11793682,
        [EnumMember(Value = DocConstantAttributeCategory.LABORATORY_VALUE_DIAGNOSTIC), SCDescript(DocConstantAttributeCategory.LABORATORY_VALUE_DIAGNOSTIC), SSDescript(DocConstantAttributeCategory.LABORATORY_VALUE_DIAGNOSTIC), SCDisplay(Name = DocConstantAttributeCategory.LABORATORY_VALUE_DIAGNOSTIC)]
        LABORATORY_VALUE_DIAGNOSTIC = 17610629,
        [EnumMember(Value = DocConstantAttributeCategory.MEDICAL_HISTORY), SCDescript(DocConstantAttributeCategory.MEDICAL_HISTORY), SSDescript(DocConstantAttributeCategory.MEDICAL_HISTORY), SCDisplay(Name = DocConstantAttributeCategory.MEDICAL_HISTORY)]
        MEDICAL_HISTORY = 11793697,
        [EnumMember(Value = DocConstantAttributeCategory.MEDICATIONS), SCDescript(DocConstantAttributeCategory.MEDICATIONS), SSDescript(DocConstantAttributeCategory.MEDICATIONS), SCDisplay(Name = DocConstantAttributeCategory.MEDICATIONS)]
        MEDICATIONS = 11793702,
        [EnumMember(Value = DocConstantAttributeCategory.MISCELLANEOUS), SCDescript(DocConstantAttributeCategory.MISCELLANEOUS), SSDescript(DocConstantAttributeCategory.MISCELLANEOUS), SCDisplay(Name = DocConstantAttributeCategory.MISCELLANEOUS)]
        MISCELLANEOUS = 11793707,
        [EnumMember(Value = DocConstantAttributeCategory.MORTALITY), SCDescript(DocConstantAttributeCategory.MORTALITY), SSDescript(DocConstantAttributeCategory.MORTALITY), SCDisplay(Name = DocConstantAttributeCategory.MORTALITY)]
        MORTALITY = 11793712,
        [EnumMember(Value = DocConstantAttributeCategory.SCALES_SCORES), SCDescript(DocConstantAttributeCategory.SCALES_SCORES), SSDescript(DocConstantAttributeCategory.SCALES_SCORES), SCDisplay(Name = DocConstantAttributeCategory.SCALES_SCORES)]
        SCALES_SCORES = 11793717,
        [EnumMember(Value = DocConstantAttributeCategory.SOCIAL_HISTORY), SCDescript(DocConstantAttributeCategory.SOCIAL_HISTORY), SSDescript(DocConstantAttributeCategory.SOCIAL_HISTORY), SCDisplay(Name = DocConstantAttributeCategory.SOCIAL_HISTORY)]
        SOCIAL_HISTORY = 11793722,
        [EnumMember(Value = DocConstantAttributeCategory.WITHDRAWAL_DRUG_DISCONTINUATION), SCDescript(DocConstantAttributeCategory.WITHDRAWAL_DRUG_DISCONTINUATION), SSDescript(DocConstantAttributeCategory.WITHDRAWAL_DRUG_DISCONTINUATION), SCDisplay(Name = DocConstantAttributeCategory.WITHDRAWAL_DRUG_DISCONTINUATION)]
        WITHDRAWAL_DRUG_DISCONTINUATION = 17610634
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this AttributeCategoryEnm instance)
        {
            switch(instance)
            {
                case AttributeCategoryEnm.ADVERSE_EVENT:
                    return DocConstantAttributeCategory.ADVERSE_EVENT;
                case AttributeCategoryEnm.CLINICAL_OUTCOME:
                    return DocConstantAttributeCategory.CLINICAL_OUTCOME;
                case AttributeCategoryEnm.COST_UTILIZATION:
                    return DocConstantAttributeCategory.COST_UTILIZATION;
                case AttributeCategoryEnm.DEMOGRAPHICS:
                    return DocConstantAttributeCategory.DEMOGRAPHICS;
                case AttributeCategoryEnm.LABORATORY_VALUE_DIAGNOSTIC:
                    return DocConstantAttributeCategory.LABORATORY_VALUE_DIAGNOSTIC;
                case AttributeCategoryEnm.MEDICAL_HISTORY:
                    return DocConstantAttributeCategory.MEDICAL_HISTORY;
                case AttributeCategoryEnm.MEDICATIONS:
                    return DocConstantAttributeCategory.MEDICATIONS;
                case AttributeCategoryEnm.MISCELLANEOUS:
                    return DocConstantAttributeCategory.MISCELLANEOUS;
                case AttributeCategoryEnm.MORTALITY:
                    return DocConstantAttributeCategory.MORTALITY;
                case AttributeCategoryEnm.SCALES_SCORES:
                    return DocConstantAttributeCategory.SCALES_SCORES;
                case AttributeCategoryEnm.SOCIAL_HISTORY:
                    return DocConstantAttributeCategory.SOCIAL_HISTORY;
                case AttributeCategoryEnm.WITHDRAWAL_DRUG_DISCONTINUATION:
                    return DocConstantAttributeCategory.WITHDRAWAL_DRUG_DISCONTINUATION;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this AttributeCategoryEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantAttributeCategory : IEquatable<DocConstantAttributeCategory>, IEqualityComparer<DocConstantAttributeCategory>
    {
        public const string ADVERSE_EVENT = "Adverse Event";
        public const string CLINICAL_OUTCOME = "Clinical Outcome";
        public const string COST_UTILIZATION = "Cost/Utilization";
        public const string DEMOGRAPHICS = "Demographics";
        public const string LABORATORY_VALUE_DIAGNOSTIC = "Laboratory Value/Diagnostic";
        public const string MEDICAL_HISTORY = "Medical History";
        public const string MEDICATIONS = "Medications";
        public const string MISCELLANEOUS = "Miscellaneous";
        public const string MORTALITY = "Mortality";
        public const string SCALES_SCORES = "Scales/Scores";
        public const string SOCIAL_HISTORY = "Social History";
        public const string WITHDRAWAL_DRUG_DISCONTINUATION = "Withdrawal/Drug Discontinuation";

        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantAttributeCategory).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantAttributeCategory(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantAttributeCategory(string Val) => new DocConstantAttributeCategory(Val);

        public static implicit operator string(DocConstantAttributeCategory item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantAttributeCategory(AttributeCategoryEnm Val) => new DocConstantAttributeCategory(Val.ToEnumString());

        public static explicit operator AttributeCategoryEnm(DocConstantAttributeCategory item)
        {
            Enum.TryParse<AttributeCategoryEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        public bool Equals(DocConstantAttributeCategory obj) => this == obj;

        public static bool operator ==(DocConstantAttributeCategory x, DocConstantAttributeCategory y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantAttributeCategory x, DocConstantAttributeCategory y) => x == y;
        
        public static bool operator !=(DocConstantAttributeCategory x, DocConstantAttributeCategory y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantAttributeCategory))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantAttributeCategory) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantAttributeCategory obj) => obj?.GetHashCode() ?? -17;
    }
}
