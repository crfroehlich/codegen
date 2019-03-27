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
    public abstract partial class ClientBase : Dto<Client>
    {
        public ClientBase() {}

        public ClientBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ClientBase(int? id) : this(DocConvert.ToInt(id)) {}

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
        public Reference DefaultLocale { get; set; }
        [ApiMember(Name = nameof(DefaultLocaleId), Description = "Primary Key of Locale", IsRequired = false)]
        public int? DefaultLocaleId { get; set; }


        [ApiMember(Name = nameof(Divisions), Description = "Division", IsRequired = false)]
        public List<Reference> Divisions { get; set; }
        public int? DivisionsCount { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Projects), Description = "Project", IsRequired = false)]
        public List<Reference> Projects { get; set; }
        public int? ProjectsCount { get; set; }


        [ApiMember(Name = nameof(Role), Description = "Role", IsRequired = true)]
        public Reference Role { get; set; }
        [ApiMember(Name = nameof(RoleId), Description = "Primary Key of Role", IsRequired = false)]
        public int? RoleId { get; set; }


        [ApiMember(Name = nameof(SalesforceAccountId), Description = "string", IsRequired = false)]
        public string SalesforceAccountId { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Settings), Description = "ClientSettings", IsRequired = false)]
        public ClientSettings Settings { get; set; }



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
        //public ClientBase With(int? pId = Id, Reference pDefaultLocale = DefaultLocale, int? pDefaultLocaleId = DefaultLocaleId, List<Reference> pDivisions = Divisions, int? pDivisionsCount = DivisionsCount, List<Reference> pDocumentSets = DocumentSets, int? pDocumentSetsCount = DocumentSetsCount, string pName = Name, List<Reference> pProjects = Projects, int? pProjectsCount = ProjectsCount, Reference pRole = Role, int? pRoleId = RoleId, string pSalesforceAccountId = SalesforceAccountId, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, ClientSettings pSettings = Settings) => 
        //	new ClientBase(pId, pDefaultLocale, pDefaultLocaleId, pDivisions, pDivisionsCount, pDocumentSets, pDocumentSetsCount, pName, pProjects, pProjectsCount, pRole, pRoleId, pSalesforceAccountId, pScopes, pScopesCount, pSettings);

    }

    [Route("/client", "POST")]
    [Route("/client/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Client : ClientBase, IReturn<Client>, IDto, ICloneable
    {
        public Client()
        {
            _Constructor();
        }

        public Client(int? id) : base(DocConvert.ToInt(id)) {}
        public Client(int id) : base(id) {}
        public Client(int? pId, Reference pDefaultLocale, int? pDefaultLocaleId, List<Reference> pDivisions, int? pDivisionsCount, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pName, List<Reference> pProjects, int? pProjectsCount, Reference pRole, int? pRoleId, string pSalesforceAccountId, List<Reference> pScopes, int? pScopesCount, ClientSettings pSettings) : 
            base(pId, pDefaultLocale, pDefaultLocaleId, pDivisions, pDivisionsCount, pDocumentSets, pDocumentSetsCount, pName, pProjects, pProjectsCount, pRole, pRoleId, pSalesforceAccountId, pScopes, pScopesCount, pSettings) { }
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Client>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DefaultLocale),nameof(DefaultLocaleId),nameof(Divisions),nameof(DivisionsCount),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Projects),nameof(ProjectsCount),nameof(Role),nameof(RoleId),nameof(SalesforceAccountId),nameof(Scopes),nameof(ScopesCount),nameof(Settings),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Client>("Client",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Divisions), nameof(DivisionsCount), nameof(DocumentSets), nameof(DocumentSetsCount), nameof(Projects), nameof(ProjectsCount), nameof(Scopes), nameof(ScopesCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<Client>();
    }
    
    [Route("/client/{Id}/copy", "POST")]
    public partial class ClientCopy : Client {}
    public partial class ClientSearchBase : Search<Client>
    {
        public int? Id { get; set; }
        public Reference DefaultLocale { get; set; }
        public List<int> DefaultLocaleIds { get; set; }
        public List<int> DivisionsIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public string Name { get; set; }
        public List<int> ProjectsIds { get; set; }
        public Reference Role { get; set; }
        public List<int> RoleIds { get; set; }
        public string SalesforceAccountId { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Settings { get; set; }
    }

    [Route("/client", "GET")]
    [Route("/client/version", "GET, POST")]
    [Route("/client/search", "GET, POST, DELETE")]
    public partial class ClientSearch : ClientSearchBase
    {
    }

    public class ClientFullTextSearch
    {
        public ClientFullTextSearch() {}
        private ClientSearch _request;
        public ClientFullTextSearch(ClientSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Updated))); }

        public bool doDefaultLocale { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.DefaultLocale))); }
        public bool doDivisions { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Divisions))); }
        public bool doDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.DocumentSets))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Name))); }
        public bool doProjects { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Projects))); }
        public bool doRole { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Role))); }
        public bool doSalesforceAccountId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.SalesforceAccountId))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Scopes))); }
        public bool doSettings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Settings))); }
    }

    [Route("/client/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ClientBatch : List<Client> { }

    [Route("/client/{Id}/{Junction}/version", "GET, POST")]
    [Route("/client/{Id}/{Junction}", "GET, POST, DELETE")]
    public class ClientJunction : ClientSearchBase {}


}
