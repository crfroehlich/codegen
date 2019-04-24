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
    public enum AttributeCategoryEnm
    {
        [EnumMember(Value = DocConstantAttributeCategory.ADVERSE_EVENT)]
        ADVERSE_EVENT,
        [EnumMember(Value = DocConstantAttributeCategory.CLINICAL_OUTCOME)]
        CLINICAL_OUTCOME,
        [EnumMember(Value = DocConstantAttributeCategory.COST_UTILIZATION)]
        COST_UTILIZATION,
        [EnumMember(Value = DocConstantAttributeCategory.DEMOGRAPHICS)]
        DEMOGRAPHICS,
        [EnumMember(Value = DocConstantAttributeCategory.LABORATORY_VALUE_DIAGNOSTIC)]
        LABORATORY_VALUE_DIAGNOSTIC,
        [EnumMember(Value = DocConstantAttributeCategory.MEDICAL_HISTORY)]
        MEDICAL_HISTORY,
        [EnumMember(Value = DocConstantAttributeCategory.MEDICATIONS)]
        MEDICATIONS,
        [EnumMember(Value = DocConstantAttributeCategory.MISCELLANEOUS)]
        MISCELLANEOUS,
        [EnumMember(Value = DocConstantAttributeCategory.MORTALITY)]
        MORTALITY,
        [EnumMember(Value = DocConstantAttributeCategory.SCALES_SCORES)]
        SCALES_SCORES,
        [EnumMember(Value = DocConstantAttributeCategory.SOCIAL_HISTORY)]
        SOCIAL_HISTORY,
        [EnumMember(Value = DocConstantAttributeCategory.WITHDRAWAL_DRUG_DISCONTINUATION)]
        WITHDRAWAL_DRUG_DISCONTINUATION
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this AttributeCategoryEnm instance)
        {
            switch(instance) 
            {
                case AttributeCategoryEnm.ADVERSE_EVENT:
                    return DocConstantAttributeCategory.ADVERSE_EVENT;
                case AttributeCategoryEnm.CLINICAL_OUTCOME:
                    return DocConstantAttributeCategory.CLINICAL_OUTCOME;
                case AttributeCategoryEnm.COST_UTILIZATION:
                    return DocConstantAttributeCategory.COST_UTILIZATION;
                case AttributeCategoryEnm.DEMOGRAPHICS:
                    return DocConstantAttributeCategory.DEMOGRAPHICS;
                case AttributeCategoryEnm.LABORATORY_VALUE_DIAGNOSTIC:
                    return DocConstantAttributeCategory.LABORATORY_VALUE_DIAGNOSTIC;
                case AttributeCategoryEnm.MEDICAL_HISTORY:
                    return DocConstantAttributeCategory.MEDICAL_HISTORY;
                case AttributeCategoryEnm.MEDICATIONS:
                    return DocConstantAttributeCategory.MEDICATIONS;
                case AttributeCategoryEnm.MISCELLANEOUS:
                    return DocConstantAttributeCategory.MISCELLANEOUS;
                case AttributeCategoryEnm.MORTALITY:
                    return DocConstantAttributeCategory.MORTALITY;
                case AttributeCategoryEnm.SCALES_SCORES:
                    return DocConstantAttributeCategory.SCALES_SCORES;
                case AttributeCategoryEnm.SOCIAL_HISTORY:
                    return DocConstantAttributeCategory.SOCIAL_HISTORY;
                case AttributeCategoryEnm.WITHDRAWAL_DRUG_DISCONTINUATION:
                    return DocConstantAttributeCategory.WITHDRAWAL_DRUG_DISCONTINUATION;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantAttributeCategory : IEquatable<DocConstantAttributeCategory>, IEqualityComparer<DocConstantAttributeCategory>
    {
        public const string ADVERSE_EVENT = "Adverse Event";
        public const string CLINICAL_OUTCOME = "Clinical Outcome";
        public const string COST_UTILIZATION = "Cost/Utilization";
        public const string DEMOGRAPHICS = "Demographics";
        public const string LABORATORY_VALUE_DIAGNOSTIC = "Laboratory Value/Diagnostic";
        public const string MEDICAL_HISTORY = "Medical History";
        public const string MEDICATIONS = "Medications";
        public const string MISCELLANEOUS = "Miscellaneous";
        public const string MORTALITY = "Mortality";
        public const string SCALES_SCORES = "Scales/Scores";
        public const string SOCIAL_HISTORY = "Social History";
        public const string WITHDRAWAL_DRUG_DISCONTINUATION = "Withdrawal/Drug Discontinuation";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantAttributeCategory).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantAttributeCategory(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantAttributeCategory(string Val) => new DocConstantAttributeCategory(Val);

        public static implicit operator string(DocConstantAttributeCategory item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantAttributeCategory obj) => this == obj;

        public static bool operator ==(DocConstantAttributeCategory x, DocConstantAttributeCategory y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantAttributeCategory x, DocConstantAttributeCategory y) => x == y;
        
        public static bool operator !=(DocConstantAttributeCategory x, DocConstantAttributeCategory y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantAttributeCategory))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantAttributeCategory) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantAttributeCategory obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
