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
    public enum VariableTypeEnm
    {
        [EnumMember(Value = DocConstantVariableType.APPLIED)]
        APPLIED,
        [EnumMember(Value = DocConstantVariableType.OVERRIDE)]
        OVERRIDE,
        [EnumMember(Value = DocConstantVariableType.TEMPLATE)]
        TEMPLATE
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this VariableTypeEnm instance)
        {
            switch(instance) 
            {
                case VariableTypeEnm.APPLIED:
                    return DocConstantVariableType.APPLIED;
                case VariableTypeEnm.OVERRIDE:
                    return DocConstantVariableType.OVERRIDE;
                case VariableTypeEnm.TEMPLATE:
                    return DocConstantVariableType.TEMPLATE;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantVariableType : IEquatable<DocConstantVariableType>, IEqualityComparer<DocConstantVariableType>
    {
        public const string APPLIED = "Applied";
        public const string OVERRIDE = "Override";
        public const string TEMPLATE = "Template";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantVariableType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantVariableType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantVariableType(string Val) => new DocConstantVariableType(Val);

        public static implicit operator string(DocConstantVariableType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantVariableType obj) => this == obj;

        public static bool operator ==(DocConstantVariableType x, DocConstantVariableType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantVariableType x, DocConstantVariableType y) => x == y;
        
        public static bool operator !=(DocConstantVariableType x, DocConstantVariableType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantVariableType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantVariableType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantVariableType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
