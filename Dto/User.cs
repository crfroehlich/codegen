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
    public abstract partial class UserBase : Dto<User>
    {
        public UserBase() {}

        public UserBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UserBase(int? id) : this(DocConvert.ToInt(id)) {}

        public UserBase(int? pId, string pClientDepartment, Reference pDivision, int? pDivisionId, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pEmail, DateTime? pExpireDate, int? pFailedLoginCount, string pFirstName, string pGravatar, List<Reference> pHistory, int? pHistoryCount, List<Reference> pImpersonated, int? pImpersonatedCount, List<Reference> pImpersonating, int? pImpersonatingCount, bool? pIsSystemUser, string pJobTitle, DateTime? pLastLogin, string pLastName, string pLegacyUsername, Reference pLocale, int? pLocaleId, int? pLoginCount, string pName, List<Role> pRoles, int? pRolesCount, List<Reference> pScopes, int? pScopesCount, List<Reference> pSessions, int? pSessionsCount, JsonObject pSettings, string pSlack, DateTime? pStartDate, Reference pStatus, int? pStatusId, List<Reference> pTeams, int? pTeamsCount, List<Reference> pTimeCards, int? pTimeCardsCount, List<Reference> pUpdates, int? pUpdatesCount, Reference pUserType, int? pUserTypeId, List<Reference> pWorkflows, int? pWorkflowsCount) : this(DocConvert.ToInt(pId)) 
        {
            ClientDepartment = pClientDepartment;
            Division = pDivision;
            DivisionId = pDivisionId;
            DocumentSets = pDocumentSets;
            DocumentSetsCount = pDocumentSetsCount;
            Email = pEmail;
            ExpireDate = pExpireDate;
            FailedLoginCount = pFailedLoginCount;
            FirstName = pFirstName;
            Gravatar = pGravatar;
            History = pHistory;
            HistoryCount = pHistoryCount;
            Impersonated = pImpersonated;
            ImpersonatedCount = pImpersonatedCount;
            Impersonating = pImpersonating;
            ImpersonatingCount = pImpersonatingCount;
            IsSystemUser = pIsSystemUser;
            JobTitle = pJobTitle;
            LastLogin = pLastLogin;
            LastName = pLastName;
            LegacyUsername = pLegacyUsername;
            Locale = pLocale;
            LocaleId = pLocaleId;
            LoginCount = pLoginCount;
            Name = pName;
            Roles = pRoles;
            RolesCount = pRolesCount;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Sessions = pSessions;
            SessionsCount = pSessionsCount;
            Settings = pSettings;
            Slack = pSlack;
            StartDate = pStartDate;
            Status = pStatus;
            StatusId = pStatusId;
            Teams = pTeams;
            TeamsCount = pTeamsCount;
            TimeCards = pTimeCards;
            TimeCardsCount = pTimeCardsCount;
            Updates = pUpdates;
            UpdatesCount = pUpdatesCount;
            UserType = pUserType;
            UserTypeId = pUserTypeId;
            Workflows = pWorkflows;
            WorkflowsCount = pWorkflowsCount;
        }

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


        [ApiMember(Name = nameof(Settings), Description = "JsonObject", IsRequired = false)]
        public JsonObject Settings { get; set; }


        [ApiMember(Name = nameof(Slack), Description = "string", IsRequired = false)]
        public string Slack { get; set; }


        [ApiMember(Name = nameof(StartDate), Description = "DateTime?", IsRequired = false)]
        public DateTime? StartDate { get; set; }


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Archived",@"Disabled",@"Inactive"})]
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



        public void Deconstruct(out string pClientDepartment, out Reference pDivision, out int? pDivisionId, out List<Reference> pDocumentSets, out int? pDocumentSetsCount, out string pEmail, out DateTime? pExpireDate, out int? pFailedLoginCount, out string pFirstName, out string pGravatar, out List<Reference> pHistory, out int? pHistoryCount, out List<Reference> pImpersonated, out int? pImpersonatedCount, out List<Reference> pImpersonating, out int? pImpersonatingCount, out bool? pIsSystemUser, out string pJobTitle, out DateTime? pLastLogin, out string pLastName, out string pLegacyUsername, out Reference pLocale, out int? pLocaleId, out int? pLoginCount, out string pName, out List<Role> pRoles, out int? pRolesCount, out List<Reference> pScopes, out int? pScopesCount, out List<Reference> pSessions, out int? pSessionsCount, out JsonObject pSettings, out string pSlack, out DateTime? pStartDate, out Reference pStatus, out int? pStatusId, out List<Reference> pTeams, out int? pTeamsCount, out List<Reference> pTimeCards, out int? pTimeCardsCount, out List<Reference> pUpdates, out int? pUpdatesCount, out Reference pUserType, out int? pUserTypeId, out List<Reference> pWorkflows, out int? pWorkflowsCount)
        {
            pClientDepartment = ClientDepartment;
            pDivision = Division;
            pDivisionId = DivisionId;
            pDocumentSets = DocumentSets;
            pDocumentSetsCount = DocumentSetsCount;
            pEmail = Email;
            pExpireDate = ExpireDate;
            pFailedLoginCount = FailedLoginCount;
            pFirstName = FirstName;
            pGravatar = Gravatar;
            pHistory = History;
            pHistoryCount = HistoryCount;
            pImpersonated = Impersonated;
            pImpersonatedCount = ImpersonatedCount;
            pImpersonating = Impersonating;
            pImpersonatingCount = ImpersonatingCount;
            pIsSystemUser = IsSystemUser;
            pJobTitle = JobTitle;
            pLastLogin = LastLogin;
            pLastName = LastName;
            pLegacyUsername = LegacyUsername;
            pLocale = Locale;
            pLocaleId = LocaleId;
            pLoginCount = LoginCount;
            pName = Name;
            pRoles = Roles;
            pRolesCount = RolesCount;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pSessions = Sessions;
            pSessionsCount = SessionsCount;
            pSettings = Settings;
            pSlack = Slack;
            pStartDate = StartDate;
            pStatus = Status;
            pStatusId = StatusId;
            pTeams = Teams;
            pTeamsCount = TeamsCount;
            pTimeCards = TimeCards;
            pTimeCardsCount = TimeCardsCount;
            pUpdates = Updates;
            pUpdatesCount = UpdatesCount;
            pUserType = UserType;
            pUserTypeId = UserTypeId;
            pWorkflows = Workflows;
            pWorkflowsCount = WorkflowsCount;
        }

        //Not ready until C# v8.?
        //public UserBase With(int? pId = Id, string pClientDepartment = ClientDepartment, Reference pDivision = Division, int? pDivisionId = DivisionId, List<Reference> pDocumentSets = DocumentSets, int? pDocumentSetsCount = DocumentSetsCount, string pEmail = Email, DateTime? pExpireDate = ExpireDate, int? pFailedLoginCount = FailedLoginCount, string pFirstName = FirstName, string pGravatar = Gravatar, List<Reference> pHistory = History, int? pHistoryCount = HistoryCount, List<Reference> pImpersonated = Impersonated, int? pImpersonatedCount = ImpersonatedCount, List<Reference> pImpersonating = Impersonating, int? pImpersonatingCount = ImpersonatingCount, bool? pIsSystemUser = IsSystemUser, string pJobTitle = JobTitle, DateTime? pLastLogin = LastLogin, string pLastName = LastName, string pLegacyUsername = LegacyUsername, Reference pLocale = Locale, int? pLocaleId = LocaleId, int? pLoginCount = LoginCount, string pName = Name, List<Role> pRoles = Roles, int? pRolesCount = RolesCount, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, List<Reference> pSessions = Sessions, int? pSessionsCount = SessionsCount, JsonObject pSettings = Settings, string pSlack = Slack, DateTime? pStartDate = StartDate, Reference pStatus = Status, int? pStatusId = StatusId, List<Reference> pTeams = Teams, int? pTeamsCount = TeamsCount, List<Reference> pTimeCards = TimeCards, int? pTimeCardsCount = TimeCardsCount, List<Reference> pUpdates = Updates, int? pUpdatesCount = UpdatesCount, Reference pUserType = UserType, int? pUserTypeId = UserTypeId, List<Reference> pWorkflows = Workflows, int? pWorkflowsCount = WorkflowsCount) => 
        //	new UserBase(pId, pClientDepartment, pDivision, pDivisionId, pDocumentSets, pDocumentSetsCount, pEmail, pExpireDate, pFailedLoginCount, pFirstName, pGravatar, pHistory, pHistoryCount, pImpersonated, pImpersonatedCount, pImpersonating, pImpersonatingCount, pIsSystemUser, pJobTitle, pLastLogin, pLastName, pLegacyUsername, pLocale, pLocaleId, pLoginCount, pName, pRoles, pRolesCount, pScopes, pScopesCount, pSessions, pSessionsCount, pSettings, pSlack, pStartDate, pStatus, pStatusId, pTeams, pTeamsCount, pTimeCards, pTimeCardsCount, pUpdates, pUpdatesCount, pUserType, pUserTypeId, pWorkflows, pWorkflowsCount);

    }

    [Route("/user", "POST")]
    [Route("/user/{Id}", "GET, PATCH, PUT")]
    public partial class User : UserBase, IReturn<User>, IDto, ICloneable
    {
        public User()
        {
            _Constructor();
        }

        public User(int? id) : base(DocConvert.ToInt(id)) {}
        public User(int id) : base(id) {}
        public User(int? pId, string pClientDepartment, Reference pDivision, int? pDivisionId, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pEmail, DateTime? pExpireDate, int? pFailedLoginCount, string pFirstName, string pGravatar, List<Reference> pHistory, int? pHistoryCount, List<Reference> pImpersonated, int? pImpersonatedCount, List<Reference> pImpersonating, int? pImpersonatingCount, bool? pIsSystemUser, string pJobTitle, DateTime? pLastLogin, string pLastName, string pLegacyUsername, Reference pLocale, int? pLocaleId, int? pLoginCount, string pName, List<Role> pRoles, int? pRolesCount, List<Reference> pScopes, int? pScopesCount, List<Reference> pSessions, int? pSessionsCount, JsonObject pSettings, string pSlack, DateTime? pStartDate, Reference pStatus, int? pStatusId, List<Reference> pTeams, int? pTeamsCount, List<Reference> pTimeCards, int? pTimeCardsCount, List<Reference> pUpdates, int? pUpdatesCount, Reference pUserType, int? pUserTypeId, List<Reference> pWorkflows, int? pWorkflowsCount) : 
            base(pId, pClientDepartment, pDivision, pDivisionId, pDocumentSets, pDocumentSetsCount, pEmail, pExpireDate, pFailedLoginCount, pFirstName, pGravatar, pHistory, pHistoryCount, pImpersonated, pImpersonatedCount, pImpersonating, pImpersonatingCount, pIsSystemUser, pJobTitle, pLastLogin, pLastName, pLegacyUsername, pLocale, pLocaleId, pLoginCount, pName, pRoles, pRolesCount, pScopes, pScopesCount, pSessions, pSessionsCount, pSettings, pSlack, pStartDate, pStatus, pStatusId, pTeams, pTeamsCount, pTimeCards, pTimeCardsCount, pUpdates, pUpdatesCount, pUserType, pUserTypeId, pWorkflows, pWorkflowsCount) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
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

        public object Clone() => this.Copy<User>();
    }
    
    [Route("/user/{Id}/copy", "POST")]
    public partial class UserCopy : User {}
    public partial class UserSearchBase : Search<User>
    {
        public int? Id { get; set; }
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
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false", "null"})]
        public List<bool?> IsSystemUser { get; set; }
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
        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Archived",@"Disabled",@"Inactive"})]
        public List<string> StatusNames { get; set; }
        public List<int> TeamsIds { get; set; }
        public List<int> TimeCardsIds { get; set; }
        public List<int> UpdatesIds { get; set; }
        public Reference UserType { get; set; }
        public List<int> UserTypeIds { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }

    [Route("/user", "GET")]
    [Route("/user/version", "GET, POST")]
    [Route("/user/search", "GET, POST, DELETE")]
    public partial class UserSearch : UserSearchBase
    {
    }

    public class UserFullTextSearch
    {
        public UserFullTextSearch() {}
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

    [Route("/user/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UserBatch : List<User> { }

    [Route("/user/{Id}/{Junction}/version", "GET, POST")]
    [Route("/user/{Id}/{Junction}", "GET, POST, DELETE")]
    public class UserJunction : UserSearchBase {}


}
