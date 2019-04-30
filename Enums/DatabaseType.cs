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
    public enum DatabaseTypeEnm
    {
        [EnumMember(Value = DocConstantDatabaseType.ASCO)]
        ASCO = 76351757,
        [EnumMember(Value = DocConstantDatabaseType.CLINICAL_TRIALS_GOV)]
        CLINICAL_TRIALS_GOV = 76351758,
        [EnumMember(Value = DocConstantDatabaseType.COCHRANE)]
        COCHRANE = 76351759,
        [EnumMember(Value = DocConstantDatabaseType.EMBASE)]
        EMBASE = 76351760,
        [EnumMember(Value = DocConstantDatabaseType.IOVS)]
        IOVS = 76351761,
        [EnumMember(Value = DocConstantDatabaseType.MANUAL_ENTRY)]
        MANUAL_ENTRY = 76351762,
        [EnumMember(Value = DocConstantDatabaseType.MEDLINE)]
        MEDLINE = 76351763,
        [EnumMember(Value = DocConstantDatabaseType.NORTHERN_LIGHT)]
        NORTHERN_LIGHT = 76351764
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this DatabaseTypeEnm instance)
        {
            switch(instance) 
            {
                case DatabaseTypeEnm.ASCO:
                    return DocConstantDatabaseType.ASCO;
                case DatabaseTypeEnm.CLINICAL_TRIALS_GOV:
                    return DocConstantDatabaseType.CLINICAL_TRIALS_GOV;
                case DatabaseTypeEnm.COCHRANE:
                    return DocConstantDatabaseType.COCHRANE;
                case DatabaseTypeEnm.EMBASE:
                    return DocConstantDatabaseType.EMBASE;
                case DatabaseTypeEnm.IOVS:
                    return DocConstantDatabaseType.IOVS;
                case DatabaseTypeEnm.MANUAL_ENTRY:
                    return DocConstantDatabaseType.MANUAL_ENTRY;
                case DatabaseTypeEnm.MEDLINE:
                    return DocConstantDatabaseType.MEDLINE;
                case DatabaseTypeEnm.NORTHERN_LIGHT:
                    return DocConstantDatabaseType.NORTHERN_LIGHT;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantDatabaseType : IEquatable<DocConstantDatabaseType>, IEqualityComparer<DocConstantDatabaseType>
    {
        public const string ASCO = "ASCO";
        public const string CLINICAL_TRIALS_GOV = "ClinicalTrials.gov";
        public const string COCHRANE = "Cochrane";
        public const string EMBASE = "Embase";
        public const string IOVS = "IOVS";
        public const string MANUAL_ENTRY = "Manual Entry";
        public const string MEDLINE = "MEDLINE";
        public const string NORTHERN_LIGHT = "Northern Light";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantDatabaseType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantDatabaseType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantDatabaseType(string Val) => new DocConstantDatabaseType(Val);

        public static implicit operator string(DocConstantDatabaseType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantDatabaseType obj) => this == obj;

        public static bool operator ==(DocConstantDatabaseType x, DocConstantDatabaseType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantDatabaseType x, DocConstantDatabaseType y) => x == y;
        
        public static bool operator !=(DocConstantDatabaseType x, DocConstantDatabaseType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantDatabaseType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDatabaseType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantDatabaseType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
