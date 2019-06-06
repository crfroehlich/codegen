
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
    public enum RatingEnm
    {
        [EnumMember(Value = DocConstantRating.MAYBE_RELEVANT), SCDescript(DocConstantRating.MAYBE_RELEVANT), SSDescript(DocConstantRating.MAYBE_RELEVANT), SCDisplay(Name = DocConstantRating.MAYBE_RELEVANT)]
        MAYBE_RELEVANT = 77289739,
        [EnumMember(Value = DocConstantRating.NOT_RATED), SCDescript(DocConstantRating.NOT_RATED), SSDescript(DocConstantRating.NOT_RATED), SCDisplay(Name = DocConstantRating.NOT_RATED)]
        NOT_RATED = 77289740,
        [EnumMember(Value = DocConstantRating.NOT_RELEVANT), SCDescript(DocConstantRating.NOT_RELEVANT), SSDescript(DocConstantRating.NOT_RELEVANT), SCDisplay(Name = DocConstantRating.NOT_RELEVANT)]
        NOT_RELEVANT = 77289738,
        [EnumMember(Value = DocConstantRating.RELEVANT), SCDescript(DocConstantRating.RELEVANT), SSDescript(DocConstantRating.RELEVANT), SCDisplay(Name = DocConstantRating.RELEVANT)]
        RELEVANT = 77289737
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this RatingEnm instance)
        {
            switch(instance)
            {
                case RatingEnm.MAYBE_RELEVANT:
                    return DocConstantRating.MAYBE_RELEVANT;
                case RatingEnm.NOT_RATED:
                    return DocConstantRating.NOT_RATED;
                case RatingEnm.NOT_RELEVANT:
                    return DocConstantRating.NOT_RELEVANT;
                case RatingEnm.RELEVANT:
                    return DocConstantRating.RELEVANT;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this RatingEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantRating : IEquatable<DocConstantRating>, IEqualityComparer<DocConstantRating>
    {
        public const string MAYBE_RELEVANT = "Maybe Relevant";
        public const string NOT_RATED = "Not Rated";
        public const string NOT_RELEVANT = "Not Relevant";
        public const string RELEVANT = "Relevant";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantRating).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantRating(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantRating(string Val) => new DocConstantRating(Val);

        public static implicit operator string(DocConstantRating item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantRating(RatingEnm Val) => new DocConstantRating(Val.ToEnumString());

        public static explicit operator RatingEnm(DocConstantRating item)
        {
            Enum.TryParse<RatingEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantRating obj) => this == obj;

        public static bool operator ==(DocConstantRating x, DocConstantRating y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantRating x, DocConstantRating y) => x == y;
        
        public static bool operator !=(DocConstantRating x, DocConstantRating y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantRating))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantRating) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantRating obj) => obj?.GetHashCode() ?? -17;

    }
}
