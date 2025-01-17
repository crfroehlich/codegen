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
    public abstract partial class PageBase : Dto<Page>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public PageBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public PageBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public PageBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public PageBase(int? pId, List<Reference> pApps, int? pAppsCount, string pDescription, List<Reference> pGlossary, int? pGlossaryCount, List<Reference> pHelp, int? pHelpCount, string pName, List<Reference> pRoles, int? pRolesCount) : this(DocConvert.ToInt(pId)) 
        {
            Apps = pApps;
            AppsCount = pAppsCount;
            Description = pDescription;
            Glossary = pGlossary;
            GlossaryCount = pGlossaryCount;
            Help = pHelp;
            HelpCount = pHelpCount;
            Name = pName;
            Roles = pRoles;
            RolesCount = pRolesCount;
        }

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


        [ApiMember(Name = nameof(Glossary), Description = "Glossary", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Glossary { get; set; }
        [ApiMember(Name = nameof(GlossaryIds), Description = "Glossary Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> GlossaryIds { get; set; }
        [ApiMember(Name = nameof(GlossaryCount), Description = "Glossary Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? GlossaryCount { get; set; }


        [ApiMember(Name = nameof(Help), Description = "Help", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Help { get; set; }
        [ApiMember(Name = nameof(HelpIds), Description = "Help Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> HelpIds { get; set; }
        [ApiMember(Name = nameof(HelpCount), Description = "Help Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? HelpCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Roles), Description = "Role", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Roles { get; set; }
        [ApiMember(Name = nameof(RolesIds), Description = "Role Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> RolesIds { get; set; }
        [ApiMember(Name = nameof(RolesCount), Description = "Role Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? RolesCount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out List<Reference> pApps, out int? pAppsCount, out string pDescription, out List<Reference> pGlossary, out int? pGlossaryCount, out List<Reference> pHelp, out int? pHelpCount, out string pName, out List<Reference> pRoles, out int? pRolesCount)
        {
            pApps = Apps;
            pAppsCount = AppsCount;
            pDescription = Description;
            pGlossary = Glossary;
            pGlossaryCount = GlossaryCount;
            pHelp = Help;
            pHelpCount = HelpCount;
            pName = Name;
            pRoles = Roles;
            pRolesCount = RolesCount;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public PageBase With(int? pId = Id, List<Reference> pApps = Apps, int? pAppsCount = AppsCount, string pDescription = Description, List<Reference> pGlossary = Glossary, int? pGlossaryCount = GlossaryCount, List<Reference> pHelp = Help, int? pHelpCount = HelpCount, string pName = Name, List<Reference> pRoles = Roles, int? pRolesCount = RolesCount) => 
        //	new PageBase(pId, pApps, pAppsCount, pDescription, pGlossary, pGlossaryCount, pHelp, pHelpCount, pName, pRoles, pRolesCount);

    }


    [Route("/page", "POST")]
    [Route("/page/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Page : PageBase, IReturn<Page>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Page() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Page(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Page(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Page(int? pId, List<Reference> pApps, int? pAppsCount, string pDescription, List<Reference> pGlossary, int? pGlossaryCount, List<Reference> pHelp, int? pHelpCount, string pName, List<Reference> pRoles, int? pRolesCount) :
            base(pId, pApps, pAppsCount, pDescription, pGlossary, pGlossaryCount, pHelp, pHelpCount, pName, pRoles, pRolesCount) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<Page>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Apps),nameof(AppsCount),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Glossary),nameof(GlossaryCount),nameof(Help),nameof(HelpCount),nameof(Locked),nameof(Name),nameof(Roles),nameof(RolesCount),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Page>("Page",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Apps), nameof(AppsCount), nameof(AppsIds), nameof(Glossary), nameof(GlossaryCount), nameof(GlossaryIds), nameof(Help), nameof(HelpCount), nameof(HelpIds), nameof(Roles), nameof(RolesCount), nameof(RolesIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<Page>();

    }
    

    [Route("/page/{Id}/copy", "POST")]
    public partial class PageCopy : Page {}

    public partial class PageSearchBase : Search<Page>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public List<int> AppsIds { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
        public List<int> GlossaryIds { get; set; }
        public List<int> HelpIds { get; set; }
        public string Name { get; set; }
        public List<string> Names { get; set; }
        public List<int> RolesIds { get; set; }
    }


    [Route("/page", "GET")]
    [Route("/page/version", "GET, POST")]
    [Route("/page/search", "GET, POST, DELETE")]

    public partial class PageSearch : PageSearchBase
    {
    }

    public class PageFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public PageFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private PageSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public PageFullTextSearch(PageSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Page.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Page.Updated))); }

        public bool doApps { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Page.Apps))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Page.Description))); }
        public bool doGlossary { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Page.Glossary))); }
        public bool doHelp { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Page.Help))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Page.Name))); }
        public bool doRoles { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Page.Roles))); }
    }


    [Route("/page/batch", "DELETE, PATCH, POST, PUT")]

    public partial class PageBatch : List<Page> { }


    [Route("/page/{Id}/{Junction}/version", "GET, POST")]
    [Route("/page/{Id}/{Junction}", "GET, POST, DELETE")]
    public class PageJunction : PageSearchBase {}



}
