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
    public enum YesNoNaEnm
    {
        [EnumMember(Value = DocConstantYesNoNa.NA), SCDescript(DocConstantYesNoNa.NA), SSDescript(DocConstantYesNoNa.NA), SCDisplay(Name = DocConstantYesNoNa.NA)]
        NA = 4958,
        [EnumMember(Value = DocConstantYesNoNa.NO), SCDescript(DocConstantYesNoNa.NO), SSDescript(DocConstantYesNoNa.NO), SCDisplay(Name = DocConstantYesNoNa.NO)]
        NO = 4963,
        [EnumMember(Value = DocConstantYesNoNa.YES), SCDescript(DocConstantYesNoNa.YES), SSDescript(DocConstantYesNoNa.YES), SCDisplay(Name = DocConstantYesNoNa.YES)]
        YES = 4968
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this YesNoNaEnm instance)
        {
            switch(instance)
            {
                case YesNoNaEnm.NA:
                    return DocConstantYesNoNa.NA;
                case YesNoNaEnm.NO:
                    return DocConstantYesNoNa.NO;
                case YesNoNaEnm.YES:
                    return DocConstantYesNoNa.YES;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this YesNoNaEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantYesNoNa : IEquatable<DocConstantYesNoNa>, IEqualityComparer<DocConstantYesNoNa>
    {
        public const string NA = "N/A";
        public const string NO = "No";
        public const string YES = "Yes";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantYesNoNa).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantYesNoNa(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantYesNoNa(string Val) => new DocConstantYesNoNa(Val);

        public static implicit operator string(DocConstantYesNoNa item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantYesNoNa(YesNoNaEnm Val) => new DocConstantYesNoNa(Val.ToEnumString());

        public static explicit operator YesNoNaEnm(DocConstantYesNoNa item)
        {
            Enum.TryParse<YesNoNaEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantYesNoNa obj) => this == obj;

        public static bool operator ==(DocConstantYesNoNa x, DocConstantYesNoNa y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantYesNoNa x, DocConstantYesNoNa y) => x == y;
        
        public static bool operator !=(DocConstantYesNoNa x, DocConstantYesNoNa y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantYesNoNa))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantYesNoNa) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantYesNoNa obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
