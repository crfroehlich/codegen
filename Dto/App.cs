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
    public abstract partial class AppBase : Dto<App>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AppBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AppBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AppBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AppBase(int? pId, string pDescription, string pName, List<Reference> pPages, int? pPagesCount, List<Reference> pRoles, int? pRolesCount, List<Reference> pScopes, int? pScopesCount) : this(DocConvert.ToInt(pId)) 
        {
            Description = pDescription;
            Name = pName;
            Pages = pPages;
            PagesCount = pPagesCount;
            Roles = pRoles;
            RolesCount = pRolesCount;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
        }

        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Description { get; set; }


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


        [ApiMember(Name = nameof(Roles), Description = "Role", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Roles { get; set; }
        [ApiMember(Name = nameof(RolesIds), Description = "Role Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> RolesIds { get; set; }
        [ApiMember(Name = nameof(RolesCount), Description = "Role Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? RolesCount { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Scopes { get; set; }
        [ApiMember(Name = nameof(ScopesIds), Description = "Scope Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ScopesIds { get; set; }
        [ApiMember(Name = nameof(ScopesCount), Description = "Scope Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ScopesCount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out string pDescription, out string pName, out List<Reference> pPages, out int? pPagesCount, out List<Reference> pRoles, out int? pRolesCount, out List<Reference> pScopes, out int? pScopesCount)
        {
            pDescription = Description;
            pName = Name;
            pPages = Pages;
            pPagesCount = PagesCount;
            pRoles = Roles;
            pRolesCount = RolesCount;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public AppBase With(int? pId = Id, string pDescription = Description, string pName = Name, List<Reference> pPages = Pages, int? pPagesCount = PagesCount, List<Reference> pRoles = Roles, int? pRolesCount = RolesCount, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount) => 
        //	new AppBase(pId, pDescription, pName, pPages, pPagesCount, pRoles, pRolesCount, pScopes, pScopesCount);

    }


    [Route("/app/{Id}", "GET, PATCH, PUT")]

    public partial class App : AppBase, IReturn<App>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public App() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public App(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public App(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public App(int? pId, string pDescription, string pName, List<Reference> pPages, int? pPagesCount, List<Reference> pRoles, int? pRolesCount, List<Reference> pScopes, int? pScopesCount) :
            base(pId, pDescription, pName, pPages, pPagesCount, pRoles, pRolesCount, pScopes, pScopesCount) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<App>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Pages),nameof(PagesCount),nameof(Roles),nameof(RolesCount),nameof(Scopes),nameof(ScopesCount),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<App>("App",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Pages), nameof(PagesCount), nameof(PagesIds), nameof(Roles), nameof(RolesCount), nameof(RolesIds), nameof(Scopes), nameof(ScopesCount), nameof(ScopesIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<App>();

    }
    

    public partial class AppSearchBase : Search<App>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
        public string Name { get; set; }
        public List<string> Names { get; set; }
        public List<int> PagesIds { get; set; }
        public List<int> RolesIds { get; set; }
        public List<int> ScopesIds { get; set; }
    }


    [Route("/app", "GET")]
    [Route("/app/version", "GET, POST")]
    [Route("/app/search", "GET, POST, DELETE")]

    public partial class AppSearch : AppSearchBase
    {
    }

    public class AppFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AppFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private AppSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AppFullTextSearch(AppSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(App.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(App.Updated))); }

        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(App.Description))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(App.Name))); }
        public bool doPages { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(App.Pages))); }
        public bool doRoles { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(App.Roles))); }
        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(App.Scopes))); }
    }


    [Route("/app/batch", "DELETE, PATCH, POST, PUT")]

    public partial class AppBatch : List<App> { }


    [Route("/app/{Id}/{Junction}/version", "GET, POST")]
    [Route("/app/{Id}/{Junction}", "GET, POST, DELETE")]
    public class AppJunction : AppSearchBase {}



}
