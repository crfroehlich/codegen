
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
    public enum UserPayrollTypeEnm
    {
        [EnumMember(Value = DocConstantUserPayrollType.HOURLY), SCDescript(DocConstantUserPayrollType.HOURLY), SSDescript(DocConstantUserPayrollType.HOURLY), SCDisplay(Name = DocConstantUserPayrollType.HOURLY)]
        HOURLY = 76351797,
        [EnumMember(Value = DocConstantUserPayrollType.SALARY), SCDescript(DocConstantUserPayrollType.SALARY), SSDescript(DocConstantUserPayrollType.SALARY), SCDisplay(Name = DocConstantUserPayrollType.SALARY)]
        SALARY = 76351796
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this UserPayrollTypeEnm instance)
        {
            switch(instance)
            {
                case UserPayrollTypeEnm.HOURLY:
                    return DocConstantUserPayrollType.HOURLY;
                case UserPayrollTypeEnm.SALARY:
                    return DocConstantUserPayrollType.SALARY;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this UserPayrollTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantUserPayrollType : IEquatable<DocConstantUserPayrollType>, IEqualityComparer<DocConstantUserPayrollType>
    {
        public const string HOURLY = "Hourly";
        public const string SALARY = "Salary";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantUserPayrollType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantUserPayrollType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantUserPayrollType(string Val) => new DocConstantUserPayrollType(Val);

        public static implicit operator string(DocConstantUserPayrollType item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantUserPayrollType(UserPayrollTypeEnm Val) => new DocConstantUserPayrollType(Val.ToEnumString());

        public static explicit operator UserPayrollTypeEnm(DocConstantUserPayrollType item)
        {
            Enum.TryParse<UserPayrollTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantUserPayrollType obj) => this == obj;

        public static bool operator ==(DocConstantUserPayrollType x, DocConstantUserPayrollType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantUserPayrollType x, DocConstantUserPayrollType y) => x == y;
        
        public static bool operator !=(DocConstantUserPayrollType x, DocConstantUserPayrollType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantUserPayrollType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantUserPayrollType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantUserPayrollType obj) => obj?.GetHashCode() ?? -17;

    }
}
