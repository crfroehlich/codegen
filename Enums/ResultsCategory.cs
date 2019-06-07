
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
    public enum ResultsCategoryEnm
    {
        [EnumMember(Value = DocConstantResultsCategory.ADVERSE_EVENT), SCDescript(DocConstantResultsCategory.ADVERSE_EVENT), SSDescript(DocConstantResultsCategory.ADVERSE_EVENT), SCDisplay(Name = DocConstantResultsCategory.ADVERSE_EVENT)]
        ADVERSE_EVENT = 79868676,
        [EnumMember(Value = DocConstantResultsCategory.CLINICAL_OUTCOME), SCDescript(DocConstantResultsCategory.CLINICAL_OUTCOME), SSDescript(DocConstantResultsCategory.CLINICAL_OUTCOME), SCDisplay(Name = DocConstantResultsCategory.CLINICAL_OUTCOME)]
        CLINICAL_OUTCOME = 79868677,
        [EnumMember(Value = DocConstantResultsCategory.COST_UTILIZATION), SCDescript(DocConstantResultsCategory.COST_UTILIZATION), SSDescript(DocConstantResultsCategory.COST_UTILIZATION), SCDisplay(Name = DocConstantResultsCategory.COST_UTILIZATION)]
        COST_UTILIZATION = 79868678,
        [EnumMember(Value = DocConstantResultsCategory.DEMOGRAPHICS), SCDescript(DocConstantResultsCategory.DEMOGRAPHICS), SSDescript(DocConstantResultsCategory.DEMOGRAPHICS), SCDisplay(Name = DocConstantResultsCategory.DEMOGRAPHICS)]
        DEMOGRAPHICS = 79868679,
        [EnumMember(Value = DocConstantResultsCategory.LABORATORY_VALUE_DIAGNOSTIC), SCDescript(DocConstantResultsCategory.LABORATORY_VALUE_DIAGNOSTIC), SSDescript(DocConstantResultsCategory.LABORATORY_VALUE_DIAGNOSTIC), SCDisplay(Name = DocConstantResultsCategory.LABORATORY_VALUE_DIAGNOSTIC)]
        LABORATORY_VALUE_DIAGNOSTIC = 79868680,
        [EnumMember(Value = DocConstantResultsCategory.MEDICAL_HISTORY), SCDescript(DocConstantResultsCategory.MEDICAL_HISTORY), SSDescript(DocConstantResultsCategory.MEDICAL_HISTORY), SCDisplay(Name = DocConstantResultsCategory.MEDICAL_HISTORY)]
        MEDICAL_HISTORY = 79868681,
        [EnumMember(Value = DocConstantResultsCategory.MISCELLANEOUS), SCDescript(DocConstantResultsCategory.MISCELLANEOUS), SSDescript(DocConstantResultsCategory.MISCELLANEOUS), SCDisplay(Name = DocConstantResultsCategory.MISCELLANEOUS)]
        MISCELLANEOUS = 79868682,
        [EnumMember(Value = DocConstantResultsCategory.MORTALITY), SCDescript(DocConstantResultsCategory.MORTALITY), SSDescript(DocConstantResultsCategory.MORTALITY), SCDisplay(Name = DocConstantResultsCategory.MORTALITY)]
        MORTALITY = 79868683,
        [EnumMember(Value = DocConstantResultsCategory.SCALES_SCORES), SCDescript(DocConstantResultsCategory.SCALES_SCORES), SSDescript(DocConstantResultsCategory.SCALES_SCORES), SCDisplay(Name = DocConstantResultsCategory.SCALES_SCORES)]
        SCALES_SCORES = 79868684,
        [EnumMember(Value = DocConstantResultsCategory.SOCIAL_HISTORY), SCDescript(DocConstantResultsCategory.SOCIAL_HISTORY), SSDescript(DocConstantResultsCategory.SOCIAL_HISTORY), SCDisplay(Name = DocConstantResultsCategory.SOCIAL_HISTORY)]
        SOCIAL_HISTORY = 79868685,
        [EnumMember(Value = DocConstantResultsCategory.THERAPIES), SCDescript(DocConstantResultsCategory.THERAPIES), SSDescript(DocConstantResultsCategory.THERAPIES), SCDisplay(Name = DocConstantResultsCategory.THERAPIES)]
        THERAPIES = 79868686,
        [EnumMember(Value = DocConstantResultsCategory.WITHDRAWAL_DRUG_DISCONTINUATION), SCDescript(DocConstantResultsCategory.WITHDRAWAL_DRUG_DISCONTINUATION), SSDescript(DocConstantResultsCategory.WITHDRAWAL_DRUG_DISCONTINUATION), SCDisplay(Name = DocConstantResultsCategory.WITHDRAWAL_DRUG_DISCONTINUATION)]
        WITHDRAWAL_DRUG_DISCONTINUATION = 79868687
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ResultsCategoryEnm instance)
        {
            switch(instance)
            {
                case ResultsCategoryEnm.ADVERSE_EVENT:
                    return DocConstantResultsCategory.ADVERSE_EVENT;
                case ResultsCategoryEnm.CLINICAL_OUTCOME:
                    return DocConstantResultsCategory.CLINICAL_OUTCOME;
                case ResultsCategoryEnm.COST_UTILIZATION:
                    return DocConstantResultsCategory.COST_UTILIZATION;
                case ResultsCategoryEnm.DEMOGRAPHICS:
                    return DocConstantResultsCategory.DEMOGRAPHICS;
                case ResultsCategoryEnm.LABORATORY_VALUE_DIAGNOSTIC:
                    return DocConstantResultsCategory.LABORATORY_VALUE_DIAGNOSTIC;
                case ResultsCategoryEnm.MEDICAL_HISTORY:
                    return DocConstantResultsCategory.MEDICAL_HISTORY;
                case ResultsCategoryEnm.MISCELLANEOUS:
                    return DocConstantResultsCategory.MISCELLANEOUS;
                case ResultsCategoryEnm.MORTALITY:
                    return DocConstantResultsCategory.MORTALITY;
                case ResultsCategoryEnm.SCALES_SCORES:
                    return DocConstantResultsCategory.SCALES_SCORES;
                case ResultsCategoryEnm.SOCIAL_HISTORY:
                    return DocConstantResultsCategory.SOCIAL_HISTORY;
                case ResultsCategoryEnm.THERAPIES:
                    return DocConstantResultsCategory.THERAPIES;
                case ResultsCategoryEnm.WITHDRAWAL_DRUG_DISCONTINUATION:
                    return DocConstantResultsCategory.WITHDRAWAL_DRUG_DISCONTINUATION;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this ResultsCategoryEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantResultsCategory : IEquatable<DocConstantResultsCategory>, IEqualityComparer<DocConstantResultsCategory>
    {
        public const string ADVERSE_EVENT = "Adverse Event";
        public const string CLINICAL_OUTCOME = "Clinical Outcome";
        public const string COST_UTILIZATION = "Cost/Utilization";
        public const string DEMOGRAPHICS = "Demographics";
        public const string LABORATORY_VALUE_DIAGNOSTIC = "Laboratory Value/Diagnostic";
        public const string MEDICAL_HISTORY = "Medical History";
        public const string MISCELLANEOUS = "Miscellaneous";
        public const string MORTALITY = "Mortality";
        public const string SCALES_SCORES = "Scales/Scores";
        public const string SOCIAL_HISTORY = "Social History";
        public const string THERAPIES = "Therapies";
        public const string WITHDRAWAL_DRUG_DISCONTINUATION = "Withdrawal/Drug Discontinuation";

        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantResultsCategory).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantResultsCategory(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantResultsCategory(string Val) => new DocConstantResultsCategory(Val);

        public static implicit operator string(DocConstantResultsCategory item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantResultsCategory(ResultsCategoryEnm Val) => new DocConstantResultsCategory(Val.ToEnumString());

        public static explicit operator ResultsCategoryEnm(DocConstantResultsCategory item)
        {
            Enum.TryParse<ResultsCategoryEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        public bool Equals(DocConstantResultsCategory obj) => this == obj;

        public static bool operator ==(DocConstantResultsCategory x, DocConstantResultsCategory y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantResultsCategory x, DocConstantResultsCategory y) => x == y;
        
        public static bool operator !=(DocConstantResultsCategory x, DocConstantResultsCategory y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantResultsCategory))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantResultsCategory) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantResultsCategory obj) => obj?.GetHashCode() ?? -17;
    }
}
