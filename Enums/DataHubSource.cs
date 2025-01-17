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
    public enum DataHubSourceEnm
    {
        [EnumMember(Value = DocConstantDataHubSource.AdditionalDataSources), SCDescript(DocConstantDataHubSource.AdditionalDataSources), SSDescript(DocConstantDataHubSource.AdditionalDataSources), SCDisplay(Name = DocConstantDataHubSource.AdditionalDataSources)]
        AdditionalDataSources = 657,
        [EnumMember(Value = DocConstantDataHubSource.DigitizedData), SCDescript(DocConstantDataHubSource.DigitizedData), SSDescript(DocConstantDataHubSource.DigitizedData), SCDisplay(Name = DocConstantDataHubSource.DigitizedData)]
        DigitizedData = 662,
        [EnumMember(Value = DocConstantDataHubSource.EpidemiologicalData), SCDescript(DocConstantDataHubSource.EpidemiologicalData), SSDescript(DocConstantDataHubSource.EpidemiologicalData), SCDisplay(Name = DocConstantDataHubSource.EpidemiologicalData)]
        EpidemiologicalData = 667,
        [EnumMember(Value = DocConstantDataHubSource.LabelingData), SCDescript(DocConstantDataHubSource.LabelingData), SSDescript(DocConstantDataHubSource.LabelingData), SCDisplay(Name = DocConstantDataHubSource.LabelingData)]
        LabelingData = 672,
        [EnumMember(Value = DocConstantDataHubSource.PublishedLiterature), SCDescript(DocConstantDataHubSource.PublishedLiterature), SSDescript(DocConstantDataHubSource.PublishedLiterature), SCDisplay(Name = DocConstantDataHubSource.PublishedLiterature)]
        PublishedLiterature = 677
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this DataHubSourceEnm instance)
        {
            switch(instance)
            {
                case DataHubSourceEnm.AdditionalDataSources:
                    return DocConstantDataHubSource.AdditionalDataSources;
                case DataHubSourceEnm.DigitizedData:
                    return DocConstantDataHubSource.DigitizedData;
                case DataHubSourceEnm.EpidemiologicalData:
                    return DocConstantDataHubSource.EpidemiologicalData;
                case DataHubSourceEnm.LabelingData:
                    return DocConstantDataHubSource.LabelingData;
                case DataHubSourceEnm.PublishedLiterature:
                    return DocConstantDataHubSource.PublishedLiterature;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this DataHubSourceEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantDataHubSource : IEquatable<DocConstantDataHubSource>, IEqualityComparer<DocConstantDataHubSource>
    {
        public const string AdditionalDataSources = "Additional Data Sources";
        public const string DigitizedData = "Digitized Data";
        public const string EpidemiologicalData = "Epidemiological Data";
        public const string LabelingData = "Labeling Data";
        public const string PublishedLiterature = "Published Literature";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantDataHubSource).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantDataHubSource(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantDataHubSource(string Val) => new DocConstantDataHubSource(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantDataHubSource item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantDataHubSource(DataHubSourceEnm Val) => new DocConstantDataHubSource(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DataHubSourceEnm(DocConstantDataHubSource item)
        {
            Enum.TryParse<DataHubSourceEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantDataHubSource obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantDataHubSource x, DocConstantDataHubSource y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantDataHubSource x, DocConstantDataHubSource y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantDataHubSource x, DocConstantDataHubSource y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantDataHubSource))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDataHubSource) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantDataHubSource obj) => obj?.GetHashCode() ?? -17;
    }
}
