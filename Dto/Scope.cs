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
    public abstract partial class ScopeBase : Dto<Scope>
    {
        public ScopeBase() {}

        public ScopeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ScopeBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(App), Description = "App", IsRequired = false)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


        [ApiMember(Name = nameof(Archived), Description = "bool?", IsRequired = false)]
        public bool? Archived { get; set; }


        [ApiMember(Name = nameof(Bindings), Description = "LookupTableBinding", IsRequired = false)]
        public List<Reference> Bindings { get; set; }
        public int? BindingsCount { get; set; }


        [ApiMember(Name = nameof(Broadcasts), Description = "Broadcast", IsRequired = false)]
        public List<Reference> Broadcasts { get; set; }
        public int? BroadcastsCount { get; set; }


        [ApiMember(Name = nameof(Client), Description = "Client", IsRequired = false)]
        public Reference Client { get; set; }
        [ApiMember(Name = nameof(ClientId), Description = "Primary Key of Client", IsRequired = false)]
        public int? ClientId { get; set; }


        [ApiMember(Name = nameof(Delete), Description = "bool?", IsRequired = false)]
        public bool? Delete { get; set; }


        [ApiMember(Name = nameof(DocumentSet), Description = "DocumentSet", IsRequired = false)]
        public Reference DocumentSet { get; set; }
        [ApiMember(Name = nameof(DocumentSetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DocumentSetId { get; set; }


        [ApiMember(Name = nameof(Edit), Description = "bool?", IsRequired = false)]
        public bool? Edit { get; set; }


        [ApiMember(Name = nameof(Help), Description = "Help", IsRequired = false)]
        public List<Reference> Help { get; set; }
        public int? HelpCount { get; set; }


        [ApiMember(Name = nameof(IsGlobal), Description = "bool?", IsRequired = false)]
        public bool? IsGlobal { get; set; }


        [ApiMember(Name = nameof(Synonyms), Description = "TermSynonym", IsRequired = false)]
        public List<Reference> Synonyms { get; set; }
        public int? SynonymsCount { get; set; }


        [ApiMember(Name = nameof(Team), Description = "Team", IsRequired = false)]
        public Reference Team { get; set; }
        [ApiMember(Name = nameof(TeamId), Description = "Primary Key of Team", IsRequired = false)]
        public int? TeamId { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"DocumentSet",@"Client",@"User",@"Global",@"App",@"Team",@"Compound"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = false)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(VariableRules), Description = "VariableRule", IsRequired = false)]
        public List<Reference> VariableRules { get; set; }
        public int? VariableRulesCount { get; set; }


        [ApiMember(Name = nameof(View), Description = "bool?", IsRequired = false)]
        public bool? View { get; set; }


        [ApiMember(Name = nameof(Workflows), Description = "Workflow", IsRequired = false)]
        public List<Reference> Workflows { get; set; }
        public int? WorkflowsCount { get; set; }


    }

    [Route("/scope", "POST")]
    [Route("/profile/scope", "POST")]
    [Route("/scope/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/scope/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Scope : ScopeBase, IReturn<Scope>, IDto
    {
        public Scope()
        {
            _Constructor();
        }

        public Scope(int? id) : base(DocConvert.ToInt(id)) {}
        public Scope(int id) : base(id) {}
        
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

        public static List<string> Fields => DocTools.Fields<Scope>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Archived),nameof(Bindings),nameof(BindingsCount),nameof(Broadcasts),nameof(BroadcastsCount),nameof(Client),nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(Delete),nameof(DocumentSet),nameof(DocumentSetId),nameof(Edit),nameof(Gestalt),nameof(Help),nameof(HelpCount),nameof(IsGlobal),nameof(Locked),nameof(Synonyms),nameof(SynonymsCount),nameof(Team),nameof(TeamId),nameof(Type),nameof(TypeId),nameof(Updated),nameof(User),nameof(UserId),nameof(VariableRules),nameof(VariableRulesCount),nameof(VersionNo),nameof(View),nameof(Workflows),nameof(WorkflowsCount)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Scope>("Scope",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Bindings), nameof(BindingsCount), nameof(Broadcasts), nameof(BroadcastsCount), nameof(Help), nameof(HelpCount), nameof(Synonyms), nameof(SynonymsCount), nameof(VariableRules), nameof(VariableRulesCount), nameof(Workflows), nameof(WorkflowsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Scope/{Id}/copy", "POST")]
    [Route("/profile/Scope/{Id}/copy", "POST")]
    public partial class ScopeCopy : Scope {}
    [Route("/scope", "GET")]
    [Route("/profile/scope", "GET")]
    [Route("/scope/search", "GET, POST, DELETE")]
    [Route("/profile/scope/search", "GET, POST, DELETE")]
    public partial class ScopeSearch : Search<Scope>
    {
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public bool? Archived { get; set; }
        public List<int> BindingsIds { get; set; }
        public List<int> BroadcastsIds { get; set; }
        public Reference Client { get; set; }
        public List<int> ClientIds { get; set; }
        public bool? Delete { get; set; }
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
        public bool? Edit { get; set; }
        public List<int> HelpIds { get; set; }
        public bool? IsGlobal { get; set; }
        public List<int> SynonymsIds { get; set; }
        public Reference Team { get; set; }
        public List<int> TeamIds { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"DocumentSet",@"Client",@"User",@"Global",@"App",@"Team",@"Compound"})]
        public List<string> TypeNames { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public List<int> VariableRulesIds { get; set; }
        public bool? View { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }
    
    public class ScopeFullTextSearch
    {
        private ScopeSearch _request;
        public ScopeFullTextSearch(ScopeSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Updated))); }
        
        public bool doApp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.App))); }
        public bool doArchived { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Archived))); }
        public bool doBindings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Bindings))); }
        public bool doBroadcasts { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Broadcasts))); }
        public bool doClient { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Client))); }
        public bool doDelete { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Delete))); }
        public bool doDocumentSet { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.DocumentSet))); }
        public bool doEdit { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Edit))); }
        public bool doHelp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Help))); }
        public bool doIsGlobal { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.IsGlobal))); }
        public bool doSynonyms { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Synonyms))); }
        public bool doTeam { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Team))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Type))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.User))); }
        public bool doVariableRules { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.VariableRules))); }
        public bool doView { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.View))); }
        public bool doWorkflows { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Workflows))); }
    }

    [Route("/scope/version", "GET, POST")]
    public partial class ScopeVersion : ScopeSearch {}

    [Route("/scope/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/scope/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ScopeBatch : List<Scope> { }

    [Route("/scope/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/profile/scope/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/scope/{Id}/broadcast", "GET, POST, DELETE")]
    [Route("/profile/scope/{Id}/broadcast", "GET, POST, DELETE")]
    [Route("/scope/{Id}/help", "GET, POST, DELETE")]
    [Route("/profile/scope/{Id}/help", "GET, POST, DELETE")]
    [Route("/scope/{Id}/termsynonym", "GET, POST, DELETE")]
    [Route("/profile/scope/{Id}/termsynonym", "GET, POST, DELETE")]
    [Route("/scope/{Id}/variablerule", "GET, POST, DELETE")]
    [Route("/profile/scope/{Id}/variablerule", "GET, POST, DELETE")]
    [Route("/scope/{Id}/workflow", "GET, POST, DELETE")]
    [Route("/profile/scope/{Id}/workflow", "GET, POST, DELETE")]
    public class ScopeJunction : Search<Scope>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public ScopeJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/scope/{Id}/lookuptablebinding/version", "GET")]
    [Route("/profile/scope/{Id}/lookuptablebinding/version", "GET")]
    [Route("/scope/{Id}/broadcast/version", "GET")]
    [Route("/profile/scope/{Id}/broadcast/version", "GET")]
    [Route("/scope/{Id}/help/version", "GET")]
    [Route("/profile/scope/{Id}/help/version", "GET")]
    [Route("/scope/{Id}/termsynonym/version", "GET")]
    [Route("/profile/scope/{Id}/termsynonym/version", "GET")]
    [Route("/scope/{Id}/variablerule/version", "GET")]
    [Route("/profile/scope/{Id}/variablerule/version", "GET")]
    [Route("/scope/{Id}/workflow/version", "GET")]
    [Route("/profile/scope/{Id}/workflow/version", "GET")]
    public class ScopeJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/scope/ids", "GET, POST")]
    public class ScopeIds
    {
        public bool All { get; set; }
    }
}