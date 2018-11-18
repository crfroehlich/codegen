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
    public enum StudyNGAEnm
    {
        [EnumMember(Value = DocConstantStudyNGA.COMPLETED_FINISHED)]
        COMPLETED_FINISHED,
        [EnumMember(Value = DocConstantStudyNGA.CROSSOVER)]
        CROSSOVER,
        [EnumMember(Value = DocConstantStudyNGA.DRUG_DISCONTINUATION)]
        DRUG_DISCONTINUATION,
        [EnumMember(Value = DocConstantStudyNGA.ENROLLED)]
        ENROLLED,
        [EnumMember(Value = DocConstantStudyNGA.ITT)]
        ITT,
        [EnumMember(Value = DocConstantStudyNGA.MODIFIED_ITT)]
        MODIFIED_ITT,
        [EnumMember(Value = DocConstantStudyNGA.PARTICIPANTS_INITIATED_STUDY)]
        PARTICIPANTS_INITIATED_STUDY,
        [EnumMember(Value = DocConstantStudyNGA.PP)]
        PP,
        [EnumMember(Value = DocConstantStudyNGA.RECRUITED)]
        RECRUITED,
        [EnumMember(Value = DocConstantStudyNGA.SAFETY)]
        SAFETY,
        [EnumMember(Value = DocConstantStudyNGA.SCREENED)]
        SCREENED,
        [EnumMember(Value = DocConstantStudyNGA.STUDY_WITHDRAWALS)]
        STUDY_WITHDRAWALS
    }
    
    public sealed partial class DocConstantStudyNGA
    {
        public const string COMPLETED_FINISHED = "Completed/Finished";
        public const string CROSSOVER = "Crossover";
        public const string DRUG_DISCONTINUATION = "Drug Discontinuation";
        public const string ENROLLED = "Enrolled";
        public const string ITT = "ITT";
        public const string MODIFIED_ITT = "Modified ITT";
        public const string PARTICIPANTS_INITIATED_STUDY = "Participants (initiated study)";
        public const string PP = "PP";
        public const string RECRUITED = "Recruited";
        public const string SAFETY = "Safety";
        public const string SCREENED = "Screened";
        public const string STUDY_WITHDRAWALS = "Study Withdrawals";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyNGA).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantStudyNGA(string ItemName = null)
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
        public static implicit operator DocConstantStudyNGA(string Val)
        {
            return new DocConstantStudyNGA(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantStudyNGA item)
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

        #region IEquatable (DocConstantStudyNGA)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantStudyNGA obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantStudyNGA ft1, DocConstantStudyNGA ft2)
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
        public static bool operator !=(DocConstantStudyNGA ft1, DocConstantStudyNGA ft2)
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
            if(!(obj is DocConstantStudyNGA))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyNGA) obj;
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

        #endregion IEquatable (DocConstantStudyNGA)
    }
}