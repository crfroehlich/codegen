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
    public enum ReasonRejectedEnm
    {
        [EnumMember(Value = DocConstantReasonRejected.ABSTRACT_INSUFFICIENT_INFORMATION)]
        ABSTRACT_INSUFFICIENT_INFORMATION,
        [EnumMember(Value = DocConstantReasonRejected.ANIMAL_STUDY)]
        ANIMAL_STUDY,
        [EnumMember(Value = DocConstantReasonRejected.DOES_NOT_MEET_PROTOCOL)]
        DOES_NOT_MEET_PROTOCOL,
        [EnumMember(Value = DocConstantReasonRejected.DUPLICATE_PUBLICATION)]
        DUPLICATE_PUBLICATION,
        [EnumMember(Value = DocConstantReasonRejected.ERRONEOUS_DATA)]
        ERRONEOUS_DATA,
        [EnumMember(Value = DocConstantReasonRejected.FAILED_JOURNAL_FILTER)]
        FAILED_JOURNAL_FILTER,
        [EnumMember(Value = DocConstantReasonRejected.IN_VITRO_STUDY)]
        IN_VITRO_STUDY,
        [EnumMember(Value = DocConstantReasonRejected.MISSING_CHARACTERISTICS)]
        MISSING_CHARACTERISTICS,
        [EnumMember(Value = DocConstantReasonRejected.MISSING_OUTCOMES)]
        MISSING_OUTCOMES,
        [EnumMember(Value = DocConstantReasonRejected.NOT_CLINICAL_STUDY)]
        NOT_CLINICAL_STUDY,
        [EnumMember(Value = DocConstantReasonRejected.NOT_ENGLISH)]
        NOT_ENGLISH,
        [EnumMember(Value = DocConstantReasonRejected.NOT_TREAMENT_STUDY)]
        NOT_TREAMENT_STUDY,
        [EnumMember(Value = DocConstantReasonRejected.OTHER)]
        OTHER,
        [EnumMember(Value = DocConstantReasonRejected.RELEVANT_MISCLASSIFIED_REFERENCE)]
        RELEVANT_MISCLASSIFIED_REFERENCE,
        [EnumMember(Value = DocConstantReasonRejected.STUDY_FITS_PROTOCOL_ADD_LATER)]
        STUDY_FITS_PROTOCOL_ADD_LATER,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_COMPARISON)]
        WRONG_COMPARISON,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_FOLLOWUP)]
        WRONG_FOLLOWUP,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_INTERVENTION)]
        WRONG_INTERVENTION,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_NUMBER_PARTICIPANTS)]
        WRONG_NUMBER_PARTICIPANTS,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_OUTCOME_STRATIFICATION)]
        WRONG_OUTCOME_STRATIFICATION,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_OUTCOMES)]
        WRONG_OUTCOMES,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_POPULATION)]
        WRONG_POPULATION,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_PUBLICATION_DATE_CUTOFF)]
        WRONG_PUBLICATION_DATE_CUTOFF,
        [EnumMember(Value = DocConstantReasonRejected.WRONG_STUDY_DESIGN)]
        WRONG_STUDY_DESIGN
    }
    
	public static partial class EnumExtensions
    {
        public static string ToEnumString(this ReasonRejectedEnm instance)
		{
			switch(instance) 
			{
                case ReasonRejectedEnm.ABSTRACT_INSUFFICIENT_INFORMATION:
                    return DocConstantReasonRejected.ABSTRACT_INSUFFICIENT_INFORMATION;
                case ReasonRejectedEnm.ANIMAL_STUDY:
                    return DocConstantReasonRejected.ANIMAL_STUDY;
                case ReasonRejectedEnm.DOES_NOT_MEET_PROTOCOL:
                    return DocConstantReasonRejected.DOES_NOT_MEET_PROTOCOL;
                case ReasonRejectedEnm.DUPLICATE_PUBLICATION:
                    return DocConstantReasonRejected.DUPLICATE_PUBLICATION;
                case ReasonRejectedEnm.ERRONEOUS_DATA:
                    return DocConstantReasonRejected.ERRONEOUS_DATA;
                case ReasonRejectedEnm.FAILED_JOURNAL_FILTER:
                    return DocConstantReasonRejected.FAILED_JOURNAL_FILTER;
                case ReasonRejectedEnm.IN_VITRO_STUDY:
                    return DocConstantReasonRejected.IN_VITRO_STUDY;
                case ReasonRejectedEnm.MISSING_CHARACTERISTICS:
                    return DocConstantReasonRejected.MISSING_CHARACTERISTICS;
                case ReasonRejectedEnm.MISSING_OUTCOMES:
                    return DocConstantReasonRejected.MISSING_OUTCOMES;
                case ReasonRejectedEnm.NOT_CLINICAL_STUDY:
                    return DocConstantReasonRejected.NOT_CLINICAL_STUDY;
                case ReasonRejectedEnm.NOT_ENGLISH:
                    return DocConstantReasonRejected.NOT_ENGLISH;
                case ReasonRejectedEnm.NOT_TREAMENT_STUDY:
                    return DocConstantReasonRejected.NOT_TREAMENT_STUDY;
                case ReasonRejectedEnm.OTHER:
                    return DocConstantReasonRejected.OTHER;
                case ReasonRejectedEnm.RELEVANT_MISCLASSIFIED_REFERENCE:
                    return DocConstantReasonRejected.RELEVANT_MISCLASSIFIED_REFERENCE;
                case ReasonRejectedEnm.STUDY_FITS_PROTOCOL_ADD_LATER:
                    return DocConstantReasonRejected.STUDY_FITS_PROTOCOL_ADD_LATER;
                case ReasonRejectedEnm.WRONG_COMPARISON:
                    return DocConstantReasonRejected.WRONG_COMPARISON;
                case ReasonRejectedEnm.WRONG_FOLLOWUP:
                    return DocConstantReasonRejected.WRONG_FOLLOWUP;
                case ReasonRejectedEnm.WRONG_INTERVENTION:
                    return DocConstantReasonRejected.WRONG_INTERVENTION;
                case ReasonRejectedEnm.WRONG_NUMBER_PARTICIPANTS:
                    return DocConstantReasonRejected.WRONG_NUMBER_PARTICIPANTS;
                case ReasonRejectedEnm.WRONG_OUTCOME_STRATIFICATION:
                    return DocConstantReasonRejected.WRONG_OUTCOME_STRATIFICATION;
                case ReasonRejectedEnm.WRONG_OUTCOMES:
                    return DocConstantReasonRejected.WRONG_OUTCOMES;
                case ReasonRejectedEnm.WRONG_POPULATION:
                    return DocConstantReasonRejected.WRONG_POPULATION;
                case ReasonRejectedEnm.WRONG_PUBLICATION_DATE_CUTOFF:
                    return DocConstantReasonRejected.WRONG_PUBLICATION_DATE_CUTOFF;
                case ReasonRejectedEnm.WRONG_STUDY_DESIGN:
                    return DocConstantReasonRejected.WRONG_STUDY_DESIGN;
				default:
					return string.Empty;
			}
		}
    }

    public sealed partial class DocConstantReasonRejected : IEquatable<DocConstantReasonRejected>, IEqualityComparer<DocConstantReasonRejected>
    {
        public const string ABSTRACT_INSUFFICIENT_INFORMATION = "Abstract with Insufficient Information";
        public const string ANIMAL_STUDY = "Animal study";
        public const string DOES_NOT_MEET_PROTOCOL = "Does not meet protocol";
        public const string DUPLICATE_PUBLICATION = "Duplicate Publication";
        public const string ERRONEOUS_DATA = "Erroneous Data";
        public const string FAILED_JOURNAL_FILTER = "Failed Journal Filter";
        public const string IN_VITRO_STUDY = "In vitro study";
        public const string MISSING_CHARACTERISTICS = "Missing Characteristic(s)";
        public const string MISSING_OUTCOMES = "Missing Outcome(s)";
        public const string NOT_CLINICAL_STUDY = "Not a Clinical Study";
        public const string NOT_ENGLISH = "Not English";
        public const string NOT_TREAMENT_STUDY = "Not a treatment Study";
        public const string OTHER = "Other";
        public const string RELEVANT_MISCLASSIFIED_REFERENCE = "Relevant misclassified reference";
        public const string STUDY_FITS_PROTOCOL_ADD_LATER = "Study fits protocol, to be possibly added later";
        public const string WRONG_COMPARISON = "Wrong Comparison";
        public const string WRONG_FOLLOWUP = "Wrong Follow-up";
        public const string WRONG_INTERVENTION = "Wrong Intervention";
        public const string WRONG_NUMBER_PARTICIPANTS = "Wrong Number of Participants";
        public const string WRONG_OUTCOME_STRATIFICATION = "Wrong Outcome Stratification";
        public const string WRONG_OUTCOMES = "Wrong Outcome(s)";
        public const string WRONG_POPULATION = "Wrong Population";
        public const string WRONG_PUBLICATION_DATE_CUTOFF = "Wrong Publication Date Cutoff";
        public const string WRONG_STUDY_DESIGN = "Wrong Study Design";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantReasonRejected).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantReasonRejected(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantReasonRejected(string Val) => new DocConstantReasonRejected(Val);

        public static implicit operator string(DocConstantReasonRejected item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable (DocConstantReasonRejected)

        public bool Equals(DocConstantReasonRejected obj) => this == obj;

        public static bool operator ==(DocConstantReasonRejected x, DocConstantReasonRejected y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantReasonRejected x, DocConstantReasonRejected y) => x == y;
        
        public static bool operator !=(DocConstantReasonRejected x, DocConstantReasonRejected y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantReasonRejected))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantReasonRejected) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value.GetHashCode();
				
        public int GetHashCode(DocConstantReasonRejected obj) => obj.GetHashCode();

        #endregion IEquatable
    }
}
