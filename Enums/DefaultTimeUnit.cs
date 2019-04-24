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
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this DefaultTimeUnitEnm instance)
        {
            switch(instance) 
            {
                case DefaultTimeUnitEnm.DAYS:
                    return DocConstantDefaultTimeUnit.DAYS;
                case DefaultTimeUnitEnm.HOURS:
                    return DocConstantDefaultTimeUnit.HOURS;
                case DefaultTimeUnitEnm.MINUTES:
                    return DocConstantDefaultTimeUnit.MINUTES;
                case DefaultTimeUnitEnm.SECONDS:
                    return DocConstantDefaultTimeUnit.SECONDS;
                case DefaultTimeUnitEnm.STUDY_SET_DEFAULT:
                    return DocConstantDefaultTimeUnit.STUDY_SET_DEFAULT;
                case DefaultTimeUnitEnm.WEEKS:
                    return DocConstantDefaultTimeUnit.WEEKS;
                case DefaultTimeUnitEnm.YEARS:
                    return DocConstantDefaultTimeUnit.YEARS;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantDefaultTimeUnit : IEquatable<DocConstantDefaultTimeUnit>, IEqualityComparer<DocConstantDefaultTimeUnit>
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

        private readonly string Value;

        private DocConstantDefaultTimeUnit(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantDefaultTimeUnit(string Val) => new DocConstantDefaultTimeUnit(Val);

        public static implicit operator string(DocConstantDefaultTimeUnit item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantDefaultTimeUnit obj) => this == obj;

        public static bool operator ==(DocConstantDefaultTimeUnit x, DocConstantDefaultTimeUnit y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantDefaultTimeUnit x, DocConstantDefaultTimeUnit y) => x == y;
        
        public static bool operator !=(DocConstantDefaultTimeUnit x, DocConstantDefaultTimeUnit y) => !(x == y);

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

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantDefaultTimeUnit obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
