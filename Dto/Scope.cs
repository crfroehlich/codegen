
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
    public abstract partial class ScopeBase : Dto<Scope>
    {
        public ScopeBase() {}

        public ScopeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ScopeBase(int? id) : this(DocConvert.ToInt(id)) {}

        public ScopeBase(int? pId, Reference pApp, int? pAppId, List<Reference> pBindings, int? pBindingsCount, List<Reference> pBroadcasts, int? pBroadcastsCount, Reference pClient, int? pClientId, bool pDelete, Reference pDocumentSet, int? pDocumentSetId, bool pEdit, List<Reference> pFiles, int? pFilesCount, List<Reference> pHelp, int? pHelpCount, bool pIsGlobal, List<Reference> pScopedComments, int? pScopedCommentsCount, List<Reference> pScopedTags, int? pScopedTagsCount, List<Reference> pSynonyms, int? pSynonymsCount, Reference pTeam, int? pTeamId, ScopeEnm? pType, Reference pUser, int? pUserId, List<Reference> pVariableRules, int? pVariableRulesCount, bool pView, List<Reference> pWorkflows, int? pWorkflowsCount) : this(DocConvert.ToInt(pId)) 
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
            Files = pFiles;
            FilesCount = pFilesCount;
            Help = pHelp;
            HelpCount = pHelpCount;
            IsGlobal = pIsGlobal;
            ScopedComments = pScopedComments;
            ScopedCommentsCount = pScopedCommentsCount;
            ScopedTags = pScopedTags;
            ScopedTagsCount = pScopedTagsCount;
            Synonyms = pSynonyms;
            SynonymsCount = pSynonymsCount;
            Team = pTeam;
            TeamId = pTeamId;
            Type = pType;
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
        public List<int> BindingsIds { get; set; }
        public int? BindingsCount { get; set; }


        [ApiMember(Name = nameof(Broadcasts), Description = "Broadcast", IsRequired = false)]
        public List<Reference> Broadcasts { get; set; }
        public List<int> BroadcastsIds { get; set; }
        public int? BroadcastsCount { get; set; }


        [ApiMember(Name = nameof(Client), Description = "Client", IsRequired = false)]
        public Reference Client { get; set; }
        [ApiMember(Name = nameof(ClientId), Description = "Primary Key of Client", IsRequired = false)]
        public int? ClientId { get; set; }


        [ApiMember(Name = nameof(Delete), Description = "bool", IsRequired = false)]
        public bool Delete { get; set; }


        [ApiMember(Name = nameof(DocumentSet), Description = "DocumentSet", IsRequired = false)]
        public Reference DocumentSet { get; set; }
        [ApiMember(Name = nameof(DocumentSetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DocumentSetId { get; set; }


        [ApiMember(Name = nameof(Edit), Description = "bool", IsRequired = false)]
        public bool Edit { get; set; }


        [ApiMember(Name = nameof(Files), Description = "File", IsRequired = false)]
        public List<Reference> Files { get; set; }
        public List<int> FilesIds { get; set; }
        public int? FilesCount { get; set; }


        [ApiMember(Name = nameof(Help), Description = "Help", IsRequired = false)]
        public List<Reference> Help { get; set; }
        public List<int> HelpIds { get; set; }
        public int? HelpCount { get; set; }


        [ApiMember(Name = nameof(IsGlobal), Description = "bool", IsRequired = false)]
        public bool IsGlobal { get; set; }


        [ApiMember(Name = nameof(ScopedComments), Description = "Comment", IsRequired = false)]
        public List<Reference> ScopedComments { get; set; }
        public List<int> ScopedCommentsIds { get; set; }
        public int? ScopedCommentsCount { get; set; }


        [ApiMember(Name = nameof(ScopedTags), Description = "Tag", IsRequired = false)]
        public List<Reference> ScopedTags { get; set; }
        public List<int> ScopedTagsIds { get; set; }
        public int? ScopedTagsCount { get; set; }


        [ApiMember(Name = nameof(Synonyms), Description = "TermSynonym", IsRequired = false)]
        public List<Reference> Synonyms { get; set; }
        public List<int> SynonymsIds { get; set; }
        public int? SynonymsCount { get; set; }


        [ApiMember(Name = nameof(Team), Description = "Team", IsRequired = false)]
        public Reference Team { get; set; }
        [ApiMember(Name = nameof(TeamId), Description = "Primary Key of Team", IsRequired = false)]
        public int? TeamId { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"App",@"Client",@"Compound",@"DocumentSet",@"Global",@"Team",@"User"})]
        [ApiMember(Name = nameof(Type), Description = "ScopeEnm?", IsRequired = false)]
        public ScopeEnm? Type { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = false)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(VariableRules), Description = "VariableRule", IsRequired = false)]
        public List<Reference> VariableRules { get; set; }
        public List<int> VariableRulesIds { get; set; }
        public int? VariableRulesCount { get; set; }


        [ApiMember(Name = nameof(View), Description = "bool", IsRequired = false)]
        public bool View { get; set; }


        [ApiMember(Name = nameof(Workflows), Description = "Workflow", IsRequired = false)]
        public List<Reference> Workflows { get; set; }
        public List<int> WorkflowsIds { get; set; }
        public int? WorkflowsCount { get; set; }



        public void Deconstruct(out Reference pApp, out int? pAppId, out List<Reference> pBindings, out int? pBindingsCount, out List<Reference> pBroadcasts, out int? pBroadcastsCount, out Reference pClient, out int? pClientId, out bool pDelete, out Reference pDocumentSet, out int? pDocumentSetId, out bool pEdit, out List<Reference> pFiles, out int? pFilesCount, out List<Reference> pHelp, out int? pHelpCount, out bool pIsGlobal, out List<Reference> pScopedComments, out int? pScopedCommentsCount, out List<Reference> pScopedTags, out int? pScopedTagsCount, out List<Reference> pSynonyms, out int? pSynonymsCount, out Reference pTeam, out int? pTeamId, out ScopeEnm? pType, out Reference pUser, out int? pUserId, out List<Reference> pVariableRules, out int? pVariableRulesCount, out bool pView, out List<Reference> pWorkflows, out int? pWorkflowsCount)
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
            pFiles = Files;
            pFilesCount = FilesCount;
            pHelp = Help;
            pHelpCount = HelpCount;
            pIsGlobal = IsGlobal;
            pScopedComments = ScopedComments;
            pScopedCommentsCount = ScopedCommentsCount;
            pScopedTags = ScopedTags;
            pScopedTagsCount = ScopedTagsCount;
            pSynonyms = Synonyms;
            pSynonymsCount = SynonymsCount;
            pTeam = Team;
            pTeamId = TeamId;
            pType = Type;
            pUser = User;
            pUserId = UserId;
            pVariableRules = VariableRules;
            pVariableRulesCount = VariableRulesCount;
            pView = View;
            pWorkflows = Workflows;
            pWorkflowsCount = WorkflowsCount;
        }

        //Not ready until C# v8.?
        //public ScopeBase With(int? pId = Id, Reference pApp = App, int? pAppId = AppId, List<Reference> pBindings = Bindings, int? pBindingsCount = BindingsCount, List<Reference> pBroadcasts = Broadcasts, int? pBroadcastsCount = BroadcastsCount, Reference pClient = Client, int? pClientId = ClientId, bool pDelete = Delete, Reference pDocumentSet = DocumentSet, int? pDocumentSetId = DocumentSetId, bool pEdit = Edit, List<Reference> pFiles = Files, int? pFilesCount = FilesCount, List<Reference> pHelp = Help, int? pHelpCount = HelpCount, bool pIsGlobal = IsGlobal, List<Reference> pScopedComments = ScopedComments, int? pScopedCommentsCount = ScopedCommentsCount, List<Reference> pScopedTags = ScopedTags, int? pScopedTagsCount = ScopedTagsCount, List<Reference> pSynonyms = Synonyms, int? pSynonymsCount = SynonymsCount, Reference pTeam = Team, int? pTeamId = TeamId, ScopeEnm? pType = Type, Reference pUser = User, int? pUserId = UserId, List<Reference> pVariableRules = VariableRules, int? pVariableRulesCount = VariableRulesCount, bool pView = View, List<Reference> pWorkflows = Workflows, int? pWorkflowsCount = WorkflowsCount) => 
        //	new ScopeBase(pId, pApp, pAppId, pBindings, pBindingsCount, pBroadcasts, pBroadcastsCount, pClient, pClientId, pDelete, pDocumentSet, pDocumentSetId, pEdit, pFiles, pFilesCount, pHelp, pHelpCount, pIsGlobal, pScopedComments, pScopedCommentsCount, pScopedTags, pScopedTagsCount, pSynonyms, pSynonymsCount, pTeam, pTeamId, pType, pUser, pUserId, pVariableRules, pVariableRulesCount, pView, pWorkflows, pWorkflowsCount);

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
        public Scope(int? pId, Reference pApp, int? pAppId, List<Reference> pBindings, int? pBindingsCount, List<Reference> pBroadcasts, int? pBroadcastsCount, Reference pClient, int? pClientId, bool pDelete, Reference pDocumentSet, int? pDocumentSetId, bool pEdit, List<Reference> pFiles, int? pFilesCount, List<Reference> pHelp, int? pHelpCount, bool pIsGlobal, List<Reference> pScopedComments, int? pScopedCommentsCount, List<Reference> pScopedTags, int? pScopedTagsCount, List<Reference> pSynonyms, int? pSynonymsCount, Reference pTeam, int? pTeamId, ScopeEnm? pType, Reference pUser, int? pUserId, List<Reference> pVariableRules, int? pVariableRulesCount, bool pView, List<Reference> pWorkflows, int? pWorkflowsCount) : 
            base(pId, pApp, pAppId, pBindings, pBindingsCount, pBroadcasts, pBroadcastsCount, pClient, pClientId, pDelete, pDocumentSet, pDocumentSetId, pEdit, pFiles, pFilesCount, pHelp, pHelpCount, pIsGlobal, pScopedComments, pScopedCommentsCount, pScopedTags, pScopedTagsCount, pSynonyms, pSynonymsCount, pTeam, pTeamId, pType, pUser, pUserId, pVariableRules, pVariableRulesCount, pView, pWorkflows, pWorkflowsCount) { }

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Scope>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Bindings),nameof(BindingsCount),nameof(Broadcasts),nameof(BroadcastsCount),nameof(Client),nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(Delete),nameof(DocumentSet),nameof(DocumentSetId),nameof(Edit),nameof(Files),nameof(FilesCount),nameof(Gestalt),nameof(Help),nameof(HelpCount),nameof(IsGlobal),nameof(Locked),nameof(ScopedComments),nameof(ScopedCommentsCount),nameof(ScopedTags),nameof(ScopedTagsCount),nameof(Synonyms),nameof(SynonymsCount),nameof(Team),nameof(TeamId),nameof(Type),nameof(Updated),nameof(User),nameof(UserId),nameof(VariableRules),nameof(VariableRulesCount),nameof(VersionNo),nameof(View),nameof(Workflows),nameof(WorkflowsCount)})]
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
                _Select = DocPermissionFactory.SetSelect<Scope>("Scope",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        private List<string> _collections = new List<string>
        {
            nameof(Bindings), nameof(BindingsCount), nameof(Broadcasts), nameof(BroadcastsCount), nameof(Files), nameof(FilesCount), nameof(Help), nameof(HelpCount), nameof(ScopedComments), nameof(ScopedCommentsCount), nameof(ScopedTags), nameof(ScopedTagsCount), nameof(Synonyms), nameof(SynonymsCount), nameof(VariableRules), nameof(VariableRulesCount), nameof(Workflows), nameof(WorkflowsCount)
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
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> Delete { get; set; }
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> Edit { get; set; }
        public List<int> FilesIds { get; set; }
        public List<int> HelpIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsGlobal { get; set; }
        public List<int> ScopedCommentsIds { get; set; }
        public List<int> ScopedTagsIds { get; set; }
        public List<int> SynonymsIds { get; set; }
        public Reference Team { get; set; }
        public List<int> TeamIds { get; set; }
        public ScopeEnm? Type { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public List<int> VariableRulesIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> View { get; set; }
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Updated))); }

        public bool doApp { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.App))); }
        public bool doBindings { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Bindings))); }
        public bool doBroadcasts { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Broadcasts))); }
        public bool doClient { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Client))); }
        public bool doDelete { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Delete))); }
        public bool doDocumentSet { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.DocumentSet))); }
        public bool doEdit { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Edit))); }
        public bool doFiles { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Files))); }
        public bool doHelp { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Help))); }
        public bool doIsGlobal { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.IsGlobal))); }
        public bool doScopedComments { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.ScopedComments))); }
        public bool doScopedTags { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.ScopedTags))); }
        public bool doSynonyms { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Synonyms))); }
        public bool doTeam { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Team))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Type))); }
        public bool doUser { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.User))); }
        public bool doVariableRules { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.VariableRules))); }
        public bool doView { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.View))); }
        public bool doWorkflows { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Scope.Workflows))); }
    }


    [Route("/scope/batch", "DELETE, PATCH, POST, PUT")]

    public partial class ScopeBatch : List<Scope> { }


    [Route("/scope/{Id}/{Junction}/version", "GET, POST")]
    [Route("/scope/{Id}/{Junction}", "GET, POST, DELETE")]
    public class ScopeJunction : ScopeSearchBase {}



}
