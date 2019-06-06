
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
    public enum StudyTypeHarmEtiologyEnm
    {
        [EnumMember(Value = DocConstantStudyTypeHarmEtiology.CAUSATION), SCDescript(DocConstantStudyTypeHarmEtiology.CAUSATION), SSDescript(DocConstantStudyTypeHarmEtiology.CAUSATION), SCDisplay(Name = DocConstantStudyTypeHarmEtiology.CAUSATION)]
        CAUSATION = 3733,
        [EnumMember(Value = DocConstantStudyTypeHarmEtiology.ETIOLOGY), SCDescript(DocConstantStudyTypeHarmEtiology.ETIOLOGY), SSDescript(DocConstantStudyTypeHarmEtiology.ETIOLOGY), SCDisplay(Name = DocConstantStudyTypeHarmEtiology.ETIOLOGY)]
        ETIOLOGY = 3738,
        [EnumMember(Value = DocConstantStudyTypeHarmEtiology.HARM), SCDescript(DocConstantStudyTypeHarmEtiology.HARM), SSDescript(DocConstantStudyTypeHarmEtiology.HARM), SCDisplay(Name = DocConstantStudyTypeHarmEtiology.HARM)]
        HARM = 3743,
        [EnumMember(Value = DocConstantStudyTypeHarmEtiology.RISK), SCDescript(DocConstantStudyTypeHarmEtiology.RISK), SSDescript(DocConstantStudyTypeHarmEtiology.RISK), SCDisplay(Name = DocConstantStudyTypeHarmEtiology.RISK)]
        RISK = 3748
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyTypeHarmEtiologyEnm instance)
        {
            switch(instance)
            {
                case StudyTypeHarmEtiologyEnm.CAUSATION:
                    return DocConstantStudyTypeHarmEtiology.CAUSATION;
                case StudyTypeHarmEtiologyEnm.ETIOLOGY:
                    return DocConstantStudyTypeHarmEtiology.ETIOLOGY;
                case StudyTypeHarmEtiologyEnm.HARM:
                    return DocConstantStudyTypeHarmEtiology.HARM;
                case StudyTypeHarmEtiologyEnm.RISK:
                    return DocConstantStudyTypeHarmEtiology.RISK;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this StudyTypeHarmEtiologyEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantStudyTypeHarmEtiology : IEquatable<DocConstantStudyTypeHarmEtiology>, IEqualityComparer<DocConstantStudyTypeHarmEtiology>
    {
        public const string CAUSATION = "Causation";
        public const string ETIOLOGY = "Etiology";
        public const string HARM = "Harm";
        public const string RISK = "Risk";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyTypeHarmEtiology).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyTypeHarmEtiology(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyTypeHarmEtiology(string Val) => new DocConstantStudyTypeHarmEtiology(Val);

        public static implicit operator string(DocConstantStudyTypeHarmEtiology item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantStudyTypeHarmEtiology(StudyTypeHarmEtiologyEnm Val) => new DocConstantStudyTypeHarmEtiology(Val.ToEnumString());

        public static explicit operator StudyTypeHarmEtiologyEnm(DocConstantStudyTypeHarmEtiology item)
        {
            Enum.TryParse<StudyTypeHarmEtiologyEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantStudyTypeHarmEtiology obj) => this == obj;

        public static bool operator ==(DocConstantStudyTypeHarmEtiology x, DocConstantStudyTypeHarmEtiology y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyTypeHarmEtiology x, DocConstantStudyTypeHarmEtiology y) => x == y;
        
        public static bool operator !=(DocConstantStudyTypeHarmEtiology x, DocConstantStudyTypeHarmEtiology y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyTypeHarmEtiology))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyTypeHarmEtiology) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyTypeHarmEtiology obj) => obj?.GetHashCode() ?? -17;

    }
}
