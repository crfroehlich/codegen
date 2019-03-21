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
    public enum OutcomeCategoryEnm
    {
        [EnumMember(Value = DocConstantOutcomeCategory.ADVERSE_EVENT)]
        ADVERSE_EVENT,
        [EnumMember(Value = DocConstantOutcomeCategory.CLINICAL_OUTCOME)]
        CLINICAL_OUTCOME,
        [EnumMember(Value = DocConstantOutcomeCategory.DEMOGRAPHICS)]
        DEMOGRAPHICS,
        [EnumMember(Value = DocConstantOutcomeCategory.LABORATORY_VALUE)]
        LABORATORY_VALUE,
        [EnumMember(Value = DocConstantOutcomeCategory.MEDICAL_HISTORY)]
        MEDICAL_HISTORY,
        [EnumMember(Value = DocConstantOutcomeCategory.OTHER)]
        OTHER,
        [EnumMember(Value = DocConstantOutcomeCategory.SCALES_SCORES)]
        SCALES_SCORES
    }
    
	public static partial class EnumExtensions
    {
        public static string ToEnumString(this OutcomeCategoryEnm instance)
		{
			switch(instance) 
			{
                case OutcomeCategoryEnm.ADVERSE_EVENT:
                    return DocConstantOutcomeCategory.ADVERSE_EVENT;
                case OutcomeCategoryEnm.CLINICAL_OUTCOME:
                    return DocConstantOutcomeCategory.CLINICAL_OUTCOME;
                case OutcomeCategoryEnm.DEMOGRAPHICS:
                    return DocConstantOutcomeCategory.DEMOGRAPHICS;
                case OutcomeCategoryEnm.LABORATORY_VALUE:
                    return DocConstantOutcomeCategory.LABORATORY_VALUE;
                case OutcomeCategoryEnm.MEDICAL_HISTORY:
                    return DocConstantOutcomeCategory.MEDICAL_HISTORY;
                case OutcomeCategoryEnm.OTHER:
                    return DocConstantOutcomeCategory.OTHER;
                case OutcomeCategoryEnm.SCALES_SCORES:
                    return DocConstantOutcomeCategory.SCALES_SCORES;
				default:
					return string.Empty;
			}
		}
    }

    public sealed partial class DocConstantOutcomeCategory : IEquatable<DocConstantOutcomeCategory>, IEqualityComparer<DocConstantOutcomeCategory>
    {
        public const string ADVERSE_EVENT = "Adverse Event";
        public const string CLINICAL_OUTCOME = "Clinical Outcome";
        public const string DEMOGRAPHICS = "Demographics";
        public const string LABORATORY_VALUE = "Laboratory Value";
        public const string MEDICAL_HISTORY = "Medical History";
        public const string OTHER = "Other";
        public const string SCALES_SCORES = "Scales/Scores";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantOutcomeCategory).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantOutcomeCategory(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantOutcomeCategory(string Val) => new DocConstantOutcomeCategory(Val);

        public static implicit operator string(DocConstantOutcomeCategory item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantOutcomeCategory obj) => this == obj;

        public static bool operator ==(DocConstantOutcomeCategory x, DocConstantOutcomeCategory y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantOutcomeCategory x, DocConstantOutcomeCategory y) => x == y;
        
        public static bool operator !=(DocConstantOutcomeCategory x, DocConstantOutcomeCategory y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantOutcomeCategory))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantOutcomeCategory) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
				
        public int GetHashCode(DocConstantOutcomeCategory obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
