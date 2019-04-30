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
    public enum ProtocolFilterOwnerEnm
    {
        [EnumMember(Value = DocConstantProtocolFilterOwner.ATTRIBUTE)]
        ATTRIBUTE = 9093548,
        [EnumMember(Value = DocConstantProtocolFilterOwner.DOSAGE_VALUE)]
        DOSAGE_VALUE = 9093553,
        [EnumMember(Value = DocConstantProtocolFilterOwner.GROUP)]
        GROUP = 9093558,
        [EnumMember(Value = DocConstantProtocolFilterOwner.INTERVENTION)]
        INTERVENTION = 9093563,
        [EnumMember(Value = DocConstantProtocolFilterOwner.STUDY)]
        STUDY = 9093568
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ProtocolFilterOwnerEnm instance)
        {
            switch(instance) 
            {
                case ProtocolFilterOwnerEnm.ATTRIBUTE:
                    return DocConstantProtocolFilterOwner.ATTRIBUTE;
                case ProtocolFilterOwnerEnm.DOSAGE_VALUE:
                    return DocConstantProtocolFilterOwner.DOSAGE_VALUE;
                case ProtocolFilterOwnerEnm.GROUP:
                    return DocConstantProtocolFilterOwner.GROUP;
                case ProtocolFilterOwnerEnm.INTERVENTION:
                    return DocConstantProtocolFilterOwner.INTERVENTION;
                case ProtocolFilterOwnerEnm.STUDY:
                    return DocConstantProtocolFilterOwner.STUDY;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantProtocolFilterOwner : IEquatable<DocConstantProtocolFilterOwner>, IEqualityComparer<DocConstantProtocolFilterOwner>
    {
        public const string ATTRIBUTE = "Attribute";
        public const string DOSAGE_VALUE = "Dosage Value";
        public const string GROUP = "Group";
        public const string INTERVENTION = "Intervention";
        public const string STUDY = "Study";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantProtocolFilterOwner).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantProtocolFilterOwner(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantProtocolFilterOwner(string Val) => new DocConstantProtocolFilterOwner(Val);

        public static implicit operator string(DocConstantProtocolFilterOwner item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantProtocolFilterOwner obj) => this == obj;

        public static bool operator ==(DocConstantProtocolFilterOwner x, DocConstantProtocolFilterOwner y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantProtocolFilterOwner x, DocConstantProtocolFilterOwner y) => x == y;
        
        public static bool operator !=(DocConstantProtocolFilterOwner x, DocConstantProtocolFilterOwner y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantProtocolFilterOwner))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantProtocolFilterOwner) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantProtocolFilterOwner obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
