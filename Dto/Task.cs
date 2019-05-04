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
    public abstract partial class TaskBase : Dto<Task>
    {
        public TaskBase() {}

        public TaskBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TaskBase(int? id) : this(DocConvert.ToInt(id)) {}

        public TaskBase(int? pId, Reference pAssignee, int? pAssigneeId, string pData, string pDescription, DateTime? pDueDate, Reference pReporter, int? pReporterId, TaskTypeEnm? pType, Reference pWorkflow, int? pWorkflowId) : this(DocConvert.ToInt(pId)) 
        {
            Assignee = pAssignee;
            AssigneeId = pAssigneeId;
            Data = pData;
            Description = pDescription;
            DueDate = pDueDate;
            Reporter = pReporter;
            ReporterId = pReporterId;
            Type = pType;
            Workflow = pWorkflow;
            WorkflowId = pWorkflowId;
        }

        [ApiMember(Name = nameof(Assignee), Description = "User", IsRequired = false)]
        public Reference Assignee { get; set; }
        [ApiMember(Name = nameof(AssigneeId), Description = "Primary Key of User", IsRequired = false)]
        public int? AssigneeId { get; set; }


        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        public string Data { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = true)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(DueDate), Description = "DateTime?", IsRequired = false)]
        public DateTime? DueDate { get; set; }


        [ApiMember(Name = nameof(Reporter), Description = "User", IsRequired = true)]
        public Reference Reporter { get; set; }
        [ApiMember(Name = nameof(ReporterId), Description = "Primary Key of User", IsRequired = false)]
        public int? ReporterId { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Evidence on Demand",@"Library Rating"})]
        [ApiMember(Name = nameof(Type), Description = "TaskTypeEnm?", IsRequired = false)]
        public TaskTypeEnm? Type { get; set; }


        [ApiMember(Name = nameof(Workflow), Description = "Workflow", IsRequired = true)]
        public Reference Workflow { get; set; }
        [ApiMember(Name = nameof(WorkflowId), Description = "Primary Key of Workflow", IsRequired = false)]
        public int? WorkflowId { get; set; }



        public void Deconstruct(out Reference pAssignee, out int? pAssigneeId, out string pData, out string pDescription, out DateTime? pDueDate, out Reference pReporter, out int? pReporterId, out TaskTypeEnm? pType, out Reference pWorkflow, out int? pWorkflowId)
        {
            pAssignee = Assignee;
            pAssigneeId = AssigneeId;
            pData = Data;
            pDescription = Description;
            pDueDate = DueDate;
            pReporter = Reporter;
            pReporterId = ReporterId;
            pType = Type;
            pWorkflow = Workflow;
            pWorkflowId = WorkflowId;
        }

        //Not ready until C# v8.?
        //public TaskBase With(int? pId = Id, Reference pAssignee = Assignee, int? pAssigneeId = AssigneeId, string pData = Data, string pDescription = Description, DateTime? pDueDate = DueDate, Reference pReporter = Reporter, int? pReporterId = ReporterId, TaskTypeEnm? pType = Type, Reference pWorkflow = Workflow, int? pWorkflowId = WorkflowId) => 
        //	new TaskBase(pId, pAssignee, pAssigneeId, pData, pDescription, pDueDate, pReporter, pReporterId, pType, pWorkflow, pWorkflowId);

    }

    [Route("/task", "POST")]
    [Route("/task/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Task : TaskBase, IReturn<Task>, IDto, ICloneable
    {
        public Task()
        {
            _Constructor();
        }

        public Task(int? id) : base(DocConvert.ToInt(id)) {}
        public Task(int id) : base(id) {}
        public Task(int? pId, Reference pAssignee, int? pAssigneeId, string pData, string pDescription, DateTime? pDueDate, Reference pReporter, int? pReporterId, TaskTypeEnm? pType, Reference pWorkflow, int? pWorkflowId) : 
            base(pId, pAssignee, pAssigneeId, pData, pDescription, pDueDate, pReporter, pReporterId, pType, pWorkflow, pWorkflowId) { }
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

        public static List<string> Fields => DocTools.Fields<Task>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Assignee),nameof(AssigneeId),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Description),nameof(DueDate),nameof(Gestalt),nameof(Locked),nameof(Reporter),nameof(ReporterId),nameof(Type),nameof(Updated),nameof(VersionNo),nameof(Workflow),nameof(WorkflowId)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Task>("Task",exists);
            }
        }

        #endregion Fields

        public object Clone() => this.Copy<Task>();
    }
    
    [Route("/task/{Id}/copy", "POST")]
    public partial class TaskCopy : Task {}
    public partial class TaskSearchBase : Search<Task>
    {
        public int? Id { get; set; }
        public Reference Assignee { get; set; }
        public List<int> AssigneeIds { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DueDateAfter { get; set; }
        public DateTime? DueDateBefore { get; set; }
        public Reference Reporter { get; set; }
        public List<int> ReporterIds { get; set; }
        public TaskTypeEnm? Type { get; set; }
        public Reference Workflow { get; set; }
        public List<int> WorkflowIds { get; set; }
    }

    [Route("/task", "GET")]
    [Route("/task/version", "GET, POST")]
    [Route("/task/search", "GET, POST, DELETE")]
    public partial class TaskSearch : TaskSearchBase
    {
    }

    public class TaskFullTextSearch
    {
        public TaskFullTextSearch() {}
        private TaskSearch _request;
        public TaskFullTextSearch(TaskSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.Updated))); }

        public bool doAssignee { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.Assignee))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.Data))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.Description))); }
        public bool doDueDate { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.DueDate))); }
        public bool doReporter { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.Reporter))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.Type))); }
        public bool doWorkflow { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Task.Workflow))); }
    }

    [Route("/task/batch", "DELETE, PATCH, POST, PUT")]
    public partial class TaskBatch : List<Task> { }

}
