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
    public enum QuestionEnm
    {
        [EnumMember(Value = DocConstantQuestion.INCLUDE_MIXED_POPULATIONS), SCDescript(DocConstantQuestion.INCLUDE_MIXED_POPULATIONS), SSDescript(DocConstantQuestion.INCLUDE_MIXED_POPULATIONS), SCDisplay(Name = DocConstantQuestion.INCLUDE_MIXED_POPULATIONS)]
        INCLUDE_MIXED_POPULATIONS = 46351032
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this QuestionEnm instance)
        {
            switch(instance)
            {
                case QuestionEnm.INCLUDE_MIXED_POPULATIONS:
                    return DocConstantQuestion.INCLUDE_MIXED_POPULATIONS;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this QuestionEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantQuestion : IEquatable<DocConstantQuestion>, IEqualityComparer<DocConstantQuestion>
    {
        public const string INCLUDE_MIXED_POPULATIONS = "Include mixed populations?";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantQuestion).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantQuestion(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantQuestion(string Val) => new DocConstantQuestion(Val);

        public static implicit operator string(DocConstantQuestion item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantQuestion(QuestionEnm Val) => new DocConstantQuestion(Val.ToEnumString());

        public static explicit operator QuestionEnm(DocConstantQuestion item)
        {
            Enum.TryParse<QuestionEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantQuestion obj) => this == obj;

        public static bool operator ==(DocConstantQuestion x, DocConstantQuestion y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantQuestion x, DocConstantQuestion y) => x == y;
        
        public static bool operator !=(DocConstantQuestion x, DocConstantQuestion y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantQuestion))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantQuestion) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantQuestion obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
