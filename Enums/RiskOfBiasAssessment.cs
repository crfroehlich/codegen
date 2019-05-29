
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
    public enum RiskOfBiasAssessmentEnm
    {
        [EnumMember(Value = DocConstantRiskOfBiasAssessment.NO)]
        NO,
        [EnumMember(Value = DocConstantRiskOfBiasAssessment.UNCLEAR)]
        UNCLEAR,
        [EnumMember(Value = DocConstantRiskOfBiasAssessment.YES)]
        YES
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this RiskOfBiasAssessmentEnm instance)
        {
            switch(instance) 
            {
                case RiskOfBiasAssessmentEnm.NO:
                    return DocConstantRiskOfBiasAssessment.NO;
                case RiskOfBiasAssessmentEnm.UNCLEAR:
                    return DocConstantRiskOfBiasAssessment.UNCLEAR;
                case RiskOfBiasAssessmentEnm.YES:
                    return DocConstantRiskOfBiasAssessment.YES;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantRiskOfBiasAssessment : IEquatable<DocConstantRiskOfBiasAssessment>, IEqualityComparer<DocConstantRiskOfBiasAssessment>
    {
        public const string NO = "No";
        public const string UNCLEAR = "Unclear";
        public const string YES = "Yes";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantRiskOfBiasAssessment).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantRiskOfBiasAssessment(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantRiskOfBiasAssessment(string Val) => new DocConstantRiskOfBiasAssessment(Val);

        public static implicit operator string(DocConstantRiskOfBiasAssessment item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantRiskOfBiasAssessment obj) => this == obj;

        public static bool operator ==(DocConstantRiskOfBiasAssessment x, DocConstantRiskOfBiasAssessment y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantRiskOfBiasAssessment x, DocConstantRiskOfBiasAssessment y) => x == y;
        
        public static bool operator !=(DocConstantRiskOfBiasAssessment x, DocConstantRiskOfBiasAssessment y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantRiskOfBiasAssessment))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantRiskOfBiasAssessment) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantRiskOfBiasAssessment obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
