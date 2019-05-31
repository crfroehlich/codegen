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
    public enum IntegrationPropertyNameEnm
    {
        [EnumMember(Value = DocConstantIntegrationPropertyName.ACCOUNT), SCDescript(DocConstantIntegrationPropertyName.ACCOUNT), SSDescript(DocConstantIntegrationPropertyName.ACCOUNT), SCDisplay(Name = DocConstantIntegrationPropertyName.ACCOUNT)]
        ACCOUNT = 76351776,
        [EnumMember(Value = DocConstantIntegrationPropertyName.OPPORTUNITY), SCDescript(DocConstantIntegrationPropertyName.OPPORTUNITY), SSDescript(DocConstantIntegrationPropertyName.OPPORTUNITY), SCDisplay(Name = DocConstantIntegrationPropertyName.OPPORTUNITY)]
        OPPORTUNITY = 76351774,
        [EnumMember(Value = DocConstantIntegrationPropertyName.PROJECT), SCDescript(DocConstantIntegrationPropertyName.PROJECT), SSDescript(DocConstantIntegrationPropertyName.PROJECT), SCDisplay(Name = DocConstantIntegrationPropertyName.PROJECT)]
        PROJECT = 94162434
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this IntegrationPropertyNameEnm instance)
        {
            switch(instance)
            {
                case IntegrationPropertyNameEnm.ACCOUNT:
                    return DocConstantIntegrationPropertyName.ACCOUNT;
                case IntegrationPropertyNameEnm.OPPORTUNITY:
                    return DocConstantIntegrationPropertyName.OPPORTUNITY;
                case IntegrationPropertyNameEnm.PROJECT:
                    return DocConstantIntegrationPropertyName.PROJECT;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this IntegrationPropertyNameEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantIntegrationPropertyName : IEquatable<DocConstantIntegrationPropertyName>, IEqualityComparer<DocConstantIntegrationPropertyName>
    {
        public const string ACCOUNT = "Account";
        public const string OPPORTUNITY = "Opportunity";
        public const string PROJECT = "Project";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantIntegrationPropertyName).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantIntegrationPropertyName(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantIntegrationPropertyName(string Val) => new DocConstantIntegrationPropertyName(Val);

        public static implicit operator string(DocConstantIntegrationPropertyName item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantIntegrationPropertyName(IntegrationPropertyNameEnm Val) => new DocConstantIntegrationPropertyName(Val.ToEnumString());

        public static explicit operator IntegrationPropertyNameEnm(DocConstantIntegrationPropertyName item)
        {
            Enum.TryParse<IntegrationPropertyNameEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantIntegrationPropertyName obj) => this == obj;

        public static bool operator ==(DocConstantIntegrationPropertyName x, DocConstantIntegrationPropertyName y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantIntegrationPropertyName x, DocConstantIntegrationPropertyName y) => x == y;
        
        public static bool operator !=(DocConstantIntegrationPropertyName x, DocConstantIntegrationPropertyName y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantIntegrationPropertyName))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantIntegrationPropertyName) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantIntegrationPropertyName obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
