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
    public enum StudyPhaseNamesEnm
    {
        [EnumMember(Value = DocConstantStudyPhaseNames.FOLLOW_UP_PERIOD), SCDescript(DocConstantStudyPhaseNames.FOLLOW_UP_PERIOD), SSDescript(DocConstantStudyPhaseNames.FOLLOW_UP_PERIOD), SCDisplay(Name = DocConstantStudyPhaseNames.FOLLOW_UP_PERIOD)]
        FOLLOW_UP_PERIOD = 3593,
        [EnumMember(Value = DocConstantStudyPhaseNames.NR), SCDescript(DocConstantStudyPhaseNames.NR), SSDescript(DocConstantStudyPhaseNames.NR), SCDisplay(Name = DocConstantStudyPhaseNames.NR)]
        NR = 3598,
        [EnumMember(Value = DocConstantStudyPhaseNames.OBSERVATIONAL_PERIOD), SCDescript(DocConstantStudyPhaseNames.OBSERVATIONAL_PERIOD), SSDescript(DocConstantStudyPhaseNames.OBSERVATIONAL_PERIOD), SCDisplay(Name = DocConstantStudyPhaseNames.OBSERVATIONAL_PERIOD)]
        OBSERVATIONAL_PERIOD = 3603,
        [EnumMember(Value = DocConstantStudyPhaseNames.RUN_IN_PERIOD), SCDescript(DocConstantStudyPhaseNames.RUN_IN_PERIOD), SSDescript(DocConstantStudyPhaseNames.RUN_IN_PERIOD), SCDisplay(Name = DocConstantStudyPhaseNames.RUN_IN_PERIOD)]
        RUN_IN_PERIOD = 3608,
        [EnumMember(Value = DocConstantStudyPhaseNames.SCREENING_PERIOD), SCDescript(DocConstantStudyPhaseNames.SCREENING_PERIOD), SSDescript(DocConstantStudyPhaseNames.SCREENING_PERIOD), SCDisplay(Name = DocConstantStudyPhaseNames.SCREENING_PERIOD)]
        SCREENING_PERIOD = 3613,
        [EnumMember(Value = DocConstantStudyPhaseNames.TITRATION_PERIOD), SCDescript(DocConstantStudyPhaseNames.TITRATION_PERIOD), SSDescript(DocConstantStudyPhaseNames.TITRATION_PERIOD), SCDisplay(Name = DocConstantStudyPhaseNames.TITRATION_PERIOD)]
        TITRATION_PERIOD = 3618,
        [EnumMember(Value = DocConstantStudyPhaseNames.TOTAL_STUDY_LENGTH), SCDescript(DocConstantStudyPhaseNames.TOTAL_STUDY_LENGTH), SSDescript(DocConstantStudyPhaseNames.TOTAL_STUDY_LENGTH), SCDisplay(Name = DocConstantStudyPhaseNames.TOTAL_STUDY_LENGTH)]
        TOTAL_STUDY_LENGTH = 3623,
        [EnumMember(Value = DocConstantStudyPhaseNames.TREATMENT_PERIOD), SCDescript(DocConstantStudyPhaseNames.TREATMENT_PERIOD), SSDescript(DocConstantStudyPhaseNames.TREATMENT_PERIOD), SCDisplay(Name = DocConstantStudyPhaseNames.TREATMENT_PERIOD)]
        TREATMENT_PERIOD = 3628,
        [EnumMember(Value = DocConstantStudyPhaseNames.WASH_OUT_PERIOD), SCDescript(DocConstantStudyPhaseNames.WASH_OUT_PERIOD), SSDescript(DocConstantStudyPhaseNames.WASH_OUT_PERIOD), SCDisplay(Name = DocConstantStudyPhaseNames.WASH_OUT_PERIOD)]
        WASH_OUT_PERIOD = 3633
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyPhaseNamesEnm instance)
        {
            switch(instance)
            {
                case StudyPhaseNamesEnm.FOLLOW_UP_PERIOD:
                    return DocConstantStudyPhaseNames.FOLLOW_UP_PERIOD;
                case StudyPhaseNamesEnm.NR:
                    return DocConstantStudyPhaseNames.NR;
                case StudyPhaseNamesEnm.OBSERVATIONAL_PERIOD:
                    return DocConstantStudyPhaseNames.OBSERVATIONAL_PERIOD;
                case StudyPhaseNamesEnm.RUN_IN_PERIOD:
                    return DocConstantStudyPhaseNames.RUN_IN_PERIOD;
                case StudyPhaseNamesEnm.SCREENING_PERIOD:
                    return DocConstantStudyPhaseNames.SCREENING_PERIOD;
                case StudyPhaseNamesEnm.TITRATION_PERIOD:
                    return DocConstantStudyPhaseNames.TITRATION_PERIOD;
                case StudyPhaseNamesEnm.TOTAL_STUDY_LENGTH:
                    return DocConstantStudyPhaseNames.TOTAL_STUDY_LENGTH;
                case StudyPhaseNamesEnm.TREATMENT_PERIOD:
                    return DocConstantStudyPhaseNames.TREATMENT_PERIOD;
                case StudyPhaseNamesEnm.WASH_OUT_PERIOD:
                    return DocConstantStudyPhaseNames.WASH_OUT_PERIOD;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this StudyPhaseNamesEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantStudyPhaseNames : IEquatable<DocConstantStudyPhaseNames>, IEqualityComparer<DocConstantStudyPhaseNames>
    {
        public const string FOLLOW_UP_PERIOD = "Follow-up Period";
        public const string NR = "NR";
        public const string OBSERVATIONAL_PERIOD = "Observational Period";
        public const string RUN_IN_PERIOD = "Run-in Period";
        public const string SCREENING_PERIOD = "Screening Period";
        public const string TITRATION_PERIOD = "Titration Period";
        public const string TOTAL_STUDY_LENGTH = "Total Study Length";
        public const string TREATMENT_PERIOD = "Treatment Period";
        public const string WASH_OUT_PERIOD = "Wash-Out Period";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyPhaseNames).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyPhaseNames(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyPhaseNames(string Val) => new DocConstantStudyPhaseNames(Val);

        public static implicit operator string(DocConstantStudyPhaseNames item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantStudyPhaseNames(StudyPhaseNamesEnm Val) => new DocConstantStudyPhaseNames(Val.ToEnumString());

        public static explicit operator StudyPhaseNamesEnm(DocConstantStudyPhaseNames item)
        {
            Enum.TryParse<StudyPhaseNamesEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantStudyPhaseNames obj) => this == obj;

        public static bool operator ==(DocConstantStudyPhaseNames x, DocConstantStudyPhaseNames y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyPhaseNames x, DocConstantStudyPhaseNames y) => x == y;
        
        public static bool operator !=(DocConstantStudyPhaseNames x, DocConstantStudyPhaseNames y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyPhaseNames))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyPhaseNames) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyPhaseNames obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
