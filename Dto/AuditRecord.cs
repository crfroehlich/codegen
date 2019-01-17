﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Security;
using Typed.Settings;

using ServiceStack;
using ServiceStack.Text;

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

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
    
        [ApiMember(Name = nameof(Action), Description = "string", IsRequired = false)]
        public string Action { get; set; }


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


    }

    [Route("/auditrecord/{Id}", "GET")]
    public partial class AuditRecord : AuditRecordBase, IReturn<AuditRecord>, IDto
    {
        public AuditRecord()
        {
            _Constructor();
        }

        public AuditRecord(int? id) : base(DocConvert.ToInt(id)) {}
        public AuditRecord(int id) : base(id) {}
        
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
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Action),nameof(ChangedOnDate),nameof(Created),nameof(CreatorId),nameof(Data),nameof(DatabaseSessionId),nameof(Deltas),nameof(DeltasCount),nameof(EntityId),nameof(EntityType),nameof(EntityVersion),nameof(Gestalt),nameof(Impersonation),nameof(ImpersonationId),nameof(Locked),nameof(TargetId),nameof(TargetType),nameof(TargetVersion),nameof(Updated),nameof(User),nameof(UserId),nameof(UserSession),nameof(UserSessionId),nameof(VersionNo)})]
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
            nameof(Deltas), nameof(DeltasCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/auditrecord", "GET")]
    [Route("/auditrecord/search", "GET, POST, DELETE")]
    public partial class AuditRecordSearch : Search<AuditRecord>
    {
        public string Action { get; set; }
        public DateTime? ChangedOnDate { get; set; }
        public DateTime? ChangedOnDateAfter { get; set; }
        public DateTime? ChangedOnDateBefore { get; set; }
        public string Data { get; set; }
        public string DatabaseSessionId { get; set; }
        public List<int> DeltasIds { get; set; }
        public int? EntityId { get; set; }
        public string EntityType { get; set; }
        public int? EntityVersion { get; set; }
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
    
    public class AuditRecordFullTextSearch
    {
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
        public bool doChangedOnDate { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.ChangedOnDate))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Data))); }
        public bool doDatabaseSessionId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.DatabaseSessionId))); }
        public bool doDeltas { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Deltas))); }
        public bool doEntityId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.EntityId))); }
        public bool doEntityType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.EntityType))); }
        public bool doEntityVersion { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.EntityVersion))); }
        public bool doImpersonation { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.Impersonation))); }
        public bool doTargetId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.TargetId))); }
        public bool doTargetType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.TargetType))); }
        public bool doTargetVersion { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.TargetVersion))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.User))); }
        public bool doUserSession { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditRecord.UserSession))); }
    }

    [Route("/auditrecord/version", "GET, POST")]
    public partial class AuditRecordVersion : AuditRecordSearch {}

    [Route("/auditrecord/batch", "DELETE, PATCH, POST, PUT")]
    public partial class AuditRecordBatch : List<AuditRecord> { }

    [Route("/auditrecord/{Id}/auditdelta", "GET, POST, DELETE")]
    public class AuditRecordJunction : Search<AuditRecord>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public AuditRecordJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/auditrecord/{Id}/auditdelta/version", "GET")]
    public class AuditRecordJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/auditrecord/ids", "GET, POST")]
    public class AuditRecordIds
    {
        public bool All { get; set; }
    }
}