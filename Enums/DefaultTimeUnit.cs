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
    public enum DefaultTimeUnitEnm
    {
        [EnumMember(Value = DocConstantDefaultTimeUnit.DAYS)]
        DAYS,
        [EnumMember(Value = DocConstantDefaultTimeUnit.HOURS)]
        HOURS,
        [EnumMember(Value = DocConstantDefaultTimeUnit.MINUTES)]
        MINUTES,
        [EnumMember(Value = DocConstantDefaultTimeUnit.SECONDS)]
        SECONDS,
        [EnumMember(Value = DocConstantDefaultTimeUnit.STUDY_SET_DEFAULT)]
        STUDY_SET_DEFAULT,
        [EnumMember(Value = DocConstantDefaultTimeUnit.WEEKS)]
        WEEKS,
        [EnumMember(Value = DocConstantDefaultTimeUnit.YEARS)]
        YEARS
    }
    
    public sealed partial class DocConstantDefaultTimeUnit
    {
        public const string DAYS = "d";
        public const string HOURS = "h";
        public const string MINUTES = "m";
        public const string SECONDS = "s";
        public const string STUDY_SET_DEFAULT = "Study Set Default";
        public const string WEEKS = "wk";
        public const string YEARS = "yr";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantDefaultTimeUnit).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantDefaultTimeUnit(string ItemName = null)
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
        public static implicit operator DocConstantDefaultTimeUnit(string Val)
        {
            return new DocConstantDefaultTimeUnit(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantDefaultTimeUnit item)
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

        #region IEquatable (DocConstantDefaultTimeUnit)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantDefaultTimeUnit obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantDefaultTimeUnit ft1, DocConstantDefaultTimeUnit ft2)
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
        public static bool operator !=(DocConstantDefaultTimeUnit ft1, DocConstantDefaultTimeUnit ft2)
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
            if(!(obj is DocConstantDefaultTimeUnit))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDefaultTimeUnit) obj;
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

        #endregion IEquatable (DocConstantDefaultTimeUnit)
    }
}
