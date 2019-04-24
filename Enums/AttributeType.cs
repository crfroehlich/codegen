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
    public enum AttributeTypeEnm
    {
        [EnumMember(Value = DocConstantAttributeType.CHANGE)]
        CHANGE,
        [EnumMember(Value = DocConstantAttributeType.DURATION)]
        DURATION,
        [EnumMember(Value = DocConstantAttributeType.NOT_IN_STUDY)]
        NOT_IN_STUDY,
        [EnumMember(Value = DocConstantAttributeType.PERCENT_CHANGE)]
        PERCENT_CHANGE,
        [EnumMember(Value = DocConstantAttributeType.STANDARD)]
        STANDARD,
        [EnumMember(Value = DocConstantAttributeType.TIME_SINCE)]
        TIME_SINCE,
        [EnumMember(Value = DocConstantAttributeType.TIME_TO)]
        TIME_TO
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this AttributeTypeEnm instance)
        {
            switch(instance) 
            {
                case AttributeTypeEnm.CHANGE:
                    return DocConstantAttributeType.CHANGE;
                case AttributeTypeEnm.DURATION:
                    return DocConstantAttributeType.DURATION;
                case AttributeTypeEnm.NOT_IN_STUDY:
                    return DocConstantAttributeType.NOT_IN_STUDY;
                case AttributeTypeEnm.PERCENT_CHANGE:
                    return DocConstantAttributeType.PERCENT_CHANGE;
                case AttributeTypeEnm.STANDARD:
                    return DocConstantAttributeType.STANDARD;
                case AttributeTypeEnm.TIME_SINCE:
                    return DocConstantAttributeType.TIME_SINCE;
                case AttributeTypeEnm.TIME_TO:
                    return DocConstantAttributeType.TIME_TO;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantAttributeType : IEquatable<DocConstantAttributeType>, IEqualityComparer<DocConstantAttributeType>
    {
        public const string CHANGE = "Change";
        public const string DURATION = "Duration";
        public const string NOT_IN_STUDY = "Not In Study";
        public const string PERCENT_CHANGE = "% Change";
        public const string STANDARD = "Standard";
        public const string TIME_SINCE = "Time Since";
        public const string TIME_TO = "Time To";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantAttributeType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantAttributeType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantAttributeType(string Val) => new DocConstantAttributeType(Val);

        public static implicit operator string(DocConstantAttributeType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantAttributeType obj) => this == obj;

        public static bool operator ==(DocConstantAttributeType x, DocConstantAttributeType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantAttributeType x, DocConstantAttributeType y) => x == y;
        
        public static bool operator !=(DocConstantAttributeType x, DocConstantAttributeType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantAttributeType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantAttributeType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantAttributeType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
