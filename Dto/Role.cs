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
    public abstract partial class RoleBase : Dto<Role>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public RoleBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public RoleBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public RoleBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public RoleBase(int? pId, Reference pAdminTeam, int? pAdminTeamId, List<Reference> pApps, int? pAppsCount, string pDescription, string pFeatures, List<Reference> pFeatureSets, int? pFeatureSetsCount, bool pIsInternal, bool pIsSuperAdmin, string pName, List<Reference> pPages, int? pPagesCount, string pPermissions, List<Reference> pUsers, int? pUsersCount) : this(DocConvert.ToInt(pId)) 
        {
            AdminTeam = pAdminTeam;
            AdminTeamId = pAdminTeamId;
            Apps = pApps;
            AppsCount = pAppsCount;
            Description = pDescription;
            Features = pFeatures;
            FeatureSets = pFeatureSets;
            FeatureSetsCount = pFeatureSetsCount;
            IsInternal = pIsInternal;
            IsSuperAdmin = pIsSuperAdmin;
            Name = pName;
            Pages = pPages;
            PagesCount = pPagesCount;
            Permissions = pPermissions;
            Users = pUsers;
            UsersCount = pUsersCount;
        }

        [ApiMember(Name = nameof(AdminTeam), Description = "Team", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference AdminTeam { get; set; }
        [ApiMember(Name = nameof(AdminTeamId), Description = "Primary Key of Team", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? AdminTeamId { get; set; }


        [ApiMember(Name = nameof(Apps), Description = "App", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Apps { get; set; }
        [ApiMember(Name = nameof(AppsIds), Description = "App Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> AppsIds { get; set; }
        [ApiMember(Name = nameof(AppsCount), Description = "App Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? AppsCount { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Features), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Features { get; set; }


        [ApiMember(Name = nameof(FeatureSets), Description = "FeatureSet", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> FeatureSets { get; set; }
        [ApiMember(Name = nameof(FeatureSetsIds), Description = "FeatureSet Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> FeatureSetsIds { get; set; }
        [ApiMember(Name = nameof(FeatureSetsCount), Description = "FeatureSet Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? FeatureSetsCount { get; set; }


        [ApiMember(Name = nameof(IsInternal), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool IsInternal { get; set; }


        [ApiMember(Name = nameof(IsSuperAdmin), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool IsSuperAdmin { get; private set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Pages), Description = "Page", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Pages { get; set; }
        [ApiMember(Name = nameof(PagesIds), Description = "Page Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> PagesIds { get; set; }
        [ApiMember(Name = nameof(PagesCount), Description = "Page Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? PagesCount { get; set; }


        [ApiMember(Name = nameof(Permissions), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Permissions { get; set; }


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
        public void Deconstruct(out Reference pAdminTeam, out int? pAdminTeamId, out List<Reference> pApps, out int? pAppsCount, out string pDescription, out string pFeatures, out List<Reference> pFeatureSets, out int? pFeatureSetsCount, out bool pIsInternal, out bool pIsSuperAdmin, out string pName, out List<Reference> pPages, out int? pPagesCount, out string pPermissions, out List<Reference> pUsers, out int? pUsersCount)
        {
            pAdminTeam = AdminTeam;
            pAdminTeamId = AdminTeamId;
            pApps = Apps;
            pAppsCount = AppsCount;
            pDescription = Description;
            pFeatures = Features;
            pFeatureSets = FeatureSets;
            pFeatureSetsCount = FeatureSetsCount;
            pIsInternal = IsInternal;
            pIsSuperAdmin = IsSuperAdmin;
            pName = Name;
            pPages = Pages;
            pPagesCount = PagesCount;
            pPermissions = Permissions;
            pUsers = Users;
            pUsersCount = UsersCount;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public RoleBase With(int? pId = Id, Reference pAdminTeam = AdminTeam, int? pAdminTeamId = AdminTeamId, List<Reference> pApps = Apps, int? pAppsCount = AppsCount, string pDescription = Description, string pFeatures = Features, List<Reference> pFeatureSets = FeatureSets, int? pFeatureSetsCount = FeatureSetsCount, bool pIsInternal = IsInternal, bool pIsSuperAdmin = IsSuperAdmin, string pName = Name, List<Reference> pPages = Pages, int? pPagesCount = PagesCount, string pPermissions = Permissions, List<Reference> pUsers = Users, int? pUsersCount = UsersCount) => 
        //	new RoleBase(pId, pAdminTeam, pAdminTeamId, pApps, pAppsCount, pDescription, pFeatures, pFeatureSets, pFeatureSetsCount, pIsInternal, pIsSuperAdmin, pName, pPages, pPagesCount, pPermissions, pUsers, pUsersCount);

    }


    [Route("/role", "POST")]
    [Route("/role/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Role : RoleBase, IReturn<Role>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Role() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Role(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Role(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Role(int? pId, Reference pAdminTeam, int? pAdminTeamId, List<Reference> pApps, int? pAppsCount, string pDescription, string pFeatures, List<Reference> pFeatureSets, int? pFeatureSetsCount, bool pIsInternal, bool pIsSuperAdmin, string pName, List<Reference> pPages, int? pPagesCount, string pPermissions, List<Reference> pUsers, int? pUsersCount) :
            base(pId, pAdminTeam, pAdminTeamId, pApps, pAppsCount, pDescription, pFeatures, pFeatureSets, pFeatureSetsCount, pIsInternal, pIsSuperAdmin, pName, pPages, pPagesCount, pPermissions, pUsers, pUsersCount) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<Role>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AdminTeam),nameof(AdminTeamId),nameof(Apps),nameof(AppsCount),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Features),nameof(FeatureSets),nameof(FeatureSetsCount),nameof(Gestalt),nameof(IsInternal),nameof(IsSuperAdmin),nameof(Locked),nameof(Name),nameof(Pages),nameof(PagesCount),nameof(Permissions),nameof(Updated),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Role>("Role",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Apps), nameof(AppsCount), nameof(AppsIds), nameof(FeatureSets), nameof(FeatureSetsCount), nameof(FeatureSetsIds), nameof(Pages), nameof(PagesCount), nameof(PagesIds), nameof(Users), nameof(UsersCount), nameof(UsersIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<Role>();

    }
    

    [Route("/role/{Id}/copy", "POST")]
    public partial class RoleCopy : Role {}

    public partial class RoleSearchBase : Search<Role>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public Reference AdminTeam { get; set; }
        public List<int> AdminTeamIds { get; set; }
        public List<int> AppsIds { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
        public string Features { get; set; }
        public List<string> Featuress { get; set; }
        public List<int> FeatureSetsIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsInternal { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsSuperAdmin { get; set; }
        public string Name { get; set; }
        public List<string> Names { get; set; }
        public List<int> PagesIds { get; set; }
        public string Permissions { get; set; }
        public List<string> Permissionss { get; set; }
        public List<int> UsersIds { get; set; }
    }


    [Route("/role", "GET")]
    [Route("/role/version", "GET, POST")]
    [Route("/role/search", "GET, POST, DELETE")]

    public partial class RoleSearch : RoleSearchBase
    {
    }

    public class RoleFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public RoleFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private RoleSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public RoleFullTextSearch(RoleSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Updated))); }

        public bool doAdminTeam { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.AdminTeam))); }
        public bool doApps { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Apps))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Description))); }
        public bool doFeatures { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Features))); }
        public bool doFeatureSets { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.FeatureSets))); }
        public bool doIsInternal { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.IsInternal))); }
        public bool doIsSuperAdmin { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.IsSuperAdmin))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Name))); }
        public bool doPages { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Pages))); }
        public bool doPermissions { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Permissions))); }
        public bool doUsers { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Role.Users))); }
    }


    [Route("/role/batch", "DELETE, PATCH, POST, PUT")]

    public partial class RoleBatch : List<Role> { }


    [Route("/role/{Id}/{Junction}/version", "GET, POST")]
    [Route("/role/{Id}/{Junction}", "GET, POST, DELETE")]
    public class RoleJunction : RoleSearchBase {}



}
