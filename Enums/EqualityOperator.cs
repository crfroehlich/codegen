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
    public enum EqualityOperatorEnm
    {
        [EnumMember(Value = DocConstantEqualityOperator.APPROXIMATELY_EQUALS)]
        APPROXIMATELY_EQUALS = 777,
        [EnumMember(Value = DocConstantEqualityOperator.APPROXIMATELY_GREATER_THAN)]
        APPROXIMATELY_GREATER_THAN = 782,
        [EnumMember(Value = DocConstantEqualityOperator.APPROXIMATELY_GREATER_THAN_OR_EQUALS)]
        APPROXIMATELY_GREATER_THAN_OR_EQUALS = 787,
        [EnumMember(Value = DocConstantEqualityOperator.APPROXIMATELY_LESS_THAN)]
        APPROXIMATELY_LESS_THAN = 792,
        [EnumMember(Value = DocConstantEqualityOperator.APPROXIMATELY_LESS_THAN_OR_EQUALS)]
        APPROXIMATELY_LESS_THAN_OR_EQUALS = 797,
        [EnumMember(Value = DocConstantEqualityOperator.EQUALS)]
        EQUALS = 802,
        [EnumMember(Value = DocConstantEqualityOperator.GREATER_THAN)]
        GREATER_THAN = 807,
        [EnumMember(Value = DocConstantEqualityOperator.GREATER_THAN_OR_EQUALS)]
        GREATER_THAN_OR_EQUALS = 812,
        [EnumMember(Value = DocConstantEqualityOperator.GREATER_THAN_OR_EQUALS_ALIAS)]
        GREATER_THAN_OR_EQUALS_ALIAS = 817,
        [EnumMember(Value = DocConstantEqualityOperator.LESS_THAN)]
        LESS_THAN = 822,
        [EnumMember(Value = DocConstantEqualityOperator.LESS_THAN_OR_EQUALS)]
        LESS_THAN_OR_EQUALS = 827,
        [EnumMember(Value = DocConstantEqualityOperator.LESS_THAN_OR_EQUALS_ALIAS)]
        LESS_THAN_OR_EQUALS_ALIAS = 832,
        [EnumMember(Value = DocConstantEqualityOperator.NOT_EQUALS)]
        NOT_EQUALS = 837
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this EqualityOperatorEnm instance)
        {
            switch(instance) 
            {
                case EqualityOperatorEnm.APPROXIMATELY_EQUALS:
                    return DocConstantEqualityOperator.APPROXIMATELY_EQUALS;
                case EqualityOperatorEnm.APPROXIMATELY_GREATER_THAN:
                    return DocConstantEqualityOperator.APPROXIMATELY_GREATER_THAN;
                case EqualityOperatorEnm.APPROXIMATELY_GREATER_THAN_OR_EQUALS:
                    return DocConstantEqualityOperator.APPROXIMATELY_GREATER_THAN_OR_EQUALS;
                case EqualityOperatorEnm.APPROXIMATELY_LESS_THAN:
                    return DocConstantEqualityOperator.APPROXIMATELY_LESS_THAN;
                case EqualityOperatorEnm.APPROXIMATELY_LESS_THAN_OR_EQUALS:
                    return DocConstantEqualityOperator.APPROXIMATELY_LESS_THAN_OR_EQUALS;
                case EqualityOperatorEnm.EQUALS:
                    return DocConstantEqualityOperator.EQUALS;
                case EqualityOperatorEnm.GREATER_THAN:
                    return DocConstantEqualityOperator.GREATER_THAN;
                case EqualityOperatorEnm.GREATER_THAN_OR_EQUALS:
                    return DocConstantEqualityOperator.GREATER_THAN_OR_EQUALS;
                case EqualityOperatorEnm.GREATER_THAN_OR_EQUALS_ALIAS:
                    return DocConstantEqualityOperator.GREATER_THAN_OR_EQUALS_ALIAS;
                case EqualityOperatorEnm.LESS_THAN:
                    return DocConstantEqualityOperator.LESS_THAN;
                case EqualityOperatorEnm.LESS_THAN_OR_EQUALS:
                    return DocConstantEqualityOperator.LESS_THAN_OR_EQUALS;
                case EqualityOperatorEnm.LESS_THAN_OR_EQUALS_ALIAS:
                    return DocConstantEqualityOperator.LESS_THAN_OR_EQUALS_ALIAS;
                case EqualityOperatorEnm.NOT_EQUALS:
                    return DocConstantEqualityOperator.NOT_EQUALS;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantEqualityOperator : IEquatable<DocConstantEqualityOperator>, IEqualityComparer<DocConstantEqualityOperator>
    {
        public const string APPROXIMATELY_EQUALS = "~=";
        public const string APPROXIMATELY_GREATER_THAN = "~>";
        public const string APPROXIMATELY_GREATER_THAN_OR_EQUALS = "~>=";
        public const string APPROXIMATELY_LESS_THAN = "~<";
        public const string APPROXIMATELY_LESS_THAN_OR_EQUALS = "~<=";
        public const string EQUALS = "=";
        public const string GREATER_THAN = ">";
        public const string GREATER_THAN_OR_EQUALS = ">=";
        public const string GREATER_THAN_OR_EQUALS_ALIAS = "≥";
        public const string LESS_THAN = "<";
        public const string LESS_THAN_OR_EQUALS = "<=";
        public const string LESS_THAN_OR_EQUALS_ALIAS = "≤";
        public const string NOT_EQUALS = "!=";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantEqualityOperator).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantEqualityOperator(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantEqualityOperator(string Val) => new DocConstantEqualityOperator(Val);

        public static implicit operator string(DocConstantEqualityOperator item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantEqualityOperator obj) => this == obj;

        public static bool operator ==(DocConstantEqualityOperator x, DocConstantEqualityOperator y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantEqualityOperator x, DocConstantEqualityOperator y) => x == y;
        
        public static bool operator !=(DocConstantEqualityOperator x, DocConstantEqualityOperator y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantEqualityOperator))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantEqualityOperator) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantEqualityOperator obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
