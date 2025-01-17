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
    public enum StudyImportLocationEnm
    {
        [EnumMember(Value = DocConstantStudyImportLocation.DEFAULT), SCDescript(DocConstantStudyImportLocation.DEFAULT), SSDescript(DocConstantStudyImportLocation.DEFAULT), SCDisplay(Name = DocConstantStudyImportLocation.DEFAULT)]
        DEFAULT = 150784189,
        [EnumMember(Value = DocConstantStudyImportLocation.DOCDATA), SCDescript(DocConstantStudyImportLocation.DOCDATA), SSDescript(DocConstantStudyImportLocation.DOCDATA), SCDisplay(Name = DocConstantStudyImportLocation.DOCDATA)]
        DOCDATA = 150784190,
        [EnumMember(Value = DocConstantStudyImportLocation.EXTRACT), SCDescript(DocConstantStudyImportLocation.EXTRACT), SSDescript(DocConstantStudyImportLocation.EXTRACT), SCDisplay(Name = DocConstantStudyImportLocation.EXTRACT)]
        EXTRACT = 150784191,
        [EnumMember(Value = DocConstantStudyImportLocation.IMPORT_DATA), SCDescript(DocConstantStudyImportLocation.IMPORT_DATA), SSDescript(DocConstantStudyImportLocation.IMPORT_DATA), SCDisplay(Name = DocConstantStudyImportLocation.IMPORT_DATA)]
        IMPORT_DATA = 150784192
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyImportLocationEnm instance)
        {
            switch(instance)
            {
                case StudyImportLocationEnm.DEFAULT:
                    return DocConstantStudyImportLocation.DEFAULT;
                case StudyImportLocationEnm.DOCDATA:
                    return DocConstantStudyImportLocation.DOCDATA;
                case StudyImportLocationEnm.EXTRACT:
                    return DocConstantStudyImportLocation.EXTRACT;
                case StudyImportLocationEnm.IMPORT_DATA:
                    return DocConstantStudyImportLocation.IMPORT_DATA;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this StudyImportLocationEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantStudyImportLocation : IEquatable<DocConstantStudyImportLocation>, IEqualityComparer<DocConstantStudyImportLocation>
    {
        public const string DEFAULT = "Default";
        public const string DOCDATA = "DocData";
        public const string EXTRACT = "Extract";
        public const string IMPORT_DATA = "Import Data";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyImportLocation).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantStudyImportLocation(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantStudyImportLocation(string Val) => new DocConstantStudyImportLocation(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantStudyImportLocation item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantStudyImportLocation(StudyImportLocationEnm Val) => new DocConstantStudyImportLocation(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator StudyImportLocationEnm(DocConstantStudyImportLocation item)
        {
            Enum.TryParse<StudyImportLocationEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyImportLocation obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantStudyImportLocation x, DocConstantStudyImportLocation y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantStudyImportLocation x, DocConstantStudyImportLocation y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantStudyImportLocation x, DocConstantStudyImportLocation y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyImportLocation))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyImportLocation) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantStudyImportLocation obj) => obj?.GetHashCode() ?? -17;
    }
}
