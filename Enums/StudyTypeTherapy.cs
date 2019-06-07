
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
    public enum StudyTypeTherapyEnm
    {
        [EnumMember(Value = DocConstantStudyTypeTherapy.BEHAVIORAL_COUNSELING), SCDescript(DocConstantStudyTypeTherapy.BEHAVIORAL_COUNSELING), SSDescript(DocConstantStudyTypeTherapy.BEHAVIORAL_COUNSELING), SCDisplay(Name = DocConstantStudyTypeTherapy.BEHAVIORAL_COUNSELING)]
        BEHAVIORAL_COUNSELING = 3753,
        [EnumMember(Value = DocConstantStudyTypeTherapy.DEVICE_SERVICE), SCDescript(DocConstantStudyTypeTherapy.DEVICE_SERVICE), SSDescript(DocConstantStudyTypeTherapy.DEVICE_SERVICE), SCDisplay(Name = DocConstantStudyTypeTherapy.DEVICE_SERVICE)]
        DEVICE_SERVICE = 3758,
        [EnumMember(Value = DocConstantStudyTypeTherapy.DRUG), SCDescript(DocConstantStudyTypeTherapy.DRUG), SSDescript(DocConstantStudyTypeTherapy.DRUG), SCDisplay(Name = DocConstantStudyTypeTherapy.DRUG)]
        DRUG = 3763,
        [EnumMember(Value = DocConstantStudyTypeTherapy.LIFESTYLE_MODIFICATION), SCDescript(DocConstantStudyTypeTherapy.LIFESTYLE_MODIFICATION), SSDescript(DocConstantStudyTypeTherapy.LIFESTYLE_MODIFICATION), SCDisplay(Name = DocConstantStudyTypeTherapy.LIFESTYLE_MODIFICATION)]
        LIFESTYLE_MODIFICATION = 3768
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyTypeTherapyEnm instance)
        {
            switch(instance)
            {
                case StudyTypeTherapyEnm.BEHAVIORAL_COUNSELING:
                    return DocConstantStudyTypeTherapy.BEHAVIORAL_COUNSELING;
                case StudyTypeTherapyEnm.DEVICE_SERVICE:
                    return DocConstantStudyTypeTherapy.DEVICE_SERVICE;
                case StudyTypeTherapyEnm.DRUG:
                    return DocConstantStudyTypeTherapy.DRUG;
                case StudyTypeTherapyEnm.LIFESTYLE_MODIFICATION:
                    return DocConstantStudyTypeTherapy.LIFESTYLE_MODIFICATION;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this StudyTypeTherapyEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantStudyTypeTherapy : IEquatable<DocConstantStudyTypeTherapy>, IEqualityComparer<DocConstantStudyTypeTherapy>
    {
        public const string BEHAVIORAL_COUNSELING = "Behavioral/Counseling";
        public const string DEVICE_SERVICE = "Device/Service";
        public const string DRUG = "Drug";
        public const string LIFESTYLE_MODIFICATION = "Lifestyle Modification";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyTypeTherapy).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyTypeTherapy(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyTypeTherapy(string Val) => new DocConstantStudyTypeTherapy(Val);

        public static implicit operator string(DocConstantStudyTypeTherapy item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantStudyTypeTherapy(StudyTypeTherapyEnm Val) => new DocConstantStudyTypeTherapy(Val.ToEnumString());

        public static explicit operator StudyTypeTherapyEnm(DocConstantStudyTypeTherapy item)
        {
            Enum.TryParse<StudyTypeTherapyEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantStudyTypeTherapy obj) => this == obj;

        public static bool operator ==(DocConstantStudyTypeTherapy x, DocConstantStudyTypeTherapy y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyTypeTherapy x, DocConstantStudyTypeTherapy y) => x == y;
        
        public static bool operator !=(DocConstantStudyTypeTherapy x, DocConstantStudyTypeTherapy y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyTypeTherapy))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyTypeTherapy) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyTypeTherapy obj) => obj?.GetHashCode() ?? -17;

    }
}
