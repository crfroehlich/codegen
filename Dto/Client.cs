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
using Services.Dto.Security;
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
    public abstract partial class ClientBase : Dto<Client>
    {
        public ClientBase() {}

        public ClientBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ClientBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Account), Description = "ForeignKey", IsRequired = false)]
        public Reference Account { get; set; }
        [ApiMember(Name = nameof(AccountId), Description = "Primary Key of ForeignKey", IsRequired = false)]
        public int? AccountId { get; set; }


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


    }

    [Route("/client", "POST")]
    [Route("/client/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Client : ClientBase, IReturn<Client>, IDto
    {
        public Client()
        {
            _Constructor();
        }

        public Client(int? id) : base(DocConvert.ToInt(id)) {}
        public Client(int id) : base(id) {}
        
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
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Account),nameof(AccountId),nameof(Created),nameof(CreatorId),nameof(DefaultLocale),nameof(DefaultLocaleId),nameof(Divisions),nameof(DivisionsCount),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Projects),nameof(ProjectsCount),nameof(Role),nameof(RoleId),nameof(SalesforceAccountId),nameof(Scopes),nameof(ScopesCount),nameof(Settings),nameof(Updated),nameof(VersionNo)})]
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
    }
    
    [Route("/Client/{Id}/copy", "POST")]
    public partial class ClientCopy : Client {}
    public partial class ClientSearchBase : Search<Client>
    {
        public Reference Account { get; set; }
        public List<int> AccountIds { get; set; }
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
    [Route("/client/search", "GET, POST, DELETE")]
    public partial class ClientSearch : ClientSearchBase
    {
    }

    public class ClientFullTextSearch
    {
        private ClientSearch _request;
        public ClientFullTextSearch(ClientSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Updated))); }
        
        public bool doAccount { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Client.Account))); }
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

    [Route("/client/version", "GET, POST")]
    public partial class ClientVersion : ClientSearch {}

    [Route("/client/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ClientBatch : List<Client> { }

    [Route("/client/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/client/{Id}/division", "GET, POST, DELETE")]
    [Route("/client/{Id}/documentset", "GET, POST, DELETE")]
    [Route("/client/{Id}/project", "GET, POST, DELETE")]
    [Route("/client/{Id}/scope", "GET, POST, DELETE")]
    [Route("/client/{Id}/user", "GET, POST, DELETE")]
    [Route("/client/{Id}/workflow", "GET, POST, DELETE")]
    public class ClientJunction : Search<Client>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public ClientJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/client/{Id}/lookuptablebinding/version", "GET")]
    [Route("/client/{Id}/division/version", "GET")]
    [Route("/client/{Id}/documentset/version", "GET")]
    [Route("/client/{Id}/project/version", "GET")]
    [Route("/client/{Id}/scope/version", "GET")]
    [Route("/client/{Id}/user/version", "GET")]
    [Route("/client/{Id}/workflow/version", "GET")]
    public class ClientJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/client/ids", "GET, POST")]
    public class ClientIds
    {
        public bool All { get; set; }
    }
}