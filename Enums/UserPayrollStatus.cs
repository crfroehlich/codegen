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
    public enum UserPayrollStatusEnm
    {
        [EnumMember(Value = DocConstantUserPayrollStatus.CONTRACT)]
        CONTRACT = 76351795,
        [EnumMember(Value = DocConstantUserPayrollStatus.FULL_TIME)]
        FULL_TIME = 76351793,
        [EnumMember(Value = DocConstantUserPayrollStatus.PART_TIME)]
        PART_TIME = 76351794
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this UserPayrollStatusEnm instance)
        {
            switch(instance) 
            {
                case UserPayrollStatusEnm.CONTRACT:
                    return DocConstantUserPayrollStatus.CONTRACT;
                case UserPayrollStatusEnm.FULL_TIME:
                    return DocConstantUserPayrollStatus.FULL_TIME;
                case UserPayrollStatusEnm.PART_TIME:
                    return DocConstantUserPayrollStatus.PART_TIME;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantUserPayrollStatus : IEquatable<DocConstantUserPayrollStatus>, IEqualityComparer<DocConstantUserPayrollStatus>
    {
        public const string CONTRACT = "Contract";
        public const string FULL_TIME = "Full-Time";
        public const string PART_TIME = "Part-Time";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantUserPayrollStatus).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantUserPayrollStatus(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantUserPayrollStatus(string Val) => new DocConstantUserPayrollStatus(Val);

        public static implicit operator string(DocConstantUserPayrollStatus item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantUserPayrollStatus(UserPayrollStatusEnm Val) => new DocConstantUserPayrollStatus(Val.ToEnumString());

        public static explicit operator UserPayrollStatusEnm(DocConstantUserPayrollStatus item)
        {
            Enum.TryParse<UserPayrollStatusEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantUserPayrollStatus obj) => this == obj;

        public static bool operator ==(DocConstantUserPayrollStatus x, DocConstantUserPayrollStatus y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantUserPayrollStatus x, DocConstantUserPayrollStatus y) => x == y;
        
        public static bool operator !=(DocConstantUserPayrollStatus x, DocConstantUserPayrollStatus y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantUserPayrollStatus))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantUserPayrollStatus) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantUserPayrollStatus obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
