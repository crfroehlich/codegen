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
    public abstract partial class ScopeBase : Dto<Scope>
    {
        public ScopeBase() {}

        public ScopeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ScopeBase(int? id) : this(DocConvert.ToInt(id)) {}

        public ScopeBase(int? pId, Reference pApp, int? pAppId, List<Reference> pBindings, int? pBindingsCount, List<Reference> pBroadcasts, int? pBroadcastsCount, Reference pClient, int? pClientId, bool? pDelete, Reference pDocumentSet, int? pDocumentSetId, bool? pEdit, List<Reference> pHelp, int? pHelpCount, bool? pIsGlobal, List<Reference> pSynonyms, int? pSynonymsCount, List<Reference> pTags, int? pTagsCount, Reference pTeam, int? pTeamId, Reference pType, int? pTypeId, Reference pUser, int? pUserId, List<Reference> pVariableRules, int? pVariableRulesCount, bool? pView, List<Reference> pWorkflows, int? pWorkflowsCount) : this(DocConvert.ToInt(pId)) 
        {
            App = pApp;
            AppId = pAppId;
            Bindings = pBindings;
            BindingsCount = pBindingsCount;
            Broadcasts = pBroadcasts;
            BroadcastsCount = pBroadcastsCount;
            Client = pClient;
            ClientId = pClientId;
            Delete = pDelete;
            DocumentSet = pDocumentSet;
            DocumentSetId = pDocumentSetId;
            Edit = pEdit;
            Help = pHelp;
            HelpCount = pHelpCount;
            IsGlobal = pIsGlobal;
            Synonyms = pSynonyms;
            SynonymsCount = pSynonymsCount;
            Tags = pTags;
            TagsCount = pTagsCount;
            Team = pTeam;
            TeamId = pTeamId;
            Type = pType;
            TypeId = pTypeId;
            User = pUser;
            UserId = pUserId;
            VariableRules = pVariableRules;
            VariableRulesCount = pVariableRulesCount;
            View = pView;
            Workflows = pWorkflows;
            WorkflowsCount = pWorkflowsCount;
        }

        [ApiMember(Name = nameof(App), Description = "App", IsRequired = false)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


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


        [ApiMember(Name = nameof(Tags), Description = "Tag", IsRequired = false)]
        public List<Reference> Tags { get; set; }
        public int? TagsCount { get; set; }


        [ApiMember(Name = nameof(Team), Description = "Team", IsRequired = false)]
        public Reference Team { get; set; }
        [ApiMember(Name = nameof(TeamId), Description = "Primary Key of Team", IsRequired = false)]
        public int? TeamId { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"App",@"Client",@"Compound",@"DocumentSet",@"Global",@"Team",@"User"})]
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



        public void Deconstruct(out Reference pApp, out int? pAppId, out List<Reference> pBindings, out int? pBindingsCount, out List<Reference> pBroadcasts, out int? pBroadcastsCount, out Reference pClient, out int? pClientId, out bool? pDelete, out Reference pDocumentSet, out int? pDocumentSetId, out bool? pEdit, out List<Reference> pHelp, out int? pHelpCount, out bool? pIsGlobal, out List<Reference> pSynonyms, out int? pSynonymsCount, out List<Reference> pTags, out int? pTagsCount, out Reference pTeam, out int? pTeamId, out Reference pType, out int? pTypeId, out Reference pUser, out int? pUserId, out List<Reference> pVariableRules, out int? pVariableRulesCount, out bool? pView, out List<Reference> pWorkflows, out int? pWorkflowsCount)
        {
            pApp = App;
            pAppId = AppId;
            pBindings = Bindings;
            pBindingsCount = BindingsCount;
            pBroadcasts = Broadcasts;
            pBroadcastsCount = BroadcastsCount;
            pClient = Client;
            pClientId = ClientId;
            pDelete = Delete;
            pDocumentSet = DocumentSet;
            pDocumentSetId = DocumentSetId;
            pEdit = Edit;
            pHelp = Help;
            pHelpCount = HelpCount;
            pIsGlobal = IsGlobal;
            pSynonyms = Synonyms;
            pSynonymsCount = SynonymsCount;
            pTags = Tags;
            pTagsCount = TagsCount;
            pTeam = Team;
            pTeamId = TeamId;
            pType = Type;
            pTypeId = TypeId;
            pUser = User;
            pUserId = UserId;
            pVariableRules = VariableRules;
            pVariableRulesCount = VariableRulesCount;
            pView = View;
            pWorkflows = Workflows;
            pWorkflowsCount = WorkflowsCount;
        }

        //Not ready until C# v8.?
        //public ScopeBase With(int? pId = Id, Reference pApp = App, int? pAppId = AppId, List<Reference> pBindings = Bindings, int? pBindingsCount = BindingsCount, List<Reference> pBroadcasts = Broadcasts, int? pBroadcastsCount = BroadcastsCount, Reference pClient = Client, int? pClientId = ClientId, bool? pDelete = Delete, Reference pDocumentSet = DocumentSet, int? pDocumentSetId = DocumentSetId, bool? pEdit = Edit, List<Reference> pHelp = Help, int? pHelpCount = HelpCount, bool? pIsGlobal = IsGlobal, List<Reference> pSynonyms = Synonyms, int? pSynonymsCount = SynonymsCount, List<Reference> pTags = Tags, int? pTagsCount = TagsCount, Reference pTeam = Team, int? pTeamId = TeamId, Reference pType = Type, int? pTypeId = TypeId, Reference pUser = User, int? pUserId = UserId, List<Reference> pVariableRules = VariableRules, int? pVariableRulesCount = VariableRulesCount, bool? pView = View, List<Reference> pWorkflows = Workflows, int? pWorkflowsCount = WorkflowsCount) => 
        //	new ScopeBase(pId, pApp, pAppId, pBindings, pBindingsCount, pBroadcasts, pBroadcastsCount, pClient, pClientId, pDelete, pDocumentSet, pDocumentSetId, pEdit, pHelp, pHelpCount, pIsGlobal, pSynonyms, pSynonymsCount, pTags, pTagsCount, pTeam, pTeamId, pType, pTypeId, pUser, pUserId, pVariableRules, pVariableRulesCount, pView, pWorkflows, pWorkflowsCount);

    }

    [Route("/scope", "POST")]
    [Route("/scope/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Scope : ScopeBase, IReturn<Scope>, IDto, ICloneable
    {
        public Scope()
        {
            _Constructor();
        }

        public Scope(int? id) : base(DocConvert.ToInt(id)) {}
        public Scope(int id) : base(id) {}
        public Scope(int? pId, Reference pApp, int? pAppId, List<Reference> pBindings, int? pBindingsCount, List<Reference> pBroadcasts, int? pBroadcastsCount, Reference pClient, int? pClientId, bool? pDelete, Reference pDocumentSet, int? pDocumentSetId, bool? pEdit, List<Reference> pHelp, int? pHelpCount, bool? pIsGlobal, List<Reference> pSynonyms, int? pSynonymsCount, List<Reference> pTags, int? pTagsCount, Reference pTeam, int? pTeamId, Reference pType, int? pTypeId, Reference pUser, int? pUserId, List<Reference> pVariableRules, int? pVariableRulesCount, bool? pView, List<Reference> pWorkflows, int? pWorkflowsCount) : 
            base(pId, pApp, pAppId, pBindings, pBindingsCount, pBroadcasts, pBroadcastsCount, pClient, pClientId, pDelete, pDocumentSet, pDocumentSetId, pEdit, pHelp, pHelpCount, pIsGlobal, pSynonyms, pSynonymsCount, pTags, pTagsCount, pTeam, pTeamId, pType, pTypeId, pUser, pUserId, pVariableRules, pVariableRulesCount, pView, pWorkflows, pWorkflowsCount) { }
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

        public static List<string> Fields => DocTools.Fields<Scope>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Bindings),nameof(BindingsCount),nameof(Broadcasts),nameof(BroadcastsCount),nameof(Client),nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(Delete),nameof(DocumentSet),nameof(DocumentSetId),nameof(Edit),nameof(Gestalt),nameof(Help),nameof(HelpCount),nameof(IsGlobal),nameof(Locked),nameof(Synonyms),nameof(SynonymsCount),nameof(Tags),nameof(TagsCount),nameof(Team),nameof(TeamId),nameof(Type),nameof(TypeId),nameof(Updated),nameof(User),nameof(UserId),nameof(VariableRules),nameof(VariableRulesCount),nameof(VersionNo),nameof(View),nameof(Workflows),nameof(WorkflowsCount)})]
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
            nameof(Bindings), nameof(BindingsCount), nameof(Broadcasts), nameof(BroadcastsCount), nameof(Help), nameof(HelpCount), nameof(Synonyms), nameof(SynonymsCount), nameof(Tags), nameof(TagsCount), nameof(VariableRules), nameof(VariableRulesCount), nameof(Workflows), nameof(WorkflowsCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<Scope>();
    }
    
    [Route("/scope/{Id}/copy", "POST")]
    public partial class ScopeCopy : Scope {}
    public partial class ScopeSearchBase : Search<Scope>
    {
        public int? Id { get; set; }
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public List<int> BindingsIds { get; set; }
        public List<int> BroadcastsIds { get; set; }
        public Reference Client { get; set; }
        public List<int> ClientIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false", "null"})]
        public List<bool?> Delete { get; set; }
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false", "null"})]
        public List<bool?> Edit { get; set; }
        public List<int> HelpIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false", "null"})]
        public List<bool?> IsGlobal { get; set; }
        public List<int> SynonymsIds { get; set; }
        public List<int> TagsIds { get; set; }
        public Reference Team { get; set; }
        public List<int> TeamIds { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"App",@"Client",@"Compound",@"DocumentSet",@"Global",@"Team",@"User"})]
        public List<string> TypeNames { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public List<int> VariableRulesIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false", "null"})]
        public List<bool?> View { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }

    [Route("/scope", "GET")]
    [Route("/scope/version", "GET, POST")]
    [Route("/scope/search", "GET, POST, DELETE")]
    public partial class ScopeSearch : ScopeSearchBase
    {
    }

    public class ScopeFullTextSearch
    {
        public ScopeFullTextSearch() {}
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
        public bool doBindings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Bindings))); }
        public bool doBroadcasts { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Broadcasts))); }
        public bool doClient { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Client))); }
        public bool doDelete { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Delete))); }
        public bool doDocumentSet { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.DocumentSet))); }
        public bool doEdit { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Edit))); }
        public bool doHelp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Help))); }
        public bool doIsGlobal { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.IsGlobal))); }
        public bool doSynonyms { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Synonyms))); }
        public bool doTags { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Tags))); }
        public bool doTeam { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Team))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Type))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.User))); }
        public bool doVariableRules { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.VariableRules))); }
        public bool doView { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.View))); }
        public bool doWorkflows { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Scope.Workflows))); }
    }

    [Route("/scope/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ScopeBatch : List<Scope> { }

    [Route("/scope/{Id}/{Junction}/version", "GET, POST")]
    [Route("/scope/{Id}/{Junction}", "GET, POST, DELETE")]
    public class ScopeJunction : ScopeSearchBase {}


}
