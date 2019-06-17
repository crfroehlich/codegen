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
    public abstract partial class ClientBase : Dto<Client>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ClientBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ClientBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ClientBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ClientBase(int? pId, Reference pDefaultLocale, int? pDefaultLocaleId, List<Reference> pDivisions, int? pDivisionsCount, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pName, List<Reference> pProjects, int? pProjectsCount, Reference pRole, int? pRoleId, string pSalesforceAccountId, List<Reference> pScopes, int? pScopesCount, ClientSettings pSettings) : this(DocConvert.ToInt(pId)) 
        {
            DefaultLocale = pDefaultLocale;
            DefaultLocaleId = pDefaultLocaleId;
            Divisions = pDivisions;
            DivisionsCount = pDivisionsCount;
            DocumentSets = pDocumentSets;
            DocumentSetsCount = pDocumentSetsCount;
            Name = pName;
            Projects = pProjects;
            ProjectsCount = pProjectsCount;
            Role = pRole;
            RoleId = pRoleId;
            SalesforceAccountId = pSalesforceAccountId;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Settings = pSettings;
        }

        [ApiMember(Name = nameof(DefaultLocale), Description = "Locale", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference DefaultLocale { get; set; }
        [ApiMember(Name = nameof(DefaultLocaleId), Description = "Primary Key of Locale", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DefaultLocaleId { get; set; }

        [ApiMember(Name = nameof(Divisions), Description = "Division", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Divisions { get; set; }
        [ApiMember(Name = nameof(DivisionsIds), Description = "Division Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DivisionsIds { get; set; }
        [ApiMember(Name = nameof(DivisionsCount), Description = "Division Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DivisionsCount { get; set; }

        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> DocumentSets { get; set; }
        [ApiMember(Name = nameof(DocumentSetsIds), Description = "DocumentSet Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DocumentSetsIds { get; set; }
        [ApiMember(Name = nameof(DocumentSetsCount), Description = "DocumentSet Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DocumentSetsCount { get; set; }

        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Name { get; set; }
        [ApiMember(Name = nameof(NameIds), Description = "Name Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> NameIds { get; set; }
        [ApiMember(Name = nameof(NameCount), Description = "Name Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? NameCount { get; set; }

        [ApiMember(Name = nameof(Projects), Description = "Project", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Projects { get; set; }
        [ApiMember(Name = nameof(ProjectsIds), Description = "Project Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ProjectsIds { get; set; }
        [ApiMember(Name = nameof(ProjectsCount), Description = "Project Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ProjectsCount { get; set; }

        [ApiMember(Name = nameof(Role), Description = "Role", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Role { get; set; }
        [ApiMember(Name = nameof(RoleId), Description = "Primary Key of Role", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? RoleId { get; set; }

        [ApiMember(Name = nameof(SalesforceAccountId), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string SalesforceAccountId { get; set; }
        [ApiMember(Name = nameof(SalesforceAccountIdIds), Description = "SalesforceAccountId Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> SalesforceAccountIdIds { get; set; }
        [ApiMember(Name = nameof(SalesforceAccountIdCount), Description = "SalesforceAccountId Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? SalesforceAccountIdCount { get; set; }

        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Scopes { get; set; }
        [ApiMember(Name = nameof(ScopesIds), Description = "Scope Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ScopesIds { get; set; }
        [ApiMember(Name = nameof(ScopesCount), Description = "Scope Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ScopesCount { get; set; }

        [ApiMember(Name = nameof(Settings), Description = "ClientSettings", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ClientSettings Settings { get; set; }
        [ApiMember(Name = nameof(SettingsIds), Description = "Settings Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> SettingsIds { get; set; }
        [ApiMember(Name = nameof(SettingsCount), Description = "Settings Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? SettingsCount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out Reference pDefaultLocale, out int? pDefaultLocaleId, out List<Reference> pDivisions, out int? pDivisionsCount, out List<Reference> pDocumentSets, out int? pDocumentSetsCount, out string pName, out List<Reference> pProjects, out int? pProjectsCount, out Reference pRole, out int? pRoleId, out string pSalesforceAccountId, out List<Reference> pScopes, out int? pScopesCount, out ClientSettings pSettings)
        {
            pDefaultLocale = DefaultLocale;
            pDefaultLocaleId = DefaultLocaleId;
            pDivisions = Divisions;
            pDivisionsCount = DivisionsCount;
            pDocumentSets = DocumentSets;
            pDocumentSetsCount = DocumentSetsCount;
            pName = Name;
            pProjects = Projects;
            pProjectsCount = ProjectsCount;
            pRole = Role;
            pRoleId = RoleId;
            pSalesforceAccountId = SalesforceAccountId;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pSettings = Settings;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public ClientBase With(int? pId = Id, Reference pDefaultLocale = DefaultLocale, int? pDefaultLocaleId = DefaultLocaleId, List<Reference> pDivisions = Divisions, int? pDivisionsCount = DivisionsCount, List<Reference> pDocumentSets = DocumentSets, int? pDocumentSetsCount = DocumentSetsCount, string pName = Name, List<Reference> pProjects = Projects, int? pProjectsCount = ProjectsCount, Reference pRole = Role, int? pRoleId = RoleId, string pSalesforceAccountId = SalesforceAccountId, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, ClientSettings pSettings = Settings) => 
        //	new ClientBase(pId, pDefaultLocale, pDefaultLocaleId, pDivisions, pDivisionsCount, pDocumentSets, pDocumentSetsCount, pName, pProjects, pProjectsCount, pRole, pRoleId, pSalesforceAccountId, pScopes, pScopesCount, pSettings);

    }


    [Route("/client", "POST")]
    [Route("/client/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Client : ClientBase, IReturn<Client>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Client() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Client(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Client(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Client(int? pId, Reference pDefaultLocale, int? pDefaultLocaleId, List<Reference> pDivisions, int? pDivisionsCount, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pName, List<Reference> pProjects, int? pProjectsCount, Reference pRole, int? pRoleId, string pSalesforceAccountId, List<Reference> pScopes, int? pScopesCount, ClientSettings pSettings) :
            base(pId, pDefaultLocale, pDefaultLocaleId, pDivisions, pDivisionsCount, pDocumentSets, pDocumentSetsCount, pName, pProjects, pProjectsCount, pRole, pRoleId, pSalesforceAccountId, pScopes, pScopesCount, pSettings) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<Client>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DefaultLocale),nameof(DefaultLocaleId),nameof(Divisions),nameof(DivisionsCount),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Projects),nameof(ProjectsCount),nameof(Role),nameof(RoleId),nameof(SalesforceAccountId),nameof(Scopes),nameof(ScopesCount),nameof(Settings),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Client>("Client",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Divisions), nameof(DivisionsCount), nameof(DivisionsIds), nameof(DocumentSets), nameof(DocumentSetsCount), nameof(DocumentSetsIds), nameof(Projects), nameof(ProjectsCount), nameof(ProjectsIds), nameof(Scopes), nameof(ScopesCount), nameof(ScopesIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<Client>();

    }
    

    [Route("/client/{Id}/copy", "POST")]
    public partial class ClientCopy : Client {}

    public partial class ClientSearchBase : Search<Client>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public Reference DefaultLocale { get; set; }
        public List<int> DefaultLocaleIds { get; set; }
        public List<int> DivisionsIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public string Name { get; set; }
        public List<string> Names { get; set; }
        public List<int> ProjectsIds { get; set; }
        public Reference Role { get; set; }
        public List<int> RoleIds { get; set; }
        public string SalesforceAccountId { get; set; }
        public List<string> SalesforceAccountIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Settings { get; set; }
        public List<string> Settingss { get; set; }
    }


    [Route("/client", "GET")]
    [Route("/client/version", "GET, POST")]
    [Route("/client/search", "GET, POST, DELETE")]

    public partial class ClientSearch : ClientSearchBase
    {
    }

    public class ClientFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ClientFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private ClientSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ClientFullTextSearch(ClientSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.Updated))); }

        public bool doDefaultLocale { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.DefaultLocale))); }
        public bool doDivisions { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.Divisions))); }
        public bool doDocumentSets { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.DocumentSets))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.Name))); }
        public bool doProjects { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.Projects))); }
        public bool doRole { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.Role))); }
        public bool doSalesforceAccountId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.SalesforceAccountId))); }
        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.Scopes))); }
        public bool doSettings { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Client.Settings))); }
    }


    [Route("/client/batch", "DELETE, PATCH, POST, PUT")]

    public partial class ClientBatch : List<Client> { }


    [Route("/client/{Id}/{Junction}/version", "GET, POST")]
    [Route("/client/{Id}/{Junction}", "GET, POST, DELETE")]
    public class ClientJunction : ClientSearchBase {}



}
