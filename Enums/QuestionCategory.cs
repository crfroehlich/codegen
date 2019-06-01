
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
    public enum QuestionCategoryEnm
    {
        [EnumMember(Value = DocConstantQuestionCategory.GENERAL), SCDescript(DocConstantQuestionCategory.GENERAL), SSDescript(DocConstantQuestionCategory.GENERAL), SCDisplay(Name = DocConstantQuestionCategory.GENERAL)]
        GENERAL = 46351038,
        [EnumMember(Value = DocConstantQuestionCategory.PICO), SCDescript(DocConstantQuestionCategory.PICO), SSDescript(DocConstantQuestionCategory.PICO), SCDisplay(Name = DocConstantQuestionCategory.PICO)]
        PICO = 46351044
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this QuestionCategoryEnm instance)
        {
            switch(instance)
            {
                case QuestionCategoryEnm.GENERAL:
                    return DocConstantQuestionCategory.GENERAL;
                case QuestionCategoryEnm.PICO:
                    return DocConstantQuestionCategory.PICO;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this QuestionCategoryEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantQuestionCategory : IEquatable<DocConstantQuestionCategory>, IEqualityComparer<DocConstantQuestionCategory>
    {
        public const string GENERAL = "General";
        public const string PICO = "PICO";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantQuestionCategory).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantQuestionCategory(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantQuestionCategory(string Val) => new DocConstantQuestionCategory(Val);

        public static implicit operator string(DocConstantQuestionCategory item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantQuestionCategory(QuestionCategoryEnm Val) => new DocConstantQuestionCategory(Val.ToEnumString());

        public static explicit operator QuestionCategoryEnm(DocConstantQuestionCategory item)
        {
            Enum.TryParse<QuestionCategoryEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantQuestionCategory obj) => this == obj;

        public static bool operator ==(DocConstantQuestionCategory x, DocConstantQuestionCategory y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantQuestionCategory x, DocConstantQuestionCategory y) => x == y;
        
        public static bool operator !=(DocConstantQuestionCategory x, DocConstantQuestionCategory y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantQuestionCategory))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantQuestionCategory) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantQuestionCategory obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
