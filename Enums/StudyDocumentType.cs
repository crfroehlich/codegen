//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Dto.Security;
using Services.Enums;
using Services.Models;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;

namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudyDocumentTypeEnm
    {
        [EnumMember(Value = DocConstantStudyDocumentType.CLINICAL_STUDY_REPORT)]
        CLINICAL_STUDY_REPORT,
        [EnumMember(Value = DocConstantStudyDocumentType.CLINICAL_TRIALS_GOV)]
        CLINICAL_TRIALS_GOV,
        [EnumMember(Value = DocConstantStudyDocumentType.DOC_DATA_DIRECT_META_ANALYSIS)]
        DOC_DATA_DIRECT_META_ANALYSIS,
        [EnumMember(Value = DocConstantStudyDocumentType.FDA_ADVISORY_COMMITTEE_SUBMISSION)]
        FDA_ADVISORY_COMMITTEE_SUBMISSION,
        [EnumMember(Value = DocConstantStudyDocumentType.FDA_APPROVAL_DOCUMENTS)]
        FDA_APPROVAL_DOCUMENTS,
        [EnumMember(Value = DocConstantStudyDocumentType.GOVERNMENT_REPORT)]
        GOVERNMENT_REPORT,
        [EnumMember(Value = DocConstantStudyDocumentType.GUIDELINE)]
        GUIDELINE,
        [EnumMember(Value = DocConstantStudyDocumentType.JOURNAL_ARTICLE)]
        JOURNAL_ARTICLE,
        [EnumMember(Value = DocConstantStudyDocumentType.LETTER_TO_THE_EDITOR)]
        LETTER_TO_THE_EDITOR,
        [EnumMember(Value = DocConstantStudyDocumentType.MEETING_ABSTRACT)]
        MEETING_ABSTRACT,
        [EnumMember(Value = DocConstantStudyDocumentType.POSTER)]
        POSTER,
        [EnumMember(Value = DocConstantStudyDocumentType.POWER_POINT)]
        POWER_POINT,
        [EnumMember(Value = DocConstantStudyDocumentType.PRESS_RELEASE)]
        PRESS_RELEASE,
        [EnumMember(Value = DocConstantStudyDocumentType.REVIEW)]
        REVIEW,
        [EnumMember(Value = DocConstantStudyDocumentType.SYSTEMATIC_REVIEW_META_ANALYSIS)]
        SYSTEMATIC_REVIEW_META_ANALYSIS,
        [EnumMember(Value = DocConstantStudyDocumentType.THESIS)]
        THESIS
    }
    
	public static partial class EnumExtensions
    {
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
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyDocumentType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyDocumentType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyDocumentType(string Val) => new DocConstantStudyDocumentType(Val);

        public static implicit operator string(DocConstantStudyDocumentType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable (DocConstantStudyDocumentType)

        public bool Equals(DocConstantStudyDocumentType obj) => this == obj;

        public static bool operator ==(DocConstantStudyDocumentType x, DocConstantStudyDocumentType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantStudyDocumentType x, DocConstantStudyDocumentType y) => x == y;
        
        public static bool operator !=(DocConstantStudyDocumentType x, DocConstantStudyDocumentType y) => !(x == y);

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

        public override int GetHashCode() => 17 * Value.GetHashCode();
				
        public int GetHashCode(DocConstantStudyDocumentType obj) => obj.GetHashCode();

        #endregion IEquatable
    }
}
