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
    public enum ProtocolFilterTypeEnm
    {
        [EnumMember(Value = DocConstantProtocolFilterType.ATTRIBUTE)]
        ATTRIBUTE,
        [EnumMember(Value = DocConstantProtocolFilterType.ATTRIBUTE_LABEL)]
        ATTRIBUTE_LABEL,
        [EnumMember(Value = DocConstantProtocolFilterType.FIRST_CLASS)]
        FIRST_CLASS
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ProtocolFilterTypeEnm instance)
        {
            switch(instance) 
            {
                case ProtocolFilterTypeEnm.ATTRIBUTE:
                    return DocConstantProtocolFilterType.ATTRIBUTE;
                case ProtocolFilterTypeEnm.ATTRIBUTE_LABEL:
                    return DocConstantProtocolFilterType.ATTRIBUTE_LABEL;
                case ProtocolFilterTypeEnm.FIRST_CLASS:
                    return DocConstantProtocolFilterType.FIRST_CLASS;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantProtocolFilterType : IEquatable<DocConstantProtocolFilterType>, IEqualityComparer<DocConstantProtocolFilterType>
    {
        public const string ATTRIBUTE = "Attribute";
        public const string ATTRIBUTE_LABEL = "Attribute Label";
        public const string FIRST_CLASS = "First Class";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantProtocolFilterType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantProtocolFilterType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantProtocolFilterType(string Val) => new DocConstantProtocolFilterType(Val);

        public static implicit operator string(DocConstantProtocolFilterType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantProtocolFilterType obj) => this == obj;

        public static bool operator ==(DocConstantProtocolFilterType x, DocConstantProtocolFilterType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantProtocolFilterType x, DocConstantProtocolFilterType y) => x == y;
        
        public static bool operator !=(DocConstantProtocolFilterType x, DocConstantProtocolFilterType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantProtocolFilterType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantProtocolFilterType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantProtocolFilterType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
