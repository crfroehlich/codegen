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
    public enum InterventionProviderEnm
    {
        [EnumMember(Value = DocConstantInterventionProvider.ALLIED_HEALTH_CARE_PROVIDER), SCDescript(DocConstantInterventionProvider.ALLIED_HEALTH_CARE_PROVIDER), SSDescript(DocConstantInterventionProvider.ALLIED_HEALTH_CARE_PROVIDER), SCDisplay(Name = DocConstantInterventionProvider.ALLIED_HEALTH_CARE_PROVIDER)]
        ALLIED_HEALTH_CARE_PROVIDER = 1167,
        [EnumMember(Value = DocConstantInterventionProvider.CARE_PROVIDER), SCDescript(DocConstantInterventionProvider.CARE_PROVIDER), SSDescript(DocConstantInterventionProvider.CARE_PROVIDER), SCDisplay(Name = DocConstantInterventionProvider.CARE_PROVIDER)]
        CARE_PROVIDER = 1172,
        [EnumMember(Value = DocConstantInterventionProvider.CLINICIAN), SCDescript(DocConstantInterventionProvider.CLINICIAN), SSDescript(DocConstantInterventionProvider.CLINICIAN), SCDisplay(Name = DocConstantInterventionProvider.CLINICIAN)]
        CLINICIAN = 1177,
        [EnumMember(Value = DocConstantInterventionProvider.DOCTOR), SCDescript(DocConstantInterventionProvider.DOCTOR), SSDescript(DocConstantInterventionProvider.DOCTOR), SCDisplay(Name = DocConstantInterventionProvider.DOCTOR)]
        DOCTOR = 1182,
        [EnumMember(Value = DocConstantInterventionProvider.DOCTORAL_STUDENT), SCDescript(DocConstantInterventionProvider.DOCTORAL_STUDENT), SSDescript(DocConstantInterventionProvider.DOCTORAL_STUDENT), SCDisplay(Name = DocConstantInterventionProvider.DOCTORAL_STUDENT)]
        DOCTORAL_STUDENT = 1187,
        [EnumMember(Value = DocConstantInterventionProvider.FOSTER_PARENT), SCDescript(DocConstantInterventionProvider.FOSTER_PARENT), SSDescript(DocConstantInterventionProvider.FOSTER_PARENT), SCDisplay(Name = DocConstantInterventionProvider.FOSTER_PARENT)]
        FOSTER_PARENT = 1192,
        [EnumMember(Value = DocConstantInterventionProvider.GENERAL_PRACTICIONER), SCDescript(DocConstantInterventionProvider.GENERAL_PRACTICIONER), SSDescript(DocConstantInterventionProvider.GENERAL_PRACTICIONER), SCDisplay(Name = DocConstantInterventionProvider.GENERAL_PRACTICIONER)]
        GENERAL_PRACTICIONER = 1197,
        [EnumMember(Value = DocConstantInterventionProvider.GRADUATE_STUDENT), SCDescript(DocConstantInterventionProvider.GRADUATE_STUDENT), SSDescript(DocConstantInterventionProvider.GRADUATE_STUDENT), SCDisplay(Name = DocConstantInterventionProvider.GRADUATE_STUDENT)]
        GRADUATE_STUDENT = 1202,
        [EnumMember(Value = DocConstantInterventionProvider.MULTIPLE_INDIVIDUALS), SCDescript(DocConstantInterventionProvider.MULTIPLE_INDIVIDUALS), SSDescript(DocConstantInterventionProvider.MULTIPLE_INDIVIDUALS), SCDisplay(Name = DocConstantInterventionProvider.MULTIPLE_INDIVIDUALS)]
        MULTIPLE_INDIVIDUALS = 1207,
        [EnumMember(Value = DocConstantInterventionProvider.N_A), SCDescript(DocConstantInterventionProvider.N_A), SSDescript(DocConstantInterventionProvider.N_A), SCDisplay(Name = DocConstantInterventionProvider.N_A)]
        N_A = 1212,
        [EnumMember(Value = DocConstantInterventionProvider.NR), SCDescript(DocConstantInterventionProvider.NR), SSDescript(DocConstantInterventionProvider.NR), SCDisplay(Name = DocConstantInterventionProvider.NR)]
        NR = 1217,
        [EnumMember(Value = DocConstantInterventionProvider.NURSE), SCDescript(DocConstantInterventionProvider.NURSE), SSDescript(DocConstantInterventionProvider.NURSE), SCDisplay(Name = DocConstantInterventionProvider.NURSE)]
        NURSE = 1222,
        [EnumMember(Value = DocConstantInterventionProvider.PAID_CAREGIVER), SCDescript(DocConstantInterventionProvider.PAID_CAREGIVER), SSDescript(DocConstantInterventionProvider.PAID_CAREGIVER), SCDisplay(Name = DocConstantInterventionProvider.PAID_CAREGIVER)]
        PAID_CAREGIVER = 1227,
        [EnumMember(Value = DocConstantInterventionProvider.PHARMACIST), SCDescript(DocConstantInterventionProvider.PHARMACIST), SSDescript(DocConstantInterventionProvider.PHARMACIST), SCDisplay(Name = DocConstantInterventionProvider.PHARMACIST)]
        PHARMACIST = 1232,
        [EnumMember(Value = DocConstantInterventionProvider.PSYCHIATRIST), SCDescript(DocConstantInterventionProvider.PSYCHIATRIST), SSDescript(DocConstantInterventionProvider.PSYCHIATRIST), SCDisplay(Name = DocConstantInterventionProvider.PSYCHIATRIST)]
        PSYCHIATRIST = 1237,
        [EnumMember(Value = DocConstantInterventionProvider.PSYCHOLOGIST), SCDescript(DocConstantInterventionProvider.PSYCHOLOGIST), SSDescript(DocConstantInterventionProvider.PSYCHOLOGIST), SCDisplay(Name = DocConstantInterventionProvider.PSYCHOLOGIST)]
        PSYCHOLOGIST = 1242,
        [EnumMember(Value = DocConstantInterventionProvider.SELF), SCDescript(DocConstantInterventionProvider.SELF), SSDescript(DocConstantInterventionProvider.SELF), SCDisplay(Name = DocConstantInterventionProvider.SELF)]
        SELF = 1247,
        [EnumMember(Value = DocConstantInterventionProvider.TEACHER), SCDescript(DocConstantInterventionProvider.TEACHER), SSDescript(DocConstantInterventionProvider.TEACHER), SCDisplay(Name = DocConstantInterventionProvider.TEACHER)]
        TEACHER = 1252,
        [EnumMember(Value = DocConstantInterventionProvider.TEAM), SCDescript(DocConstantInterventionProvider.TEAM), SSDescript(DocConstantInterventionProvider.TEAM), SCDisplay(Name = DocConstantInterventionProvider.TEAM)]
        TEAM = 1257,
        [EnumMember(Value = DocConstantInterventionProvider.THERAPIST), SCDescript(DocConstantInterventionProvider.THERAPIST), SSDescript(DocConstantInterventionProvider.THERAPIST), SCDisplay(Name = DocConstantInterventionProvider.THERAPIST)]
        THERAPIST = 1262,
        [EnumMember(Value = DocConstantInterventionProvider.UNPAID_CAREGIVER), SCDescript(DocConstantInterventionProvider.UNPAID_CAREGIVER), SSDescript(DocConstantInterventionProvider.UNPAID_CAREGIVER), SCDisplay(Name = DocConstantInterventionProvider.UNPAID_CAREGIVER)]
        UNPAID_CAREGIVER = 1267
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

        public static string ToEnumString(this InterventionProviderEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
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
        
        public static explicit operator DocConstantInterventionProvider(InterventionProviderEnm Val) => new DocConstantInterventionProvider(Val.ToEnumString());

        public static explicit operator InterventionProviderEnm(DocConstantInterventionProvider item)
        {
            Enum.TryParse<InterventionProviderEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

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
