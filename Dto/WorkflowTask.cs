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
    public abstract partial class WorkflowTaskBase : Dto<WorkflowTask>
    {
        public WorkflowTaskBase() {}

        public WorkflowTaskBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public WorkflowTaskBase(int? id) : this(DocConvert.ToInt(id)) {}
    
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


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Requested",@"Collected",@"Unavailable"})]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Evidence on Demand"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


        [ApiMember(Name = nameof(Workflow), Description = "Workflow", IsRequired = true)]
        public Reference Workflow { get; set; }
        [ApiMember(Name = nameof(WorkflowId), Description = "Primary Key of Workflow", IsRequired = false)]
        public int? WorkflowId { get; set; }


    }

    [Route("/workflowtask", "POST")]
    [Route("/profile/workflowtask", "POST")]
    [Route("/workflowtask/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/workflowtask/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class WorkflowTask : WorkflowTaskBase, IReturn<WorkflowTask>, IDto
    {
        public WorkflowTask()
        {
            _Constructor();
        }

        public WorkflowTask(int? id) : base(DocConvert.ToInt(id)) {}
        public WorkflowTask(int id) : base(id) {}
        
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

        private static List<string> _fields;
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<WorkflowTask>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Assignee),nameof(AssigneeId),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Description),nameof(DueDate),nameof(Gestalt),nameof(Locked),nameof(Reporter),nameof(ReporterId),nameof(Status),nameof(StatusId),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo),nameof(Workflow),nameof(WorkflowId)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<WorkflowTask>("WorkflowTask",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/WorkflowTask/{Id}/copy", "POST")]
    [Route("/profile/WorkflowTask/{Id}/copy", "POST")]
    public partial class WorkflowTaskCopy : WorkflowTask {}
    [Route("/workflowtask", "GET")]
    [Route("/profile/workflowtask", "GET")]
    [Route("/workflowtask/search", "GET, POST, DELETE")]
    [Route("/profile/workflowtask/search", "GET, POST, DELETE")]
    public partial class WorkflowTaskSearch : Search<WorkflowTask>
    {
        public Reference Assignee { get; set; }
        public List<int> AssigneeIds { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DueDateAfter { get; set; }
        public DateTime? DueDateBefore { get; set; }
        public Reference Reporter { get; set; }
        public List<int> ReporterIds { get; set; }
        public Reference Status { get; set; }
        public List<int> StatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Requested",@"Collected",@"Unavailable"})]
        public List<string> StatusNames { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Evidence on Demand"})]
        public List<string> TypeNames { get; set; }
        public Reference Workflow { get; set; }
        public List<int> WorkflowIds { get; set; }
    }
    
    public class WorkflowTaskFullTextSearch
    {
        private WorkflowTaskSearch _request;
        public WorkflowTaskFullTextSearch(WorkflowTaskSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Updated))); }
        
        public bool doAssignee { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Assignee))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Data))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Description))); }
        public bool doDueDate { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.DueDate))); }
        public bool doReporter { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Reporter))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Status))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Type))); }
        public bool doWorkflow { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowTask.Workflow))); }
    }

    [Route("/workflowtask/version", "GET, POST")]
    public partial class WorkflowTaskVersion : WorkflowTaskSearch {}

    [Route("/workflowtask/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/workflowtask/batch", "DELETE, PATCH, POST, PUT")]
    public partial class WorkflowTaskBatch : List<WorkflowTask> { }

}