
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
    public enum StudyTypeEnm
    {
        [EnumMember(Value = DocConstantStudyType.CAUSATION_ETIOLOGY)]
        CAUSATION_ETIOLOGY,
        [EnumMember(Value = DocConstantStudyType.DIAGNOSIS)]
        DIAGNOSIS,
        [EnumMember(Value = DocConstantStudyType.HARM)]
        HARM,
        [EnumMember(Value = DocConstantStudyType.MODELING)]
        MODELING,
        [EnumMember(Value = DocConstantStudyType.OTHER)]
        OTHER,
        [EnumMember(Value = DocConstantStudyType.PREVALENCE)]
        PREVALENCE,
        [EnumMember(Value = DocConstantStudyType.PREVENTION_RISK)]
        PREVENTION_RISK,
        [EnumMember(Value = DocConstantStudyType.PROGNOSIS)]
        PROGNOSIS,
        [EnumMember(Value = DocConstantStudyType.THERAPY)]
        THERAPY
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyTypeEnm instance)
        {
            switch(instance) 
            {
                case StudyTypeEnm.CAUSATION_ETIOLOGY:
                    return DocConstantStudyType.CAUSATION_ETIOLOGY;
                case StudyTypeEnm.DIAGNOSIS:
                    return DocConstantStudyType.DIAGNOSIS;
                case StudyTypeEnm.HARM:
                    return DocConstantStudyType.HARM;
                case StudyTypeEnm.MODELING:
                    return DocConstantStudyType.MODELING;
                case StudyTypeEnm.OTHER:
                    return DocConstantStudyType.OTHER;
                case StudyTypeEnm.PREVALENCE:
                    return DocConstantStudyType.PREVALENCE;
                case StudyTypeEnm.PREVENTION_RISK:
                    return DocConstantStudyType.PREVENTION_RISK;
                case StudyTypeEnm.PROGNOSIS:
                    return DocConstantStudyType.PROGNOSIS;
                case StudyTypeEnm.THERAPY:
                    return DocConstantStudyType.THERAPY;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantStudyType : IEquatable<DocConstantStudyType>, IEqualityComparer<DocConstantStudyType>
    {
        public const string CAUSATION_ETIOLOGY = "Causation/Etiology";
        public const string DIAGNOSIS = "Diagnosis";
        public const string HARM = "Harm";
        public const string MODELING = "Modeling";
        public const string OTHER = "Other";
        public const string PREVALENCE = "Prevalence";
        public const string PREVENTION_RISK = "Prevention/Risk";
        public const string PROGNOSIS = "Prognosis";
        public const string THERAPY = "Therapy";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyType(string Val) => new DocConstantStudyType(Val);

        public static implicit operator string(DocConstantStudyType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantStudyType obj) => this == obj;

        public static bool operator ==(DocConstantStudyType x, DocConstantStudyType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyType x, DocConstantStudyType y) => x == y;
        
        public static bool operator !=(DocConstantStudyType x, DocConstantStudyType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
