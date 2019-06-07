
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
    public enum AppEnm
    {
        [EnumMember(Value = DocConstantApp.BAMBOO), SCDescript(DocConstantApp.BAMBOO), SSDescript(DocConstantApp.BAMBOO), SCDisplay(Name = DocConstantApp.BAMBOO)]
        BAMBOO = 139850785,
        [EnumMember(Value = DocConstantApp.BITBUCKET), SCDescript(DocConstantApp.BITBUCKET), SSDescript(DocConstantApp.BITBUCKET), SCDisplay(Name = DocConstantApp.BITBUCKET)]
        BITBUCKET = 139850784,
        [EnumMember(Value = DocConstantApp.CONFLUENCE), SCDescript(DocConstantApp.CONFLUENCE), SSDescript(DocConstantApp.CONFLUENCE), SCDisplay(Name = DocConstantApp.CONFLUENCE)]
        CONFLUENCE = 139850783,
        [EnumMember(Value = DocConstantApp.DOC_CREATE), SCDescript(DocConstantApp.DOC_CREATE), SSDescript(DocConstantApp.DOC_CREATE), SCDisplay(Name = DocConstantApp.DOC_CREATE)]
        DOC_CREATE = 139850769,
        [EnumMember(Value = DocConstantApp.DOC_DASHBOARD), SCDescript(DocConstantApp.DOC_DASHBOARD), SSDescript(DocConstantApp.DOC_DASHBOARD), SCDisplay(Name = DocConstantApp.DOC_DASHBOARD)]
        DOC_DASHBOARD = 139850786,
        [EnumMember(Value = DocConstantApp.DOC_DATA_ADMIN), SCDescript(DocConstantApp.DOC_DATA_ADMIN), SSDescript(DocConstantApp.DOC_DATA_ADMIN), SCDisplay(Name = DocConstantApp.DOC_DATA_ADMIN)]
        DOC_DATA_ADMIN = 139850759,
        [EnumMember(Value = DocConstantApp.DOC_DATA_V1), SCDescript(DocConstantApp.DOC_DATA_V1), SSDescript(DocConstantApp.DOC_DATA_V1), SCDisplay(Name = DocConstantApp.DOC_DATA_V1)]
        DOC_DATA_V1 = 139850767,
        [EnumMember(Value = DocConstantApp.DOC_DATA_V2), SCDescript(DocConstantApp.DOC_DATA_V2), SSDescript(DocConstantApp.DOC_DATA_V2), SCDisplay(Name = DocConstantApp.DOC_DATA_V2)]
        DOC_DATA_V2 = 139850768,
        [EnumMember(Value = DocConstantApp.DOC_DEVELOPMENT), SCDescript(DocConstantApp.DOC_DEVELOPMENT), SSDescript(DocConstantApp.DOC_DEVELOPMENT), SCDisplay(Name = DocConstantApp.DOC_DEVELOPMENT)]
        DOC_DEVELOPMENT = 139850777,
        [EnumMember(Value = DocConstantApp.DOC_EXTRACT_V1), SCDescript(DocConstantApp.DOC_EXTRACT_V1), SSDescript(DocConstantApp.DOC_EXTRACT_V1), SCDisplay(Name = DocConstantApp.DOC_EXTRACT_V1)]
        DOC_EXTRACT_V1 = 139850761,
        [EnumMember(Value = DocConstantApp.DOC_EXTRACT_V2), SCDescript(DocConstantApp.DOC_EXTRACT_V2), SSDescript(DocConstantApp.DOC_EXTRACT_V2), SCDisplay(Name = DocConstantApp.DOC_EXTRACT_V2)]
        DOC_EXTRACT_V2 = 139850762,
        [EnumMember(Value = DocConstantApp.DOC_EXTRACT_V3), SCDescript(DocConstantApp.DOC_EXTRACT_V3), SSDescript(DocConstantApp.DOC_EXTRACT_V3), SCDisplay(Name = DocConstantApp.DOC_EXTRACT_V3)]
        DOC_EXTRACT_V3 = 139850763,
        [EnumMember(Value = DocConstantApp.DOC_LABEL), SCDescript(DocConstantApp.DOC_LABEL), SSDescript(DocConstantApp.DOC_LABEL), SCDisplay(Name = DocConstantApp.DOC_LABEL)]
        DOC_LABEL = 139850770,
        [EnumMember(Value = DocConstantApp.DOC_LIBRARY), SCDescript(DocConstantApp.DOC_LIBRARY), SSDescript(DocConstantApp.DOC_LIBRARY), SCDisplay(Name = DocConstantApp.DOC_LIBRARY)]
        DOC_LIBRARY = 139850766,
        [EnumMember(Value = DocConstantApp.DOC_NHANES), SCDescript(DocConstantApp.DOC_NHANES), SSDescript(DocConstantApp.DOC_NHANES), SCDisplay(Name = DocConstantApp.DOC_NHANES)]
        DOC_NHANES = 139850771,
        [EnumMember(Value = DocConstantApp.DOC_SEARCH), SCDescript(DocConstantApp.DOC_SEARCH), SSDescript(DocConstantApp.DOC_SEARCH), SCDisplay(Name = DocConstantApp.DOC_SEARCH)]
        DOC_SEARCH = 139850773,
        [EnumMember(Value = DocConstantApp.DOC_TIMELY), SCDescript(DocConstantApp.DOC_TIMELY), SSDescript(DocConstantApp.DOC_TIMELY), SCDisplay(Name = DocConstantApp.DOC_TIMELY)]
        DOC_TIMELY = 139850780,
        [EnumMember(Value = DocConstantApp.DOC_TRACK), SCDescript(DocConstantApp.DOC_TRACK), SSDescript(DocConstantApp.DOC_TRACK), SCDisplay(Name = DocConstantApp.DOC_TRACK)]
        DOC_TRACK = 139850781,
        [EnumMember(Value = DocConstantApp.DRE_ADMIN), SCDescript(DocConstantApp.DRE_ADMIN), SSDescript(DocConstantApp.DRE_ADMIN), SCDisplay(Name = DocConstantApp.DRE_ADMIN)]
        DRE_ADMIN = 139850760,
        [EnumMember(Value = DocConstantApp.GRADE), SCDescript(DocConstantApp.GRADE), SSDescript(DocConstantApp.GRADE), SCDisplay(Name = DocConstantApp.GRADE)]
        GRADE = 139850772,
        [EnumMember(Value = DocConstantApp.GROWTH), SCDescript(DocConstantApp.GROWTH), SSDescript(DocConstantApp.GROWTH), SCDisplay(Name = DocConstantApp.GROWTH)]
        GROWTH = 139850774,
        [EnumMember(Value = DocConstantApp.JIRA), SCDescript(DocConstantApp.JIRA), SSDescript(DocConstantApp.JIRA), SCDisplay(Name = DocConstantApp.JIRA)]
        JIRA = 139850782,
        [EnumMember(Value = DocConstantApp.LAUNCH), SCDescript(DocConstantApp.LAUNCH), SSDescript(DocConstantApp.LAUNCH), SCDisplay(Name = DocConstantApp.LAUNCH)]
        LAUNCH = 139850779,
        [EnumMember(Value = DocConstantApp.LMS), SCDescript(DocConstantApp.LMS), SSDescript(DocConstantApp.LMS), SCDisplay(Name = DocConstantApp.LMS)]
        LMS = 139850764,
        [EnumMember(Value = DocConstantApp.LOGIN), SCDescript(DocConstantApp.LOGIN), SSDescript(DocConstantApp.LOGIN), SCDisplay(Name = DocConstantApp.LOGIN)]
        LOGIN = 139850778,
        [EnumMember(Value = DocConstantApp.MISC), SCDescript(DocConstantApp.MISC), SSDescript(DocConstantApp.MISC), SCDisplay(Name = DocConstantApp.MISC)]
        MISC = 139850776,
        [EnumMember(Value = DocConstantApp.REPORTS), SCDescript(DocConstantApp.REPORTS), SSDescript(DocConstantApp.REPORTS), SCDisplay(Name = DocConstantApp.REPORTS)]
        REPORTS = 139850775,
        [EnumMember(Value = DocConstantApp.SERVE), SCDescript(DocConstantApp.SERVE), SSDescript(DocConstantApp.SERVE), SCDisplay(Name = DocConstantApp.SERVE)]
        SERVE = 146157827
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this AppEnm instance)
        {
            switch(instance)
            {
                case AppEnm.BAMBOO:
                    return DocConstantApp.BAMBOO;
                case AppEnm.BITBUCKET:
                    return DocConstantApp.BITBUCKET;
                case AppEnm.CONFLUENCE:
                    return DocConstantApp.CONFLUENCE;
                case AppEnm.DOC_CREATE:
                    return DocConstantApp.DOC_CREATE;
                case AppEnm.DOC_DASHBOARD:
                    return DocConstantApp.DOC_DASHBOARD;
                case AppEnm.DOC_DATA_ADMIN:
                    return DocConstantApp.DOC_DATA_ADMIN;
                case AppEnm.DOC_DATA_V1:
                    return DocConstantApp.DOC_DATA_V1;
                case AppEnm.DOC_DATA_V2:
                    return DocConstantApp.DOC_DATA_V2;
                case AppEnm.DOC_DEVELOPMENT:
                    return DocConstantApp.DOC_DEVELOPMENT;
                case AppEnm.DOC_EXTRACT_V1:
                    return DocConstantApp.DOC_EXTRACT_V1;
                case AppEnm.DOC_EXTRACT_V2:
                    return DocConstantApp.DOC_EXTRACT_V2;
                case AppEnm.DOC_EXTRACT_V3:
                    return DocConstantApp.DOC_EXTRACT_V3;
                case AppEnm.DOC_LABEL:
                    return DocConstantApp.DOC_LABEL;
                case AppEnm.DOC_LIBRARY:
                    return DocConstantApp.DOC_LIBRARY;
                case AppEnm.DOC_NHANES:
                    return DocConstantApp.DOC_NHANES;
                case AppEnm.DOC_SEARCH:
                    return DocConstantApp.DOC_SEARCH;
                case AppEnm.DOC_TIMELY:
                    return DocConstantApp.DOC_TIMELY;
                case AppEnm.DOC_TRACK:
                    return DocConstantApp.DOC_TRACK;
                case AppEnm.DRE_ADMIN:
                    return DocConstantApp.DRE_ADMIN;
                case AppEnm.GRADE:
                    return DocConstantApp.GRADE;
                case AppEnm.GROWTH:
                    return DocConstantApp.GROWTH;
                case AppEnm.JIRA:
                    return DocConstantApp.JIRA;
                case AppEnm.LAUNCH:
                    return DocConstantApp.LAUNCH;
                case AppEnm.LMS:
                    return DocConstantApp.LMS;
                case AppEnm.LOGIN:
                    return DocConstantApp.LOGIN;
                case AppEnm.MISC:
                    return DocConstantApp.MISC;
                case AppEnm.REPORTS:
                    return DocConstantApp.REPORTS;
                case AppEnm.SERVE:
                    return DocConstantApp.SERVE;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this AppEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantApp : IEquatable<DocConstantApp>, IEqualityComparer<DocConstantApp>
    {
        public const string BAMBOO = "Bamboo";
        public const string BITBUCKET = "Bitbucket";
        public const string CONFLUENCE = "Confluence";
        public const string DOC_CREATE = "DOC Create";
        public const string DOC_DASHBOARD = "DOC Dashboard";
        public const string DOC_DATA_ADMIN = "DOC Data Admin";
        public const string DOC_DATA_V1 = "DOC Data 1.0";
        public const string DOC_DATA_V2 = "DOC Data";
        public const string DOC_DEVELOPMENT = "DOC Development";
        public const string DOC_EXTRACT_V1 = "Doc Extract 1.0";
        public const string DOC_EXTRACT_V2 = "Doc Extract 2.0";
        public const string DOC_EXTRACT_V3 = "Doc Extract 3.0";
        public const string DOC_LABEL = "DOC Label";
        public const string DOC_LIBRARY = "DOC Library";
        public const string DOC_NHANES = "DOC NHANES";
        public const string DOC_SEARCH = "DOC Search";
        public const string DOC_TIMELY = "DOC Timely";
        public const string DOC_TRACK = "DOC Track";
        public const string DRE_ADMIN = "DRE Admin";
        public const string GRADE = "GRADE";
        public const string GROWTH = "GROWTH";
        public const string JIRA = "Jira";
        public const string LAUNCH = "Launch";
        public const string LMS = "LMS";
        public const string LOGIN = "Login";
        public const string MISC = "Miscellaneous";
        public const string REPORTS = "Reports";
        public const string SERVE = "SERVE";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantApp).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantApp(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantApp(string Val) => new DocConstantApp(Val);

        public static implicit operator string(DocConstantApp item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantApp(AppEnm Val) => new DocConstantApp(Val.ToEnumString());

        public static explicit operator AppEnm(DocConstantApp item)
        {
            Enum.TryParse<AppEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantApp obj) => this == obj;

        public static bool operator ==(DocConstantApp x, DocConstantApp y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantApp x, DocConstantApp y) => x == y;
        
        public static bool operator !=(DocConstantApp x, DocConstantApp y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantApp))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantApp) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantApp obj) => obj?.GetHashCode() ?? -17;

    }
}
