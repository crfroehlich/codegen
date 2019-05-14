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
    public enum ExternalKeyEnm
    {
        [EnumMember(Value = DocConstantExternalKey.ATTRIBUTE_NAME_ID)]
        ATTRIBUTE_NAME_ID = 842,
        [EnumMember(Value = DocConstantExternalKey.FILTER)]
        FILTER = 10483075,
        [EnumMember(Value = DocConstantExternalKey.FRAMED_QUESTION_ID)]
        FRAMED_QUESTION_ID = 847,
        [EnumMember(Value = DocConstantExternalKey.PROJECT)]
        PROJECT = 10483080,
        [EnumMember(Value = DocConstantExternalKey.STUDY_DESIGN_ID)]
        STUDY_DESIGN_ID = 852,
        [EnumMember(Value = DocConstantExternalKey.STUDY_TYPE_ID)]
        STUDY_TYPE_ID = 857
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ExternalKeyEnm instance)
        {
            switch(instance) 
            {
                case ExternalKeyEnm.ATTRIBUTE_NAME_ID:
                    return DocConstantExternalKey.ATTRIBUTE_NAME_ID;
                case ExternalKeyEnm.FILTER:
                    return DocConstantExternalKey.FILTER;
                case ExternalKeyEnm.FRAMED_QUESTION_ID:
                    return DocConstantExternalKey.FRAMED_QUESTION_ID;
                case ExternalKeyEnm.PROJECT:
                    return DocConstantExternalKey.PROJECT;
                case ExternalKeyEnm.STUDY_DESIGN_ID:
                    return DocConstantExternalKey.STUDY_DESIGN_ID;
                case ExternalKeyEnm.STUDY_TYPE_ID:
                    return DocConstantExternalKey.STUDY_TYPE_ID;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantExternalKey : IEquatable<DocConstantExternalKey>, IEqualityComparer<DocConstantExternalKey>
    {
        public const string ATTRIBUTE_NAME_ID = "Attribute Name Id";
        public const string FILTER = "Filter";
        public const string FRAMED_QUESTION_ID = "Framed Question Id";
        public const string PROJECT = "Project";
        public const string STUDY_DESIGN_ID = "Study Design Id";
        public const string STUDY_TYPE_ID = "Study Type Id";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantExternalKey).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantExternalKey(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantExternalKey(string Val) => new DocConstantExternalKey(Val);

        public static implicit operator string(DocConstantExternalKey item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantExternalKey(ExternalKeyEnm Val) => new DocConstantExternalKey(Val.ToEnumString());

        public static explicit operator ExternalKeyEnm(DocConstantExternalKey item)
        {
            Enum.TryParse<ExternalKeyEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantExternalKey obj) => this == obj;

        public static bool operator ==(DocConstantExternalKey x, DocConstantExternalKey y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantExternalKey x, DocConstantExternalKey y) => x == y;
        
        public static bool operator !=(DocConstantExternalKey x, DocConstantExternalKey y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantExternalKey))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantExternalKey) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantExternalKey obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
