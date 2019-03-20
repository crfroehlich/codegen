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
    public enum ScopeEnm
    {
        [EnumMember(Value = DocConstantScope.APP)]
        APP,
        [EnumMember(Value = DocConstantScope.CLIENT)]
        CLIENT,
        [EnumMember(Value = DocConstantScope.COMPOUND)]
        COMPOUND,
        [EnumMember(Value = DocConstantScope.DOCUMENTSET)]
        DOCUMENTSET,
        [EnumMember(Value = DocConstantScope.GLOBAL)]
        GLOBAL,
        [EnumMember(Value = DocConstantScope.TEAM)]
        TEAM,
        [EnumMember(Value = DocConstantScope.USER)]
        USER
    }
    
	public static partial class EnumExtensions
    {
        public static string ToEnumString(this ScopeEnm instance)
		{
			switch(instance) 
			{
                case ScopeEnm.APP:
                    return DocConstantScope.APP;
                case ScopeEnm.CLIENT:
                    return DocConstantScope.CLIENT;
                case ScopeEnm.COMPOUND:
                    return DocConstantScope.COMPOUND;
                case ScopeEnm.DOCUMENTSET:
                    return DocConstantScope.DOCUMENTSET;
                case ScopeEnm.GLOBAL:
                    return DocConstantScope.GLOBAL;
                case ScopeEnm.TEAM:
                    return DocConstantScope.TEAM;
                case ScopeEnm.USER:
                    return DocConstantScope.USER;
				default:
					return string.Empty;
			}
		}
    }

    public sealed partial class DocConstantScope : IEquatable<DocConstantScope>, IEqualityComparer<DocConstantScope>
    {
        public const string APP = "App";
        public const string CLIENT = "Client";
        public const string COMPOUND = "Compound";
        public const string DOCUMENTSET = "DocumentSet";
        public const string GLOBAL = "Global";
        public const string TEAM = "Team";
        public const string USER = "User";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantScope).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantScope(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantScope(string Val) => new DocConstantScope(Val);

        public static implicit operator string(DocConstantScope item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable (DocConstantScope)

        public bool Equals(DocConstantScope obj) => this == obj;

        public static bool operator ==(DocConstantScope x, DocConstantScope y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantScope x, DocConstantScope y) => x == y;
        
        public static bool operator !=(DocConstantScope x, DocConstantScope y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantScope))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantScope) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value.GetHashCode();
				
        public int GetHashCode(DocConstantScope obj) => obj.GetHashCode();

        #endregion IEquatable
    }
}
