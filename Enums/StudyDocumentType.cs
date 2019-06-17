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
    public enum StudyDocumentTypeEnm
    {
        [EnumMember(Value = DocConstantStudyDocumentType.CLINICAL_STUDY_REPORT), SCDescript(DocConstantStudyDocumentType.CLINICAL_STUDY_REPORT), SSDescript(DocConstantStudyDocumentType.CLINICAL_STUDY_REPORT), SCDisplay(Name = DocConstantStudyDocumentType.CLINICAL_STUDY_REPORT)]
        CLINICAL_STUDY_REPORT = 3263,
        [EnumMember(Value = DocConstantStudyDocumentType.CLINICAL_TRIALS_GOV), SCDescript(DocConstantStudyDocumentType.CLINICAL_TRIALS_GOV), SSDescript(DocConstantStudyDocumentType.CLINICAL_TRIALS_GOV), SCDisplay(Name = DocConstantStudyDocumentType.CLINICAL_TRIALS_GOV)]
        CLINICAL_TRIALS_GOV = 3268,
        [EnumMember(Value = DocConstantStudyDocumentType.DOC_DATA_DIRECT_META_ANALYSIS), SCDescript(DocConstantStudyDocumentType.DOC_DATA_DIRECT_META_ANALYSIS), SSDescript(DocConstantStudyDocumentType.DOC_DATA_DIRECT_META_ANALYSIS), SCDisplay(Name = DocConstantStudyDocumentType.DOC_DATA_DIRECT_META_ANALYSIS)]
        DOC_DATA_DIRECT_META_ANALYSIS = 3308,
        [EnumMember(Value = DocConstantStudyDocumentType.FDA_ADVISORY_COMMITTEE_SUBMISSION), SCDescript(DocConstantStudyDocumentType.FDA_ADVISORY_COMMITTEE_SUBMISSION), SSDescript(DocConstantStudyDocumentType.FDA_ADVISORY_COMMITTEE_SUBMISSION), SCDisplay(Name = DocConstantStudyDocumentType.FDA_ADVISORY_COMMITTEE_SUBMISSION)]
        FDA_ADVISORY_COMMITTEE_SUBMISSION = 3273,
        [EnumMember(Value = DocConstantStudyDocumentType.FDA_APPROVAL_DOCUMENTS), SCDescript(DocConstantStudyDocumentType.FDA_APPROVAL_DOCUMENTS), SSDescript(DocConstantStudyDocumentType.FDA_APPROVAL_DOCUMENTS), SCDisplay(Name = DocConstantStudyDocumentType.FDA_APPROVAL_DOCUMENTS)]
        FDA_APPROVAL_DOCUMENTS = 3278,
        [EnumMember(Value = DocConstantStudyDocumentType.GOVERNMENT_REPORT), SCDescript(DocConstantStudyDocumentType.GOVERNMENT_REPORT), SSDescript(DocConstantStudyDocumentType.GOVERNMENT_REPORT), SCDisplay(Name = DocConstantStudyDocumentType.GOVERNMENT_REPORT)]
        GOVERNMENT_REPORT = 3283,
        [EnumMember(Value = DocConstantStudyDocumentType.GUIDELINE), SCDescript(DocConstantStudyDocumentType.GUIDELINE), SSDescript(DocConstantStudyDocumentType.GUIDELINE), SCDisplay(Name = DocConstantStudyDocumentType.GUIDELINE)]
        GUIDELINE = 3288,
        [EnumMember(Value = DocConstantStudyDocumentType.JOURNAL_ARTICLE), SCDescript(DocConstantStudyDocumentType.JOURNAL_ARTICLE), SSDescript(DocConstantStudyDocumentType.JOURNAL_ARTICLE), SCDisplay(Name = DocConstantStudyDocumentType.JOURNAL_ARTICLE)]
        JOURNAL_ARTICLE = 3293,
        [EnumMember(Value = DocConstantStudyDocumentType.LETTER_TO_THE_EDITOR), SCDescript(DocConstantStudyDocumentType.LETTER_TO_THE_EDITOR), SSDescript(DocConstantStudyDocumentType.LETTER_TO_THE_EDITOR), SCDisplay(Name = DocConstantStudyDocumentType.LETTER_TO_THE_EDITOR)]
        LETTER_TO_THE_EDITOR = 3298,
        [EnumMember(Value = DocConstantStudyDocumentType.MEETING_ABSTRACT), SCDescript(DocConstantStudyDocumentType.MEETING_ABSTRACT), SSDescript(DocConstantStudyDocumentType.MEETING_ABSTRACT), SCDisplay(Name = DocConstantStudyDocumentType.MEETING_ABSTRACT)]
        MEETING_ABSTRACT = 3303,
        [EnumMember(Value = DocConstantStudyDocumentType.POSTER), SCDescript(DocConstantStudyDocumentType.POSTER), SSDescript(DocConstantStudyDocumentType.POSTER), SCDisplay(Name = DocConstantStudyDocumentType.POSTER)]
        POSTER = 3313,
        [EnumMember(Value = DocConstantStudyDocumentType.POWER_POINT), SCDescript(DocConstantStudyDocumentType.POWER_POINT), SSDescript(DocConstantStudyDocumentType.POWER_POINT), SCDisplay(Name = DocConstantStudyDocumentType.POWER_POINT)]
        POWER_POINT = 3318,
        [EnumMember(Value = DocConstantStudyDocumentType.PRESS_RELEASE), SCDescript(DocConstantStudyDocumentType.PRESS_RELEASE), SSDescript(DocConstantStudyDocumentType.PRESS_RELEASE), SCDisplay(Name = DocConstantStudyDocumentType.PRESS_RELEASE)]
        PRESS_RELEASE = 3323,
        [EnumMember(Value = DocConstantStudyDocumentType.REVIEW), SCDescript(DocConstantStudyDocumentType.REVIEW), SSDescript(DocConstantStudyDocumentType.REVIEW), SCDisplay(Name = DocConstantStudyDocumentType.REVIEW)]
        REVIEW = 3328,
        [EnumMember(Value = DocConstantStudyDocumentType.SYSTEMATIC_REVIEW_META_ANALYSIS), SCDescript(DocConstantStudyDocumentType.SYSTEMATIC_REVIEW_META_ANALYSIS), SSDescript(DocConstantStudyDocumentType.SYSTEMATIC_REVIEW_META_ANALYSIS), SCDisplay(Name = DocConstantStudyDocumentType.SYSTEMATIC_REVIEW_META_ANALYSIS)]
        SYSTEMATIC_REVIEW_META_ANALYSIS = 3333,
        [EnumMember(Value = DocConstantStudyDocumentType.THESIS), SCDescript(DocConstantStudyDocumentType.THESIS), SSDescript(DocConstantStudyDocumentType.THESIS), SCDisplay(Name = DocConstantStudyDocumentType.THESIS)]
        THESIS = 3338
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyDocumentTypeEnm instance)
        {
            switch(instance)
            {
                case StudyDocumentTypeEnm.CLINICAL_STUDY_REPORT:
                    return DocConstantStudyDocumentType.CLINICAL_STUDY_REPORT;
                case StudyDocumentTypeEnm.CLINICAL_TRIALS_GOV:
                    return DocConstantStudyDocumentType.CLINICAL_TRIALS_GOV;
                case StudyDocumentTypeEnm.DOC_DATA_DIRECT_META_ANALYSIS:
                    return DocConstantStudyDocumentType.DOC_DATA_DIRECT_META_ANALYSIS;
                case StudyDocumentTypeEnm.FDA_ADVISORY_COMMITTEE_SUBMISSION:
                    return DocConstantStudyDocumentType.FDA_ADVISORY_COMMITTEE_SUBMISSION;
                case StudyDocumentTypeEnm.FDA_APPROVAL_DOCUMENTS:
                    return DocConstantStudyDocumentType.FDA_APPROVAL_DOCUMENTS;
                case StudyDocumentTypeEnm.GOVERNMENT_REPORT:
                    return DocConstantStudyDocumentType.GOVERNMENT_REPORT;
                case StudyDocumentTypeEnm.GUIDELINE:
                    return DocConstantStudyDocumentType.GUIDELINE;
                case StudyDocumentTypeEnm.JOURNAL_ARTICLE:
                    return DocConstantStudyDocumentType.JOURNAL_ARTICLE;
                case StudyDocumentTypeEnm.LETTER_TO_THE_EDITOR:
                    return DocConstantStudyDocumentType.LETTER_TO_THE_EDITOR;
                case StudyDocumentTypeEnm.MEETING_ABSTRACT:
                    return DocConstantStudyDocumentType.MEETING_ABSTRACT;
                case StudyDocumentTypeEnm.POSTER:
                    return DocConstantStudyDocumentType.POSTER;
                case StudyDocumentTypeEnm.POWER_POINT:
                    return DocConstantStudyDocumentType.POWER_POINT;
                case StudyDocumentTypeEnm.PRESS_RELEASE:
                    return DocConstantStudyDocumentType.PRESS_RELEASE;
                case StudyDocumentTypeEnm.REVIEW:
                    return DocConstantStudyDocumentType.REVIEW;
                case StudyDocumentTypeEnm.SYSTEMATIC_REVIEW_META_ANALYSIS:
                    return DocConstantStudyDocumentType.SYSTEMATIC_REVIEW_META_ANALYSIS;
                case StudyDocumentTypeEnm.THESIS:
                    return DocConstantStudyDocumentType.THESIS;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyDocumentTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantStudyDocumentType : IEquatable<DocConstantStudyDocumentType>, IEqualityComparer<DocConstantStudyDocumentType>
    {
        public const string CLINICAL_STUDY_REPORT = "Clinical Study Report";
        public const string CLINICAL_TRIALS_GOV = "Compliance";
        public const string DOC_DATA_DIRECT_META_ANALYSIS = "Meta Analysis";
        public const string FDA_ADVISORY_COMMITTEE_SUBMISSION = "FDA Advisory Committee Submission";
        public const string FDA_APPROVAL_DOCUMENTS = "FDA Approval Documents";
        public const string GOVERNMENT_REPORT = "Government Report";
        public const string GUIDELINE = "Guideline";
        public const string JOURNAL_ARTICLE = "Journal Article";
        public const string LETTER_TO_THE_EDITOR = "Letter to the Editor";
        public const string MEETING_ABSTRACT = "Meeting Abstract";
        public const string POSTER = "Poster";
        public const string POWER_POINT = "PowerPoint";
        public const string PRESS_RELEASE = "Press Release";
        public const string REVIEW = "Review";
        public const string SYSTEMATIC_REVIEW_META_ANALYSIS = "Systematic Review & Meta Analysis";
        public const string THESIS = "Thesis";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyDocumentType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantStudyDocumentType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantStudyDocumentType(string Val) => new DocConstantStudyDocumentType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantStudyDocumentType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantStudyDocumentType(StudyDocumentTypeEnm Val) => new DocConstantStudyDocumentType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator StudyDocumentTypeEnm(DocConstantStudyDocumentType item)
        {
            Enum.TryParse<StudyDocumentTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyDocumentType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantStudyDocumentType x, DocConstantStudyDocumentType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyDocumentType x, DocConstantStudyDocumentType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantStudyDocumentType x, DocConstantStudyDocumentType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyDocumentType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyDocumentType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantStudyDocumentType obj) => obj?.GetHashCode() ?? -17;
    }
}
