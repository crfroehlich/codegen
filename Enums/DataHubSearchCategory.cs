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
    public enum DataHubSearchCategoryEnm
    {
        [EnumMember(Value = DocConstantDataHubSearchCategory.CharacteristicVariables), SCDescript(DocConstantDataHubSearchCategory.CharacteristicVariables), SSDescript(DocConstantDataHubSearchCategory.CharacteristicVariables), SCDisplay(Name = DocConstantDataHubSearchCategory.CharacteristicVariables)]
        CharacteristicVariables = 612,
        [EnumMember(Value = DocConstantDataHubSearchCategory.InterventionalStudies), SCDescript(DocConstantDataHubSearchCategory.InterventionalStudies), SSDescript(DocConstantDataHubSearchCategory.InterventionalStudies), SCDisplay(Name = DocConstantDataHubSearchCategory.InterventionalStudies)]
        InterventionalStudies = 617,
        [EnumMember(Value = DocConstantDataHubSearchCategory.NhanesPrevalence), SCDescript(DocConstantDataHubSearchCategory.NhanesPrevalence), SSDescript(DocConstantDataHubSearchCategory.NhanesPrevalence), SCDisplay(Name = DocConstantDataHubSearchCategory.NhanesPrevalence)]
        NhanesPrevalence = 622,
        [EnumMember(Value = DocConstantDataHubSearchCategory.ObservationalStudies), SCDescript(DocConstantDataHubSearchCategory.ObservationalStudies), SSDescript(DocConstantDataHubSearchCategory.ObservationalStudies), SCDisplay(Name = DocConstantDataHubSearchCategory.ObservationalStudies)]
        ObservationalStudies = 627,
        [EnumMember(Value = DocConstantDataHubSearchCategory.OutcomeVariables), SCDescript(DocConstantDataHubSearchCategory.OutcomeVariables), SSDescript(DocConstantDataHubSearchCategory.OutcomeVariables), SCDisplay(Name = DocConstantDataHubSearchCategory.OutcomeVariables)]
        OutcomeVariables = 632,
        [EnumMember(Value = DocConstantDataHubSearchCategory.TitleOnly), SCDescript(DocConstantDataHubSearchCategory.TitleOnly), SSDescript(DocConstantDataHubSearchCategory.TitleOnly), SCDisplay(Name = DocConstantDataHubSearchCategory.TitleOnly)]
        TitleOnly = 637,
        [EnumMember(Value = DocConstantDataHubSearchCategory.TitlesAndAbstracts), SCDescript(DocConstantDataHubSearchCategory.TitlesAndAbstracts), SSDescript(DocConstantDataHubSearchCategory.TitlesAndAbstracts), SCDisplay(Name = DocConstantDataHubSearchCategory.TitlesAndAbstracts)]
        TitlesAndAbstracts = 642,
        [EnumMember(Value = DocConstantDataHubSearchCategory.UkProductLabels), SCDescript(DocConstantDataHubSearchCategory.UkProductLabels), SSDescript(DocConstantDataHubSearchCategory.UkProductLabels), SCDisplay(Name = DocConstantDataHubSearchCategory.UkProductLabels)]
        UkProductLabels = 647,
        [EnumMember(Value = DocConstantDataHubSearchCategory.UsProductLabels), SCDescript(DocConstantDataHubSearchCategory.UsProductLabels), SSDescript(DocConstantDataHubSearchCategory.UsProductLabels), SCDisplay(Name = DocConstantDataHubSearchCategory.UsProductLabels)]
        UsProductLabels = 652
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this DataHubSearchCategoryEnm instance)
        {
            switch(instance)
            {
                case DataHubSearchCategoryEnm.CharacteristicVariables:
                    return DocConstantDataHubSearchCategory.CharacteristicVariables;
                case DataHubSearchCategoryEnm.InterventionalStudies:
                    return DocConstantDataHubSearchCategory.InterventionalStudies;
                case DataHubSearchCategoryEnm.NhanesPrevalence:
                    return DocConstantDataHubSearchCategory.NhanesPrevalence;
                case DataHubSearchCategoryEnm.ObservationalStudies:
                    return DocConstantDataHubSearchCategory.ObservationalStudies;
                case DataHubSearchCategoryEnm.OutcomeVariables:
                    return DocConstantDataHubSearchCategory.OutcomeVariables;
                case DataHubSearchCategoryEnm.TitleOnly:
                    return DocConstantDataHubSearchCategory.TitleOnly;
                case DataHubSearchCategoryEnm.TitlesAndAbstracts:
                    return DocConstantDataHubSearchCategory.TitlesAndAbstracts;
                case DataHubSearchCategoryEnm.UkProductLabels:
                    return DocConstantDataHubSearchCategory.UkProductLabels;
                case DataHubSearchCategoryEnm.UsProductLabels:
                    return DocConstantDataHubSearchCategory.UsProductLabels;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this DataHubSearchCategoryEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantDataHubSearchCategory : IEquatable<DocConstantDataHubSearchCategory>, IEqualityComparer<DocConstantDataHubSearchCategory>
    {
        public const string CharacteristicVariables = "Characteristic Variables";
        public const string InterventionalStudies = "CT.gov Interventional Studies";
        public const string NhanesPrevalence = "NHANES Prevalence";
        public const string ObservationalStudies = "CT.gov Observational Studies";
        public const string OutcomeVariables = "Outcome Variables";
        public const string TitleOnly = "Title Only";
        public const string TitlesAndAbstracts = "Titles & Abstracts";
        public const string UkProductLabels = "UK Product Labels";
        public const string UsProductLabels = "US Product Labels";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantDataHubSearchCategory).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantDataHubSearchCategory(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantDataHubSearchCategory(string Val) => new DocConstantDataHubSearchCategory(Val);

        public static implicit operator string(DocConstantDataHubSearchCategory item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantDataHubSearchCategory(DataHubSearchCategoryEnm Val) => new DocConstantDataHubSearchCategory(Val.ToEnumString());

        public static explicit operator DataHubSearchCategoryEnm(DocConstantDataHubSearchCategory item)
        {
            Enum.TryParse<DataHubSearchCategoryEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantDataHubSearchCategory obj) => this == obj;

        public static bool operator ==(DocConstantDataHubSearchCategory x, DocConstantDataHubSearchCategory y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantDataHubSearchCategory x, DocConstantDataHubSearchCategory y) => x == y;
        
        public static bool operator !=(DocConstantDataHubSearchCategory x, DocConstantDataHubSearchCategory y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantDataHubSearchCategory))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDataHubSearchCategory) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantDataHubSearchCategory obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
