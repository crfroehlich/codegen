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
    public abstract partial class TaskBase : Dto<Task>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TaskBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TaskBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TaskBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Assignee { get; set; }
        [ApiMember(Name = nameof(AssigneeId), Description = "Primary Key of User", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? AssigneeId { get; set; }


        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Data { get; set; }
        [ApiMember(Name = nameof(DataIds), Description = "Data Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DataIds { get; set; }
        [ApiMember(Name = nameof(DataCount), Description = "Data Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DataCount { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Description { get; set; }
        [ApiMember(Name = nameof(DescriptionIds), Description = "Description Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DescriptionIds { get; set; }
        [ApiMember(Name = nameof(DescriptionCount), Description = "Description Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DescriptionCount { get; set; }


        [ApiMember(Name = nameof(DueDate), Description = "DateTime?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime? DueDate { get; set; }
        [ApiMember(Name = nameof(DueDateIds), Description = "DueDate Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DueDateIds { get; set; }
        [ApiMember(Name = nameof(DueDateCount), Description = "DueDate Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DueDateCount { get; set; }


        [ApiMember(Name = nameof(Reporter), Description = "User", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Reporter { get; set; }
        [ApiMember(Name = nameof(ReporterId), Description = "Primary Key of User", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ReporterId { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Document Adjudication",@"Document Rating",@"Document Search Reconciliation",@"Evidence on Demand"})]
        [ApiMember(Name = nameof(Type), Description = "TaskTypeEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TaskTypeEnm? Type { get; set; }
        [ApiMember(Name = nameof(TypeIds), Description = "Type Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> TypeIds { get; set; }
        [ApiMember(Name = nameof(TypeCount), Description = "Type Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? TypeCount { get; set; }


        [ApiMember(Name = nameof(Workflow), Description = "Workflow", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Workflow { get; set; }
        [ApiMember(Name = nameof(WorkflowId), Description = "Primary Key of Workflow", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? WorkflowId { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public TaskBase With(int? pId = Id, Reference pAssignee = Assignee, int? pAssigneeId = AssigneeId, string pData = Data, string pDescription = Description, DateTime? pDueDate = DueDate, Reference pReporter = Reporter, int? pReporterId = ReporterId, TaskTypeEnm? pType = Type, Reference pWorkflow = Workflow, int? pWorkflowId = WorkflowId) => 
        //	new TaskBase(pId, pAssignee, pAssigneeId, pData, pDescription, pDueDate, pReporter, pReporterId, pType, pWorkflow, pWorkflowId);

    }


    [Route("/task", "POST")]
    [Route("/task/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Task : TaskBase, IReturn<Task>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Task() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Task(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Task(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Task(int? pId, Reference pAssignee, int? pAssigneeId, string pData, string pDescription, DateTime? pDueDate, Reference pReporter, int? pReporterId, TaskTypeEnm? pType, Reference pWorkflow, int? pWorkflowId) :
            base(pId, pAssignee, pAssigneeId, pData, pDescription, pDueDate, pReporter, pReporterId, pType, pWorkflow, pWorkflowId) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<Task>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Assignee),nameof(AssigneeId),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Description),nameof(DueDate),nameof(Gestalt),nameof(Locked),nameof(Reporter),nameof(ReporterId),nameof(Type),nameof(Updated),nameof(VersionNo),nameof(Workflow),nameof(WorkflowId)})]
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
                _Select = DocPermissionFactory.SetSelect<Task>("Task",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<Task>();

    }
    

    [Route("/task/{Id}/copy", "POST")]
    public partial class TaskCopy : Task {}

    public partial class TaskSearchBase : Search<Task>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public Reference Assignee { get; set; }
        public List<int> AssigneeIds { get; set; }
        public string Data { get; set; }
        public List<string> Datas { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DueDateAfter { get; set; }
        public DateTime? DueDateBefore { get; set; }
        public Reference Reporter { get; set; }
        public List<int> ReporterIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Document Adjudication",@"Document Rating",@"Document Search Reconciliation",@"Evidence on Demand"})]
        public TaskTypeEnm? Type { get; set; }
        public List<TaskTypeEnm> Types { get; set; }
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TaskFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private TaskSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TaskFullTextSearch(TaskSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.Updated))); }

        public bool doAssignee { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.Assignee))); }
        public bool doData { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.Data))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.Description))); }
        public bool doDueDate { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.DueDate))); }
        public bool doReporter { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.Reporter))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.Type))); }
        public bool doWorkflow { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Task.Workflow))); }
    }


    [Route("/task/batch", "DELETE, PATCH, POST, PUT")]

    public partial class TaskBatch : List<Task> { }


}
