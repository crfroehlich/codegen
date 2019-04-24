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
    public enum StudyBlindingMethodEnm
    {
        [EnumMember(Value = DocConstantStudyBlindingMethod.DOUBLE_BLIND)]
        DOUBLE_BLIND,
        [EnumMember(Value = DocConstantStudyBlindingMethod.OPEN_BLINDED_ENDPOINT)]
        OPEN_BLINDED_ENDPOINT,
        [EnumMember(Value = DocConstantStudyBlindingMethod.OPEN_NO_BLINDING)]
        OPEN_NO_BLINDING,
        [EnumMember(Value = DocConstantStudyBlindingMethod.SINGLE_BLIND)]
        SINGLE_BLIND
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyBlindingMethodEnm instance)
        {
            switch(instance) 
            {
                case StudyBlindingMethodEnm.DOUBLE_BLIND:
                    return DocConstantStudyBlindingMethod.DOUBLE_BLIND;
                case StudyBlindingMethodEnm.OPEN_BLINDED_ENDPOINT:
                    return DocConstantStudyBlindingMethod.OPEN_BLINDED_ENDPOINT;
                case StudyBlindingMethodEnm.OPEN_NO_BLINDING:
                    return DocConstantStudyBlindingMethod.OPEN_NO_BLINDING;
                case StudyBlindingMethodEnm.SINGLE_BLIND:
                    return DocConstantStudyBlindingMethod.SINGLE_BLIND;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantStudyBlindingMethod : IEquatable<DocConstantStudyBlindingMethod>, IEqualityComparer<DocConstantStudyBlindingMethod>
    {
        public const string DOUBLE_BLIND = "Double Blind";
        public const string OPEN_BLINDED_ENDPOINT = "Open Blinded Endpoint";
        public const string OPEN_NO_BLINDING = "Open/No Blinding";
        public const string SINGLE_BLIND = "Single Blind";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyBlindingMethod).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyBlindingMethod(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyBlindingMethod(string Val) => new DocConstantStudyBlindingMethod(Val);

        public static implicit operator string(DocConstantStudyBlindingMethod item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantStudyBlindingMethod obj) => this == obj;

        public static bool operator ==(DocConstantStudyBlindingMethod x, DocConstantStudyBlindingMethod y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyBlindingMethod x, DocConstantStudyBlindingMethod y) => x == y;
        
        public static bool operator !=(DocConstantStudyBlindingMethod x, DocConstantStudyBlindingMethod y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyBlindingMethod))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyBlindingMethod) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyBlindingMethod obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
