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
    public enum InterventionProviderEnm
    {
        [EnumMember(Value = DocConstantInterventionProvider.ALLIED_HEALTH_CARE_PROVIDER)]
        ALLIED_HEALTH_CARE_PROVIDER,
        [EnumMember(Value = DocConstantInterventionProvider.CARE_PROVIDER)]
        CARE_PROVIDER,
        [EnumMember(Value = DocConstantInterventionProvider.CLINICIAN)]
        CLINICIAN,
        [EnumMember(Value = DocConstantInterventionProvider.DOCTOR)]
        DOCTOR,
        [EnumMember(Value = DocConstantInterventionProvider.DOCTORAL_STUDENT)]
        DOCTORAL_STUDENT,
        [EnumMember(Value = DocConstantInterventionProvider.FOSTER_PARENT)]
        FOSTER_PARENT,
        [EnumMember(Value = DocConstantInterventionProvider.GENERAL_PRACTICIONER)]
        GENERAL_PRACTICIONER,
        [EnumMember(Value = DocConstantInterventionProvider.GRADUATE_STUDENT)]
        GRADUATE_STUDENT,
        [EnumMember(Value = DocConstantInterventionProvider.MULTIPLE_INDIVIDUALS)]
        MULTIPLE_INDIVIDUALS,
        [EnumMember(Value = DocConstantInterventionProvider.N_A)]
        N_A,
        [EnumMember(Value = DocConstantInterventionProvider.NR)]
        NR,
        [EnumMember(Value = DocConstantInterventionProvider.NURSE)]
        NURSE,
        [EnumMember(Value = DocConstantInterventionProvider.PAID_CAREGIVER)]
        PAID_CAREGIVER,
        [EnumMember(Value = DocConstantInterventionProvider.PHARMACIST)]
        PHARMACIST,
        [EnumMember(Value = DocConstantInterventionProvider.PSYCHIATRIST)]
        PSYCHIATRIST,
        [EnumMember(Value = DocConstantInterventionProvider.PSYCHOLOGIST)]
        PSYCHOLOGIST,
        [EnumMember(Value = DocConstantInterventionProvider.SELF)]
        SELF,
        [EnumMember(Value = DocConstantInterventionProvider.TEACHER)]
        TEACHER,
        [EnumMember(Value = DocConstantInterventionProvider.TEAM)]
        TEAM,
        [EnumMember(Value = DocConstantInterventionProvider.THERAPIST)]
        THERAPIST,
        [EnumMember(Value = DocConstantInterventionProvider.UNPAID_CAREGIVER)]
        UNPAID_CAREGIVER
    }
    
	public static partial class EnumExtensions
    {
        public static string ToEnumString(this InterventionProviderEnm instance)
		{
			switch(instance) 
			{
                case InterventionProviderEnm.ALLIED_HEALTH_CARE_PROVIDER:
                    return DocConstantInterventionProvider.ALLIED_HEALTH_CARE_PROVIDER;
                case InterventionProviderEnm.CARE_PROVIDER:
                    return DocConstantInterventionProvider.CARE_PROVIDER;
                case InterventionProviderEnm.CLINICIAN:
                    return DocConstantInterventionProvider.CLINICIAN;
                case InterventionProviderEnm.DOCTOR:
                    return DocConstantInterventionProvider.DOCTOR;
                case InterventionProviderEnm.DOCTORAL_STUDENT:
                    return DocConstantInterventionProvider.DOCTORAL_STUDENT;
                case InterventionProviderEnm.FOSTER_PARENT:
                    return DocConstantInterventionProvider.FOSTER_PARENT;
                case InterventionProviderEnm.GENERAL_PRACTICIONER:
                    return DocConstantInterventionProvider.GENERAL_PRACTICIONER;
                case InterventionProviderEnm.GRADUATE_STUDENT:
                    return DocConstantInterventionProvider.GRADUATE_STUDENT;
                case InterventionProviderEnm.MULTIPLE_INDIVIDUALS:
                    return DocConstantInterventionProvider.MULTIPLE_INDIVIDUALS;
                case InterventionProviderEnm.N_A:
                    return DocConstantInterventionProvider.N_A;
                case InterventionProviderEnm.NR:
                    return DocConstantInterventionProvider.NR;
                case InterventionProviderEnm.NURSE:
                    return DocConstantInterventionProvider.NURSE;
                case InterventionProviderEnm.PAID_CAREGIVER:
                    return DocConstantInterventionProvider.PAID_CAREGIVER;
                case InterventionProviderEnm.PHARMACIST:
                    return DocConstantInterventionProvider.PHARMACIST;
                case InterventionProviderEnm.PSYCHIATRIST:
                    return DocConstantInterventionProvider.PSYCHIATRIST;
                case InterventionProviderEnm.PSYCHOLOGIST:
                    return DocConstantInterventionProvider.PSYCHOLOGIST;
                case InterventionProviderEnm.SELF:
                    return DocConstantInterventionProvider.SELF;
                case InterventionProviderEnm.TEACHER:
                    return DocConstantInterventionProvider.TEACHER;
                case InterventionProviderEnm.TEAM:
                    return DocConstantInterventionProvider.TEAM;
                case InterventionProviderEnm.THERAPIST:
                    return DocConstantInterventionProvider.THERAPIST;
                case InterventionProviderEnm.UNPAID_CAREGIVER:
                    return DocConstantInterventionProvider.UNPAID_CAREGIVER;
				default:
					return string.Empty;
			}
		}
    }

    public sealed partial class DocConstantInterventionProvider : IEquatable<DocConstantInterventionProvider>, IEqualityComparer<DocConstantInterventionProvider>
    {
        public const string ALLIED_HEALTH_CARE_PROVIDER = "Allied Health Care Provider";
        public const string CARE_PROVIDER = "Care Provider";
        public const string CLINICIAN = "Clinician";
        public const string DOCTOR = "Doctor";
        public const string DOCTORAL_STUDENT = "Doctoral Student";
        public const string FOSTER_PARENT = "Foster Parent";
        public const string GENERAL_PRACTICIONER = "General Practicioner";
        public const string GRADUATE_STUDENT = "Graduate Student";
        public const string MULTIPLE_INDIVIDUALS = "Multiple Individuals";
        public const string N_A = "N/A";
        public const string NR = "NR";
        public const string NURSE = "Nurse";
        public const string PAID_CAREGIVER = "Paid Caregiver";
        public const string PHARMACIST = "Pharmacist";
        public const string PSYCHIATRIST = "Psychiatrist";
        public const string PSYCHOLOGIST = "Psychologist";
        public const string SELF = "Self";
        public const string TEACHER = "Teacher";
        public const string TEAM = "Team";
        public const string THERAPIST = "Therapist";
        public const string UNPAID_CAREGIVER = "Unpaid Caregiver";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantInterventionProvider).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantInterventionProvider(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantInterventionProvider(string Val) => new DocConstantInterventionProvider(Val);

        public static implicit operator string(DocConstantInterventionProvider item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantInterventionProvider obj) => this == obj;

        public static bool operator ==(DocConstantInterventionProvider x, DocConstantInterventionProvider y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantInterventionProvider x, DocConstantInterventionProvider y) => x == y;
        
        public static bool operator !=(DocConstantInterventionProvider x, DocConstantInterventionProvider y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantInterventionProvider))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantInterventionProvider) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
				
        public int GetHashCode(DocConstantInterventionProvider obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
