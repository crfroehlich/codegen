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
    public enum UnitTypeEnm
    {
        [EnumMember(Value = DocConstantUnitType.AMOUNT)]
        AMOUNT,
        [EnumMember(Value = DocConstantUnitType.AREA)]
        AREA,
        [EnumMember(Value = DocConstantUnitType.CONCENTRATION)]
        CONCENTRATION,
        [EnumMember(Value = DocConstantUnitType.CONCENTRATION_MOLAR)]
        CONCENTRATION_MOLAR,
        [EnumMember(Value = DocConstantUnitType.CONCENTRATION_SOLUTION)]
        CONCENTRATION_SOLUTION,
        [EnumMember(Value = DocConstantUnitType.LABEL)]
        LABEL,
        [EnumMember(Value = DocConstantUnitType.LENGTH)]
        LENGTH,
        [EnumMember(Value = DocConstantUnitType.MASS)]
        MASS,
        [EnumMember(Value = DocConstantUnitType.MOLES)]
        MOLES,
        [EnumMember(Value = DocConstantUnitType.NON_TIME)]
        NON_TIME,
        [EnumMember(Value = DocConstantUnitType.NON_UNIT)]
        NON_UNIT,
        [EnumMember(Value = DocConstantUnitType.RADIATION)]
        RADIATION,
        [EnumMember(Value = DocConstantUnitType.TIME)]
        TIME,
        [EnumMember(Value = DocConstantUnitType.VOLUME)]
        VOLUME,
        [EnumMember(Value = DocConstantUnitType.WEIGHT)]
        WEIGHT
    }
    
    public sealed partial class DocConstantUnitType
    {
        public const string AMOUNT = "Amount";
        public const string AREA = "Area";
        public const string CONCENTRATION = "Concentration";
        public const string CONCENTRATION_MOLAR = "Concentration Molar";
        public const string CONCENTRATION_SOLUTION = "Concentration Solution";
        public const string LABEL = "Label";
        public const string LENGTH = "Length";
        public const string MASS = "Mass";
        public const string MOLES = "Moles";
        public const string NON_TIME = "NonTime";
        public const string NON_UNIT = "NonUnit";
        public const string RADIATION = "Radiation";
        public const string TIME = "Time";
        public const string VOLUME = "Volume";
        public const string WEIGHT = "Weight";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantUnitType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantUnitType(string ItemName = null)
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
        public static implicit operator DocConstantUnitType(string Val)
        {
            return new DocConstantUnitType(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantUnitType item)
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

        #region IEquatable (DocConstantUnitType)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantUnitType obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantUnitType ft1, DocConstantUnitType ft2)
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
        public static bool operator !=(DocConstantUnitType ft1, DocConstantUnitType ft2)
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
            if(!(obj is DocConstantUnitType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantUnitType) obj;
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

        #endregion IEquatable (DocConstantUnitType)
    }
}