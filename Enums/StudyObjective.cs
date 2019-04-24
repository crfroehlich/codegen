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
    public enum StudyObjectiveEnm
    {
        [EnumMember(Value = DocConstantStudyObjective.OTHERS)]
        OTHERS,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_EFFICACY_OUTCOME)]
        PRIMARY_EFFICACY_OUTCOME,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_ENDPOINT)]
        PRIMARY_ENDPOINT,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_ENDPOINT_OUTCOME)]
        PRIMARY_ENDPOINT_OUTCOME,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_OBJECTIVE)]
        PRIMARY_OBJECTIVE,
        [EnumMember(Value = DocConstantStudyObjective.PRIMARY_SAFETY_OUTCOME)]
        PRIMARY_SAFETY_OUTCOME,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_EFFICACY_OUTCOME)]
        SECONDARY_EFFICACY_OUTCOME,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_ENDPOINT)]
        SECONDARY_ENDPOINT,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_ENDPOINT_OUTCOME)]
        SECONDARY_ENDPOINT_OUTCOME,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_OBJECTIVE)]
        SECONDARY_OBJECTIVE,
        [EnumMember(Value = DocConstantStudyObjective.SECONDARY_SAFETY_OUTCOME)]
        SECONDARY_SAFETY_OUTCOME,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_AIM)]
        STUDY_AIM,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_HYPOTHESIS)]
        STUDY_HYPOTHESIS,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_OBJECTIVE)]
        STUDY_OBJECTIVE,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_PURPOSE)]
        STUDY_PURPOSE,
        [EnumMember(Value = DocConstantStudyObjective.STUDY_QUESTION)]
        STUDY_QUESTION,
        [EnumMember(Value = DocConstantStudyObjective.TERIARY_ENDPOINT)]
        TERIARY_ENDPOINT,
        [EnumMember(Value = DocConstantStudyObjective.TERTIARY_EFFICACY_OUTCOME)]
        TERTIARY_EFFICACY_OUTCOME,
        [EnumMember(Value = DocConstantStudyObjective.TERTIARY_ENDPOINT_OUTCOME)]
        TERTIARY_ENDPOINT_OUTCOME,
        [EnumMember(Value = DocConstantStudyObjective.TERTIARY_OBJECTIVE)]
        TERTIARY_OBJECTIVE,
        [EnumMember(Value = DocConstantStudyObjective.TERTIARY_SAFETY_OUTCOME)]
        TERTIARY_SAFETY_OUTCOME
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyObjectiveEnm instance)
        {
            switch(instance) 
            {
                case StudyObjectiveEnm.OTHERS:
                    return DocConstantStudyObjective.OTHERS;
                case StudyObjectiveEnm.PRIMARY_EFFICACY_OUTCOME:
                    return DocConstantStudyObjective.PRIMARY_EFFICACY_OUTCOME;
                case StudyObjectiveEnm.PRIMARY_ENDPOINT:
                    return DocConstantStudyObjective.PRIMARY_ENDPOINT;
                case StudyObjectiveEnm.PRIMARY_ENDPOINT_OUTCOME:
                    return DocConstantStudyObjective.PRIMARY_ENDPOINT_OUTCOME;
                case StudyObjectiveEnm.PRIMARY_OBJECTIVE:
                    return DocConstantStudyObjective.PRIMARY_OBJECTIVE;
                case StudyObjectiveEnm.PRIMARY_SAFETY_OUTCOME:
                    return DocConstantStudyObjective.PRIMARY_SAFETY_OUTCOME;
                case StudyObjectiveEnm.SECONDARY_EFFICACY_OUTCOME:
                    return DocConstantStudyObjective.SECONDARY_EFFICACY_OUTCOME;
                case StudyObjectiveEnm.SECONDARY_ENDPOINT:
                    return DocConstantStudyObjective.SECONDARY_ENDPOINT;
                case StudyObjectiveEnm.SECONDARY_ENDPOINT_OUTCOME:
                    return DocConstantStudyObjective.SECONDARY_ENDPOINT_OUTCOME;
                case StudyObjectiveEnm.SECONDARY_OBJECTIVE:
                    return DocConstantStudyObjective.SECONDARY_OBJECTIVE;
                case StudyObjectiveEnm.SECONDARY_SAFETY_OUTCOME:
                    return DocConstantStudyObjective.SECONDARY_SAFETY_OUTCOME;
                case StudyObjectiveEnm.STUDY_AIM:
                    return DocConstantStudyObjective.STUDY_AIM;
                case StudyObjectiveEnm.STUDY_HYPOTHESIS:
                    return DocConstantStudyObjective.STUDY_HYPOTHESIS;
                case StudyObjectiveEnm.STUDY_OBJECTIVE:
                    return DocConstantStudyObjective.STUDY_OBJECTIVE;
                case StudyObjectiveEnm.STUDY_PURPOSE:
                    return DocConstantStudyObjective.STUDY_PURPOSE;
                case StudyObjectiveEnm.STUDY_QUESTION:
                    return DocConstantStudyObjective.STUDY_QUESTION;
                case StudyObjectiveEnm.TERIARY_ENDPOINT:
                    return DocConstantStudyObjective.TERIARY_ENDPOINT;
                case StudyObjectiveEnm.TERTIARY_EFFICACY_OUTCOME:
                    return DocConstantStudyObjective.TERTIARY_EFFICACY_OUTCOME;
                case StudyObjectiveEnm.TERTIARY_ENDPOINT_OUTCOME:
                    return DocConstantStudyObjective.TERTIARY_ENDPOINT_OUTCOME;
                case StudyObjectiveEnm.TERTIARY_OBJECTIVE:
                    return DocConstantStudyObjective.TERTIARY_OBJECTIVE;
                case StudyObjectiveEnm.TERTIARY_SAFETY_OUTCOME:
                    return DocConstantStudyObjective.TERTIARY_SAFETY_OUTCOME;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantStudyObjective : IEquatable<DocConstantStudyObjective>, IEqualityComparer<DocConstantStudyObjective>
    {
        public const string OTHERS = "Others";
        public const string PRIMARY_EFFICACY_OUTCOME = "Primary Efficacy Outcome";
        public const string PRIMARY_ENDPOINT = "Primary Endpoint";
        public const string PRIMARY_ENDPOINT_OUTCOME = "Primary Endpoint/Outcome";
        public const string PRIMARY_OBJECTIVE = "Primary Objective";
        public const string PRIMARY_SAFETY_OUTCOME = "Primary Safety Outcome";
        public const string SECONDARY_EFFICACY_OUTCOME = "Secondary Efficacy Outcome";
        public const string SECONDARY_ENDPOINT = "Secondary Endpoint";
        public const string SECONDARY_ENDPOINT_OUTCOME = "Secondary Endpoint/Outcome";
        public const string SECONDARY_OBJECTIVE = "Secondary Objective";
        public const string SECONDARY_SAFETY_OUTCOME = "Secondary Safety Outcome";
        public const string STUDY_AIM = "Study Aim";
        public const string STUDY_HYPOTHESIS = "Study Hypothesis";
        public const string STUDY_OBJECTIVE = "Study Objective";
        public const string STUDY_PURPOSE = "Study Purpose";
        public const string STUDY_QUESTION = "Study Question";
        public const string TERIARY_ENDPOINT = "Tertiary Endpoint";
        public const string TERTIARY_EFFICACY_OUTCOME = "Tertiary Efficacy Outcome";
        public const string TERTIARY_ENDPOINT_OUTCOME = "Tertiary Endpoint/Outcome";
        public const string TERTIARY_OBJECTIVE = "Tertiary Objective";
        public const string TERTIARY_SAFETY_OUTCOME = "Tertiary Safety Outcome";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyObjective).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyObjective(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyObjective(string Val) => new DocConstantStudyObjective(Val);

        public static implicit operator string(DocConstantStudyObjective item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantStudyObjective obj) => this == obj;

        public static bool operator ==(DocConstantStudyObjective x, DocConstantStudyObjective y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyObjective x, DocConstantStudyObjective y) => x == y;
        
        public static bool operator !=(DocConstantStudyObjective x, DocConstantStudyObjective y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyObjective))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyObjective) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyObjective obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
