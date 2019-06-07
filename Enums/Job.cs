
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
    public enum JobEnm
    {
        [EnumMember(Value = DocConstantJob.CLEANUP_HISTORY), SCDescript(DocConstantJob.CLEANUP_HISTORY), SSDescript(DocConstantJob.CLEANUP_HISTORY), SCDisplay(Name = DocConstantJob.CLEANUP_HISTORY)]
        CLEANUP_HISTORY = 139850818,
        [EnumMember(Value = DocConstantJob.CREATE_ALL_APPS), SCDescript(DocConstantJob.CREATE_ALL_APPS), SSDescript(DocConstantJob.CREATE_ALL_APPS), SCDisplay(Name = DocConstantJob.CREATE_ALL_APPS)]
        CREATE_ALL_APPS = 139850819,
        [EnumMember(Value = DocConstantJob.CREATE_ALL_ROLE_PERMISSIONS), SCDescript(DocConstantJob.CREATE_ALL_ROLE_PERMISSIONS), SSDescript(DocConstantJob.CREATE_ALL_ROLE_PERMISSIONS), SCDisplay(Name = DocConstantJob.CREATE_ALL_ROLE_PERMISSIONS)]
        CREATE_ALL_ROLE_PERMISSIONS = 139850820,
        [EnumMember(Value = DocConstantJob.CREATE_ALL_VALUE_TYPES), SCDescript(DocConstantJob.CREATE_ALL_VALUE_TYPES), SSDescript(DocConstantJob.CREATE_ALL_VALUE_TYPES), SCDisplay(Name = DocConstantJob.CREATE_ALL_VALUE_TYPES)]
        CREATE_ALL_VALUE_TYPES = 139850821,
        [EnumMember(Value = DocConstantJob.CREATE_DOCUMENT_SET_QUEUES), SCDescript(DocConstantJob.CREATE_DOCUMENT_SET_QUEUES), SSDescript(DocConstantJob.CREATE_DOCUMENT_SET_QUEUES), SCDisplay(Name = DocConstantJob.CREATE_DOCUMENT_SET_QUEUES)]
        CREATE_DOCUMENT_SET_QUEUES = 139850822,
        [EnumMember(Value = DocConstantJob.EXTRACT_IMPORT), SCDescript(DocConstantJob.EXTRACT_IMPORT), SSDescript(DocConstantJob.EXTRACT_IMPORT), SCDisplay(Name = DocConstantJob.EXTRACT_IMPORT)]
        EXTRACT_IMPORT = 139850823,
        [EnumMember(Value = DocConstantJob.EXTRACT_NOTIFICATIONS), SCDescript(DocConstantJob.EXTRACT_NOTIFICATIONS), SSDescript(DocConstantJob.EXTRACT_NOTIFICATIONS), SCDisplay(Name = DocConstantJob.EXTRACT_NOTIFICATIONS)]
        EXTRACT_NOTIFICATIONS = 139850824,
        [EnumMember(Value = DocConstantJob.IMPORT_LIBRARY), SCDescript(DocConstantJob.IMPORT_LIBRARY), SSDescript(DocConstantJob.IMPORT_LIBRARY), SCDisplay(Name = DocConstantJob.IMPORT_LIBRARY)]
        IMPORT_LIBRARY = 139850825,
        [EnumMember(Value = DocConstantJob.IMPORT_PACKAGES), SCDescript(DocConstantJob.IMPORT_PACKAGES), SSDescript(DocConstantJob.IMPORT_PACKAGES), SCDisplay(Name = DocConstantJob.IMPORT_PACKAGES)]
        IMPORT_PACKAGES = 139850826,
        [EnumMember(Value = DocConstantJob.INVALIDATE_EXPIRED_CACHE), SCDescript(DocConstantJob.INVALIDATE_EXPIRED_CACHE), SSDescript(DocConstantJob.INVALIDATE_EXPIRED_CACHE), SCDisplay(Name = DocConstantJob.INVALIDATE_EXPIRED_CACHE)]
        INVALIDATE_EXPIRED_CACHE = 157825539,
        [EnumMember(Value = DocConstantJob.PROCESS_EVENTS), SCDescript(DocConstantJob.PROCESS_EVENTS), SSDescript(DocConstantJob.PROCESS_EVENTS), SCDisplay(Name = DocConstantJob.PROCESS_EVENTS)]
        PROCESS_EVENTS = 139850827,
        [EnumMember(Value = DocConstantJob.PROCESS_LIBRARY_RATINGS), SCDescript(DocConstantJob.PROCESS_LIBRARY_RATINGS), SSDescript(DocConstantJob.PROCESS_LIBRARY_RATINGS), SCDisplay(Name = DocConstantJob.PROCESS_LIBRARY_RATINGS)]
        PROCESS_LIBRARY_RATINGS = 153882376,
        [EnumMember(Value = DocConstantJob.PROCESS_STATS), SCDescript(DocConstantJob.PROCESS_STATS), SSDescript(DocConstantJob.PROCESS_STATS), SCDisplay(Name = DocConstantJob.PROCESS_STATS)]
        PROCESS_STATS = 139850828,
        [EnumMember(Value = DocConstantJob.PROCESS_UPDATES), SCDescript(DocConstantJob.PROCESS_UPDATES), SSDescript(DocConstantJob.PROCESS_UPDATES), SCDisplay(Name = DocConstantJob.PROCESS_UPDATES)]
        PROCESS_UPDATES = 139850829,
        [EnumMember(Value = DocConstantJob.REASSIGN_ARCHIVED_USERS), SCDescript(DocConstantJob.REASSIGN_ARCHIVED_USERS), SSDescript(DocConstantJob.REASSIGN_ARCHIVED_USERS), SCDisplay(Name = DocConstantJob.REASSIGN_ARCHIVED_USERS)]
        REASSIGN_ARCHIVED_USERS = 150784176,
        [EnumMember(Value = DocConstantJob.RUN_TIMECARD_RULES), SCDescript(DocConstantJob.RUN_TIMECARD_RULES), SSDescript(DocConstantJob.RUN_TIMECARD_RULES), SCDisplay(Name = DocConstantJob.RUN_TIMECARD_RULES)]
        RUN_TIMECARD_RULES = 139850830,
        [EnumMember(Value = DocConstantJob.STUDYSET_HISTORY), SCDescript(DocConstantJob.STUDYSET_HISTORY), SSDescript(DocConstantJob.STUDYSET_HISTORY), SCDisplay(Name = DocConstantJob.STUDYSET_HISTORY)]
        STUDYSET_HISTORY = 139850831,
        [EnumMember(Value = DocConstantJob.SYNC_LOOKUP_TABLES), SCDescript(DocConstantJob.SYNC_LOOKUP_TABLES), SSDescript(DocConstantJob.SYNC_LOOKUP_TABLES), SCDisplay(Name = DocConstantJob.SYNC_LOOKUP_TABLES)]
        SYNC_LOOKUP_TABLES = 139850833,
        [EnumMember(Value = DocConstantJob.SYNC_USERS), SCDescript(DocConstantJob.SYNC_USERS), SSDescript(DocConstantJob.SYNC_USERS), SCDisplay(Name = DocConstantJob.SYNC_USERS)]
        SYNC_USERS = 139850835
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this JobEnm instance)
        {
            switch(instance)
            {
                case JobEnm.CLEANUP_HISTORY:
                    return DocConstantJob.CLEANUP_HISTORY;
                case JobEnm.CREATE_ALL_APPS:
                    return DocConstantJob.CREATE_ALL_APPS;
                case JobEnm.CREATE_ALL_ROLE_PERMISSIONS:
                    return DocConstantJob.CREATE_ALL_ROLE_PERMISSIONS;
                case JobEnm.CREATE_ALL_VALUE_TYPES:
                    return DocConstantJob.CREATE_ALL_VALUE_TYPES;
                case JobEnm.CREATE_DOCUMENT_SET_QUEUES:
                    return DocConstantJob.CREATE_DOCUMENT_SET_QUEUES;
                case JobEnm.EXTRACT_IMPORT:
                    return DocConstantJob.EXTRACT_IMPORT;
                case JobEnm.EXTRACT_NOTIFICATIONS:
                    return DocConstantJob.EXTRACT_NOTIFICATIONS;
                case JobEnm.IMPORT_LIBRARY:
                    return DocConstantJob.IMPORT_LIBRARY;
                case JobEnm.IMPORT_PACKAGES:
                    return DocConstantJob.IMPORT_PACKAGES;
                case JobEnm.INVALIDATE_EXPIRED_CACHE:
                    return DocConstantJob.INVALIDATE_EXPIRED_CACHE;
                case JobEnm.PROCESS_EVENTS:
                    return DocConstantJob.PROCESS_EVENTS;
                case JobEnm.PROCESS_LIBRARY_RATINGS:
                    return DocConstantJob.PROCESS_LIBRARY_RATINGS;
                case JobEnm.PROCESS_STATS:
                    return DocConstantJob.PROCESS_STATS;
                case JobEnm.PROCESS_UPDATES:
                    return DocConstantJob.PROCESS_UPDATES;
                case JobEnm.REASSIGN_ARCHIVED_USERS:
                    return DocConstantJob.REASSIGN_ARCHIVED_USERS;
                case JobEnm.RUN_TIMECARD_RULES:
                    return DocConstantJob.RUN_TIMECARD_RULES;
                case JobEnm.STUDYSET_HISTORY:
                    return DocConstantJob.STUDYSET_HISTORY;
                case JobEnm.SYNC_LOOKUP_TABLES:
                    return DocConstantJob.SYNC_LOOKUP_TABLES;
                case JobEnm.SYNC_USERS:
                    return DocConstantJob.SYNC_USERS;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this JobEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantJob : IEquatable<DocConstantJob>, IEqualityComparer<DocConstantJob>
    {
        public const string CLEANUP_HISTORY = "CleanupHistory";
        public const string CREATE_ALL_APPS = "CreateAllApps";
        public const string CREATE_ALL_ROLE_PERMISSIONS = "CreateAllRolePermissions";
        public const string CREATE_ALL_VALUE_TYPES = "CreateAllValueTypes";
        public const string CREATE_DOCUMENT_SET_QUEUES = "CreateDocumentSetQueues";
        public const string EXTRACT_IMPORT = "ExtractImport";
        public const string EXTRACT_NOTIFICATIONS = "ExtractNotifications";
        public const string IMPORT_LIBRARY = "ImportLibrary";
        public const string IMPORT_PACKAGES = "ImportPackages";
        public const string INVALIDATE_EXPIRED_CACHE = "InvalidateExpiredCache";
        public const string PROCESS_EVENTS = "ProcessEvents";
        public const string PROCESS_LIBRARY_RATINGS = "ProcessLibraryRatings";
        public const string PROCESS_STATS = "ProcessStats";
        public const string PROCESS_UPDATES = "ProcessUpdates";
        public const string REASSIGN_ARCHIVED_USERS = "ReassignArchivedUsers";
        public const string RUN_TIMECARD_RULES = "RunTimecardRules";
        public const string STUDYSET_HISTORY = "StudySetHistory";
        public const string SYNC_LOOKUP_TABLES = "SyncLookupTables";
        public const string SYNC_USERS = "SyncUsers";

        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantJob).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantJob(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantJob(string Val) => new DocConstantJob(Val);

        public static implicit operator string(DocConstantJob item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantJob(JobEnm Val) => new DocConstantJob(Val.ToEnumString());

        public static explicit operator JobEnm(DocConstantJob item)
        {
            Enum.TryParse<JobEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        public bool Equals(DocConstantJob obj) => this == obj;

        public static bool operator ==(DocConstantJob x, DocConstantJob y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantJob x, DocConstantJob y) => x == y;
        
        public static bool operator !=(DocConstantJob x, DocConstantJob y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantJob))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantJob) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantJob obj) => obj?.GetHashCode() ?? -17;
    }
}
