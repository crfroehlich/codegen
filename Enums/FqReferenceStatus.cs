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
    public enum FqReferenceStatusEnm
    {
        [EnumMember(Value = DocConstantFqReferenceStatus.ASSIGNED)]
        ASSIGNED,
        [EnumMember(Value = DocConstantFqReferenceStatus.HOLD)]
        HOLD,
        [EnumMember(Value = DocConstantFqReferenceStatus.REJECTED)]
        REJECTED,
        [EnumMember(Value = DocConstantFqReferenceStatus.REVIEW)]
        REVIEW,
        [EnumMember(Value = DocConstantFqReferenceStatus.UPLOADED)]
        UPLOADED
    }
    
	public static partial class EnumExtensions
    {
        public static string ToEnumString(this FqReferenceStatusEnm instance)
		{
			switch(instance) 
			{
                case FqReferenceStatusEnm.ASSIGNED:
                    return DocConstantFqReferenceStatus.ASSIGNED;
                case FqReferenceStatusEnm.HOLD:
                    return DocConstantFqReferenceStatus.HOLD;
                case FqReferenceStatusEnm.REJECTED:
                    return DocConstantFqReferenceStatus.REJECTED;
                case FqReferenceStatusEnm.REVIEW:
                    return DocConstantFqReferenceStatus.REVIEW;
                case FqReferenceStatusEnm.UPLOADED:
                    return DocConstantFqReferenceStatus.UPLOADED;
				default:
					return string.Empty;
			}
		}
    }

    public sealed partial class DocConstantFqReferenceStatus : IEquatable<DocConstantFqReferenceStatus>, IEqualityComparer<DocConstantFqReferenceStatus>
    {
        public const string ASSIGNED = "Assigned";
        public const string HOLD = "Hold";
        public const string REJECTED = "Rejected";
        public const string REVIEW = "Review";
        public const string UPLOADED = "Uploaded";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantFqReferenceStatus).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantFqReferenceStatus(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantFqReferenceStatus(string Val) => new DocConstantFqReferenceStatus(Val);

        public static implicit operator string(DocConstantFqReferenceStatus item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable (DocConstantFqReferenceStatus)

        public bool Equals(DocConstantFqReferenceStatus obj) => this == obj;

        public static bool operator ==(DocConstantFqReferenceStatus x, DocConstantFqReferenceStatus y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantFqReferenceStatus x, DocConstantFqReferenceStatus y) => x == y;
        
        public static bool operator !=(DocConstantFqReferenceStatus x, DocConstantFqReferenceStatus y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantFqReferenceStatus))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantFqReferenceStatus) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value.GetHashCode();
				
        public int GetHashCode(DocConstantFqReferenceStatus obj) => obj.GetHashCode();

        #endregion IEquatable
    }
}
