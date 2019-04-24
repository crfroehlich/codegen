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
    public enum TimepointTypeEnm
    {
        [EnumMember(Value = DocConstantTimepointType.AFTER)]
        AFTER,
        [EnumMember(Value = DocConstantTimepointType.AVERAGE)]
        AVERAGE,
        [EnumMember(Value = DocConstantTimepointType.BEFORE)]
        BEFORE,
        [EnumMember(Value = DocConstantTimepointType.DURATION)]
        DURATION,
        [EnumMember(Value = DocConstantTimepointType.DURING)]
        DURING,
        [EnumMember(Value = DocConstantTimepointType.MAX_RANGE)]
        MAX_RANGE,
        [EnumMember(Value = DocConstantTimepointType.MAXIMUM)]
        MAXIMUM,
        [EnumMember(Value = DocConstantTimepointType.MEAN)]
        MEAN,
        [EnumMember(Value = DocConstantTimepointType.MEDIAN)]
        MEDIAN,
        [EnumMember(Value = DocConstantTimepointType.NA)]
        NA,
        [EnumMember(Value = DocConstantTimepointType.NONE)]
        NONE,
        [EnumMember(Value = DocConstantTimepointType.NR)]
        NR,
        [EnumMember(Value = DocConstantTimepointType.TIME_ZERO)]
        TIME_ZERO,
        [EnumMember(Value = DocConstantTimepointType.TOTAL)]
        TOTAL,
        [EnumMember(Value = DocConstantTimepointType.VARIES)]
        VARIES
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this TimepointTypeEnm instance)
        {
            switch(instance) 
            {
                case TimepointTypeEnm.AFTER:
                    return DocConstantTimepointType.AFTER;
                case TimepointTypeEnm.AVERAGE:
                    return DocConstantTimepointType.AVERAGE;
                case TimepointTypeEnm.BEFORE:
                    return DocConstantTimepointType.BEFORE;
                case TimepointTypeEnm.DURATION:
                    return DocConstantTimepointType.DURATION;
                case TimepointTypeEnm.DURING:
                    return DocConstantTimepointType.DURING;
                case TimepointTypeEnm.MAX_RANGE:
                    return DocConstantTimepointType.MAX_RANGE;
                case TimepointTypeEnm.MAXIMUM:
                    return DocConstantTimepointType.MAXIMUM;
                case TimepointTypeEnm.MEAN:
                    return DocConstantTimepointType.MEAN;
                case TimepointTypeEnm.MEDIAN:
                    return DocConstantTimepointType.MEDIAN;
                case TimepointTypeEnm.NA:
                    return DocConstantTimepointType.NA;
                case TimepointTypeEnm.NONE:
                    return DocConstantTimepointType.NONE;
                case TimepointTypeEnm.NR:
                    return DocConstantTimepointType.NR;
                case TimepointTypeEnm.TIME_ZERO:
                    return DocConstantTimepointType.TIME_ZERO;
                case TimepointTypeEnm.TOTAL:
                    return DocConstantTimepointType.TOTAL;
                case TimepointTypeEnm.VARIES:
                    return DocConstantTimepointType.VARIES;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantTimepointType : IEquatable<DocConstantTimepointType>, IEqualityComparer<DocConstantTimepointType>
    {
        public const string AFTER = "After";
        public const string AVERAGE = "Average";
        public const string BEFORE = "Before";
        public const string DURATION = "Duration";
        public const string DURING = "During";
        public const string MAX_RANGE = "Max Range";
        public const string MAXIMUM = "Maximum";
        public const string MEAN = "Mean";
        public const string MEDIAN = "Median";
        public const string NA = "N/A";
        public const string NONE = "None";
        public const string NR = "Not Reported";
        public const string TIME_ZERO = "Time Zero";
        public const string TOTAL = "Total";
        public const string VARIES = "Varies";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantTimepointType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantTimepointType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantTimepointType(string Val) => new DocConstantTimepointType(Val);

        public static implicit operator string(DocConstantTimepointType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantTimepointType obj) => this == obj;

        public static bool operator ==(DocConstantTimepointType x, DocConstantTimepointType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantTimepointType x, DocConstantTimepointType y) => x == y;
        
        public static bool operator !=(DocConstantTimepointType x, DocConstantTimepointType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantTimepointType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantTimepointType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantTimepointType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
