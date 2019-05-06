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
    public abstract partial class WorkflowBase : Dto<Workflow>
    {
        public WorkflowBase() {}

        public WorkflowBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public WorkflowBase(int? id) : this(DocConvert.ToInt(id)) {}

        public WorkflowBase(int? pId, List<Reference> pBindings, int? pBindingsCount, string pData, string pDescription, List<Reference> pDocuments, int? pDocumentsCount, string pName, Reference pOwner, int? pOwnerId, List<Reference> pScopes, int? pScopesCount, WorkflowStatusEnm? pStatus, List<Reference> pTasks, int? pTasksCount, WorkflowEnm? pType, Reference pUser, int? pUserId, List<Reference> pVariables, int? pVariablesCount, List<Reference> pWorkflows, int? pWorkflowsCount) : this(DocConvert.ToInt(pId)) 
        {
            Bindings = pBindings;
            BindingsCount = pBindingsCount;
            Data = pData;
            Description = pDescription;
            Documents = pDocuments;
            DocumentsCount = pDocumentsCount;
            Name = pName;
            Owner = pOwner;
            OwnerId = pOwnerId;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Status = pStatus;
            Tasks = pTasks;
            TasksCount = pTasksCount;
            Type = pType;
            User = pUser;
            UserId = pUserId;
            Variables = pVariables;
            VariablesCount = pVariablesCount;
            Workflows = pWorkflows;
            WorkflowsCount = pWorkflowsCount;
        }

        [ApiMember(Name = nameof(Bindings), Description = "LookupTableBinding", IsRequired = false)]
        public List<Reference> Bindings { get; set; }
        public int? BindingsCount { get; set; }


        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        public string Data { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Documents), Description = "Document", IsRequired = false)]
        public List<Reference> Documents { get; set; }
        public int? DocumentsCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Owner), Description = "Workflow", IsRequired = false)]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of Workflow", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Accepted",@"Collected",@"Rejected",@"Requested",@"Unavailable"})]
        [ApiMember(Name = nameof(Status), Description = "WorkflowStatusEnm?", IsRequired = false)]
        public WorkflowStatusEnm? Status { get; set; }


        [ApiMember(Name = nameof(Tasks), Description = "Task", IsRequired = false)]
        public List<Reference> Tasks { get; set; }
        public int? TasksCount { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Audit Error",@"Bayesian NMA",@"Cohort Analysis",@"Custom Report",@"Data Export",@"DIA Report",@"Evidence on Demand",@"Evidence Statements",@"Evidence Table",@"FAQ",@"Filter",@"Framed Question Data Set",@"Framed Question Library",@"Frequentist NMA",@"HTA",@"Library Ratings",@"Direct Meta Analysis",@"Nameset",@"R Snippet",@"Rapid Review",@"Ratings Adjudication",@"Response Letter",@"Risk of Bias",@"RMD Snippet",@"Systematic Review",@"View"})]
        [ApiMember(Name = nameof(Type), Description = "WorkflowEnm?", IsRequired = false)]
        public WorkflowEnm? Type { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(Variables), Description = "VariableInstance", IsRequired = false)]
        public List<Reference> Variables { get; set; }
        public int? VariablesCount { get; set; }


        [ApiMember(Name = nameof(Workflows), Description = "Workflow", IsRequired = false)]
        public List<Reference> Workflows { get; set; }
        public int? WorkflowsCount { get; set; }



        public void Deconstruct(out List<Reference> pBindings, out int? pBindingsCount, out string pData, out string pDescription, out List<Reference> pDocuments, out int? pDocumentsCount, out string pName, out Reference pOwner, out int? pOwnerId, out List<Reference> pScopes, out int? pScopesCount, out WorkflowStatusEnm? pStatus, out List<Reference> pTasks, out int? pTasksCount, out WorkflowEnm? pType, out Reference pUser, out int? pUserId, out List<Reference> pVariables, out int? pVariablesCount, out List<Reference> pWorkflows, out int? pWorkflowsCount)
        {
            pBindings = Bindings;
            pBindingsCount = BindingsCount;
            pData = Data;
            pDescription = Description;
            pDocuments = Documents;
            pDocumentsCount = DocumentsCount;
            pName = Name;
            pOwner = Owner;
            pOwnerId = OwnerId;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pStatus = Status;
            pTasks = Tasks;
            pTasksCount = TasksCount;
            pType = Type;
            pUser = User;
            pUserId = UserId;
            pVariables = Variables;
            pVariablesCount = VariablesCount;
            pWorkflows = Workflows;
            pWorkflowsCount = WorkflowsCount;
        }

        //Not ready until C# v8.?
        //public WorkflowBase With(int? pId = Id, List<Reference> pBindings = Bindings, int? pBindingsCount = BindingsCount, string pData = Data, string pDescription = Description, List<Reference> pDocuments = Documents, int? pDocumentsCount = DocumentsCount, string pName = Name, Reference pOwner = Owner, int? pOwnerId = OwnerId, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, WorkflowStatusEnm? pStatus = Status, List<Reference> pTasks = Tasks, int? pTasksCount = TasksCount, WorkflowEnm? pType = Type, Reference pUser = User, int? pUserId = UserId, List<Reference> pVariables = Variables, int? pVariablesCount = VariablesCount, List<Reference> pWorkflows = Workflows, int? pWorkflowsCount = WorkflowsCount) => 
        //	new WorkflowBase(pId, pBindings, pBindingsCount, pData, pDescription, pDocuments, pDocumentsCount, pName, pOwner, pOwnerId, pScopes, pScopesCount, pStatus, pTasks, pTasksCount, pType, pUser, pUserId, pVariables, pVariablesCount, pWorkflows, pWorkflowsCount);

    }

    [Route("/workflow", "POST")]
    [Route("/workflow/{Id}", "GET, PATCH, PUT")]
    public partial class Workflow : WorkflowBase, IReturn<Workflow>, IDto, ICloneable
    {
        public Workflow()
        {
            _Constructor();
        }

        public Workflow(int? id) : base(DocConvert.ToInt(id)) {}
        public Workflow(int id) : base(id) {}
        public Workflow(int? pId, List<Reference> pBindings, int? pBindingsCount, string pData, string pDescription, List<Reference> pDocuments, int? pDocumentsCount, string pName, Reference pOwner, int? pOwnerId, List<Reference> pScopes, int? pScopesCount, WorkflowStatusEnm? pStatus, List<Reference> pTasks, int? pTasksCount, WorkflowEnm? pType, Reference pUser, int? pUserId, List<Reference> pVariables, int? pVariablesCount, List<Reference> pWorkflows, int? pWorkflowsCount) : 
            base(pId, pBindings, pBindingsCount, pData, pDescription, pDocuments, pDocumentsCount, pName, pOwner, pOwnerId, pScopes, pScopesCount, pStatus, pTasks, pTasksCount, pType, pUser, pUserId, pVariables, pVariablesCount, pWorkflows, pWorkflowsCount) { }
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

        public static List<string> Fields => DocTools.Fields<Workflow>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Bindings),nameof(BindingsCount),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Description),nameof(Documents),nameof(DocumentsCount),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Owner),nameof(OwnerId),nameof(Scopes),nameof(ScopesCount),nameof(Status),nameof(Tasks),nameof(TasksCount),nameof(Type),nameof(Updated),nameof(User),nameof(UserId),nameof(Variables),nameof(VariablesCount),nameof(VersionNo),nameof(Workflows),nameof(WorkflowsCount)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Workflow>("Workflow",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Bindings), nameof(BindingsCount), nameof(Documents), nameof(DocumentsCount), nameof(Scopes), nameof(ScopesCount), nameof(Tasks), nameof(TasksCount), nameof(Variables), nameof(VariablesCount), nameof(Workflows), nameof(WorkflowsCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<Workflow>();
    }
    
    [Route("/workflow/{Id}/copy", "POST")]
    public partial class WorkflowCopy : Workflow {}
    public partial class WorkflowSearchBase : Search<Workflow>
    {
        public int? Id { get; set; }
        public List<int> BindingsIds { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public List<int> DocumentsIds { get; set; }
        public string Name { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public WorkflowStatusEnm? Status { get; set; }
        public List<int> TasksIds { get; set; }
        public WorkflowEnm? Type { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public List<int> VariablesIds { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }

    [Route("/workflow", "GET")]
    [Route("/workflow/version", "GET, POST")]
    [Route("/workflow/search", "GET, POST, DELETE")]
    public partial class WorkflowSearch : WorkflowSearchBase
    {
    }

    public class WorkflowFullTextSearch
    {
        public WorkflowFullTextSearch() {}
        private WorkflowSearch _request;
        public WorkflowFullTextSearch(WorkflowSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Updated))); }

        public bool doBindings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Bindings))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Data))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Description))); }
        public bool doDocuments { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Documents))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Name))); }
        public bool doOwner { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Owner))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Scopes))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Status))); }
        public bool doTasks { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Tasks))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Type))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.User))); }
        public bool doVariables { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Variables))); }
        public bool doWorkflows { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Workflows))); }
    }

    [Route("/workflow/batch", "DELETE, PATCH, POST, PUT")]
    public partial class WorkflowBatch : List<Workflow> { }

    [Route("/workflow/{Id}/{Junction}/version", "GET, POST")]
    [Route("/workflow/{Id}/{Junction}", "GET, POST, DELETE")]
    public class WorkflowJunction : WorkflowSearchBase {}


}
