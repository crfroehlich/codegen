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
    public abstract partial class UserBase : Dto<User>
    {
        public UserBase() {}

        public UserBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UserBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(ClientDepartment), Description = "string", IsRequired = false)]
        public string ClientDepartment { get; set; }


        [ApiMember(Name = nameof(Division), Description = "Division", IsRequired = true)]
        public Reference Division { get; set; }
        [ApiMember(Name = nameof(DivisionId), Description = "Primary Key of Division", IsRequired = false)]
        public int? DivisionId { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(Email), Description = "string", IsRequired = false)]
        public string Email { get; set; }


        [ApiMember(Name = nameof(ExpireDate), Description = "DateTime?", IsRequired = false)]
        public DateTime? ExpireDate { get; set; }


        [ApiMember(Name = nameof(FailedLoginCount), Description = "int?", IsRequired = false)]
        public int? FailedLoginCount { get; set; }


        [ApiMember(Name = nameof(FirstName), Description = "string", IsRequired = false)]
        public string FirstName { get; set; }


        [ApiMember(Name = nameof(Gravatar), Description = "string", IsRequired = false)]
        public string Gravatar { get; set; }


        [ApiMember(Name = nameof(History), Description = "History", IsRequired = false)]
        public List<Reference> History { get; set; }
        public int? HistoryCount { get; set; }


        [ApiMember(Name = nameof(Impersonated), Description = "Impersonation", IsRequired = false)]
        public List<Reference> Impersonated { get; set; }
        public int? ImpersonatedCount { get; set; }


        [ApiMember(Name = nameof(Impersonating), Description = "Impersonation", IsRequired = false)]
        public List<Reference> Impersonating { get; set; }
        public int? ImpersonatingCount { get; set; }


        [ApiMember(Name = nameof(IsSystemUser), Description = "bool?", IsRequired = false)]
        public bool? IsSystemUser { get; private set; }


        [ApiMember(Name = nameof(JobTitle), Description = "string", IsRequired = false)]
        public string JobTitle { get; set; }


        [ApiMember(Name = nameof(LastLogin), Description = "DateTime?", IsRequired = false)]
        public DateTime? LastLogin { get; set; }


        [ApiMember(Name = nameof(LastName), Description = "string", IsRequired = false)]
        public string LastName { get; set; }


        [ApiMember(Name = nameof(LegacyUsername), Description = "string", IsRequired = false)]
        public string LegacyUsername { get; set; }


        [ApiMember(Name = nameof(Locale), Description = "Locale", IsRequired = false)]
        public Reference Locale { get; set; }
        [ApiMember(Name = nameof(LocaleId), Description = "Primary Key of Locale", IsRequired = false)]
        public int? LocaleId { get; set; }


        [ApiMember(Name = nameof(LoginCount), Description = "int?", IsRequired = false)]
        public int? LoginCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Roles), Description = "Role", IsRequired = false)]
        public List<Role> Roles { get; set; }
        public int? RolesCount { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Sessions), Description = "UserSession", IsRequired = false)]
        public List<Reference> Sessions { get; set; }
        public int? SessionsCount { get; set; }


        [ApiMember(Name = nameof(Settings), Description = "UserSettings", IsRequired = false)]
        public UserSettings Settings { get; set; }


        [ApiMember(Name = nameof(Slack), Description = "string", IsRequired = false)]
        public string Slack { get; set; }


        [ApiMember(Name = nameof(StartDate), Description = "DateTime?", IsRequired = false)]
        public DateTime? StartDate { get; set; }


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Inactive",@"Archived",@"Disabled"})]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }


        [ApiMember(Name = nameof(Teams), Description = "Team", IsRequired = false)]
        public List<Reference> Teams { get; set; }
        public int? TeamsCount { get; set; }


        [ApiMember(Name = nameof(TimeCards), Description = "TimeCard", IsRequired = false)]
        public List<Reference> TimeCards { get; set; }
        public int? TimeCardsCount { get; set; }


        [ApiMember(Name = nameof(Updates), Description = "Update", IsRequired = false)]
        public List<Reference> Updates { get; set; }
        public int? UpdatesCount { get; set; }


        [ApiMember(Name = nameof(UserType), Description = "UserType", IsRequired = false)]
        public Reference UserType { get; set; }
        [ApiMember(Name = nameof(UserTypeId), Description = "Primary Key of UserType", IsRequired = false)]
        public int? UserTypeId { get; set; }


        [ApiMember(Name = nameof(Workflows), Description = "Workflow", IsRequired = false)]
        public List<Reference> Workflows { get; set; }
        public int? WorkflowsCount { get; set; }


    }

    [Route("/user", "POST")]
    [Route("/profile/user", "POST")]
    [Route("/user/{Id}", "GET, PATCH, PUT")]
    [Route("/profile/user/{Id}", "GET, PATCH, PUT")]
    public partial class User : UserBase, IReturn<User>, IDto
    {
        public User()
        {
            _Constructor();
        }

        public User(int? id) : base(DocConvert.ToInt(id)) {}
        public User(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (DocTools.AreEqual(nameof(VisibleFields), field)) return false;
            if (DocTools.AreEqual(nameof(Fields), field)) return false;
            if (DocTools.AreEqual(nameof(AssignFields), field)) return false;
            if (DocTools.AreEqual(nameof(IgnoreCache), field)) return false;
            if (DocTools.AreEqual(nameof(Id), field)) return true;
            return true == VisibleFields?.Matches(field, true);
        }

        public static List<string> Fields => DocTools.Fields<User>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(ClientDepartment),nameof(Created),nameof(CreatorId),nameof(Division),nameof(DivisionId),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(Email),nameof(ExpireDate),nameof(FailedLoginCount),nameof(FirstName),nameof(Gestalt),nameof(Gravatar),nameof(History),nameof(HistoryCount),nameof(Impersonated),nameof(ImpersonatedCount),nameof(Impersonating),nameof(ImpersonatingCount),nameof(IsSystemUser),nameof(JobTitle),nameof(LastLogin),nameof(LastName),nameof(LegacyUsername),nameof(Locale),nameof(LocaleId),nameof(Locked),nameof(LoginCount),nameof(Name),nameof(Roles),nameof(RolesCount),nameof(Scopes),nameof(ScopesCount),nameof(Sessions),nameof(SessionsCount),nameof(Settings),nameof(Slack),nameof(StartDate),nameof(Status),nameof(StatusId),nameof(Teams),nameof(TeamsCount),nameof(TimeCards),nameof(TimeCardsCount),nameof(Updated),nameof(Updates),nameof(UpdatesCount),nameof(UserType),nameof(UserTypeId),nameof(VersionNo),nameof(Workflows),nameof(WorkflowsCount)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<User>("User",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(DocumentSets), nameof(DocumentSetsCount), nameof(History), nameof(HistoryCount), nameof(Impersonated), nameof(ImpersonatedCount), nameof(Impersonating), nameof(ImpersonatingCount), nameof(Roles), nameof(RolesCount), nameof(Scopes), nameof(ScopesCount), nameof(Sessions), nameof(SessionsCount), nameof(Teams), nameof(TeamsCount), nameof(TimeCards), nameof(TimeCardsCount), nameof(Updates), nameof(UpdatesCount), nameof(Workflows), nameof(WorkflowsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/User/{Id}/copy", "POST")]
    [Route("/profile/User/{Id}/copy", "POST")]
    public partial class UserCopy : User {}
    [Route("/user", "GET")]
    [Route("/profile/user", "GET")]
    [Route("/user/search", "GET, POST, DELETE")]
    [Route("/profile/user/search", "GET, POST, DELETE")]
    public partial class UserSearch : Search<User>
    {
        public string ClientDepartment { get; set; }
        public Reference Division { get; set; }
        public List<int> DivisionIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public string Email { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ExpireDateAfter { get; set; }
        public DateTime? ExpireDateBefore { get; set; }
        public int? FailedLoginCount { get; set; }
        public string FirstName { get; set; }
        public string Gravatar { get; set; }
        public List<int> HistoryIds { get; set; }
        public List<int> ImpersonatedIds { get; set; }
        public List<int> ImpersonatingIds { get; set; }
        public bool? IsSystemUser { get; private set; }
        public string JobTitle { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? LastLoginAfter { get; set; }
        public DateTime? LastLoginBefore { get; set; }
        public string LastName { get; set; }
        public string LegacyUsername { get; set; }
        public Reference Locale { get; set; }
        public List<int> LocaleIds { get; set; }
        public int? LoginCount { get; set; }
        public string Name { get; set; }
        public List<int> RolesIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public List<int> SessionsIds { get; set; }
        public string Settings { get; set; }
        public string Slack { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartDateAfter { get; set; }
        public DateTime? StartDateBefore { get; set; }
        public Reference Status { get; set; }
        public List<int> StatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Inactive",@"Archived",@"Disabled"})]
        public List<string> StatusNames { get; set; }
        public List<int> TeamsIds { get; set; }
        public List<int> TimeCardsIds { get; set; }
        public List<int> UpdatesIds { get; set; }
        public Reference UserType { get; set; }
        public List<int> UserTypeIds { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }
    
    public class UserFullTextSearch
    {
        private UserSearch _request;
        public UserFullTextSearch(UserSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Updated))); }
        
        public bool doClientDepartment { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.ClientDepartment))); }
        public bool doDivision { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Division))); }
        public bool doDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.DocumentSets))); }
        public bool doEmail { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Email))); }
        public bool doExpireDate { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.ExpireDate))); }
        public bool doFailedLoginCount { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.FailedLoginCount))); }
        public bool doFirstName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.FirstName))); }
        public bool doGravatar { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Gravatar))); }
        public bool doHistory { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.History))); }
        public bool doImpersonated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Impersonated))); }
        public bool doImpersonating { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Impersonating))); }
        public bool doIsSystemUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.IsSystemUser))); }
        public bool doJobTitle { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.JobTitle))); }
        public bool doLastLogin { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.LastLogin))); }
        public bool doLastName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.LastName))); }
        public bool doLegacyUsername { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.LegacyUsername))); }
        public bool doLocale { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Locale))); }
        public bool doLoginCount { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.LoginCount))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Name))); }
        public bool doRoles { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Roles))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Scopes))); }
        public bool doSessions { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Sessions))); }
        public bool doSettings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Settings))); }
        public bool doSlack { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Slack))); }
        public bool doStartDate { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.StartDate))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Status))); }
        public bool doTeams { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Teams))); }
        public bool doTimeCards { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.TimeCards))); }
        public bool doUpdates { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Updates))); }
        public bool doUserType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.UserType))); }
        public bool doWorkflows { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(User.Workflows))); }
    }

    [Route("/user/version", "GET, POST")]
    public partial class UserVersion : UserSearch {}

    [Route("/user/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/user/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UserBatch : List<User> { }

    [Route("/user/{Id}/auditrecord", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/auditrecord", "GET, POST, DELETE")]
    [Route("/user/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/user/{Id}/documentset", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/documentset", "GET, POST, DELETE")]
    [Route("/user/{Id}/history", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/history", "GET, POST, DELETE")]
    [Route("/user/{Id}/impersonateduser", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/impersonateduser", "GET, POST, DELETE")]
    [Route("/user/{Id}/impersonatinguser", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/impersonatinguser", "GET, POST, DELETE")]
    [Route("/user/{Id}/role", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/role", "GET, POST, DELETE")]
    [Route("/user/{Id}/scope", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/scope", "GET, POST, DELETE")]
    [Route("/user/{Id}/session", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/session", "GET, POST, DELETE")]
    [Route("/user/{Id}/team", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/team", "GET, POST, DELETE")]
    [Route("/user/{Id}/timecard", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/timecard", "GET, POST, DELETE")]
    [Route("/user/{Id}/update", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/update", "GET, POST, DELETE")]
    [Route("/user/{Id}/workflow", "GET, POST, DELETE")]
    [Route("/profile/user/{Id}/workflow", "GET, POST, DELETE")]
    public class UserJunction : Search<User>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public UserJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/user/{Id}/auditrecord/version", "GET")]
    [Route("/profile/user/{Id}/auditrecord/version", "GET")]
    [Route("/user/{Id}/lookuptablebinding/version", "GET")]
    [Route("/profile/user/{Id}/lookuptablebinding/version", "GET")]
    [Route("/user/{Id}/documentset/version", "GET")]
    [Route("/profile/user/{Id}/documentset/version", "GET")]
    [Route("/user/{Id}/history/version", "GET")]
    [Route("/profile/user/{Id}/history/version", "GET")]
    [Route("/user/{Id}/impersonateduser/version", "GET")]
    [Route("/profile/user/{Id}/impersonateduser/version", "GET")]
    [Route("/user/{Id}/impersonatinguser/version", "GET")]
    [Route("/profile/user/{Id}/impersonatinguser/version", "GET")]
    [Route("/user/{Id}/role/version", "GET")]
    [Route("/profile/user/{Id}/role/version", "GET")]
    [Route("/user/{Id}/scope/version", "GET")]
    [Route("/profile/user/{Id}/scope/version", "GET")]
    [Route("/user/{Id}/session/version", "GET")]
    [Route("/profile/user/{Id}/session/version", "GET")]
    [Route("/user/{Id}/team/version", "GET")]
    [Route("/profile/user/{Id}/team/version", "GET")]
    [Route("/user/{Id}/timecard/version", "GET")]
    [Route("/profile/user/{Id}/timecard/version", "GET")]
    [Route("/user/{Id}/update/version", "GET")]
    [Route("/profile/user/{Id}/update/version", "GET")]
    [Route("/user/{Id}/workflow/version", "GET")]
    [Route("/profile/user/{Id}/workflow/version", "GET")]
    public class UserJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/user/ids", "GET, POST")]
    public class UserIds
    {
        public bool All { get; set; }
    }
}