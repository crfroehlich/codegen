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
    public enum TermClassificationEnm
    {
        [EnumMember(Value = DocConstantTermClassification.CHARACTERISTIC)]
        CHARACTERISTIC = 90640196,
        [EnumMember(Value = DocConstantTermClassification.OUTCOME)]
        OUTCOME = 90640195
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this TermClassificationEnm instance)
        {
            switch(instance) 
            {
                case TermClassificationEnm.CHARACTERISTIC:
                    return DocConstantTermClassification.CHARACTERISTIC;
                case TermClassificationEnm.OUTCOME:
                    return DocConstantTermClassification.OUTCOME;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantTermClassification : IEquatable<DocConstantTermClassification>, IEqualityComparer<DocConstantTermClassification>
    {
        public const string CHARACTERISTIC = "Characteristic";
        public const string OUTCOME = "Outcome";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantTermClassification).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantTermClassification(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantTermClassification(string Val) => new DocConstantTermClassification(Val);

        public static implicit operator string(DocConstantTermClassification item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantTermClassification obj) => this == obj;

        public static bool operator ==(DocConstantTermClassification x, DocConstantTermClassification y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantTermClassification x, DocConstantTermClassification y) => x == y;
        
        public static bool operator !=(DocConstantTermClassification x, DocConstantTermClassification y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantTermClassification))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantTermClassification) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantTermClassification obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
