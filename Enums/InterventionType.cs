//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
    public enum InterventionTypeEnm
    {
        [EnumMember(Value = DocConstantInterventionType.ACCURACY_OUTCOMES), SCDescript(DocConstantInterventionType.ACCURACY_OUTCOMES), SSDescript(DocConstantInterventionType.ACCURACY_OUTCOMES), SCDisplay(Name = DocConstantInterventionType.ACCURACY_OUTCOMES)]
        ACCURACY_OUTCOMES = 96669191,
        [EnumMember(Value = DocConstantInterventionType.CLINICAL_OUTCOMES), SCDescript(DocConstantInterventionType.CLINICAL_OUTCOMES), SSDescript(DocConstantInterventionType.CLINICAL_OUTCOMES), SCDisplay(Name = DocConstantInterventionType.CLINICAL_OUTCOMES)]
        CLINICAL_OUTCOMES = 96669192,
        [EnumMember(Value = DocConstantInterventionType.COST_EFFECTIVENESS), SCDescript(DocConstantInterventionType.COST_EFFECTIVENESS), SSDescript(DocConstantInterventionType.COST_EFFECTIVENESS), SCDisplay(Name = DocConstantInterventionType.COST_EFFECTIVENESS)]
        COST_EFFECTIVENESS = 96669193,
        [EnumMember(Value = DocConstantInterventionType.GENE_TRANSFER), SCDescript(DocConstantInterventionType.GENE_TRANSFER), SSDescript(DocConstantInterventionType.GENE_TRANSFER), SCDisplay(Name = DocConstantInterventionType.GENE_TRANSFER)]
        GENE_TRANSFER = 96669194,
        [EnumMember(Value = DocConstantInterventionType.INFORMATIONAL_MATERIAL), SCDescript(DocConstantInterventionType.INFORMATIONAL_MATERIAL), SSDescript(DocConstantInterventionType.INFORMATIONAL_MATERIAL), SCDisplay(Name = DocConstantInterventionType.INFORMATIONAL_MATERIAL)]
        INFORMATIONAL_MATERIAL = 1502,
        [EnumMember(Value = DocConstantInterventionType.MINERALS), SCDescript(DocConstantInterventionType.MINERALS), SSDescript(DocConstantInterventionType.MINERALS), SCDisplay(Name = DocConstantInterventionType.MINERALS)]
        MINERALS = 96669195,
        [EnumMember(Value = DocConstantInterventionType.QUALITY_OF_LIFE), SCDescript(DocConstantInterventionType.QUALITY_OF_LIFE), SSDescript(DocConstantInterventionType.QUALITY_OF_LIFE), SCDisplay(Name = DocConstantInterventionType.QUALITY_OF_LIFE)]
        QUALITY_OF_LIFE = 96669196,
        [EnumMember(Value = DocConstantInterventionType.RECOMBINANT_DNA), SCDescript(DocConstantInterventionType.RECOMBINANT_DNA), SSDescript(DocConstantInterventionType.RECOMBINANT_DNA), SCDisplay(Name = DocConstantInterventionType.RECOMBINANT_DNA)]
        RECOMBINANT_DNA = 96669197,
        [EnumMember(Value = DocConstantInterventionType.SESSION_MEETING), SCDescript(DocConstantInterventionType.SESSION_MEETING), SSDescript(DocConstantInterventionType.SESSION_MEETING), SCDisplay(Name = DocConstantInterventionType.SESSION_MEETING)]
        SESSION_MEETING = 1507,
        [EnumMember(Value = DocConstantInterventionType.STEM_CELL), SCDescript(DocConstantInterventionType.STEM_CELL), SSDescript(DocConstantInterventionType.STEM_CELL), SCDisplay(Name = DocConstantInterventionType.STEM_CELL)]
        STEM_CELL = 96669198,
        [EnumMember(Value = DocConstantInterventionType.VITAMINS), SCDescript(DocConstantInterventionType.VITAMINS), SSDescript(DocConstantInterventionType.VITAMINS), SCDisplay(Name = DocConstantInterventionType.VITAMINS)]
        VITAMINS = 96669199
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this InterventionTypeEnm instance)
        {
            switch(instance)
            {
                case InterventionTypeEnm.ACCURACY_OUTCOMES:
                    return DocConstantInterventionType.ACCURACY_OUTCOMES;
                case InterventionTypeEnm.CLINICAL_OUTCOMES:
                    return DocConstantInterventionType.CLINICAL_OUTCOMES;
                case InterventionTypeEnm.COST_EFFECTIVENESS:
                    return DocConstantInterventionType.COST_EFFECTIVENESS;
                case InterventionTypeEnm.GENE_TRANSFER:
                    return DocConstantInterventionType.GENE_TRANSFER;
                case InterventionTypeEnm.INFORMATIONAL_MATERIAL:
                    return DocConstantInterventionType.INFORMATIONAL_MATERIAL;
                case InterventionTypeEnm.MINERALS:
                    return DocConstantInterventionType.MINERALS;
                case InterventionTypeEnm.QUALITY_OF_LIFE:
                    return DocConstantInterventionType.QUALITY_OF_LIFE;
                case InterventionTypeEnm.RECOMBINANT_DNA:
                    return DocConstantInterventionType.RECOMBINANT_DNA;
                case InterventionTypeEnm.SESSION_MEETING:
                    return DocConstantInterventionType.SESSION_MEETING;
                case InterventionTypeEnm.STEM_CELL:
                    return DocConstantInterventionType.STEM_CELL;
                case InterventionTypeEnm.VITAMINS:
                    return DocConstantInterventionType.VITAMINS;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this InterventionTypeEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantInterventionType : IEquatable<DocConstantInterventionType>, IEqualityComparer<DocConstantInterventionType>
    {
        public const string ACCURACY_OUTCOMES = "Accuracy Outcomes";
        public const string CLINICAL_OUTCOMES = "Clinical Outcomes";
        public const string COST_EFFECTIVENESS = "Cost - Effectiveness";
        public const string GENE_TRANSFER = "Gene Transfer";
        public const string INFORMATIONAL_MATERIAL = "Informational Material";
        public const string MINERALS = "Minerals";
        public const string QUALITY_OF_LIFE = "Quality of Life";
        public const string RECOMBINANT_DNA = "Recombinant DNA";
        public const string SESSION_MEETING = "Session/Meeting";
        public const string STEM_CELL = "Stem Cell";
        public const string VITAMINS = "Vitamins";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantInterventionType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantInterventionType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantInterventionType(string Val) => new DocConstantInterventionType(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantInterventionType item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantInterventionType(InterventionTypeEnm Val) => new DocConstantInterventionType(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator InterventionTypeEnm(DocConstantInterventionType item)
        {
            Enum.TryParse<InterventionTypeEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantInterventionType obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantInterventionType x, DocConstantInterventionType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantInterventionType x, DocConstantInterventionType y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantInterventionType x, DocConstantInterventionType y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantInterventionType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantInterventionType) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantInterventionType obj) => obj?.GetHashCode() ?? -17;
    }
}
