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
    public abstract partial class BackgroundTaskItemBase : Dto<BackgroundTaskItem>
    {
        public BackgroundTaskItemBase() {}

        public BackgroundTaskItemBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public BackgroundTaskItemBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Attempts), Description = "int?", IsRequired = false)]
        public int? Attempts { get; set; }


        [ApiMember(Name = nameof(AuditRecord), Description = "AuditRecord", IsRequired = false)]
        public Reference AuditRecord { get; set; }
        [ApiMember(Name = nameof(AuditRecordId), Description = "Primary Key of AuditRecord", IsRequired = false)]
        public int? AuditRecordId { get; set; }


        [ApiMember(Name = nameof(Data), Description = "JsonObject", IsRequired = false)]
        public JsonObject Data { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Ended), Description = "DateTime?", IsRequired = false)]
        public DateTime? Ended { get; set; }


        [ApiMember(Name = nameof(EntityId), Description = "int?", IsRequired = false)]
        public int? EntityId { get; set; }


        [ApiMember(Name = nameof(ExecutionTime), Description = "string", IsRequired = false)]
        public string ExecutionTime { get; set; }


        [ApiMember(Name = nameof(Started), Description = "DateTime?", IsRequired = false)]
        public DateTime? Started { get; set; }


        [ApiMember(Name = nameof(Status), Description = "string", IsRequired = false)]
        public string Status { get; set; }


        [ApiMember(Name = nameof(Succeeded), Description = "bool", IsRequired = false)]
        public bool Succeeded { get; set; }


        [ApiMember(Name = nameof(Task), Description = "BackgroundTask", IsRequired = true)]
        public Reference Task { get; set; }
        [ApiMember(Name = nameof(TaskId), Description = "Primary Key of BackgroundTask", IsRequired = false)]
        public int? TaskId { get; set; }


        [ApiMember(Name = nameof(TaskHistory), Description = "BackgroundTaskHistory", IsRequired = false)]
        public List<Reference> TaskHistory { get; set; }
        public int? TaskHistoryCount { get; set; }


    }

    [Route("/backgroundtaskitem/{Id}", "GET")]
    [Route("/profile/backgroundtaskitem/{Id}", "GET")]
    public partial class BackgroundTaskItem : BackgroundTaskItemBase, IReturn<BackgroundTaskItem>, IDto
    {
        public BackgroundTaskItem()
        {
            _Constructor();
        }

        public BackgroundTaskItem(int? id) : base(DocConvert.ToInt(id)) {}
        public BackgroundTaskItem(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<BackgroundTaskItem>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Attempts),nameof(AuditRecord),nameof(AuditRecordId),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Description),nameof(Ended),nameof(EntityId),nameof(ExecutionTime),nameof(Gestalt),nameof(Locked),nameof(Started),nameof(Status),nameof(Succeeded),nameof(Task),nameof(TaskHistory),nameof(TaskHistoryCount),nameof(TaskId),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<BackgroundTaskItem>("BackgroundTaskItem",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(TaskHistory), nameof(TaskHistoryCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/backgroundtaskitem", "GET")]
    [Route("/profile/backgroundtaskitem", "GET")]
    [Route("/backgroundtaskitem/search", "GET, POST, DELETE")]
    [Route("/profile/backgroundtaskitem/search", "GET, POST, DELETE")]
    public partial class BackgroundTaskItemSearch : Search<BackgroundTaskItem>
    {
        public int? Attempts { get; set; }
        public Reference AuditRecord { get; set; }
        public List<int> AuditRecordIds { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public DateTime? Ended { get; set; }
        public DateTime? EndedAfter { get; set; }
        public DateTime? EndedBefore { get; set; }
        public int? EntityId { get; set; }
        public string ExecutionTime { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? StartedAfter { get; set; }
        public DateTime? StartedBefore { get; set; }
        public string Status { get; set; }
        public bool? Succeeded { get; set; }
        public Reference Task { get; set; }
        public List<int> TaskIds { get; set; }
        public List<int> TaskHistoryIds { get; set; }
    }
    
    public class BackgroundTaskItemFullTextSearch
    {
        private BackgroundTaskItemSearch _request;
        public BackgroundTaskItemFullTextSearch(BackgroundTaskItemSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Updated))); }
        
        public bool doAttempts { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Attempts))); }
        public bool doAuditRecord { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.AuditRecord))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Data))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Description))); }
        public bool doEnded { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Ended))); }
        public bool doEntityId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.EntityId))); }
        public bool doExecutionTime { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.ExecutionTime))); }
        public bool doStarted { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Started))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Status))); }
        public bool doSucceeded { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Succeeded))); }
        public bool doTask { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.Task))); }
        public bool doTaskHistory { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskItem.TaskHistory))); }
    }

    [Route("/backgroundtaskitem/version", "GET, POST")]
    public partial class BackgroundTaskItemVersion : BackgroundTaskItemSearch {}

    [Route("/backgroundtaskitem/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/backgroundtaskitem/batch", "DELETE, PATCH, POST, PUT")]
    public partial class BackgroundTaskItemBatch : List<BackgroundTaskItem> { }

    [Route("/backgroundtaskitem/{Id}/backgroundtaskhistory", "GET, POST, DELETE")]
    [Route("/profile/backgroundtaskitem/{Id}/backgroundtaskhistory", "GET, POST, DELETE")]
    public class BackgroundTaskItemJunction : Search<BackgroundTaskItem>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public BackgroundTaskItemJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/backgroundtaskitem/{Id}/backgroundtaskhistory/version", "GET")]
    [Route("/profile/backgroundtaskitem/{Id}/backgroundtaskhistory/version", "GET")]
    public class BackgroundTaskItemJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/backgroundtaskitem/ids", "GET, POST")]
    public class BackgroundTaskItemIds
    {
        public bool All { get; set; }
    }
}