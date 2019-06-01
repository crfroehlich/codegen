
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;

using ServiceStack;

using SCDescript = System.ComponentModel.DescriptionAttribute;
using SCDisplay = System.ComponentModel.DataAnnotations.DisplayAttribute;
using SSDescript = ServiceStack.DataAnnotations.DescriptionAttribute;
namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InterventionLineOfTreatmentEnm
    {
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.FIRST), SCDescript(DocConstantInterventionLineOfTreatment.FIRST), SSDescript(DocConstantInterventionLineOfTreatment.FIRST), SCDisplay(Name = DocConstantInterventionLineOfTreatment.FIRST)]
        FIRST = 74232468,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.MAINTENANCE), SCDescript(DocConstantInterventionLineOfTreatment.MAINTENANCE), SSDescript(DocConstantInterventionLineOfTreatment.MAINTENANCE), SCDisplay(Name = DocConstantInterventionLineOfTreatment.MAINTENANCE)]
        MAINTENANCE = 74232469,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.MIXED), SCDescript(DocConstantInterventionLineOfTreatment.MIXED), SSDescript(DocConstantInterventionLineOfTreatment.MIXED), SCDisplay(Name = DocConstantInterventionLineOfTreatment.MIXED)]
        MIXED = 74232470,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.OTHER), SCDescript(DocConstantInterventionLineOfTreatment.OTHER), SSDescript(DocConstantInterventionLineOfTreatment.OTHER), SCDisplay(Name = DocConstantInterventionLineOfTreatment.OTHER)]
        OTHER = 74232471,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.SECOND), SCDescript(DocConstantInterventionLineOfTreatment.SECOND), SSDescript(DocConstantInterventionLineOfTreatment.SECOND), SCDisplay(Name = DocConstantInterventionLineOfTreatment.SECOND)]
        SECOND = 74232472,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.THIRD), SCDescript(DocConstantInterventionLineOfTreatment.THIRD), SSDescript(DocConstantInterventionLineOfTreatment.THIRD), SCDisplay(Name = DocConstantInterventionLineOfTreatment.THIRD)]
        THIRD = 74232473
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this InterventionLineOfTreatmentEnm instance)
        {
            switch(instance)
            {
                case InterventionLineOfTreatmentEnm.FIRST:
                    return DocConstantInterventionLineOfTreatment.FIRST;
                case InterventionLineOfTreatmentEnm.MAINTENANCE:
                    return DocConstantInterventionLineOfTreatment.MAINTENANCE;
                case InterventionLineOfTreatmentEnm.MIXED:
                    return DocConstantInterventionLineOfTreatment.MIXED;
                case InterventionLineOfTreatmentEnm.OTHER:
                    return DocConstantInterventionLineOfTreatment.OTHER;
                case InterventionLineOfTreatmentEnm.SECOND:
                    return DocConstantInterventionLineOfTreatment.SECOND;
                case InterventionLineOfTreatmentEnm.THIRD:
                    return DocConstantInterventionLineOfTreatment.THIRD;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this InterventionLineOfTreatmentEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantInterventionLineOfTreatment : IEquatable<DocConstantInterventionLineOfTreatment>, IEqualityComparer<DocConstantInterventionLineOfTreatment>
    {
        public const string FIRST = "First";
        public const string MAINTENANCE = "Maintenance";
        public const string MIXED = "Mixed";
        public const string OTHER = "Other";
        public const string SECOND = "Second";
        public const string THIRD = "Third";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantInterventionLineOfTreatment).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantInterventionLineOfTreatment(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantInterventionLineOfTreatment(string Val) => new DocConstantInterventionLineOfTreatment(Val);

        public static implicit operator string(DocConstantInterventionLineOfTreatment item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantInterventionLineOfTreatment(InterventionLineOfTreatmentEnm Val) => new DocConstantInterventionLineOfTreatment(Val.ToEnumString());

        public static explicit operator InterventionLineOfTreatmentEnm(DocConstantInterventionLineOfTreatment item)
        {
            Enum.TryParse<InterventionLineOfTreatmentEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantInterventionLineOfTreatment obj) => this == obj;

        public static bool operator ==(DocConstantInterventionLineOfTreatment x, DocConstantInterventionLineOfTreatment y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantInterventionLineOfTreatment x, DocConstantInterventionLineOfTreatment y) => x == y;
        
        public static bool operator !=(DocConstantInterventionLineOfTreatment x, DocConstantInterventionLineOfTreatment y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantInterventionLineOfTreatment))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantInterventionLineOfTreatment) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantInterventionLineOfTreatment obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
