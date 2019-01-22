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
    public abstract partial class UserSessionBase : Dto<UserSession>
    {
        public UserSessionBase() {}

        public UserSessionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UserSessionBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(ClientId), Description = "string", IsRequired = false)]
        public string ClientId { get; set; }


        [ApiMember(Name = nameof(Hits), Description = "int?", IsRequired = false)]
        public int? Hits { get; set; }


        [ApiMember(Name = nameof(Impersonations), Description = "Impersonation", IsRequired = false)]
        public List<Reference> Impersonations { get; set; }
        public int? ImpersonationsCount { get; set; }


        [ApiMember(Name = nameof(IpAddress), Description = "string", IsRequired = false)]
        public string IpAddress { get; set; }


        [ApiMember(Name = nameof(Requests), Description = "UserRequest", IsRequired = false)]
        public List<Reference> Requests { get; set; }
        public int? RequestsCount { get; set; }


        [ApiMember(Name = nameof(SessionId), Description = "string", IsRequired = false)]
        public string SessionId { get; set; }


        [ApiMember(Name = nameof(TemporarySessionId), Description = "string", IsRequired = false)]
        public string TemporarySessionId { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(UserHistory), Description = "History", IsRequired = false)]
        public List<Reference> UserHistory { get; set; }
        public int? UserHistoryCount { get; set; }


    }

    [Route("/usersession/{Id}", "GET")]
    public partial class UserSession : UserSessionBase, IReturn<UserSession>, IDto
    {
        public UserSession()
        {
            _Constructor();
        }

        public UserSession(int? id) : base(DocConvert.ToInt(id)) {}
        public UserSession(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<UserSession>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Hits),nameof(Impersonations),nameof(ImpersonationsCount),nameof(IpAddress),nameof(Locked),nameof(Requests),nameof(RequestsCount),nameof(SessionId),nameof(TemporarySessionId),nameof(Updated),nameof(User),nameof(UserHistory),nameof(UserHistoryCount),nameof(UserId),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<UserSession>("UserSession",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Impersonations), nameof(ImpersonationsCount), nameof(Requests), nameof(RequestsCount), nameof(UserHistory), nameof(UserHistoryCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/usersession", "GET")]
    [Route("/usersession/search", "GET, POST, DELETE")]
    public partial class UserSessionSearch : Search<UserSession>
    {
        public string ClientId { get; set; }
        public int? Hits { get; set; }
        public List<int> ImpersonationsIds { get; set; }
        public string IpAddress { get; set; }
        public List<int> RequestsIds { get; set; }
        public string SessionId { get; set; }
        public string TemporarySessionId { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public List<int> UserHistoryIds { get; set; }
    }
    
    public class UserSessionFullTextSearch
    {
        private UserSessionSearch _request;
        public UserSessionFullTextSearch(UserSessionSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Updated))); }
        
        public bool doClientId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.ClientId))); }
        public bool doHits { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Hits))); }
        public bool doImpersonations { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Impersonations))); }
        public bool doIpAddress { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.IpAddress))); }
        public bool doRequests { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Requests))); }
        public bool doSessionId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.SessionId))); }
        public bool doTemporarySessionId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.TemporarySessionId))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.User))); }
        public bool doUserHistory { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserSession.UserHistory))); }
    }

    [Route("/usersession/version", "GET, POST")]
    public partial class UserSessionVersion : UserSessionSearch {}

    [Route("/usersession/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UserSessionBatch : List<UserSession> { }

    [Route("/usersession/{Id}/impersonation", "GET, POST, DELETE")]
    [Route("/usersession/{Id}/request", "GET, POST, DELETE")]
    [Route("/usersession/{Id}/history", "GET, POST, DELETE")]
    public class UserSessionJunction : Search<UserSession>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public UserSessionJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/usersession/{Id}/impersonation/version", "GET")]
    [Route("/usersession/{Id}/request/version", "GET")]
    [Route("/usersession/{Id}/history/version", "GET")]
    public class UserSessionJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/usersession/ids", "GET, POST")]
    public class UserSessionIds
    {
        public bool All { get; set; }
    }
}