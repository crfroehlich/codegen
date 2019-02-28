//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
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
    public enum InterventionScheduleEnm
    {
        [EnumMember(Value = DocConstantInterventionSchedule.AFTERNOON)]
        AFTERNOON,
        [EnumMember(Value = DocConstantInterventionSchedule.BEDTIME)]
        BEDTIME,
        [EnumMember(Value = DocConstantInterventionSchedule.BREAKFAST)]
        BREAKFAST,
        [EnumMember(Value = DocConstantInterventionSchedule.DAILY)]
        DAILY,
        [EnumMember(Value = DocConstantInterventionSchedule.DINNER)]
        DINNER,
        [EnumMember(Value = DocConstantInterventionSchedule.EVENING)]
        EVENING,
        [EnumMember(Value = DocConstantInterventionSchedule.INTRAOPERATIVE)]
        INTRAOPERATIVE,
        [EnumMember(Value = DocConstantInterventionSchedule.LUNCH)]
        LUNCH,
        [EnumMember(Value = DocConstantInterventionSchedule.MORNING)]
        MORNING,
        [EnumMember(Value = DocConstantInterventionSchedule.PERI_OP)]
        PERI_OP,
        [EnumMember(Value = DocConstantInterventionSchedule.POST_BREAKFAST)]
        POST_BREAKFAST,
        [EnumMember(Value = DocConstantInterventionSchedule.POST_DIAGNOSTIC)]
        POST_DIAGNOSTIC,
        [EnumMember(Value = DocConstantInterventionSchedule.POST_DINNER)]
        POST_DINNER,
        [EnumMember(Value = DocConstantInterventionSchedule.POST_LUNCH)]
        POST_LUNCH,
        [EnumMember(Value = DocConstantInterventionSchedule.POST_PRANDIAL)]
        POST_PRANDIAL,
        [EnumMember(Value = DocConstantInterventionSchedule.PRANDIAL)]
        PRANDIAL,
        [EnumMember(Value = DocConstantInterventionSchedule.PRE_BREAKFAST)]
        PRE_BREAKFAST,
        [EnumMember(Value = DocConstantInterventionSchedule.PRE_DIAGNOSTIC)]
        PRE_DIAGNOSTIC,
        [EnumMember(Value = DocConstantInterventionSchedule.PRE_DINNER)]
        PRE_DINNER,
        [EnumMember(Value = DocConstantInterventionSchedule.PRE_LUNCH)]
        PRE_LUNCH,
        [EnumMember(Value = DocConstantInterventionSchedule.PRE_POST_OP)]
        PRE_POST_OP,
        [EnumMember(Value = DocConstantInterventionSchedule.PRE_PRANDIAL)]
        PRE_PRANDIAL
    }
    
    public sealed partial class DocConstantInterventionSchedule
    {
        public const string AFTERNOON = "Afternoon";
        public const string BEDTIME = "Bedtime";
        public const string BREAKFAST = "Breakfast";
        public const string DAILY = "Daily";
        public const string DINNER = "Dinner";
        public const string EVENING = "Evening";
        public const string INTRAOPERATIVE = "Intraoperative";
        public const string LUNCH = "Lunch";
        public const string MORNING = "Morning";
        public const string PERI_OP = "Peri-op";
        public const string POST_BREAKFAST = "Post-Breakfast";
        public const string POST_DIAGNOSTIC = "Post-Diagnostic";
        public const string POST_DINNER = "Post-Dinner";
        public const string POST_LUNCH = "Post-Lunch";
        public const string POST_PRANDIAL = "Post-Prandial";
        public const string PRANDIAL = "Prandial";
        public const string PRE_BREAKFAST = "Pre-Breakfast";
        public const string PRE_DIAGNOSTIC = "Pre-Diagnostic";
        public const string PRE_DINNER = "Pre-Dinner";
        public const string PRE_LUNCH = "Pre-Lunch";
        public const string PRE_POST_OP = "Pre/Post-op";
        public const string PRE_PRANDIAL = "Pre-Prandial";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantInterventionSchedule).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantInterventionSchedule(string ItemName = null)
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
        public static implicit operator DocConstantInterventionSchedule(string Val)
        {
            return new DocConstantInterventionSchedule(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantInterventionSchedule item)
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

        #region IEquatable (DocConstantInterventionSchedule)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantInterventionSchedule obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantInterventionSchedule ft1, DocConstantInterventionSchedule ft2)
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
        public static bool operator !=(DocConstantInterventionSchedule ft1, DocConstantInterventionSchedule ft2)
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
            if(!(obj is DocConstantInterventionSchedule))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantInterventionSchedule) obj;
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

        #endregion IEquatable (DocConstantInterventionSchedule)
    }
}
