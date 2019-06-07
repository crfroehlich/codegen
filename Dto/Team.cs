
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
        public TeamBase() {}

        public TeamBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TeamBase(int? id) : this(DocConvert.ToInt(id)) {}

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
        public List<Reference> AdminRoles { get; set; }
        public List<int> AdminRolesIds { get; set; }
        public int? AdminRolesCount { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Email), Description = "string", IsRequired = false)]
        public string Email { get; set; }


        [ApiMember(Name = nameof(IsInternal), Description = "bool", IsRequired = false)]
        public bool IsInternal { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Owner), Description = "User", IsRequired = true)]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of User", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public List<int> ScopesIds { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Settings), Description = "TeamSettings", IsRequired = false)]
        public TeamSettings Settings { get; set; }


        [ApiMember(Name = nameof(Slack), Description = "string", IsRequired = false)]
        public string Slack { get; set; }


        [ApiMember(Name = nameof(Updates), Description = "Update", IsRequired = false)]
        public List<Reference> Updates { get; set; }
        public List<int> UpdatesIds { get; set; }
        public int? UpdatesCount { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public List<int> UsersIds { get; set; }
        public int? UsersCount { get; set; }



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
        //public TeamBase With(int? pId = Id, List<Reference> pAdminRoles = AdminRoles, int? pAdminRolesCount = AdminRolesCount, string pDescription = Description, string pEmail = Email, bool pIsInternal = IsInternal, string pName = Name, Reference pOwner = Owner, int? pOwnerId = OwnerId, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, TeamSettings pSettings = Settings, string pSlack = Slack, List<Reference> pUpdates = Updates, int? pUpdatesCount = UpdatesCount, List<Reference> pUsers = Users, int? pUsersCount = UsersCount) => 
        //	new TeamBase(pId, pAdminRoles, pAdminRolesCount, pDescription, pEmail, pIsInternal, pName, pOwner, pOwnerId, pScopes, pScopesCount, pSettings, pSlack, pUpdates, pUpdatesCount, pUsers, pUsersCount);

    }


    [Route("/team", "POST")]
    [Route("/team/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Team : TeamBase, IReturn<Team>, IDto, ICloneable
    {
        public Team()
        {
            _Constructor();
        }

        public Team(int? id) : base(DocConvert.ToInt(id)) {}
        public Team(int id) : base(id) {}
        public Team(int? pId, List<Reference> pAdminRoles, int? pAdminRolesCount, string pDescription, string pEmail, bool pIsInternal, string pName, Reference pOwner, int? pOwnerId, List<Reference> pScopes, int? pScopesCount, TeamSettings pSettings, string pSlack, List<Reference> pUpdates, int? pUpdatesCount, List<Reference> pUsers, int? pUsersCount) : 
            base(pId, pAdminRoles, pAdminRolesCount, pDescription, pEmail, pIsInternal, pName, pOwner, pOwnerId, pScopes, pScopesCount, pSettings, pSlack, pUpdates, pUpdatesCount, pUsers, pUsersCount) { }

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Team>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AdminRoles),nameof(AdminRolesCount),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Email),nameof(Gestalt),nameof(IsInternal),nameof(Locked),nameof(Name),nameof(Owner),nameof(OwnerId),nameof(Scopes),nameof(ScopesCount),nameof(Settings),nameof(Slack),nameof(Updated),nameof(Updates),nameof(UpdatesCount),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
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

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        private List<string> _collections = new List<string>
        {
            nameof(AdminRoles), nameof(AdminRolesCount), nameof(Scopes), nameof(ScopesCount), nameof(Updates), nameof(UpdatesCount), nameof(Users), nameof(UsersCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<Team>();

    }
    

    [Route("/team/{Id}/copy", "POST")]
    public partial class TeamCopy : Team {}

    public partial class TeamSearchBase : Search<Team>
    {
        public int? Id { get; set; }
        public List<int> AdminRolesIds { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsInternal { get; set; }
        public string Name { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Settings { get; set; }
        public string Slack { get; set; }
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
        public TeamFullTextSearch() {}
        private TeamSearch _request;
        public TeamFullTextSearch(TeamSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Team.Created))); }
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
