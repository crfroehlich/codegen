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
    public enum DataHubSearchCategoryEnm
    {
        [EnumMember(Value = DocConstantDataHubSearchCategory.CharacteristicVariables)]
        CharacteristicVariables,
        [EnumMember(Value = DocConstantDataHubSearchCategory.InterventionalStudies)]
        InterventionalStudies,
        [EnumMember(Value = DocConstantDataHubSearchCategory.NhanesPrevalence)]
        NhanesPrevalence,
        [EnumMember(Value = DocConstantDataHubSearchCategory.ObservationalStudies)]
        ObservationalStudies,
        [EnumMember(Value = DocConstantDataHubSearchCategory.OutcomeVariables)]
        OutcomeVariables,
        [EnumMember(Value = DocConstantDataHubSearchCategory.TitleOnly)]
        TitleOnly,
        [EnumMember(Value = DocConstantDataHubSearchCategory.TitlesAndAbstracts)]
        TitlesAndAbstracts,
        [EnumMember(Value = DocConstantDataHubSearchCategory.UkProductLabels)]
        UkProductLabels,
        [EnumMember(Value = DocConstantDataHubSearchCategory.UsProductLabels)]
        UsProductLabels
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
