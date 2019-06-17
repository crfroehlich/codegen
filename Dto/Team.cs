//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;


namespace Services.Dto
{
    public abstract partial class TeamBase : Dto<Team>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TeamBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TeamBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TeamBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TeamBase(int? pId, List<Reference> pAdminRoles, int? pAdminRolesCount, string pDescription, string pEmail, bool pIsInternal, string pName, Reference pOwner, int? pOwnerId, List<Reference> pScopes, int? pScopesCount, TeamSettings pSettings, string pSlack, List<Reference> pUpdates, int? pUpdatesCount, List<Reference> pUsers, int? pUsersCount) : this(DocConvert.ToInt(pId)) 
        {
            AdminRoles = pAdminRoles;
            AdminRolesCount = pAdminRolesCount;
            Description = pDescription;
            Email = pEmail;
            IsInternal = pIsInternal;
            Name = pName;
            Owner = pOwner;
            OwnerId = pOwnerId;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Settings = pSettings;
            Slack = pSlack;
            Updates = pUpdates;
            UpdatesCount = pUpdatesCount;
            Users = pUsers;
            UsersCount = pUsersCount;
        }

        [ApiMember(Name = nameof(AdminRoles), Description = "Role", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> AdminRoles { get; set; }
        [ApiMember(Name = nameof(AdminRolesIds), Description = "Role Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> AdminRolesIds { get; set; }
        [ApiMember(Name = nameof(AdminRolesCount), Description = "Role Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? AdminRolesCount { get; set; }

        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Description { get; set; }
        [ApiMember(Name = nameof(DescriptionIds), Description = "Description Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DescriptionIds { get; set; }
        [ApiMember(Name = nameof(DescriptionCount), Description = "Description Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DescriptionCount { get; set; }

        [ApiMember(Name = nameof(Email), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Email { get; set; }
        [ApiMember(Name = nameof(EmailIds), Description = "Email Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> EmailIds { get; set; }
        [ApiMember(Name = nameof(EmailCount), Description = "Email Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? EmailCount { get; set; }

        [ApiMember(Name = nameof(IsInternal), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool IsInternal { get; set; }
        [ApiMember(Name = nameof(IsInternalIds), Description = "IsInternal Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> IsInternalIds { get; set; }
        [ApiMember(Name = nameof(IsInternalCount), Description = "IsInternal Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? IsInternalCount { get; set; }

        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Name { get; set; }
        [ApiMember(Name = nameof(NameIds), Description = "Name Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> NameIds { get; set; }
        [ApiMember(Name = nameof(NameCount), Description = "Name Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? NameCount { get; set; }

        [ApiMember(Name = nameof(Owner), Description = "User", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of User", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? OwnerId { get; set; }

        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Scopes { get; set; }
        [ApiMember(Name = nameof(ScopesIds), Description = "Scope Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ScopesIds { get; set; }
        [ApiMember(Name = nameof(ScopesCount), Description = "Scope Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ScopesCount { get; set; }

        [ApiMember(Name = nameof(Settings), Description = "TeamSettings", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TeamSettings Settings { get; set; }
        [ApiMember(Name = nameof(SettingsIds), Description = "Settings Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> SettingsIds { get; set; }
        [ApiMember(Name = nameof(SettingsCount), Description = "Settings Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? SettingsCount { get; set; }

        [ApiMember(Name = nameof(Slack), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Slack { get; set; }
        [ApiMember(Name = nameof(SlackIds), Description = "Slack Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> SlackIds { get; set; }
        [ApiMember(Name = nameof(SlackCount), Description = "Slack Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? SlackCount { get; set; }

        [ApiMember(Name = nameof(Updates), Description = "Update", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Updates { get; set; }
        [ApiMember(Name = nameof(UpdatesIds), Description = "Update Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> UpdatesIds { get; set; }
        [ApiMember(Name = nameof(UpdatesCount), Description = "Update Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? UpdatesCount { get; set; }

        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Users { get; set; }
        [ApiMember(Name = nameof(UsersIds), Description = "User Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> UsersIds { get; set; }
        [ApiMember(Name = nameof(UsersCount), Description = "User Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? UsersCount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out List<Reference> pAdminRoles, out int? pAdminRolesCount, out string pDescription, out string pEmail, out bool pIsInternal, out string pName, out Reference pOwner, out int? pOwnerId, out List<Reference> pScopes, out int? pScopesCount, out TeamSettings pSettings, out string pSlack, out List<Reference> pUpdates, out int? pUpdatesCount, out List<Reference> pUsers, out int? pUsersCount)
        {
            pAdminRoles = AdminRoles;
            pAdminRolesCount = AdminRolesCount;
            pDescription = Description;
            pEmail = Email;
            pIsInternal = IsInternal;
            pName = Name;
            pOwner = Owner;
            pOwnerId = OwnerId;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pSettings = Settings;
            pSlack = Slack;
            pUpdates = Updates;
            pUpdatesCount = UpdatesCount;
            pUsers = Users;
            pUsersCount = UsersCount;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public TeamBase With(int? pId = Id, List<Reference> pAdminRoles = AdminRoles, int? pAdminRolesCount = AdminRolesCount, string pDescription = Description, string pEmail = Email, bool pIsInternal = IsInternal, string pName = Name, Reference pOwner = Owner, int? pOwnerId = OwnerId, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, TeamSettings pSettings = Settings, string pSlack = Slack, List<Reference> pUpdates = Updates, int? pUpdatesCount = UpdatesCount, List<Reference> pUsers = Users, int? pUsersCount = UsersCount) => 
        //	new TeamBase(pId, pAdminRoles, pAdminRolesCount, pDescription, pEmail, pIsInternal, pName, pOwner, pOwnerId, pScopes, pScopesCount, pSettings, pSlack, pUpdates, pUpdatesCount, pUsers, pUsersCount);

    }


    [Route("/team", "POST")]
    [Route("/team/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Team : TeamBase, IReturn<Team>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Team() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Team(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Team(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Team(int? pId, List<Reference> pAdminRoles, int? pAdminRolesCount, string pDescription, string pEmail, bool pIsInternal, string pName, Reference pOwner, int? pOwnerId, List<Reference> pScopes, int? pScopesCount, TeamSettings pSettings, string pSlack, List<Reference> pUpdates, int? pUpdatesCount, List<Reference> pUsers, int? pUsersCount) :
            base(pId, pAdminRoles, pAdminRolesCount, pDescription, pEmail, pIsInternal, pName, pOwner, pOwnerId, pScopes, pScopesCount, pSettings, pSlack, pUpdates, pUpdatesCount, pUsers, pUsersCount) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<Team>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AdminRoles),nameof(AdminRolesCount),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Email),nameof(Gestalt),nameof(IsInternal),nameof(Locked),nameof(Name),nameof(Owner),nameof(OwnerId),nameof(Scopes),nameof(ScopesCount),nameof(Settings),nameof(Slack),nameof(Updated),nameof(Updates),nameof(UpdatesCount),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocWebSession.GetTypeSelect(this);

                }
                return _Select;
            }
            set
            {

                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<Team>("Team",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(AdminRoles), nameof(AdminRolesCount), nameof(AdminRolesIds), nameof(Scopes), nameof(ScopesCount), nameof(ScopesIds), nameof(Updates), nameof(UpdatesCount), nameof(UpdatesIds), nameof(Users), nameof(UsersCount), nameof(UsersIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<Team>();

    }
    

    [Route("/team/{Id}/copy", "POST")]
    public partial class TeamCopy : Team {}

    public partial class TeamSearchBase : Search<Team>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public List<int> AdminRolesIds { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
        public string Email { get; set; }
        public List<string> Emails { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsInternal { get; set; }
        public string Name { get; set; }
        public List<string> Names { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Settings { get; set; }
        public List<string> Settingss { get; set; }
        public string Slack { get; set; }
        public List<string> Slacks { get; set; }
        public List<int> UpdatesIds { get; set; }
        public List<int> UsersIds { get; set; }
    }


    [Route("/team", "GET")]
    [Route("/team/version", "GET, POST")]
    [Route("/team/search", "GET, POST, DELETE")]

    public partial class TeamSearch : TeamSearchBase
    {
    }

    public class TeamFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TeamFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private TeamSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TeamFullTextSearch(TeamSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Updated))); }

        public bool doAdminRoles { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.AdminRoles))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Description))); }
        public bool doEmail { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Email))); }
        public bool doIsInternal { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.IsInternal))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Name))); }
        public bool doOwner { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Owner))); }
        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Scopes))); }
        public bool doSettings { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Settings))); }
        public bool doSlack { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Slack))); }
        public bool doUpdates { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Updates))); }
        public bool doUsers { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Users))); }
    }


    [Route("/team/batch", "DELETE, PATCH, POST, PUT")]

    public partial class TeamBatch : List<Team> { }


    [Route("/team/{Id}/{Junction}/version", "GET, POST")]
    [Route("/team/{Id}/{Junction}", "GET, POST, DELETE")]
    public class TeamJunction : TeamSearchBase {}



}
