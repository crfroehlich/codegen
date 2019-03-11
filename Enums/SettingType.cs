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
    public enum SettingTypeEnm
    {
        [EnumMember(Value = DocConstantSettingType.CRIMINAL_JUSTICE_SYSTEM)]
        CRIMINAL_JUSTICE_SYSTEM,
        [EnumMember(Value = DocConstantSettingType.EDUCATION_SYSTEM)]
        EDUCATION_SYSTEM,
        [EnumMember(Value = DocConstantSettingType.HOME)]
        HOME,
        [EnumMember(Value = DocConstantSettingType.INPATIENT)]
        INPATIENT,
        [EnumMember(Value = DocConstantSettingType.MIXED)]
        MIXED,
        [EnumMember(Value = DocConstantSettingType.NA)]
        NA,
        [EnumMember(Value = DocConstantSettingType.NR)]
        NR,
        [EnumMember(Value = DocConstantSettingType.OTHER)]
        OTHER,
        [EnumMember(Value = DocConstantSettingType.OUTPATIENT)]
        OUTPATIENT,
        [EnumMember(Value = DocConstantSettingType.SURVEY)]
        SURVEY,
        [EnumMember(Value = DocConstantSettingType.UNCLEAR)]
        UNCLEAR
    }
    
    public sealed partial class DocConstantSettingType
    {
        public const string CRIMINAL_JUSTICE_SYSTEM = "Criminal Justice System";
        public const string EDUCATION_SYSTEM = "Education System";
        public const string HOME = "Home";
        public const string INPATIENT = "Inpatient";
        public const string MIXED = "Mixed";
        public const string NA = "N/A";
        public const string NR = "NR";
        public const string OTHER = "Other";
        public const string OUTPATIENT = "Outpatient";
        public const string SURVEY = "Survey";
        public const string UNCLEAR = "Unclear";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantSettingType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantSettingType(string ItemName = null)
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
        public static implicit operator DocConstantSettingType(string Val)
        {
            return new DocConstantSettingType(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantSettingType item)
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

        #region IEquatable (DocConstantSettingType)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantSettingType obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantSettingType ft1, DocConstantSettingType ft2)
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
        public static bool operator !=(DocConstantSettingType ft1, DocConstantSettingType ft2)
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
            if(!(obj is DocConstantSettingType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantSettingType) obj;
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

        #endregion IEquatable (DocConstantSettingType)
    }
}