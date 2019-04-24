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
    public enum StudyRandomizationMethodEnm
    {
        [EnumMember(Value = DocConstantStudyRandomizationMethod.CLUSTER)]
        CLUSTER,
        [EnumMember(Value = DocConstantStudyRandomizationMethod.INDIVIDUAL)]
        INDIVIDUAL,
        [EnumMember(Value = DocConstantStudyRandomizationMethod.INDIVIDUAL_CLUSTER)]
        INDIVIDUAL_CLUSTER,
        [EnumMember(Value = DocConstantStudyRandomizationMethod.N_A)]
        N_A,
        [EnumMember(Value = DocConstantStudyRandomizationMethod.NR)]
        NR
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyRandomizationMethodEnm instance)
        {
            switch(instance) 
            {
                case StudyRandomizationMethodEnm.CLUSTER:
                    return DocConstantStudyRandomizationMethod.CLUSTER;
                case StudyRandomizationMethodEnm.INDIVIDUAL:
                    return DocConstantStudyRandomizationMethod.INDIVIDUAL;
                case StudyRandomizationMethodEnm.INDIVIDUAL_CLUSTER:
                    return DocConstantStudyRandomizationMethod.INDIVIDUAL_CLUSTER;
                case StudyRandomizationMethodEnm.N_A:
                    return DocConstantStudyRandomizationMethod.N_A;
                case StudyRandomizationMethodEnm.NR:
                    return DocConstantStudyRandomizationMethod.NR;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantStudyRandomizationMethod : IEquatable<DocConstantStudyRandomizationMethod>, IEqualityComparer<DocConstantStudyRandomizationMethod>
    {
        public const string CLUSTER = "Cluster";
        public const string INDIVIDUAL = "Individual";
        public const string INDIVIDUAL_CLUSTER = "Individual/Cluster";
        public const string N_A = "N/A";
        public const string NR = "NR";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyRandomizationMethod).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyRandomizationMethod(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyRandomizationMethod(string Val) => new DocConstantStudyRandomizationMethod(Val);

        public static implicit operator string(DocConstantStudyRandomizationMethod item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantStudyRandomizationMethod obj) => this == obj;

        public static bool operator ==(DocConstantStudyRandomizationMethod x, DocConstantStudyRandomizationMethod y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyRandomizationMethod x, DocConstantStudyRandomizationMethod y) => x == y;
        
        public static bool operator !=(DocConstantStudyRandomizationMethod x, DocConstantStudyRandomizationMethod y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyRandomizationMethod))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyRandomizationMethod) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyRandomizationMethod obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
