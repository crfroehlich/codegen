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

namespace Services.Dto
{
    public abstract partial class AuditRecordBase : Dto<AuditRecord>
    {
        public AuditRecordBase() {}

        public AuditRecordBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public AuditRecordBase(int? id) : this(DocConvert.ToInt(id)) {}

        public AuditRecordBase(int? pId, string pAction, Reference pBackgroundTask, int? pBackgroundTaskId, DateTime? pChangedOnDate, string pData, string pDatabaseSessionId, List<Reference> pDeltas, int? pDeltasCount, int? pEntityId, string pEntityType, int? pEntityVersion, List<Reference> pEvents, int? pEventsCount, Reference pImpersonation, int? pImpersonationId, int? pTargetId, string pTargetType, int? pTargetVersion, Reference pUser, int? pUserId, Reference pUserSession, int? pUserSessionId) : this(DocConvert.ToInt(pId)) 
        {
            Action = pAction;
            BackgroundTask = pBackgroundTask;
            BackgroundTaskId = pBackgroundTaskId;
            ChangedOnDate = pChangedOnDate;
            Data = pData;
            DatabaseSessionId = pDatabaseSessionId;
            Deltas = pDeltas;
            DeltasCount = pDeltasCount;
            EntityId = pEntityId;
            EntityType = pEntityType;
            EntityVersion = pEntityVersion;
            Events = pEvents;
            EventsCount = pEventsCount;
            Impersonation = pImpersonation;
            ImpersonationId = pImpersonationId;
            TargetId = pTargetId;
            TargetType = pTargetType;
            TargetVersion = pTargetVersion;
            User = pUser;
            UserId = pUserId;
            UserSession = pUserSession;
            UserSessionId = pUserSessionId;
        }

        [ApiMember(Name = nameof(Action), Description = "string", IsRequired = false)]
        public string Action { get; set; }


        [ApiMember(Name = nameof(BackgroundTask), Description = "BackgroundTask", IsRequired = false)]
        public Reference BackgroundTask { get; set; }
        [ApiMember(Name = nameof(BackgroundTaskId), Description = "Primary Key of BackgroundTask", IsRequired = false)]
        public int? BackgroundTaskId { get; set; }


        [ApiMember(Name = nameof(ChangedOnDate), Description = "DateTime?", IsRequired = true)]
        public DateTime? ChangedOnDate { get; set; }


        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        public string Data { get; set; }


        [ApiMember(Name = nameof(DatabaseSessionId), Description = "string", IsRequired = false)]
        public string DatabaseSessionId { get; set; }


        [ApiMember(Name = nameof(Deltas), Description = "AuditDelta", IsRequired = false)]
        public List<Reference> Deltas { get; set; }
        public int? DeltasCount { get; set; }


        [ApiMember(Name = nameof(EntityId), Description = "int?", IsRequired = false)]
        public int? EntityId { get; set; }


        [ApiMember(Name = nameof(EntityType), Description = "string", IsRequired = false)]
        public string EntityType { get; set; }


        [ApiMember(Name = nameof(EntityVersion), Description = "int?", IsRequired = false)]
        public int? EntityVersion { get; set; }


        [ApiMember(Name = nameof(Events), Description = "Event", IsRequired = false)]
        public List<Reference> Events { get; set; }
        public int? EventsCount { get; set; }


        [ApiMember(Name = nameof(Impersonation), Description = "Impersonation", IsRequired = false)]
        public Reference Impersonation { get; set; }
        [ApiMember(Name = nameof(ImpersonationId), Description = "Primary Key of Impersonation", IsRequired = false)]
        public int? ImpersonationId { get; set; }


        [ApiMember(Name = nameof(TargetId), Description = "int?", IsRequired = false)]
        public int? TargetId { get; set; }


        [ApiMember(Name = nameof(TargetType), Description = "string", IsRequired = false)]
        public string TargetType { get; set; }


        [ApiMember(Name = nameof(TargetVersion), Description = "int?", IsRequired = false)]
        public int? TargetVersion { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = false)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(UserSession), Description = "UserSession", IsRequired = false)]
        public Reference UserSession { get; set; }
        [ApiMember(Name = nameof(UserSessionId), Description = "Primary Key of UserSession", IsRequired = false)]
        public int? UserSessionId { get; set; }



        public void Deconstruct(out string pAction, out Reference pBackgroundTask, out int? pBackgroundTaskId, out DateTime? pChangedOnDate, out string pData, out string pDatabaseSessionId, out List<Reference> pDeltas, out int? pDeltasCount, out int? pEntityId, out string pEntityType, out int? pEntityVersion, out List<Reference> pEvents, out int? pEventsCount, out Reference pImpersonation, out int? pImpersonationId, out int? pTargetId, out string pTargetType, out int? pTargetVersion, out Reference pUser, out int? pUserId, out Reference pUserSession, out int? pUserSessionId)
        {
            pAction = Action;
            pBackgroundTask = BackgroundTask;
            pBackgroundTaskId = BackgroundTaskId;
            pChangedOnDate = ChangedOnDate;
            pData = Data;
            pDatabaseSessionId = DatabaseSessionId;
            pDeltas = Deltas;
            pDeltasCount = DeltasCount;
            pEntityId = EntityId;
            pEntityType = EntityType;
            pEntityVersion = EntityVersion;
            pEvents = Events;
            pEventsCount = EventsCount;
            pImpersonation = Impersonation;
            pImpersonationId = ImpersonationId;
            pTargetId = TargetId;
            pTargetType = TargetType;
            pTargetVersion = TargetVersion;
            pUser = User;
            pUserId = UserId;
            pUserSession = UserSession;
            pUserSessionId = UserSessionId;
        }

        //Not ready until C# v8.?
        //public AuditRecordBase With(int? pId = Id, string pAction = Action, Reference pBackgroundTask = BackgroundTask, int? pBackgroundTaskId = BackgroundTaskId, DateTime? pChangedOnDate = ChangedOnDate, string pData = Data, string pDatabaseSessionId = DatabaseSessionId, List<Reference> pDeltas = Deltas, int? pDeltasCount = DeltasCount, int? pEntityId = EntityId, string pEntityType = EntityType, int? pEntityVersion = EntityVersion, List<Reference> pEvents = Events, int? pEventsCount = EventsCount, Reference pImpersonation = Impersonation, int? pImpersonationId = ImpersonationId, int? pTargetId = TargetId, string pTargetType = TargetType, int? pTargetVersion = TargetVersion, Reference pUser = User, int? pUserId = UserId, Reference pUserSession = UserSession, int? pUserSessionId = UserSessionId) => 
        //	new AuditRecordBase(pId, pAction, pBackgroundTask, pBackgroundTaskId, pChangedOnDate, pData, pDatabaseSessionId, pDeltas, pDeltasCount, pEntityId, pEntityType, pEntityVersion, pEvents, pEventsCount, pImpersonation, pImpersonationId, pTargetId, pTargetType, pTargetVersion, pUser, pUserId, pUserSession, pUserSessionId);

    }

    [Route("/auditrecord/{Id}", "GET")]
    public partial class AuditRecord : AuditRecordBase, IReturn<AuditRecord>, IDto, ICloneable
    {
        public AuditRecord()
        {
            _Constructor();
        }

        public AuditRecord(int? id) : base(DocConvert.ToInt(id)) {}
        public AuditRecord(int id) : base(id) {}
        public AuditRecord(int? pId, string pAction, Reference pBackgroundTask, int? pBackgroundTaskId, DateTime? pChangedOnDate, string pData, string pDatabaseSessionId, List<Reference> pDeltas, int? pDeltasCount, int? pEntityId, string pEntityType, int? pEntityVersion, List<Reference> pEvents, int? pEventsCount, Reference pImpersonation, int? pImpersonationId, int? pTargetId, string pTargetType, int? pTargetVersion, Reference pUser, int? pUserId, Reference pUserSession, int? pUserSessionId) : 
            base(pId, pAction, pBackgroundTask, pBackgroundTaskId, pChangedOnDate, pData, pDatabaseSessionId, pDeltas, pDeltasCount, pEntityId, pEntityType, pEntityVersion, pEvents, pEventsCount, pImpersonation, pImpersonationId, pTargetId, pTargetType, pTargetVersion, pUser, pUserId, pUserSession, pUserSessionId) { }
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<AuditRecord>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Action),nameof(BackgroundTask),nameof(BackgroundTaskId),nameof(ChangedOnDate),nameof(Created),nameof(CreatorId),nameof(Data),nameof(DatabaseSessionId),nameof(Deltas),nameof(DeltasCount),nameof(EntityId),nameof(EntityType),nameof(EntityVersion),nameof(Events),nameof(EventsCount),nameof(Gestalt),nameof(Impersonation),nameof(ImpersonationId),nameof(Locked),nameof(TargetId),nameof(TargetType),nameof(TargetVersion),nameof(Updated),nameof(User),nameof(UserId),nameof(UserSession),nameof(UserSessionId),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocWebSession.GetTypeVisibleFields(this);
                }
                return _VisibleFields;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _VisibleFields = DocPermissionFactory.SetVisibleFields<AuditRecord>("AuditRecord",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Deltas), nameof(DeltasCount), nameof(Events), nameof(EventsCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<AuditRecord>();
    }
    
    public partial class AuditRecordSearchBase : Search<AuditRecord>
    {
        public int? Id { get; set; }
        public string Action { get; set; }
        public Reference BackgroundTask { get; set; }
        public List<int> BackgroundTaskIds { get; set; }
        public DateTime? ChangedOnDate { get; set; }
        public DateTime? ChangedOnDateAfter { get; set; }
        public DateTime? ChangedOnDateBefore { get; set; }
        public string Data { get; set; }
        public string DatabaseSessionId { get; set; }
        public List<int> DeltasIds { get; set; }
        public int? EntityId { get; set; }
        public string EntityType { get; set; }
        public int? EntityVersion { get; set; }
        public List<int> EventsIds { get; set; }
        public Reference Impersonation { get; set; }
        public List<int> ImpersonationIds { get; set; }
        public int? TargetId { get; set; }
        public string TargetType { get; set; }
        public int? TargetVersion { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public Reference UserSession { get; set; }
        public List<int> UserSessionIds { get; set; }
    }

    [Route("/auditrecord", "GET")]
    [Route("/auditrecord/version", "GET, POST")]
    [Route("/auditrecord/search", "GET, POST, DELETE")]
    public partial class AuditRecordSearch : AuditRecordSearchBase
    {
    }

    public class AuditRecordFullTextSearch
    {
        public AuditRecordFullTextSearch() {}
        private AuditRecordSearch _request;
        public AuditRecordFullTextSearch(AuditRecordSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Updated))); }

        public bool doAction { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Action))); }
        public bool doBackgroundTask { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.BackgroundTask))); }
        public bool doChangedOnDate { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.ChangedOnDate))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Data))); }
        public bool doDatabaseSessionId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.DatabaseSessionId))); }
        public bool doDeltas { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Deltas))); }
        public bool doEntityId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.EntityId))); }
        public bool doEntityType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.EntityType))); }
        public bool doEntityVersion { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.EntityVersion))); }
        public bool doEvents { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Events))); }
        public bool doImpersonation { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Impersonation))); }
        public bool doTargetId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.TargetId))); }
        public bool doTargetType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.TargetType))); }
        public bool doTargetVersion { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.TargetVersion))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.User))); }
        public bool doUserSession { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.UserSession))); }
    }

    public partial class AuditRecordBatch : List<AuditRecord> { }

    [Route("/auditrecord/{Id}/{Junction}/version", "GET, POST")]
    [Route("/auditrecord/{Id}/{Junction}", "GET, POST, DELETE")]
    public class AuditRecordJunction : AuditRecordSearchBase {}


}
