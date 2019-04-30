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
    public enum JunctionTypeEnm
    {
        [EnumMember(Value = DocConstantJunctionType.APPROVAL)]
        APPROVAL = 74232474,
        [EnumMember(Value = DocConstantJunctionType.COMMENT)]
        COMMENT = 74232475,
        [EnumMember(Value = DocConstantJunctionType.FLAGGED_FOR_APPROVAL)]
        FLAGGED_FOR_APPROVAL = 74232476,
        [EnumMember(Value = DocConstantJunctionType.RATING)]
        RATING = 74232477
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this JunctionTypeEnm instance)
        {
            switch(instance) 
            {
                case JunctionTypeEnm.APPROVAL:
                    return DocConstantJunctionType.APPROVAL;
                case JunctionTypeEnm.COMMENT:
                    return DocConstantJunctionType.COMMENT;
                case JunctionTypeEnm.FLAGGED_FOR_APPROVAL:
                    return DocConstantJunctionType.FLAGGED_FOR_APPROVAL;
                case JunctionTypeEnm.RATING:
                    return DocConstantJunctionType.RATING;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantJunctionType : IEquatable<DocConstantJunctionType>, IEqualityComparer<DocConstantJunctionType>
    {
        public const string APPROVAL = "Approval";
        public const string COMMENT = "Comment";
        public const string FLAGGED_FOR_APPROVAL = "Flagged for Approval";
        public const string RATING = "Rating";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantJunctionType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantJunctionType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantJunctionType(string Val) => new DocConstantJunctionType(Val);

        public static implicit operator string(DocConstantJunctionType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantJunctionType obj) => this == obj;

        public static bool operator ==(DocConstantJunctionType x, DocConstantJunctionType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantJunctionType x, DocConstantJunctionType y) => x == y;
        
        public static bool operator !=(DocConstantJunctionType x, DocConstantJunctionType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantJunctionType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantJunctionType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantJunctionType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
