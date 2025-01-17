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
    public enum PermissionEnm
    {
        [EnumMember(Value = DocConstantPermission.ADD), SCDescript(DocConstantPermission.ADD), SSDescript(DocConstantPermission.ADD), SCDisplay(Name = DocConstantPermission.ADD)]
        ADD = 17611229,
        [EnumMember(Value = DocConstantPermission.DELETE), SCDescript(DocConstantPermission.DELETE), SSDescript(DocConstantPermission.DELETE), SCDisplay(Name = DocConstantPermission.DELETE)]
        DELETE = 17611234,
        [EnumMember(Value = DocConstantPermission.EDIT), SCDescript(DocConstantPermission.EDIT), SSDescript(DocConstantPermission.EDIT), SCDisplay(Name = DocConstantPermission.EDIT)]
        EDIT = 10483119,
        [EnumMember(Value = DocConstantPermission.REMOVE), SCDescript(DocConstantPermission.REMOVE), SSDescript(DocConstantPermission.REMOVE), SCDisplay(Name = DocConstantPermission.REMOVE)]
        REMOVE = 107893902,
        [EnumMember(Value = DocConstantPermission.UNLOCK), SCDescript(DocConstantPermission.UNLOCK), SSDescript(DocConstantPermission.UNLOCK), SCDisplay(Name = DocConstantPermission.UNLOCK)]
        UNLOCK = 90640194,
        [EnumMember(Value = DocConstantPermission.VIEW), SCDescript(DocConstantPermission.VIEW), SSDescript(DocConstantPermission.VIEW), SCDisplay(Name = DocConstantPermission.VIEW)]
        VIEW = 10483124
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this PermissionEnm instance)
        {
            switch(instance)
            {
                case PermissionEnm.ADD:
                    return DocConstantPermission.ADD;
                case PermissionEnm.DELETE:
                    return DocConstantPermission.DELETE;
                case PermissionEnm.EDIT:
                    return DocConstantPermission.EDIT;
                case PermissionEnm.REMOVE:
                    return DocConstantPermission.REMOVE;
                case PermissionEnm.UNLOCK:
                    return DocConstantPermission.UNLOCK;
                case PermissionEnm.VIEW:
                    return DocConstantPermission.VIEW;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this PermissionEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantPermission : IEquatable<DocConstantPermission>, IEqualityComparer<DocConstantPermission>
    {
        public const string ADD = "Add";
        public const string DELETE = "Delete";
        public const string EDIT = "Edit";
        public const string REMOVE = "Remove";
        public const string UNLOCK = "Unlock";
        public const string VIEW = "View";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantPermission).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantPermission(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantPermission(string Val) => new DocConstantPermission(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantPermission item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantPermission(PermissionEnm Val) => new DocConstantPermission(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator PermissionEnm(DocConstantPermission item)
        {
            Enum.TryParse<PermissionEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantPermission obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantPermission x, DocConstantPermission y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantPermission x, DocConstantPermission y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantPermission x, DocConstantPermission y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantPermission))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantPermission) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantPermission obj) => obj?.GetHashCode() ?? -17;
    }
}
