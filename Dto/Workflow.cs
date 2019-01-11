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
    public abstract partial class WorkflowBase : Dto<Workflow>
    {
        public WorkflowBase() {}

        public WorkflowBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public WorkflowBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Archived), Description = "bool?", IsRequired = false)]
        public bool? Archived { get; set; }


        [ApiMember(Name = nameof(Bindings), Description = "LookupTableBinding", IsRequired = false)]
        public List<Reference> Bindings { get; set; }
        public int? BindingsCount { get; set; }


        [ApiMember(Name = nameof(Comments), Description = "WorkflowComment", IsRequired = false)]
        public List<Reference> Comments { get; set; }
        public int? CommentsCount { get; set; }


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


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Requested",@"Collected",@"Unavailable"})]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }


        [ApiMember(Name = nameof(Tags), Description = "Tag", IsRequired = false)]
        public List<Reference> Tags { get; set; }
        public int? TagsCount { get; set; }


        [ApiMember(Name = nameof(Tasks), Description = "WorkflowTask", IsRequired = false)]
        public List<Reference> Tasks { get; set; }
        public int? TasksCount { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Audit Error",@"Bayesian NMA",@"Cohort Analysis",@"Custom Report",@"Data Export",@"DIA Project",@"DIA Report",@"DOC Data Project",@"DOC Extract Project",@"DOC Library Project",@"Evidence on Demand",@"Evidence Statements",@"Evidence Table",@"Filter",@"Framed Question Data Set",@"Framed Question Library",@"Frequentist NMA",@"HTA",@"Direct Meta Analysis",@"Methodology Project",@"Nameset",@"Ontology Project",@"PICO Rating",@"Rapid Review",@"Response Letter",@"Risk of Bias",@"R Snippet",@"RMD Snippet",@"FAQ",@"Survey Design",@"Survery Wizard",@"Systematic Review",@"Tag",@"View"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


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


    }

    [Route("/workflow", "POST")]
    [Route("/profile/workflow", "POST")]
    [Route("/workflow/{Id}", "GET, PATCH, PUT")]
    [Route("/profile/workflow/{Id}", "GET, PATCH, PUT")]
    public partial class Workflow : WorkflowBase, IReturn<Workflow>, IDto
    {
        public Workflow()
        {
            _Constructor();
        }

        public Workflow(int? id) : base(DocConvert.ToInt(id)) {}
        public Workflow(int id) : base(id) {}
        
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

        public static List<string> Fields => DocTools.Fields<Workflow>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Archived),nameof(Bindings),nameof(BindingsCount),nameof(Comments),nameof(CommentsCount),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Description),nameof(Documents),nameof(DocumentsCount),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Owner),nameof(OwnerId),nameof(Scopes),nameof(ScopesCount),nameof(Status),nameof(StatusId),nameof(Tags),nameof(TagsCount),nameof(Tasks),nameof(TasksCount),nameof(Type),nameof(TypeId),nameof(Updated),nameof(User),nameof(UserId),nameof(Variables),nameof(VariablesCount),nameof(VersionNo),nameof(Workflows),nameof(WorkflowsCount)})]
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
            nameof(Bindings), nameof(BindingsCount), nameof(Comments), nameof(CommentsCount), nameof(Documents), nameof(DocumentsCount), nameof(Scopes), nameof(ScopesCount), nameof(Tags), nameof(TagsCount), nameof(Tasks), nameof(TasksCount), nameof(Variables), nameof(VariablesCount), nameof(Workflows), nameof(WorkflowsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Workflow/{Id}/copy", "POST")]
    [Route("/profile/Workflow/{Id}/copy", "POST")]
    public partial class WorkflowCopy : Workflow {}
    [Route("/workflow", "GET")]
    [Route("/profile/workflow", "GET")]
    [Route("/workflow/search", "GET, POST, DELETE")]
    [Route("/profile/workflow/search", "GET, POST, DELETE")]
    public partial class WorkflowSearch : Search<Workflow>
    {
        public bool? Archived { get; set; }
        public List<int> BindingsIds { get; set; }
        public List<int> CommentsIds { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public List<int> DocumentsIds { get; set; }
        public string Name { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public Reference Status { get; set; }
        public List<int> StatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Requested",@"Collected",@"Unavailable"})]
        public List<string> StatusNames { get; set; }
        public List<int> TagsIds { get; set; }
        public List<int> TasksIds { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Audit Error",@"Bayesian NMA",@"Cohort Analysis",@"Custom Report",@"Data Export",@"DIA Project",@"DIA Report",@"DOC Data Project",@"DOC Extract Project",@"DOC Library Project",@"Evidence on Demand",@"Evidence Statements",@"Evidence Table",@"Filter",@"Framed Question Data Set",@"Framed Question Library",@"Frequentist NMA",@"HTA",@"Direct Meta Analysis",@"Methodology Project",@"Nameset",@"Ontology Project",@"PICO Rating",@"Rapid Review",@"Response Letter",@"Risk of Bias",@"R Snippet",@"RMD Snippet",@"FAQ",@"Survey Design",@"Survery Wizard",@"Systematic Review",@"Tag",@"View"})]
        public List<string> TypeNames { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public List<int> VariablesIds { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }
    
    public class WorkflowFullTextSearch
    {
        private WorkflowSearch _request;
        public WorkflowFullTextSearch(WorkflowSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Updated))); }
        
        public bool doArchived { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Archived))); }
        public bool doBindings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Bindings))); }
        public bool doComments { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Comments))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Data))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Description))); }
        public bool doDocuments { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Documents))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Name))); }
        public bool doOwner { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Owner))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Scopes))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Status))); }
        public bool doTags { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Tags))); }
        public bool doTasks { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Tasks))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Type))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.User))); }
        public bool doVariables { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Variables))); }
        public bool doWorkflows { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Workflow.Workflows))); }
    }

    [Route("/workflow/version", "GET, POST")]
    public partial class WorkflowVersion : WorkflowSearch {}

    [Route("/workflow/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/workflow/batch", "DELETE, PATCH, POST, PUT")]
    public partial class WorkflowBatch : List<Workflow> { }

    [Route("/workflow/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/profile/workflow/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/workflow/{Id}/workflowcomment", "GET, POST, DELETE")]
    [Route("/profile/workflow/{Id}/workflowcomment", "GET, POST, DELETE")]
    [Route("/workflow/{Id}/document", "GET, POST, DELETE")]
    [Route("/profile/workflow/{Id}/document", "GET, POST, DELETE")]
    [Route("/workflow/{Id}/scope", "GET, POST, DELETE")]
    [Route("/profile/workflow/{Id}/scope", "GET, POST, DELETE")]
    [Route("/workflow/{Id}/tag", "GET, POST, DELETE")]
    [Route("/profile/workflow/{Id}/tag", "GET, POST, DELETE")]
    [Route("/workflow/{Id}/workflowtask", "GET, POST, DELETE")]
    [Route("/profile/workflow/{Id}/workflowtask", "GET, POST, DELETE")]
    [Route("/workflow/{Id}/variableinstance", "GET, POST, DELETE")]
    [Route("/profile/workflow/{Id}/variableinstance", "GET, POST, DELETE")]
    [Route("/workflow/{Id}/workflow", "GET, POST, DELETE")]
    [Route("/profile/workflow/{Id}/workflow", "GET, POST, DELETE")]
    public class WorkflowJunction : Search<Workflow>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public WorkflowJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/workflow/{Id}/lookuptablebinding/version", "GET")]
    [Route("/profile/workflow/{Id}/lookuptablebinding/version", "GET")]
    [Route("/workflow/{Id}/workflowcomment/version", "GET")]
    [Route("/profile/workflow/{Id}/workflowcomment/version", "GET")]
    [Route("/workflow/{Id}/document/version", "GET")]
    [Route("/profile/workflow/{Id}/document/version", "GET")]
    [Route("/workflow/{Id}/scope/version", "GET")]
    [Route("/profile/workflow/{Id}/scope/version", "GET")]
    [Route("/workflow/{Id}/tag/version", "GET")]
    [Route("/profile/workflow/{Id}/tag/version", "GET")]
    [Route("/workflow/{Id}/workflowtask/version", "GET")]
    [Route("/profile/workflow/{Id}/workflowtask/version", "GET")]
    [Route("/workflow/{Id}/variableinstance/version", "GET")]
    [Route("/profile/workflow/{Id}/variableinstance/version", "GET")]
    [Route("/workflow/{Id}/workflow/version", "GET")]
    [Route("/profile/workflow/{Id}/workflow/version", "GET")]
    public class WorkflowJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/workflow/ids", "GET, POST")]
    public class WorkflowIds
    {
        public bool All { get; set; }
    }
}