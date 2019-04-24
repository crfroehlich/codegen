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
    public enum InterventionStageSettingEnm
    {
        [EnumMember(Value = DocConstantInterventionStageSetting.ADJUVANT)]
        ADJUVANT,
        [EnumMember(Value = DocConstantInterventionStageSetting.NEO_ADJUVANT)]
        NEO_ADJUVANT
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this InterventionStageSettingEnm instance)
        {
            switch(instance) 
            {
                case InterventionStageSettingEnm.ADJUVANT:
                    return DocConstantInterventionStageSetting.ADJUVANT;
                case InterventionStageSettingEnm.NEO_ADJUVANT:
                    return DocConstantInterventionStageSetting.NEO_ADJUVANT;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantInterventionStageSetting : IEquatable<DocConstantInterventionStageSetting>, IEqualityComparer<DocConstantInterventionStageSetting>
    {
        public const string ADJUVANT = "Adjuvant";
        public const string NEO_ADJUVANT = "Neo-Adjuvant";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantInterventionStageSetting).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantInterventionStageSetting(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantInterventionStageSetting(string Val) => new DocConstantInterventionStageSetting(Val);

        public static implicit operator string(DocConstantInterventionStageSetting item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantInterventionStageSetting obj) => this == obj;

        public static bool operator ==(DocConstantInterventionStageSetting x, DocConstantInterventionStageSetting y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantInterventionStageSetting x, DocConstantInterventionStageSetting y) => x == y;
        
        public static bool operator !=(DocConstantInterventionStageSetting x, DocConstantInterventionStageSetting y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantInterventionStageSetting))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantInterventionStageSetting) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantInterventionStageSetting obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
