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
    public enum HelpEnm
    {
        [EnumMember(Value = DocConstantHelp.DIALOG)]
        DIALOG = 61884870,
        [EnumMember(Value = DocConstantHelp.MANUAL)]
        MANUAL = 74232466,
        [EnumMember(Value = DocConstantHelp.SECTION)]
        SECTION = 74232467,
        [EnumMember(Value = DocConstantHelp.SIDEBAR)]
        SIDEBAR = 61884876
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this HelpEnm instance)
        {
            switch(instance) 
            {
                case HelpEnm.DIALOG:
                    return DocConstantHelp.DIALOG;
                case HelpEnm.MANUAL:
                    return DocConstantHelp.MANUAL;
                case HelpEnm.SECTION:
                    return DocConstantHelp.SECTION;
                case HelpEnm.SIDEBAR:
                    return DocConstantHelp.SIDEBAR;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantHelp : IEquatable<DocConstantHelp>, IEqualityComparer<DocConstantHelp>
    {
        public const string DIALOG = "Dialog";
        public const string MANUAL = "Manual";
        public const string SECTION = "Section";
        public const string SIDEBAR = "Sidebar";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantHelp).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantHelp(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantHelp(string Val) => new DocConstantHelp(Val);

        public static implicit operator string(DocConstantHelp item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantHelp(HelpEnm Val) => new DocConstantHelp(Val.ToEnumString());

        public static explicit operator HelpEnm(DocConstantHelp item)
        {
            Enum.TryParse<HelpEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantHelp obj) => this == obj;

        public static bool operator ==(DocConstantHelp x, DocConstantHelp y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantHelp x, DocConstantHelp y) => x == y;
        
        public static bool operator !=(DocConstantHelp x, DocConstantHelp y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantHelp))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantHelp) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantHelp obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
