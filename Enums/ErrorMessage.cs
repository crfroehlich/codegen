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
    public enum ErrorMessageEnm
    {
        [EnumMember(Value = DocConstantErrorMessage.ORNY), SCDescript(DocConstantErrorMessage.ORNY), SSDescript(DocConstantErrorMessage.ORNY), SCDisplay(Name = DocConstantErrorMessage.ORNY)]
        ORNY = 67058497
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this ErrorMessageEnm instance)
        {
            switch(instance)
            {
                case ErrorMessageEnm.ORNY:
                    return DocConstantErrorMessage.ORNY;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this ErrorMessageEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantErrorMessage : IEquatable<DocConstantErrorMessage>, IEqualityComparer<DocConstantErrorMessage>
    {
        public const string ORNY = "Object Reference not set to instance of object";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantErrorMessage).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantErrorMessage(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantErrorMessage(string Val) => new DocConstantErrorMessage(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantErrorMessage item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantErrorMessage(ErrorMessageEnm Val) => new DocConstantErrorMessage(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator ErrorMessageEnm(DocConstantErrorMessage item)
        {
            Enum.TryParse<ErrorMessageEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantErrorMessage obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantErrorMessage x, DocConstantErrorMessage y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantErrorMessage x, DocConstantErrorMessage y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantErrorMessage x, DocConstantErrorMessage y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantErrorMessage))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantErrorMessage) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantErrorMessage obj) => obj?.GetHashCode() ?? -17;
    }
}
