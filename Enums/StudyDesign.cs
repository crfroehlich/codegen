﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by a CodeSmith Generator project.
//
//    Changes to this file may cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudyDesignEnm
    {
        [EnumMember(Value = DocConstantStudyDesign.BEFORE_AND_AFTER_TRIAL)]
        BEFORE_AND_AFTER_TRIAL,
        [EnumMember(Value = DocConstantStudyDesign.CASE_CONTROL)]
        CASE_CONTROL,
        [EnumMember(Value = DocConstantStudyDesign.CASE_REPORT)]
        CASE_REPORT,
        [EnumMember(Value = DocConstantStudyDesign.CASE_SERIES)]
        CASE_SERIES,
        [EnumMember(Value = DocConstantStudyDesign.CLUSTER_RCT)]
        CLUSTER_RCT,
        [EnumMember(Value = DocConstantStudyDesign.COHORT_STUDY)]
        COHORT_STUDY,
        [EnumMember(Value = DocConstantStudyDesign.CONTROLLED_BEFORE_AND_AFTER_TRIAL)]
        CONTROLLED_BEFORE_AND_AFTER_TRIAL,
        [EnumMember(Value = DocConstantStudyDesign.CROSS_SECTIONAL_STUDY)]
        CROSS_SECTIONAL_STUDY,
        [EnumMember(Value = DocConstantStudyDesign.EXPANDED_ACCESS_PROGRAM)]
        EXPANDED_ACCESS_PROGRAM,
        [EnumMember(Value = DocConstantStudyDesign.FOLLOW_UP_EXTENSION)]
        FOLLOW_UP_EXTENSION,
        [EnumMember(Value = DocConstantStudyDesign.LITERATURE_REVIEW)]
        LITERATURE_REVIEW,
        [EnumMember(Value = DocConstantStudyDesign.NON_COMPARATIVE_OTHER)]
        NON_COMPARATIVE_OTHER,
        [EnumMember(Value = DocConstantStudyDesign.NON_CONTROLLED_CLINICAL_TRIAL)]
        NON_CONTROLLED_CLINICAL_TRIAL,
        [EnumMember(Value = DocConstantStudyDesign.NON_RANDOMIZED_CONTROLLED_TRIAL)]
        NON_RANDOMIZED_CONTROLLED_TRIAL,
        [EnumMember(Value = DocConstantStudyDesign.NON_RANDOMIZED_CROSSOVER)]
        NON_RANDOMIZED_CROSSOVER,
        [EnumMember(Value = DocConstantStudyDesign.OBSERVATIONAL_NON_COMPARATIVE_STUDY)]
        OBSERVATIONAL_NON_COMPARATIVE_STUDY,
        [EnumMember(Value = DocConstantStudyDesign.POOLED_ANALYSIS)]
        POOLED_ANALYSIS,
        [EnumMember(Value = DocConstantStudyDesign.POSTHOC_ANALYSIS)]
        POSTHOC_ANALYSIS,
        [EnumMember(Value = DocConstantStudyDesign.PROSPECTIVE_COHORT_STUDY)]
        PROSPECTIVE_COHORT_STUDY,
        [EnumMember(Value = DocConstantStudyDesign.QUALITATIVE_RESEARCH)]
        QUALITATIVE_RESEARCH,
        [EnumMember(Value = DocConstantStudyDesign.RANDOMIZED_CONTROLLED_TRIAL)]
        RANDOMIZED_CONTROLLED_TRIAL,
        [EnumMember(Value = DocConstantStudyDesign.RANDOMIZED_CROSSOVER)]
        RANDOMIZED_CROSSOVER,
        [EnumMember(Value = DocConstantStudyDesign.RANDOMIZED_NON_CONTROLLED_TRIAL)]
        RANDOMIZED_NON_CONTROLLED_TRIAL,
        [EnumMember(Value = DocConstantStudyDesign.RETROSPECTIVE_COHORT_STUDY)]
        RETROSPECTIVE_COHORT_STUDY,
        [EnumMember(Value = DocConstantStudyDesign.SUB_GROUP_ANALYSIS)]
        SUB_GROUP_ANALYSIS
    }
    
    public sealed partial class DocConstantStudyDesign
    {
        public const string BEFORE_AND_AFTER_TRIAL = "Before and After Trial";
        public const string CASE_CONTROL = "Case Control";
        public const string CASE_REPORT = "Case Report";
        public const string CASE_SERIES = "Case Series";
        public const string CLUSTER_RCT = "Cluster RCT";
        public const string COHORT_STUDY = "Cohort Study";
        public const string CONTROLLED_BEFORE_AND_AFTER_TRIAL = "Controlled Before and After Trial";
        public const string CROSS_SECTIONAL_STUDY = "Cross Sectional Study";
        public const string EXPANDED_ACCESS_PROGRAM = "Expanded Access Program";
        public const string FOLLOW_UP_EXTENSION = "Follow-up/Extension";
        public const string LITERATURE_REVIEW = "Literature Review";
        public const string NON_COMPARATIVE_OTHER = "Non-Comparative, Other";
        public const string NON_CONTROLLED_CLINICAL_TRIAL = "Non-Controlled Clinical Trial";
        public const string NON_RANDOMIZED_CONTROLLED_TRIAL = "Non-Randomized Controlled Trial";
        public const string NON_RANDOMIZED_CROSSOVER = "Non-Randomized Crossover";
        public const string OBSERVATIONAL_NON_COMPARATIVE_STUDY = "Observational Non-Comparative Study";
        public const string POOLED_ANALYSIS = "Pooled Analysis";
        public const string POSTHOC_ANALYSIS = "Posthoc Analysis";
        public const string PROSPECTIVE_COHORT_STUDY = "Prospective Cohort Study";
        public const string QUALITATIVE_RESEARCH = "Qualitative Research";
        public const string RANDOMIZED_CONTROLLED_TRIAL = "Randomized Controlled Trial";
        public const string RANDOMIZED_CROSSOVER = "Randomized Crossover";
        public const string RANDOMIZED_NON_CONTROLLED_TRIAL = "Randomized Non-Controlled Trial";
        public const string RETROSPECTIVE_COHORT_STUDY = "Retrospective Cohort Study";
        public const string SUB_GROUP_ANALYSIS = "Sub-Group Analysis";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyDesign).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantStudyDesign(string ItemName = null)
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
        public static implicit operator DocConstantStudyDesign(string Val)
        {
            return new DocConstantStudyDesign(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantStudyDesign item)
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

        #region IEquatable (DocConstantStudyDesign)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantStudyDesign obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantStudyDesign ft1, DocConstantStudyDesign ft2)
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
        public static bool operator !=(DocConstantStudyDesign ft1, DocConstantStudyDesign ft2)
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
            if(!(obj is DocConstantStudyDesign))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyDesign) obj;
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

        #endregion IEquatable (DocConstantStudyDesign)
    }
}