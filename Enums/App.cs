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
    public enum AppEnm
    {
        [EnumMember(Value = DocConstantApp.BAMBOO)]
        BAMBOO,
        [EnumMember(Value = DocConstantApp.BITBUCKET)]
        BITBUCKET,
        [EnumMember(Value = DocConstantApp.CONFLUENCE)]
        CONFLUENCE,
        [EnumMember(Value = DocConstantApp.DOC_CREATE)]
        DOC_CREATE,
        [EnumMember(Value = DocConstantApp.DOC_DASHBOARD)]
        DOC_DASHBOARD,
        [EnumMember(Value = DocConstantApp.DOC_DATA_ADMIN)]
        DOC_DATA_ADMIN,
        [EnumMember(Value = DocConstantApp.DOC_DATA_V1)]
        DOC_DATA_V1,
        [EnumMember(Value = DocConstantApp.DOC_DATA_V2)]
        DOC_DATA_V2,
        [EnumMember(Value = DocConstantApp.DOC_DEVELOPMENT)]
        DOC_DEVELOPMENT,
        [EnumMember(Value = DocConstantApp.DOC_EXTRACT_V1)]
        DOC_EXTRACT_V1,
        [EnumMember(Value = DocConstantApp.DOC_EXTRACT_V2)]
        DOC_EXTRACT_V2,
        [EnumMember(Value = DocConstantApp.DOC_EXTRACT_V3)]
        DOC_EXTRACT_V3,
        [EnumMember(Value = DocConstantApp.DOC_LABEL)]
        DOC_LABEL,
        [EnumMember(Value = DocConstantApp.DOC_LIBRARY_V1)]
        DOC_LIBRARY_V1,
        [EnumMember(Value = DocConstantApp.DOC_LIBRARY_V2)]
        DOC_LIBRARY_V2,
        [EnumMember(Value = DocConstantApp.DOC_NHANES)]
        DOC_NHANES,
        [EnumMember(Value = DocConstantApp.DOC_SEARCH)]
        DOC_SEARCH,
        [EnumMember(Value = DocConstantApp.DOC_TIMELY)]
        DOC_TIMELY,
        [EnumMember(Value = DocConstantApp.DOC_TRACK)]
        DOC_TRACK,
        [EnumMember(Value = DocConstantApp.DRE_ADMIN)]
        DRE_ADMIN,
        [EnumMember(Value = DocConstantApp.GRADE)]
        GRADE,
        [EnumMember(Value = DocConstantApp.GROWTH)]
        GROWTH,
        [EnumMember(Value = DocConstantApp.JIRA)]
        JIRA,
        [EnumMember(Value = DocConstantApp.LAUNCH)]
        LAUNCH,
        [EnumMember(Value = DocConstantApp.LMS)]
        LMS,
        [EnumMember(Value = DocConstantApp.LOGIN)]
        LOGIN,
        [EnumMember(Value = DocConstantApp.MISC)]
        MISC,
        [EnumMember(Value = DocConstantApp.REPORTS)]
        REPORTS
    }
    
    public sealed partial class DocConstantApp
    {
        public const string BAMBOO = "Bamboo";
        public const string BITBUCKET = "Bitbucket";
        public const string CONFLUENCE = "Confluence";
        public const string DOC_CREATE = "DOC Create";
        public const string DOC_DASHBOARD = "DOC Dashboard";
        public const string DOC_DATA_ADMIN = "DOC Data Admin";
        public const string DOC_DATA_V1 = "DOC Data 1.0";
        public const string DOC_DATA_V2 = "DOC Data";
        public const string DOC_DEVELOPMENT = "DOC Development";
        public const string DOC_EXTRACT_V1 = "Doc Extract 1.0";
        public const string DOC_EXTRACT_V2 = "Doc Extract 2.0";
        public const string DOC_EXTRACT_V3 = "Doc Extract 3.0";
        public const string DOC_LABEL = "DOC Label";
        public const string DOC_LIBRARY_V1 = "DOC Library 1.0";
        public const string DOC_LIBRARY_V2 = "DOC Library";
        public const string DOC_NHANES = "DOC NHANES";
        public const string DOC_SEARCH = "DOC Search";
        public const string DOC_TIMELY = "DOC Timely";
        public const string DOC_TRACK = "DOC Track";
        public const string DRE_ADMIN = "DRE Admin";
        public const string GRADE = "GRADE";
        public const string GROWTH = "GROWTH";
        public const string JIRA = "Jira";
        public const string LAUNCH = "Launch";
        public const string LMS = "LMS";
        public const string LOGIN = "Login";
        public const string MISC = "Miscellaneous";
        public const string REPORTS = "Reports";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantApp).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantApp(string ItemName = null)
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
        public static implicit operator DocConstantApp(string Val)
        {
            return new DocConstantApp(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantApp item)
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

        #region IEquatable (DocConstantApp)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantApp obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantApp ft1, DocConstantApp ft2)
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
        public static bool operator !=(DocConstantApp ft1, DocConstantApp ft2)
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
            if(!(obj is DocConstantApp))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantApp) obj;
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

        #endregion IEquatable (DocConstantApp)
    }
}