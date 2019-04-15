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
    public enum BroadcastTypeEnm
    {
        [EnumMember(Value = DocConstantBroadcastType.CHANGE_LOG)]
        CHANGE_LOG,
        [EnumMember(Value = DocConstantBroadcastType.SCOPE_SPECIFIC)]
        SCOPE_SPECIFIC,
        [EnumMember(Value = DocConstantBroadcastType.SYSTEM_ALERT)]
        SYSTEM_ALERT,
        [EnumMember(Value = DocConstantBroadcastType.TERMS_OF_SERVICE)]
        TERMS_OF_SERVICE
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this BroadcastTypeEnm instance)
        {
            switch(instance) 
            {
                case BroadcastTypeEnm.CHANGE_LOG:
                    return DocConstantBroadcastType.CHANGE_LOG;
                case BroadcastTypeEnm.SCOPE_SPECIFIC:
                    return DocConstantBroadcastType.SCOPE_SPECIFIC;
                case BroadcastTypeEnm.SYSTEM_ALERT:
                    return DocConstantBroadcastType.SYSTEM_ALERT;
                case BroadcastTypeEnm.TERMS_OF_SERVICE:
                    return DocConstantBroadcastType.TERMS_OF_SERVICE;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantBroadcastType : IEquatable<DocConstantBroadcastType>, IEqualityComparer<DocConstantBroadcastType>
    {
        public const string CHANGE_LOG = "Change Log";
        public const string SCOPE_SPECIFIC = "Scope Specific";
        public const string SYSTEM_ALERT = "System Alert";
        public const string TERMS_OF_SERVICE = "Terms of Service";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantBroadcastType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantBroadcastType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantBroadcastType(string Val) => new DocConstantBroadcastType(Val);

        public static implicit operator string(DocConstantBroadcastType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantBroadcastType obj) => this == obj;

        public static bool operator ==(DocConstantBroadcastType x, DocConstantBroadcastType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantBroadcastType x, DocConstantBroadcastType y) => x == y;
        
        public static bool operator !=(DocConstantBroadcastType x, DocConstantBroadcastType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantBroadcastType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantBroadcastType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantBroadcastType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
