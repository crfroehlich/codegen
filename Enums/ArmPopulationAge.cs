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
    public enum ArmPopulationAgeEnm
    {
        [EnumMember(Value = DocConstantArmPopulationAge.MEAN_RANGE)]
        MEAN_RANGE = 153,
        [EnumMember(Value = DocConstantArmPopulationAge.MEAN_SD)]
        MEAN_SD = 158,
        [EnumMember(Value = DocConstantArmPopulationAge.MEAN_SE)]
        MEAN_SE = 163,
        [EnumMember(Value = DocConstantArmPopulationAge.MEDIAN_RANGE)]
        MEDIAN_RANGE = 168,
        [EnumMember(Value = DocConstantArmPopulationAge.MEDIAN_SD)]
        MEDIAN_SD = 173,
        [EnumMember(Value = DocConstantArmPopulationAge.MEDIAN_SE)]
        MEDIAN_SE = 178
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ArmPopulationAgeEnm instance)
        {
            switch(instance) 
            {
                case ArmPopulationAgeEnm.MEAN_RANGE:
                    return DocConstantArmPopulationAge.MEAN_RANGE;
                case ArmPopulationAgeEnm.MEAN_SD:
                    return DocConstantArmPopulationAge.MEAN_SD;
                case ArmPopulationAgeEnm.MEAN_SE:
                    return DocConstantArmPopulationAge.MEAN_SE;
                case ArmPopulationAgeEnm.MEDIAN_RANGE:
                    return DocConstantArmPopulationAge.MEDIAN_RANGE;
                case ArmPopulationAgeEnm.MEDIAN_SD:
                    return DocConstantArmPopulationAge.MEDIAN_SD;
                case ArmPopulationAgeEnm.MEDIAN_SE:
                    return DocConstantArmPopulationAge.MEDIAN_SE;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantArmPopulationAge : IEquatable<DocConstantArmPopulationAge>, IEqualityComparer<DocConstantArmPopulationAge>
    {
        public const string MEAN_RANGE = "Mean (Range)";
        public const string MEAN_SD = "Mean +/- SD";
        public const string MEAN_SE = "Mean +/- SE";
        public const string MEDIAN_RANGE = "Median (Range)";
        public const string MEDIAN_SD = "Median +/- SD";
        public const string MEDIAN_SE = "Median +/- SE";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantArmPopulationAge).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantArmPopulationAge(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantArmPopulationAge(string Val) => new DocConstantArmPopulationAge(Val);

        public static implicit operator string(DocConstantArmPopulationAge item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantArmPopulationAge obj) => this == obj;

        public static bool operator ==(DocConstantArmPopulationAge x, DocConstantArmPopulationAge y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantArmPopulationAge x, DocConstantArmPopulationAge y) => x == y;
        
        public static bool operator !=(DocConstantArmPopulationAge x, DocConstantArmPopulationAge y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantArmPopulationAge))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantArmPopulationAge) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantArmPopulationAge obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
