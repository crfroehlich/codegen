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
    
    public sealed partial class DocConstantStudyObjective
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

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantStudyObjective(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        /// <summary>
        /// Determines if the Constant contains an exact match (case insensitive) for the name
        /// </summary>
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        ///    Implicit cast to Enum
        /// </summary>
        /// <param name="Val">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator DocConstantStudyObjective(string Val)
        {
            return new DocConstantStudyObjective(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantStudyObjective item)
        {
            return item?.Value ?? string.Empty;
        }

        /// <summary>
        ///    Override of ToString
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return Value;
        }

        #endregion Internals

        #region IEquatable (DocConstantStudyObjective)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantStudyObjective obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantStudyObjective ft1, DocConstantStudyObjective ft2)
        {
            //do a string comparison on the fieldtypes
            return string.Equals(Convert.ToString(ft1), Convert.ToString(ft2), StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        ///    != Inequality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(DocConstantStudyObjective ft1, DocConstantStudyObjective ft2)
        {
            return !(ft1 == ft2);
        }

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
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

        /// <summary>
        ///    Get Hash Code
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            var ret = 23;
            const int prime = 37;
            ret = (ret * prime) + Value.GetHashCode();
            ret = (ret * prime) + All.GetHashCode();
            return ret;
        }

        #endregion IEquatable (DocConstantStudyObjective)
    }
}
