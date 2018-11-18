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
    public enum AssociationMeasureEnm
    {
        [EnumMember(Value = DocConstantAssociationMeasure.COHENS_D)]
        COHENS_D,
        [EnumMember(Value = DocConstantAssociationMeasure.HAZARD_RATIO)]
        HAZARD_RATIO,
        [EnumMember(Value = DocConstantAssociationMeasure.HEDGES_G)]
        HEDGES_G,
        [EnumMember(Value = DocConstantAssociationMeasure.MEAN_DIFFERENCE)]
        MEAN_DIFFERENCE,
        [EnumMember(Value = DocConstantAssociationMeasure.ODDS_RATIO)]
        ODDS_RATIO,
        [EnumMember(Value = DocConstantAssociationMeasure.RATE_RATIO)]
        RATE_RATIO,
        [EnumMember(Value = DocConstantAssociationMeasure.RAW_DIFFERENCE)]
        RAW_DIFFERENCE,
        [EnumMember(Value = DocConstantAssociationMeasure.RELATIVE_RISK_INCREASE)]
        RELATIVE_RISK_INCREASE,
        [EnumMember(Value = DocConstantAssociationMeasure.RELATIVE_RISK_REDUCTION)]
        RELATIVE_RISK_REDUCTION,
        [EnumMember(Value = DocConstantAssociationMeasure.RISK_DIFFERENCE)]
        RISK_DIFFERENCE,
        [EnumMember(Value = DocConstantAssociationMeasure.RISK_RATIO)]
        RISK_RATIO,
        [EnumMember(Value = DocConstantAssociationMeasure.RISK_RATIO_RELATIVE_RISK)]
        RISK_RATIO_RELATIVE_RISK
    }
    
    public sealed partial class DocConstantAssociationMeasure
    {
        public const string COHENS_D = "Cohen's D";
        public const string HAZARD_RATIO = "Hazard Ratio";
        public const string HEDGES_G = "Hedges G";
        public const string MEAN_DIFFERENCE = "Mean Difference";
        public const string ODDS_RATIO = "Odds Ratio";
        public const string RATE_RATIO = "Rate Ratio";
        public const string RAW_DIFFERENCE = "Raw Difference";
        public const string RELATIVE_RISK_INCREASE = "Relative Risk Increase";
        public const string RELATIVE_RISK_REDUCTION = "Relative Risk Reduction";
        public const string RISK_DIFFERENCE = "Risk Difference";
        public const string RISK_RATIO = "Risk Ratio";
        public const string RISK_RATIO_RELATIVE_RISK = "Risk Ratio/Relative Risk";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantAssociationMeasure).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantAssociationMeasure(string ItemName = null)
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
        public static implicit operator DocConstantAssociationMeasure(string Val)
        {
            return new DocConstantAssociationMeasure(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantAssociationMeasure item)
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

        #region IEquatable (DocConstantAssociationMeasure)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantAssociationMeasure obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantAssociationMeasure ft1, DocConstantAssociationMeasure ft2)
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
        public static bool operator !=(DocConstantAssociationMeasure ft1, DocConstantAssociationMeasure ft2)
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
            if(!(obj is DocConstantAssociationMeasure))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantAssociationMeasure) obj;
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

        #endregion IEquatable (DocConstantAssociationMeasure)
    }
}