
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;

using ServiceStack;

using SCDescript = System.ComponentModel.DescriptionAttribute;
using SCDisplay = System.ComponentModel.DataAnnotations.DisplayAttribute;
using SSDescript = ServiceStack.DataAnnotations.DescriptionAttribute;
namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UnitTypeEnm
    {
        [EnumMember(Value = DocConstantUnitType.AMOUNT), SCDescript(DocConstantUnitType.AMOUNT), SSDescript(DocConstantUnitType.AMOUNT), SCDisplay(Name = DocConstantUnitType.AMOUNT)]
        AMOUNT = 4553,
        [EnumMember(Value = DocConstantUnitType.AREA), SCDescript(DocConstantUnitType.AREA), SSDescript(DocConstantUnitType.AREA), SCDisplay(Name = DocConstantUnitType.AREA)]
        AREA = 4558,
        [EnumMember(Value = DocConstantUnitType.CONCENTRATION), SCDescript(DocConstantUnitType.CONCENTRATION), SSDescript(DocConstantUnitType.CONCENTRATION), SCDisplay(Name = DocConstantUnitType.CONCENTRATION)]
        CONCENTRATION = 4563,
        [EnumMember(Value = DocConstantUnitType.CONCENTRATION_MOLAR), SCDescript(DocConstantUnitType.CONCENTRATION_MOLAR), SSDescript(DocConstantUnitType.CONCENTRATION_MOLAR), SCDisplay(Name = DocConstantUnitType.CONCENTRATION_MOLAR)]
        CONCENTRATION_MOLAR = 4568,
        [EnumMember(Value = DocConstantUnitType.CONCENTRATION_SOLUTION), SCDescript(DocConstantUnitType.CONCENTRATION_SOLUTION), SSDescript(DocConstantUnitType.CONCENTRATION_SOLUTION), SCDisplay(Name = DocConstantUnitType.CONCENTRATION_SOLUTION)]
        CONCENTRATION_SOLUTION = 4573,
        [EnumMember(Value = DocConstantUnitType.LABEL), SCDescript(DocConstantUnitType.LABEL), SSDescript(DocConstantUnitType.LABEL), SCDisplay(Name = DocConstantUnitType.LABEL)]
        LABEL = 4578,
        [EnumMember(Value = DocConstantUnitType.LENGTH), SCDescript(DocConstantUnitType.LENGTH), SSDescript(DocConstantUnitType.LENGTH), SCDisplay(Name = DocConstantUnitType.LENGTH)]
        LENGTH = 67058544,
        [EnumMember(Value = DocConstantUnitType.MASS), SCDescript(DocConstantUnitType.MASS), SSDescript(DocConstantUnitType.MASS), SCDisplay(Name = DocConstantUnitType.MASS)]
        MASS = 4583,
        [EnumMember(Value = DocConstantUnitType.MOLES), SCDescript(DocConstantUnitType.MOLES), SSDescript(DocConstantUnitType.MOLES), SCDisplay(Name = DocConstantUnitType.MOLES)]
        MOLES = 4588,
        [EnumMember(Value = DocConstantUnitType.NON_TIME), SCDescript(DocConstantUnitType.NON_TIME), SSDescript(DocConstantUnitType.NON_TIME), SCDisplay(Name = DocConstantUnitType.NON_TIME)]
        NON_TIME = 4593,
        [EnumMember(Value = DocConstantUnitType.NON_UNIT), SCDescript(DocConstantUnitType.NON_UNIT), SSDescript(DocConstantUnitType.NON_UNIT), SCDisplay(Name = DocConstantUnitType.NON_UNIT)]
        NON_UNIT = 4598,
        [EnumMember(Value = DocConstantUnitType.RADIATION), SCDescript(DocConstantUnitType.RADIATION), SSDescript(DocConstantUnitType.RADIATION), SCDisplay(Name = DocConstantUnitType.RADIATION)]
        RADIATION = 4603,
        [EnumMember(Value = DocConstantUnitType.TIME), SCDescript(DocConstantUnitType.TIME), SSDescript(DocConstantUnitType.TIME), SCDisplay(Name = DocConstantUnitType.TIME)]
        TIME = 4608,
        [EnumMember(Value = DocConstantUnitType.VOLUME), SCDescript(DocConstantUnitType.VOLUME), SSDescript(DocConstantUnitType.VOLUME), SCDisplay(Name = DocConstantUnitType.VOLUME)]
        VOLUME = 4613,
        [EnumMember(Value = DocConstantUnitType.WEIGHT), SCDescript(DocConstantUnitType.WEIGHT), SSDescript(DocConstantUnitType.WEIGHT), SCDisplay(Name = DocConstantUnitType.WEIGHT)]
        WEIGHT = 4618
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this UnitTypeEnm instance)
        {
            switch(instance)
            {
                case UnitTypeEnm.AMOUNT:
                    return DocConstantUnitType.AMOUNT;
                case UnitTypeEnm.AREA:
                    return DocConstantUnitType.AREA;
                case UnitTypeEnm.CONCENTRATION:
                    return DocConstantUnitType.CONCENTRATION;
                case UnitTypeEnm.CONCENTRATION_MOLAR:
                    return DocConstantUnitType.CONCENTRATION_MOLAR;
                case UnitTypeEnm.CONCENTRATION_SOLUTION:
                    return DocConstantUnitType.CONCENTRATION_SOLUTION;
                case UnitTypeEnm.LABEL:
                    return DocConstantUnitType.LABEL;
                case UnitTypeEnm.LENGTH:
                    return DocConstantUnitType.LENGTH;
                case UnitTypeEnm.MASS:
                    return DocConstantUnitType.MASS;
                case UnitTypeEnm.MOLES:
                    return DocConstantUnitType.MOLES;
                case UnitTypeEnm.NON_TIME:
                    return DocConstantUnitType.NON_TIME;
                case UnitTypeEnm.NON_UNIT:
                    return DocConstantUnitType.NON_UNIT;
                case UnitTypeEnm.RADIATION:
                    return DocConstantUnitType.RADIATION;
                case UnitTypeEnm.TIME:
                    return DocConstantUnitType.TIME;
                case UnitTypeEnm.VOLUME:
                    return DocConstantUnitType.VOLUME;
                case UnitTypeEnm.WEIGHT:
                    return DocConstantUnitType.WEIGHT;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this UnitTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantUnitType : IEquatable<DocConstantUnitType>, IEqualityComparer<DocConstantUnitType>
    {
        public const string AMOUNT = "Amount";
        public const string AREA = "Area";
        public const string CONCENTRATION = "Concentration";
        public const string CONCENTRATION_MOLAR = "Concentration Molar";
        public const string CONCENTRATION_SOLUTION = "Concentration Solution";
        public const string LABEL = "Label";
        public const string LENGTH = "Length";
        public const string MASS = "Mass";
        public const string MOLES = "Moles";
        public const string NON_TIME = "NonTime";
        public const string NON_UNIT = "NonUnit";
        public const string RADIATION = "Radiation";
        public const string TIME = "Time";
        public const string VOLUME = "Volume";
        public const string WEIGHT = "Weight";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantUnitType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantUnitType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantUnitType(string Val) => new DocConstantUnitType(Val);

        public static implicit operator string(DocConstantUnitType item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantUnitType(UnitTypeEnm Val) => new DocConstantUnitType(Val.ToEnumString());

        public static explicit operator UnitTypeEnm(DocConstantUnitType item)
        {
            Enum.TryParse<UnitTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantUnitType obj) => this == obj;

        public static bool operator ==(DocConstantUnitType x, DocConstantUnitType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantUnitType x, DocConstantUnitType y) => x == y;
        
        public static bool operator !=(DocConstantUnitType x, DocConstantUnitType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantUnitType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantUnitType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantUnitType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
