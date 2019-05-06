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
    public enum QueueChannelEnm
    {
        [EnumMember(Value = DocConstantQueueChannel.PORTAL_AUDIT)]
        PORTAL_AUDIT = 139850941,
        [EnumMember(Value = DocConstantQueueChannel.PORTAL_BACKGROUND_TASK)]
        PORTAL_BACKGROUND_TASK = 139850942,
        [EnumMember(Value = DocConstantQueueChannel.PORTAL_NOTIFICATION)]
        PORTAL_NOTIFICATION = 139850943,
        [EnumMember(Value = DocConstantQueueChannel.PORTAL_USER_UPDATE)]
        PORTAL_USER_UPDATE = 139850944,
        [EnumMember(Value = DocConstantQueueChannel.QUEUE_ERROR)]
        QUEUE_ERROR = 139850945,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_AUDIT)]
        SERVICES_AUDIT = 139850946,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_AUDIT_FAILURES)]
        SERVICES_AUDIT_FAILURES = 139850947,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_DOCUMENT_IMPORT)]
        SERVICES_DOCUMENT_IMPORT = 146157835,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_DOCUMENT_UPDATE)]
        SERVICES_DOCUMENT_UPDATE = 139850949,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_ERRORS)]
        SERVICES_ERRORS = 150784182,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_EXTRACT_ANNOTATION)]
        SERVICES_EXTRACT_ANNOTATION = 150784183,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_EXTRACT_NOTIFICATION)]
        SERVICES_EXTRACT_NOTIFICATION = 139850950,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_HEARTBEAT)]
        SERVICES_HEARTBEAT = 139850951,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_LOGS)]
        SERVICES_LOGS = 146157836,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_LOGS_TO_SEGMENT)]
        SERVICES_LOGS_TO_SEGMENT = 146157837,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_LOGS_TO_SLACK)]
        SERVICES_LOGS_TO_SLACK = 146157838,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_LOGS_TO_STACKIFY)]
        SERVICES_LOGS_TO_STACKIFY = 146157839,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_METADATA_UPDATE)]
        SERVICES_METADATA_UPDATE = 150784184,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_SALESFORCE)]
        SERVICES_SALESFORCE = 146157840,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_SLACK)]
        SERVICES_SLACK = 139850957,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_TEAM_SERVE)]
        SERVICES_TEAM_SERVE = 150784185,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_SESSION)]
        SERVICES_USER_SESSION = 139850958,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE)]
        SERVICES_USER_UPDATE = 139850959,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE_ARCHIVING)]
        SERVICES_USER_UPDATE_ARCHIVING = 146157841,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE_BROADCASTS)]
        SERVICES_USER_UPDATE_BROADCASTS = 146157842,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE_DOCUMENT_ASSIGNMENT)]
        SERVICES_USER_UPDATE_DOCUMENT_ASSIGNMENT = 146157843,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE_DOCUMENT_IMPORTS)]
        SERVICES_USER_UPDATE_DOCUMENT_IMPORTS = 146157844,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE_DOCUMENT_SET_ASSIGNMENT)]
        SERVICES_USER_UPDATE_DOCUMENT_SET_ASSIGNMENT = 146157845,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE_ROLES)]
        SERVICES_USER_UPDATE_ROLES = 146157846,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE_SHARING)]
        SERVICES_USER_UPDATE_SHARING = 146157847,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_USER_UPDATE_TEAMS)]
        SERVICES_USER_UPDATE_TEAMS = 146157848,
        [EnumMember(Value = DocConstantQueueChannel.SERVICES_WORKFLOW_UPDATE)]
        SERVICES_WORKFLOW_UPDATE = 150786180
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this QueueChannelEnm instance)
        {
            switch(instance) 
            {
                case QueueChannelEnm.PORTAL_AUDIT:
                    return DocConstantQueueChannel.PORTAL_AUDIT;
                case QueueChannelEnm.PORTAL_BACKGROUND_TASK:
                    return DocConstantQueueChannel.PORTAL_BACKGROUND_TASK;
                case QueueChannelEnm.PORTAL_NOTIFICATION:
                    return DocConstantQueueChannel.PORTAL_NOTIFICATION;
                case QueueChannelEnm.PORTAL_USER_UPDATE:
                    return DocConstantQueueChannel.PORTAL_USER_UPDATE;
                case QueueChannelEnm.QUEUE_ERROR:
                    return DocConstantQueueChannel.QUEUE_ERROR;
                case QueueChannelEnm.SERVICES_AUDIT:
                    return DocConstantQueueChannel.SERVICES_AUDIT;
                case QueueChannelEnm.SERVICES_AUDIT_FAILURES:
                    return DocConstantQueueChannel.SERVICES_AUDIT_FAILURES;
                case QueueChannelEnm.SERVICES_DOCUMENT_IMPORT:
                    return DocConstantQueueChannel.SERVICES_DOCUMENT_IMPORT;
                case QueueChannelEnm.SERVICES_DOCUMENT_UPDATE:
                    return DocConstantQueueChannel.SERVICES_DOCUMENT_UPDATE;
                case QueueChannelEnm.SERVICES_ERRORS:
                    return DocConstantQueueChannel.SERVICES_ERRORS;
                case QueueChannelEnm.SERVICES_EXTRACT_ANNOTATION:
                    return DocConstantQueueChannel.SERVICES_EXTRACT_ANNOTATION;
                case QueueChannelEnm.SERVICES_EXTRACT_NOTIFICATION:
                    return DocConstantQueueChannel.SERVICES_EXTRACT_NOTIFICATION;
                case QueueChannelEnm.SERVICES_HEARTBEAT:
                    return DocConstantQueueChannel.SERVICES_HEARTBEAT;
                case QueueChannelEnm.SERVICES_LOGS:
                    return DocConstantQueueChannel.SERVICES_LOGS;
                case QueueChannelEnm.SERVICES_LOGS_TO_SEGMENT:
                    return DocConstantQueueChannel.SERVICES_LOGS_TO_SEGMENT;
                case QueueChannelEnm.SERVICES_LOGS_TO_SLACK:
                    return DocConstantQueueChannel.SERVICES_LOGS_TO_SLACK;
                case QueueChannelEnm.SERVICES_LOGS_TO_STACKIFY:
                    return DocConstantQueueChannel.SERVICES_LOGS_TO_STACKIFY;
                case QueueChannelEnm.SERVICES_METADATA_UPDATE:
                    return DocConstantQueueChannel.SERVICES_METADATA_UPDATE;
                case QueueChannelEnm.SERVICES_SALESFORCE:
                    return DocConstantQueueChannel.SERVICES_SALESFORCE;
                case QueueChannelEnm.SERVICES_SLACK:
                    return DocConstantQueueChannel.SERVICES_SLACK;
                case QueueChannelEnm.SERVICES_TEAM_SERVE:
                    return DocConstantQueueChannel.SERVICES_TEAM_SERVE;
                case QueueChannelEnm.SERVICES_USER_SESSION:
                    return DocConstantQueueChannel.SERVICES_USER_SESSION;
                case QueueChannelEnm.SERVICES_USER_UPDATE:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE;
                case QueueChannelEnm.SERVICES_USER_UPDATE_ARCHIVING:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE_ARCHIVING;
                case QueueChannelEnm.SERVICES_USER_UPDATE_BROADCASTS:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE_BROADCASTS;
                case QueueChannelEnm.SERVICES_USER_UPDATE_DOCUMENT_ASSIGNMENT:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE_DOCUMENT_ASSIGNMENT;
                case QueueChannelEnm.SERVICES_USER_UPDATE_DOCUMENT_IMPORTS:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE_DOCUMENT_IMPORTS;
                case QueueChannelEnm.SERVICES_USER_UPDATE_DOCUMENT_SET_ASSIGNMENT:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE_DOCUMENT_SET_ASSIGNMENT;
                case QueueChannelEnm.SERVICES_USER_UPDATE_ROLES:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE_ROLES;
                case QueueChannelEnm.SERVICES_USER_UPDATE_SHARING:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE_SHARING;
                case QueueChannelEnm.SERVICES_USER_UPDATE_TEAMS:
                    return DocConstantQueueChannel.SERVICES_USER_UPDATE_TEAMS;
                case QueueChannelEnm.SERVICES_WORKFLOW_UPDATE:
                    return DocConstantQueueChannel.SERVICES_WORKFLOW_UPDATE;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantQueueChannel : IEquatable<DocConstantQueueChannel>, IEqualityComparer<DocConstantQueueChannel>
    {
        public const string PORTAL_AUDIT = "portal_audit";
        public const string PORTAL_BACKGROUND_TASK = "portal_background_task";
        public const string PORTAL_NOTIFICATION = "portal_notification";
        public const string PORTAL_USER_UPDATE = "portal_user_update";
        public const string QUEUE_ERROR = "queue_error";
        public const string SERVICES_AUDIT = "services_audit";
        public const string SERVICES_AUDIT_FAILURES = "services_audit_failures";
        public const string SERVICES_DOCUMENT_IMPORT = "services_document_import";
        public const string SERVICES_DOCUMENT_UPDATE = "services_document_update";
        public const string SERVICES_ERRORS = "services_errors";
        public const string SERVICES_EXTRACT_ANNOTATION = "services_extract_annotation";
        public const string SERVICES_EXTRACT_NOTIFICATION = "services_extract_notification";
        public const string SERVICES_HEARTBEAT = "services_heartbeat";
        public const string SERVICES_LOGS = "services_logs";
        public const string SERVICES_LOGS_TO_SEGMENT = "services_logs_to_segment";
        public const string SERVICES_LOGS_TO_SLACK = "services_logs_to_slack";
        public const string SERVICES_LOGS_TO_STACKIFY = "services_logs_to_stackify";
        public const string SERVICES_METADATA_UPDATE = "services_metadata_update";
        public const string SERVICES_SALESFORCE = "services_salesforce";
        public const string SERVICES_SLACK = "services_slack";
        public const string SERVICES_TEAM_SERVE = "services_team_serve";
        public const string SERVICES_USER_SESSION = "services_user_session";
        public const string SERVICES_USER_UPDATE = "services_user_update";
        public const string SERVICES_USER_UPDATE_ARCHIVING = "services_user_update_archiving";
        public const string SERVICES_USER_UPDATE_BROADCASTS = "services_user_update_broadcasts";
        public const string SERVICES_USER_UPDATE_DOCUMENT_ASSIGNMENT = "services_user_update_document_assignment";
        public const string SERVICES_USER_UPDATE_DOCUMENT_IMPORTS = "services_user_update_document_imports";
        public const string SERVICES_USER_UPDATE_DOCUMENT_SET_ASSIGNMENT = "services_user_update_document_set_assignment";
        public const string SERVICES_USER_UPDATE_ROLES = "services_user_update_roles";
        public const string SERVICES_USER_UPDATE_SHARING = "services_user_update_sharing";
        public const string SERVICES_USER_UPDATE_TEAMS = "services_user_update_teams";
        public const string SERVICES_WORKFLOW_UPDATE = "services_workflow_update";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantQueueChannel).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantQueueChannel(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantQueueChannel(string Val) => new DocConstantQueueChannel(Val);

        public static implicit operator string(DocConstantQueueChannel item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantQueueChannel obj) => this == obj;

        public static bool operator ==(DocConstantQueueChannel x, DocConstantQueueChannel y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantQueueChannel x, DocConstantQueueChannel y) => x == y;
        
        public static bool operator !=(DocConstantQueueChannel x, DocConstantQueueChannel y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantQueueChannel))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantQueueChannel) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantQueueChannel obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
