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
    public abstract partial class EventBase : Dto<Event>
    {
        public EventBase() {}

        public EventBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public EventBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(AuditRecord), Description = "AuditRecord", IsRequired = true)]
        public Reference AuditRecord { get; set; }
        [ApiMember(Name = nameof(AuditRecordId), Description = "Primary Key of AuditRecord", IsRequired = false)]
        public int? AuditRecordId { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Processed), Description = "DateTime?", IsRequired = false)]
        public DateTime? Processed { get; set; }


        [ApiMember(Name = nameof(Status), Description = "string", IsRequired = false)]
        public string Status { get; set; }


        [ApiMember(Name = nameof(Teams), Description = "Team", IsRequired = false)]
        public List<Reference> Teams { get; set; }
        public int? TeamsCount { get; set; }


        [ApiMember(Name = nameof(Updates), Description = "Update", IsRequired = false)]
        public List<Reference> Updates { get; set; }
        public int? UpdatesCount { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public int? UsersCount { get; set; }


    }

    [Route("/event/{Id}", "GET")]
    public partial class Event : EventBase, IReturn<Event>, IDto
    {
        public Event()
        {
            _Constructor();
        }

        public Event(int? id) : base(DocConvert.ToInt(id)) {}
        public Event(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Event>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AuditRecord),nameof(AuditRecordId),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Processed),nameof(Status),nameof(Teams),nameof(TeamsCount),nameof(Updated),nameof(Updates),nameof(UpdatesCount),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Event>("Event",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Teams), nameof(TeamsCount), nameof(Updates), nameof(UpdatesCount), nameof(Users), nameof(UsersCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/event", "GET")]
    [Route("/event/search", "GET, POST, DELETE")]
    public partial class EventSearch : Search<Event>
    {
        public Reference AuditRecord { get; set; }
        public List<int> AuditRecordIds { get; set; }
        public string Description { get; set; }
        public DateTime? Processed { get; set; }
        public DateTime? ProcessedAfter { get; set; }
        public DateTime? ProcessedBefore { get; set; }
        public string Status { get; set; }
        public List<int> TeamsIds { get; set; }
        public List<int> UpdatesIds { get; set; }
        public List<int> UsersIds { get; set; }
    }
    
    public class EventFullTextSearch
    {
        private EventSearch _request;
        public EventFullTextSearch(EventSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.Updated))); }
        
        public bool doAuditRecord { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.AuditRecord))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.Description))); }
        public bool doProcessed { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.Processed))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.Status))); }
        public bool doTeams { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.Teams))); }
        public bool doUpdates { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.Updates))); }
        public bool doUsers { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Event.Users))); }
    }

    [Route("/event/version", "GET, POST")]
    public partial class EventVersion : EventSearch {}

    [Route("/event/batch", "DELETE, PATCH, POST, PUT")]
    public partial class EventBatch : List<Event> { }

    [Route("/event/{Id}/team", "GET, POST, DELETE")]
    [Route("/event/{Id}/update", "GET, POST, DELETE")]
    [Route("/event/{Id}/user", "GET, POST, DELETE")]
    public class EventJunction : Search<Event>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public EventJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/event/{Id}/team/version", "GET")]
    [Route("/event/{Id}/update/version", "GET")]
    [Route("/event/{Id}/user/version", "GET")]
    public class EventJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/event/ids", "GET, POST")]
    public class EventIds
    {
        public bool All { get; set; }
    }
}