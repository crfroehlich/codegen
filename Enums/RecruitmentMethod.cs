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
    public enum RecruitmentMethodEnm
    {
        [EnumMember(Value = DocConstantRecruitmentMethod.EMAIL)]
        EMAIL,
        [EnumMember(Value = DocConstantRecruitmentMethod.FLYER)]
        FLYER,
        [EnumMember(Value = DocConstantRecruitmentMethod.PHONE)]
        PHONE,
        [EnumMember(Value = DocConstantRecruitmentMethod.REFERRAL)]
        REFERRAL,
        [EnumMember(Value = DocConstantRecruitmentMethod.REGISTRY)]
        REGISTRY
    }
    
	public static partial class EnumExtensions
    {
        public static string ToEnumString(this RecruitmentMethodEnm instance)
		{
			switch(instance) 
			{
                case RecruitmentMethodEnm.EMAIL:
                    return DocConstantRecruitmentMethod.EMAIL;
                case RecruitmentMethodEnm.FLYER:
                    return DocConstantRecruitmentMethod.FLYER;
                case RecruitmentMethodEnm.PHONE:
                    return DocConstantRecruitmentMethod.PHONE;
                case RecruitmentMethodEnm.REFERRAL:
                    return DocConstantRecruitmentMethod.REFERRAL;
                case RecruitmentMethodEnm.REGISTRY:
                    return DocConstantRecruitmentMethod.REGISTRY;
				default:
					return string.Empty;
			}
		}
    }

    public sealed partial class DocConstantRecruitmentMethod : IEquatable<DocConstantRecruitmentMethod>, IEqualityComparer<DocConstantRecruitmentMethod>
    {
        public const string EMAIL = "Email";
        public const string FLYER = "Flyer";
        public const string PHONE = "Phone";
        public const string REFERRAL = "Referral";
        public const string REGISTRY = "Registry";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantRecruitmentMethod).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantRecruitmentMethod(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantRecruitmentMethod(string Val) => new DocConstantRecruitmentMethod(Val);

        public static implicit operator string(DocConstantRecruitmentMethod item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantRecruitmentMethod obj) => this == obj;

        public static bool operator ==(DocConstantRecruitmentMethod x, DocConstantRecruitmentMethod y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantRecruitmentMethod x, DocConstantRecruitmentMethod y) => x == y;
        
        public static bool operator !=(DocConstantRecruitmentMethod x, DocConstantRecruitmentMethod y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantRecruitmentMethod))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantRecruitmentMethod) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
				
        public int GetHashCode(DocConstantRecruitmentMethod obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
