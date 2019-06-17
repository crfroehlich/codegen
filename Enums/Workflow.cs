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
    public enum WorkflowEnm
    {
        [EnumMember(Value = DocConstantWorkflow.AUDIT_ERROR), SCDescript(DocConstantWorkflow.AUDIT_ERROR), SSDescript(DocConstantWorkflow.AUDIT_ERROR), SCDisplay(Name = DocConstantWorkflow.AUDIT_ERROR)]
        AUDIT_ERROR = 76351812,
        [EnumMember(Value = DocConstantWorkflow.BAYESIAN_ANALYSIS), SCDescript(DocConstantWorkflow.BAYESIAN_ANALYSIS), SSDescript(DocConstantWorkflow.BAYESIAN_ANALYSIS), SCDisplay(Name = DocConstantWorkflow.BAYESIAN_ANALYSIS)]
        BAYESIAN_ANALYSIS = 23395205,
        [EnumMember(Value = DocConstantWorkflow.COHORT_ANALYSIS), SCDescript(DocConstantWorkflow.COHORT_ANALYSIS), SSDescript(DocConstantWorkflow.COHORT_ANALYSIS), SCDisplay(Name = DocConstantWorkflow.COHORT_ANALYSIS)]
        COHORT_ANALYSIS = 17686252,
        [EnumMember(Value = DocConstantWorkflow.CUSTOM_REPORT), SCDescript(DocConstantWorkflow.CUSTOM_REPORT), SSDescript(DocConstantWorkflow.CUSTOM_REPORT), SCDisplay(Name = DocConstantWorkflow.CUSTOM_REPORT)]
        CUSTOM_REPORT = 120648707,
        [EnumMember(Value = DocConstantWorkflow.DATA_EXPORT), SCDescript(DocConstantWorkflow.DATA_EXPORT), SSDescript(DocConstantWorkflow.DATA_EXPORT), SCDisplay(Name = DocConstantWorkflow.DATA_EXPORT)]
        DATA_EXPORT = 22669313,
        [EnumMember(Value = DocConstantWorkflow.DEFAULT_FILTER), SCDescript(DocConstantWorkflow.DEFAULT_FILTER), SSDescript(DocConstantWorkflow.DEFAULT_FILTER), SCDisplay(Name = DocConstantWorkflow.DEFAULT_FILTER)]
        DEFAULT_FILTER = 150785541,
        [EnumMember(Value = DocConstantWorkflow.DEFAULT_NAMESET), SCDescript(DocConstantWorkflow.DEFAULT_NAMESET), SSDescript(DocConstantWorkflow.DEFAULT_NAMESET), SCDisplay(Name = DocConstantWorkflow.DEFAULT_NAMESET)]
        DEFAULT_NAMESET = 150785542,
        [EnumMember(Value = DocConstantWorkflow.DIA_REPORT), SCDescript(DocConstantWorkflow.DIA_REPORT), SSDescript(DocConstantWorkflow.DIA_REPORT), SCDisplay(Name = DocConstantWorkflow.DIA_REPORT)]
        DIA_REPORT = 76351811,
        [EnumMember(Value = DocConstantWorkflow.EVIDENCE_ON_DEMAND), SCDescript(DocConstantWorkflow.EVIDENCE_ON_DEMAND), SSDescript(DocConstantWorkflow.EVIDENCE_ON_DEMAND), SCDisplay(Name = DocConstantWorkflow.EVIDENCE_ON_DEMAND)]
        EVIDENCE_ON_DEMAND = 76351619,
        [EnumMember(Value = DocConstantWorkflow.EVIDENCE_STATEMENTS), SCDescript(DocConstantWorkflow.EVIDENCE_STATEMENTS), SSDescript(DocConstantWorkflow.EVIDENCE_STATEMENTS), SCDisplay(Name = DocConstantWorkflow.EVIDENCE_STATEMENTS)]
        EVIDENCE_STATEMENTS = 146157857,
        [EnumMember(Value = DocConstantWorkflow.EVIDENCE_TABLE), SCDescript(DocConstantWorkflow.EVIDENCE_TABLE), SSDescript(DocConstantWorkflow.EVIDENCE_TABLE), SCDisplay(Name = DocConstantWorkflow.EVIDENCE_TABLE)]
        EVIDENCE_TABLE = 10483144,
        [EnumMember(Value = DocConstantWorkflow.FAQ), SCDescript(DocConstantWorkflow.FAQ), SSDescript(DocConstantWorkflow.FAQ), SCDisplay(Name = DocConstantWorkflow.FAQ)]
        FAQ = 146157861,
        [EnumMember(Value = DocConstantWorkflow.FILTER), SCDescript(DocConstantWorkflow.FILTER), SSDescript(DocConstantWorkflow.FILTER), SCDisplay(Name = DocConstantWorkflow.FILTER)]
        FILTER = 10483149,
        [EnumMember(Value = DocConstantWorkflow.FRAMED_QUESTION_DATA_SET), SCDescript(DocConstantWorkflow.FRAMED_QUESTION_DATA_SET), SSDescript(DocConstantWorkflow.FRAMED_QUESTION_DATA_SET), SCDisplay(Name = DocConstantWorkflow.FRAMED_QUESTION_DATA_SET)]
        FRAMED_QUESTION_DATA_SET = 76351798,
        [EnumMember(Value = DocConstantWorkflow.FRAMED_QUESTION_LIBRARY), SCDescript(DocConstantWorkflow.FRAMED_QUESTION_LIBRARY), SSDescript(DocConstantWorkflow.FRAMED_QUESTION_LIBRARY), SCDisplay(Name = DocConstantWorkflow.FRAMED_QUESTION_LIBRARY)]
        FRAMED_QUESTION_LIBRARY = 76351799,
        [EnumMember(Value = DocConstantWorkflow.FREQUENTIST_ANALYSIS), SCDescript(DocConstantWorkflow.FREQUENTIST_ANALYSIS), SSDescript(DocConstantWorkflow.FREQUENTIST_ANALYSIS), SCDisplay(Name = DocConstantWorkflow.FREQUENTIST_ANALYSIS)]
        FREQUENTIST_ANALYSIS = 21595126,
        [EnumMember(Value = DocConstantWorkflow.HTA), SCDescript(DocConstantWorkflow.HTA), SSDescript(DocConstantWorkflow.HTA), SCDisplay(Name = DocConstantWorkflow.HTA)]
        HTA = 76351809,
        [EnumMember(Value = DocConstantWorkflow.LIBRARY_RATINGS), SCDescript(DocConstantWorkflow.LIBRARY_RATINGS), SSDescript(DocConstantWorkflow.LIBRARY_RATINGS), SCDisplay(Name = DocConstantWorkflow.LIBRARY_RATINGS)]
        LIBRARY_RATINGS = 150785214,
        [EnumMember(Value = DocConstantWorkflow.META_ANALYSIS), SCDescript(DocConstantWorkflow.META_ANALYSIS), SSDescript(DocConstantWorkflow.META_ANALYSIS), SCDisplay(Name = DocConstantWorkflow.META_ANALYSIS)]
        META_ANALYSIS = 12627091,
        [EnumMember(Value = DocConstantWorkflow.NAMESET), SCDescript(DocConstantWorkflow.NAMESET), SSDescript(DocConstantWorkflow.NAMESET), SCDisplay(Name = DocConstantWorkflow.NAMESET)]
        NAMESET = 17611704,
        [EnumMember(Value = DocConstantWorkflow.PICO_RATING), SCDescript(DocConstantWorkflow.PICO_RATING), SSDescript(DocConstantWorkflow.PICO_RATING), SCDisplay(Name = DocConstantWorkflow.PICO_RATING)]
        PICO_RATING = 76351813,
        [EnumMember(Value = DocConstantWorkflow.R_SNIPPET), SCDescript(DocConstantWorkflow.R_SNIPPET), SSDescript(DocConstantWorkflow.R_SNIPPET), SCDisplay(Name = DocConstantWorkflow.R_SNIPPET)]
        R_SNIPPET = 146157859,
        [EnumMember(Value = DocConstantWorkflow.RAPID_REVIEW), SCDescript(DocConstantWorkflow.RAPID_REVIEW), SSDescript(DocConstantWorkflow.RAPID_REVIEW), SCDisplay(Name = DocConstantWorkflow.RAPID_REVIEW)]
        RAPID_REVIEW = 76351810,
        [EnumMember(Value = DocConstantWorkflow.RECONCILIATION), SCDescript(DocConstantWorkflow.RECONCILIATION), SSDescript(DocConstantWorkflow.RECONCILIATION), SCDisplay(Name = DocConstantWorkflow.RECONCILIATION)]
        RECONCILIATION = 157821103,
        [EnumMember(Value = DocConstantWorkflow.RESPONSE_LETTER), SCDescript(DocConstantWorkflow.RESPONSE_LETTER), SSDescript(DocConstantWorkflow.RESPONSE_LETTER), SCDisplay(Name = DocConstantWorkflow.RESPONSE_LETTER)]
        RESPONSE_LETTER = 76351808,
        [EnumMember(Value = DocConstantWorkflow.RISK_OF_BIAS), SCDescript(DocConstantWorkflow.RISK_OF_BIAS), SSDescript(DocConstantWorkflow.RISK_OF_BIAS), SCDisplay(Name = DocConstantWorkflow.RISK_OF_BIAS)]
        RISK_OF_BIAS = 146157858,
        [EnumMember(Value = DocConstantWorkflow.RMD_SNIPPET), SCDescript(DocConstantWorkflow.RMD_SNIPPET), SSDescript(DocConstantWorkflow.RMD_SNIPPET), SCDisplay(Name = DocConstantWorkflow.RMD_SNIPPET)]
        RMD_SNIPPET = 146157860,
        [EnumMember(Value = DocConstantWorkflow.SYSTEMATIC_REVIEW), SCDescript(DocConstantWorkflow.SYSTEMATIC_REVIEW), SSDescript(DocConstantWorkflow.SYSTEMATIC_REVIEW), SCDisplay(Name = DocConstantWorkflow.SYSTEMATIC_REVIEW)]
        SYSTEMATIC_REVIEW = 76351807,
        [EnumMember(Value = DocConstantWorkflow.VIEW), SCDescript(DocConstantWorkflow.VIEW), SSDescript(DocConstantWorkflow.VIEW), SCDisplay(Name = DocConstantWorkflow.VIEW)]
        VIEW = 41790614
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this WorkflowEnm instance)
        {
            switch(instance)
            {
                case WorkflowEnm.AUDIT_ERROR:
                    return DocConstantWorkflow.AUDIT_ERROR;
                case WorkflowEnm.BAYESIAN_ANALYSIS:
                    return DocConstantWorkflow.BAYESIAN_ANALYSIS;
                case WorkflowEnm.COHORT_ANALYSIS:
                    return DocConstantWorkflow.COHORT_ANALYSIS;
                case WorkflowEnm.CUSTOM_REPORT:
                    return DocConstantWorkflow.CUSTOM_REPORT;
                case WorkflowEnm.DATA_EXPORT:
                    return DocConstantWorkflow.DATA_EXPORT;
                case WorkflowEnm.DEFAULT_FILTER:
                    return DocConstantWorkflow.DEFAULT_FILTER;
                case WorkflowEnm.DEFAULT_NAMESET:
                    return DocConstantWorkflow.DEFAULT_NAMESET;
                case WorkflowEnm.DIA_REPORT:
                    return DocConstantWorkflow.DIA_REPORT;
                case WorkflowEnm.EVIDENCE_ON_DEMAND:
                    return DocConstantWorkflow.EVIDENCE_ON_DEMAND;
                case WorkflowEnm.EVIDENCE_STATEMENTS:
                    return DocConstantWorkflow.EVIDENCE_STATEMENTS;
                case WorkflowEnm.EVIDENCE_TABLE:
                    return DocConstantWorkflow.EVIDENCE_TABLE;
                case WorkflowEnm.FAQ:
                    return DocConstantWorkflow.FAQ;
                case WorkflowEnm.FILTER:
                    return DocConstantWorkflow.FILTER;
                case WorkflowEnm.FRAMED_QUESTION_DATA_SET:
                    return DocConstantWorkflow.FRAMED_QUESTION_DATA_SET;
                case WorkflowEnm.FRAMED_QUESTION_LIBRARY:
                    return DocConstantWorkflow.FRAMED_QUESTION_LIBRARY;
                case WorkflowEnm.FREQUENTIST_ANALYSIS:
                    return DocConstantWorkflow.FREQUENTIST_ANALYSIS;
                case WorkflowEnm.HTA:
                    return DocConstantWorkflow.HTA;
                case WorkflowEnm.LIBRARY_RATINGS:
                    return DocConstantWorkflow.LIBRARY_RATINGS;
                case WorkflowEnm.META_ANALYSIS:
                    return DocConstantWorkflow.META_ANALYSIS;
                case WorkflowEnm.NAMESET:
                    return DocConstantWorkflow.NAMESET;
                case WorkflowEnm.PICO_RATING:
                    return DocConstantWorkflow.PICO_RATING;
                case WorkflowEnm.R_SNIPPET:
                    return DocConstantWorkflow.R_SNIPPET;
                case WorkflowEnm.RAPID_REVIEW:
                    return DocConstantWorkflow.RAPID_REVIEW;
                case WorkflowEnm.RECONCILIATION:
                    return DocConstantWorkflow.RECONCILIATION;
                case WorkflowEnm.RESPONSE_LETTER:
                    return DocConstantWorkflow.RESPONSE_LETTER;
                case WorkflowEnm.RISK_OF_BIAS:
                    return DocConstantWorkflow.RISK_OF_BIAS;
                case WorkflowEnm.RMD_SNIPPET:
                    return DocConstantWorkflow.RMD_SNIPPET;
                case WorkflowEnm.SYSTEMATIC_REVIEW:
                    return DocConstantWorkflow.SYSTEMATIC_REVIEW;
                case WorkflowEnm.VIEW:
                    return DocConstantWorkflow.VIEW;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this WorkflowEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantWorkflow : IEquatable<DocConstantWorkflow>, IEqualityComparer<DocConstantWorkflow>
    {
        public const string AUDIT_ERROR = "Audit Error";
        public const string BAYESIAN_ANALYSIS = "Bayesian NMA";
        public const string COHORT_ANALYSIS = "Cohort Analysis";
        public const string CUSTOM_REPORT = "Custom Report";
        public const string DATA_EXPORT = "Data Export";
        public const string DEFAULT_FILTER = "Default Filter";
        public const string DEFAULT_NAMESET = "Default Nameset";
        public const string DIA_REPORT = "DIA Report";
        public const string EVIDENCE_ON_DEMAND = "Evidence on Demand";
        public const string EVIDENCE_STATEMENTS = "Evidence Statements";
        public const string EVIDENCE_TABLE = "Evidence Table";
        public const string FAQ = "FAQ";
        public const string FILTER = "Filter";
        public const string FRAMED_QUESTION_DATA_SET = "Framed Question Data Set";
        public const string FRAMED_QUESTION_LIBRARY = "Framed Question Library";
        public const string FREQUENTIST_ANALYSIS = "Frequentist NMA";
        public const string HTA = "HTA";
        public const string LIBRARY_RATINGS = "Library Ratings";
        public const string META_ANALYSIS = "Direct Meta Analysis";
        public const string NAMESET = "Nameset";
        public const string PICO_RATING = "PICO Rating";
        public const string R_SNIPPET = "R Snippet";
        public const string RAPID_REVIEW = "Rapid Review";
        public const string RECONCILIATION = "Reconciliation";
        public const string RESPONSE_LETTER = "Response Letter";
        public const string RISK_OF_BIAS = "Risk of Bias";
        public const string RMD_SNIPPET = "RMD Snippet";
        public const string SYSTEMATIC_REVIEW = "Systematic Review";
        public const string VIEW = "View";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantWorkflow).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantWorkflow(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantWorkflow(string Val) => new DocConstantWorkflow(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantWorkflow item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantWorkflow(WorkflowEnm Val) => new DocConstantWorkflow(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator WorkflowEnm(DocConstantWorkflow item)
        {
            Enum.TryParse<WorkflowEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantWorkflow obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantWorkflow x, DocConstantWorkflow y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantWorkflow x, DocConstantWorkflow y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantWorkflow x, DocConstantWorkflow y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantWorkflow))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantWorkflow) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantWorkflow obj) => obj?.GetHashCode() ?? -17;
    }
}
